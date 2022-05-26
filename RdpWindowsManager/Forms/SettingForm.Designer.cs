namespace RdpWindowsManager.Forms
{
   partial class SettingForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
         this.label1 = new System.Windows.Forms.Label();
         this.boxLanguage = new Rynte.WinForms.Controls.RynteComboBox();
         this.btSave = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         resources.ApplyResources(this.label1, "label1");
         this.label1.Name = "label1";
         // 
         // boxLanguage
         // 
         this.boxLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.boxLanguage.BorderColor = System.Drawing.Color.Gray;
         this.boxLanguage.ButtonColor = System.Drawing.Color.LightGray;
         this.boxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         resources.ApplyResources(this.boxLanguage, "boxLanguage");
         this.boxLanguage.ForeColor = System.Drawing.Color.Gainsboro;
         this.boxLanguage.FormattingEnabled = true;
         this.boxLanguage.Name = "boxLanguage";
         // 
         // btSave
         // 
         this.btSave.BackColor = System.Drawing.Color.LightGray;
         this.btSave.FlatAppearance.BorderSize = 0;
         resources.ApplyResources(this.btSave, "btSave");
         this.btSave.ForeColor = System.Drawing.Color.Black;
         this.btSave.Name = "btSave";
         this.btSave.UseVisualStyleBackColor = false;
         this.btSave.Click += new System.EventHandler(this.BtSave_Click);
         // 
         // SettingForm
         // 
         resources.ApplyResources(this, "$this");
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.Controls.Add(this.btSave);
         this.Controls.Add(this.boxLanguage);
         this.Controls.Add(this.label1);
         this.ForeColor = System.Drawing.Color.Gainsboro;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "SettingForm";
         this.Load += new System.EventHandler(this.SettingForm_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private Rynte.WinForms.Controls.RynteComboBox boxLanguage;
      private System.Windows.Forms.Button btSave;
   }
}