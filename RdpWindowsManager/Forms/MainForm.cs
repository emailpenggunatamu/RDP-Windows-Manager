using RdpWindowsManager.Controls;
using RdpWindowsManager.Models;
using RdpWindowsManager.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Threading;
using System.Windows.Forms;

namespace RdpWindowsManager.Forms
{
   public partial class MainForm : Form
   {
      private Size _sizeClient;

      public MainForm()
      {
         if (!string.IsNullOrEmpty(Settings.Default.Language))
         {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Settings.Default.Language);
         }

         InitializeComponent();
      }

      private void MainForm_Load(object sender, EventArgs e)
      {
         LoadServer();

         _sizeClient = tabPage1.Size;
         serverTabControl.TabPages.Remove(tabPage1);
         serverView.ExpandAll();
      }

      private void ServerView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
      {
         if (e.Button == MouseButtons.Right)
         {
            serverView.SelectedNode = e.Node;

            ServerTreeNode parent = (ServerTreeNode)(serverView.SelectedNode.Parent == null ? serverView.SelectedNode : null);
            ServerTreeNode server = (ServerTreeNode)(serverView.SelectedNode.Parent != null ? serverView.SelectedNode : null);

            if (parent != null)
            {
               menuCategory.Show(serverView, e.Location);
            }

            if (server != null)
            {
               menuServer.Show(serverView, e.Location);
            }
         }
      }

      private void BtSetting_Click(object sender, EventArgs e)
      {
         using (SettingForm setting = new SettingForm())
         {
            if (setting.ShowDialog() == DialogResult.OK)
            {
               DialogResult dialog = MessageBox.Show(this, TranslationString.Reboot, TranslationString.Warning, MessageBoxButtons.YesNo);

               if (dialog == DialogResult.Yes)
               {
                  Application.Restart();
               }
            }
         }
      }

      private void BtCategoryEdit_Click(object sender, EventArgs e)
      {
         ServerTreeNode node = (ServerTreeNode)serverView.SelectedNode;

         using (CategoryForm form = new CategoryForm(serverView.GetParents()))
         {
            form.SetCategory(node);

            if (form.ShowDialog() == DialogResult.OK)
            {
               node.Text = form.Category.Text;
               node.ForeColor = form.Category.ForeColor;
               node.ToolTipText = form.Category.ToolTipText;

               SaveServer();
            }
         }
      }

      private void BtAddServer_Click(object sender, EventArgs e)
      {
         ServerTreeNode node = (ServerTreeNode)serverView.SelectedNode;

         using (ServerForm form = new ServerForm(serverView.GetParents()))
         {
            if (form.ShowDialog() == DialogResult.OK)
            {
               ServerTreeNode category = serverView.Nodes.Cast<ServerTreeNode>().FirstOrDefault(x => x.Text == form.Category);

               if (category == null)
               {
                  category = new ServerTreeNode(form.Category)
                  {
                     ForeColor = Color.Gainsboro,
                     ImageIndex = 0,
                     SelectedImageIndex = 0
                  };

                  serverView.Nodes.Add(category);
               }

               category.Nodes.Add(form.Server);
               SaveServer();
            }
         }
      }

      private void BtServerEdit_Click(object sender, EventArgs e)
      {
         ServerTreeNode node = (ServerTreeNode)serverView.SelectedNode;

         using (ServerForm form = new ServerForm(serverView.GetParents()))
         {
            form.SetServer(node);

            if (form.ShowDialog() == DialogResult.OK)
            {
               node.Text = form.Server.Text;
               node.ForeColor = form.Server.ForeColor;
               node.ToolTipText = form.Server.ToolTipText;
               node.Host = form.Server.Host;
               node.Port = form.Server.Port;
               node.Username = form.Server.Username;
               node.Password = form.Server.Password;

               SaveServer();
            }
         }
      }

      private void RemoveServerTreeNode(object sender, EventArgs e)
      {
         ServerTreeNode node = (ServerTreeNode)serverView.SelectedNode;
         DialogResult dialog = MessageBox.Show(this, $"{TranslationString.Delete} {node.Text}?", TranslationString.Warning, MessageBoxButtons.YesNo);

         if (dialog == DialogResult.Yes)
         {
            serverView.Nodes.Remove(node);
            SaveServer();
         }
      }

      private void ConnectServer(object sender, EventArgs e)
      {
         ServerTreeNode node = (ServerTreeNode)serverView.SelectedNode;

         if (node.Parent != null)
         {
            if (serverTabControl.TabPages.Cast<TabPage>().Any(x => x.Text == node.Text))
            {
               return;
            }

            TabPage tabPage = new TabPage(node.Text)
            {
               BackColor = Color.FromArgb(53, 59, 72)
            };

            RemoteClient rdpClient = new RemoteClient(_sizeClient, tabPage);
            rdpClient.Initialize();
            rdpClient.ClientDisconnected += (message) => MessageBox.Show(message);
            rdpClient.Conntect(node.Host, node.Username, node.Password, node.Port);

            serverTabControl.TabPages.Add(tabPage);
            serverTabControl.SelectedTab = tabPage;
         }
      }

      private void LoadServer()
      {
         if (File.Exists("servers.xml"))
         {
            using (FileStream fs = new FileStream("servers.xml", FileMode.Open))
            {
               SoapFormatter sf = new SoapFormatter();

               serverView.Nodes.AddRange((ServerTreeNode[])sf.Deserialize(fs));
               serverView.ExpandAll();
            }
         }
      }

      private void SaveServer()
      {
         ServerTreeNode[] tempNodes = new ServerTreeNode[serverView.Nodes.Count];

         for (int i = 0; i < serverView.Nodes.Count; i++)
         {
            tempNodes[i] = (ServerTreeNode)serverView.Nodes[i];
         }

         using (FileStream fs = new FileStream("servers.xml", FileMode.Create, FileAccess.Write))
         {
            SoapFormatter sf = new SoapFormatter();

            sf.Serialize(fs, tempNodes);
         }
      }

      private void TxtSearch_DefaultTextChanged(object sender, EventArgs e)
      {
         serverView.SelectedNode = SearchServer(txtSearch.DefaultText.ToLower(), serverView.Nodes.Cast<ServerTreeNode>());
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