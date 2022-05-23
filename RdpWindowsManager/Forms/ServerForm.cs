using RdpWindowsManager.Controls;
using Rynte.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RdpWindowsManager.Forms
{
   public partial class ServerForm : Form
   {
      public string Category { get; private set; }
      public ServerTreeNode ServerTreeNode { get; private set; }

      public ServerForm(IEnumerable<TreeNode> collection)
      {
         InitializeComponent();

         foreach (TreeNode item in collection)
         {
            boxCategory.Items.Add(item.Text);
         }
      }

      public void SetDataServerNode(ServerTreeNode serverNode)
      {
         txtName.DefaultText = serverNode.Text;
         txtHost.DefaultText = serverNode.Host;
         txtPort.DefaultText = serverNode.Port.ToString();
         txtUsername.DefaultText = serverNode.Username;
         txtPassword.DefaultText = serverNode.Password;
         txtDescription.DefaultText = serverNode.ToolTipText;

         lbColor.ForeColor = serverNode.ForeColor;

         btAdd.Text = "Изменить";
         pnCategory.Visible = false;
      }

      private void TxtPort_KeyPress(object sender, KeyPressEventArgs e)
      {
         char number = e.KeyChar;

         if (!char.IsDigit(number) && number != 8)
         {
            e.Handled = true;
         }
      }

      private void BtColor_Click(object sender, EventArgs e)
      {
         if (colorDialog.ShowDialog() == DialogResult.OK)
         {
            lbColor.ForeColor = colorDialog.Color;
         }
      }

      private void BtAddCategory_Click(object sender, EventArgs e)
      {
         string categoryName = txtCategory.DefaultText;

         if (!string.IsNullOrEmpty(categoryName) && !boxCategory.Items.Contains(categoryName))
         {
            boxCategory.Items.Add(categoryName);
            boxCategory.SelectedItem = categoryName;

            txtCategory.DefaultText = "";
         }
      }

      private void BtAdd_Click(object sender, EventArgs e)
      {
         if (IsEmptyTextBoxes() || IsSelectCategory())
         {
            MessageBox.Show(this, "Заполните все поля", "Ошибка");
            return;
         }

         ServerTreeNode = new ServerTreeNode()
         {
            Text = txtName.DefaultText,
            Host = txtHost.DefaultText,
            Port = int.Parse(txtPort.DefaultText),
            Username = txtUsername.DefaultText,
            Password = txtPassword.DefaultText,
            ToolTipText = txtDescription.DefaultText,

            ForeColor = lbColor.ForeColor
         };

         DialogResult = DialogResult.OK;
      }

      private bool IsEmptyTextBoxes()
      {
         foreach (RynteTextBox textBox in Controls.OfType<RynteTextBox>())
         {
            if (textBox.TabIndex == 7)
            {
               break;
            }

            if (string.IsNullOrEmpty(textBox.DefaultText))
            {
               return true;
            }
         }

         return false;
      }

      private bool IsSelectCategory()
      {
         if (pnCategory.Visible)
         {
            if (boxCategory.SelectedIndex == -1)
            {
               return true;
            }

            Category = boxCategory.SelectedItem.ToString();

            return false;
         }

         return false;
      }
   }
}