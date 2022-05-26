using RdpWindowsManager.Properties;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace RdpWindowsManager.Forms
{
   public partial class SettingForm : Form
   {
      public SettingForm()
      {
         if (!string.IsNullOrEmpty(Settings.Default.Language))
         {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Settings.Default.Language);
         }

         InitializeComponent();
      }

      private void SettingForm_Load(object sender, EventArgs e)
      {
         boxLanguage.DataSource = new CultureInfo[]
         {
            CultureInfo.GetCultureInfo("ru-RU"),
            CultureInfo.GetCultureInfo("en-US"),
         };

         boxLanguage.DisplayMember = "NativeMethod";
         boxLanguage.ValueMember = "Name";

         if (!string.IsNullOrEmpty(Settings.Default.Language))
         {
            boxLanguage.SelectedValue = Settings.Default.Language;
         }
      }

      private void BtSave_Click(object sender, EventArgs e)
      {
         Settings.Default.Language = boxLanguage.SelectedItem.ToString();
         Settings.Default.Save();

         DialogResult = DialogResult.OK;
      }
   }
}