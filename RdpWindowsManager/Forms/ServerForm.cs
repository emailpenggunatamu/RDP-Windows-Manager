using RdpWindowsManager.Models;
using RdpWindowsManager.Properties;
using Rynte.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RdpWindowsManager.Forms
{
   public partial class ServerForm : Form
   {
      public ServerForm(IEnumerable<TreeNode> categoryes)
      {
         if (!string.IsNullOrEmpty(Settings.Default.Language))
         {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Settings.Default.Language);
         }

         InitializeComponent();

         foreach (TreeNode item in categoryes)
         {
            boxCategory.Items.Add(item.Text);
         }
      }

      public string Category { get; private set; }
      public ServerTreeNode Server { get; private set; }

      public void SetServer(ServerTreeNode server)
      {
         txtName.DefaultText = server.Text;
         txtHost.DefaultText = server.Host;
         txtPort.DefaultText = server.Port.ToString();
         txtUsername.DefaultText = server.Username;
         txtPassword.DefaultText = server.Password;

         lbColor.ForeColor = server.ForeColor;
         txtDescription.DefaultText = server.ToolTipText;

         pnCategory.Visible = false;
         btAdd.Text = TranslationString.ButtonServer;
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
         string name = txtNewCategory.DefaultText.Trim();

         if (!string.IsNullOrEmpty(name) && !boxCategory.Items.Contains(name))
         {
            boxCategory.Items.Add(name);
            boxCategory.SelectedItem = name;

            txtNewCategory.DefaultText = "";
         }
      }

      private void TxtPort_KeyPress(object sender, KeyPressEventArgs e)
      {
         char number = e.KeyChar;

         if (!char.IsDigit(number) && number != 8)
         {
            e.Handled = true;
         }
      }

      private void BtAdd_Click(object sender, EventArgs e)
      {
         if (IsEmptyTextBox())
         {
            MessageBox.Show(this, TranslationString.ServerEmptyLogin, TranslationString.Warning);
            return;
         }

         if (IsSelectCategory())
         {
            MessageBox.Show(this, TranslationString.ServerEmptyCategory, TranslationString.Warning);
            return;
         }

         Server = new ServerTreeNode()
         {
            Text = txtName.DefaultText,
            Host = txtHost.DefaultText,
            Port = int.Parse(txtPort.DefaultText),
            Username = txtUsername.DefaultText,
            Password = txtPassword.DefaultText,
            ToolTipText = txtDescription.DefaultText,

            ForeColor = lbColor.ForeColor,
            ImageIndex = 1,
            SelectedImageIndex = 1,
         };

         DialogResult = DialogResult.OK;
      }

      private bool IsEmptyTextBox()
      {
         foreach (RynteTextBox item in Controls.OfType<RynteTextBox>())
         {
            if (item.Name == txtNewCategory.Name)
            {
               continue;
            }

            if (string.IsNullOrEmpty(item.DefaultText))
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