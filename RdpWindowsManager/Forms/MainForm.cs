using RdpWindowsManager.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Windows.Forms;

namespace RdpWindowsManager.Forms
{
   public partial class MainForm : Form
   {
      private Size _sizeClient;

      public MainForm()
      {
         InitializeComponent();
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         LoadServers();

         _sizeClient = tabControl.Size;
      }

      private void BtAdd_Click(object sender, EventArgs e)
      {
         using (ServerForm form = new ServerForm(serverTreeView.GetParents()))
         {
            if (form.ShowDialog() == DialogResult.OK)
            {
               AddServer(form.Category, form.ServerTreeNode);

               serverTreeView.ExpandAll();
               SaveServers();
            }
         }
      }

      private void BtEdit_Click(object sender, EventArgs e)
      {
         ServerTreeNode serverNode = (ServerTreeNode)serverTreeView.SelectedNode;

         if (serverNode.Parent == null)
         {
            return;
         }

         using (ServerForm form = new ServerForm(serverTreeView.GetParents()))
         {
            form.SetDataServerNode(serverNode);
            if (form.ShowDialog() == DialogResult.OK)
            {
               EditServer(serverNode, form.ServerTreeNode);
               SaveServers();
            }
         }
      }

      private void BtRemove_Click(object sender, EventArgs e)
      {
         ServerTreeNode serverNode = (ServerTreeNode)serverTreeView.SelectedNode;

         DialogResult dialogResult = MessageBox.Show(this, "Вы уверены что хотите удалить " + serverNode.Text,
            "Внимание", MessageBoxButtons.OKCancel);

         if (serverNode != null && dialogResult == DialogResult.OK)
         {
            serverNode.Remove();
         }
      }

      private void RynteTextBox1_DefaultTextChanged(object sender, EventArgs e)
      {
         serverTreeView.SelectedNode = SearchServer(txtSearch.DefaultText.ToLower(), serverTreeView.Nodes.Cast<ServerTreeNode>());
      }

      private void AddServer(string category, ServerTreeNode serverNode)
      {
         ServerTreeNode parent = serverTreeView.Nodes.Cast<ServerTreeNode>().FirstOrDefault(x => x.Text == category);

         if (parent == null)
         {
            parent = new ServerTreeNode(category)
            {
               ForeColor = Color.Gainsboro,
               ImageIndex = 0,
               SelectedImageIndex = 0
            };

            serverTreeView.Nodes.Add(parent);
         }

         serverNode.ImageIndex = 1;
         serverNode.SelectedImageIndex = 1;

         parent.Nodes.Add(serverNode);
      }

      private void EditServer(ServerTreeNode oldServerNode, ServerTreeNode newServerNode)
      {
         oldServerNode.Text = newServerNode.Text;
         oldServerNode.ForeColor = newServerNode.ForeColor;
         oldServerNode.ToolTipText = newServerNode.ToolTipText;
         oldServerNode.Host = newServerNode.Host;
         oldServerNode.Port = newServerNode.Port;
         oldServerNode.Username = newServerNode.Username;
         oldServerNode.Password = newServerNode.Password;
      }

      private void BtConnect_Click(object sender, EventArgs e)
      {
         ServerTreeNode serverNode = (ServerTreeNode)serverTreeView.SelectedNode;

         if (serverNode.Parent != null)
         {
            TabPage tabPage = new TabPage(serverNode.Text)
            {
               BackColor = Color.FromArgb(53, 59, 72)
            };

            RdpClient rdpClient = new RdpClient(_sizeClient, tabPage);
            rdpClient.Initialize();
            rdpClient.ClientDisconnected += (message) => MessageBox.Show(message);
            rdpClient.Conntect(serverNode.Host, serverNode.Username, serverNode.Password, serverNode.Port);

            tabControl.TabPages.Add(tabPage);
            tabControl.SelectedTab = tabPage;
         }
      }

      private void SaveServers()
      {
         ServerTreeNode[] tempNodes = new ServerTreeNode[serverTreeView.Nodes.Count];

         for (int i = 0; i < serverTreeView.Nodes.Count; i++)
         {
            tempNodes[i] = (ServerTreeNode)serverTreeView.Nodes[i];
         }

         using (FileStream fs = new FileStream("servers.xml", FileMode.Create, FileAccess.Write))
         {
            SoapFormatter sf = new SoapFormatter();

            sf.Serialize(fs, tempNodes);
         }
      }

      private void LoadServers()
      {
         if (File.Exists("servers.xml"))
         {
            using (FileStream fs = new FileStream("servers.xml", FileMode.Open))
            {
               SoapFormatter sf = new SoapFormatter();

               serverTreeView.Nodes.AddRange((ServerTreeNode[])sf.Deserialize(fs));
               serverTreeView.ExpandAll();
            }
         }
      }

      private void TabControl_MouseClick(object sender, MouseEventArgs e)
      {
         if (e.Button == MouseButtons.Right)
         {
            contextMenuStrip1.Show(tabControl, e.Location);
         }
      }

      private void TabDisconnect_Click(object sender, EventArgs e)
      {
         int index = tabControl.SelectedIndex;
         string title = tabControl.TabPages[index].Text;

         DialogResult dialog = MessageBox.Show(this, $"Вы уверены что хотите закрыть подключение к {title}?", title, MessageBoxButtons.YesNo);

         if (dialog == DialogResult.Yes)
         {
            tabControl.TabPages[index].Dispose();
         }
      }

      private TreeNode SearchServer(string pattern, IEnumerable<TreeNode> nodes)
      {
         foreach (TreeNode item in nodes)
         {
            if (item.Text.ToLower().Contains(pattern))
            {
               return item;
            }

            TreeNode node = SearchServer(pattern, item.Nodes.Cast<ServerTreeNode>());

            if (node != null)
            {
               return node;
            }
         }

         return null;
      }
   }
}