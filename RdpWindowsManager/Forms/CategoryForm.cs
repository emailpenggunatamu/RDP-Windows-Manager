using RdpWindowsManager.Models;
using RdpWindowsManager.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace RdpWindowsManager.Forms
{
   public partial class CategoryForm : Form
   {
      private readonly IEnumerable<TreeNode> _categoryes;

      public CategoryForm(IEnumerable<TreeNode> categoryes)
      {
         if (!string.IsNullOrEmpty(Settings.Default.Language))
         {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Settings.Default.Language);
         }

         InitializeComponent();

         _categoryes = categoryes;
      }

      public ServerTreeNode Category { get; private set; }

      public void SetCategory(ServerTreeNode category)
      {
         txtName.DefaultText = category.Text;
         txtName.ForeColor = Color.Gainsboro;
         txtDescription.DefaultText = category.ToolTipText;
         txtDescription.ForeColor = Color.Gainsboro;
      }

      private void BtColor_Click(object sender, EventArgs e)
      {
         if (colorDialog.ShowDialog() == DialogResult.OK)
         {
            lbColor.ForeColor = colorDialog.Color;
         }
      }

      private void BtSave_Click(object sender, EventArgs e)
      {
         string name = txtName.DefaultText.Trim();

         if (string.IsNullOrEmpty(name))
         {
            MessageBox.Show(this, TranslationString.NameEmptyCategory, TranslationString.Warning);
            return;
         }

         if (_categoryes.Any(x => x.Text == name))
         {
            MessageBox.Show(this, TranslationString.NameExistsCategory, TranslationString.Warning);
            return;
         }

         Category = new ServerTreeNode()
         {
            Text = name,
            ForeColor = lbColor.ForeColor,
            ToolTipText = txtDescription.DefaultText
         };

         DialogResult = DialogResult.OK;
      }
   }
}