namespace RdpWindowsManager.Forms
{
   partial class ServerForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
         this.label1 = new System.Windows.Forms.Label();
         this.txtName = new Rynte.WinForms.Controls.RynteTextBox();
         this.txtHost = new Rynte.WinForms.Controls.RynteTextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.txtPort = new Rynte.WinForms.Controls.RynteTextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtUsername = new Rynte.WinForms.Controls.RynteTextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.txtPassword = new Rynte.WinForms.Controls.RynteTextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.btAdd = new System.Windows.Forms.Button();
         this.lbColor = new System.Windows.Forms.Label();
         this.btColor = new System.Windows.Forms.Button();
         this.label6 = new System.Windows.Forms.Label();
         this.txtDescription = new Rynte.WinForms.Controls.RynteTextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.btAddCategory = new System.Windows.Forms.Button();
         this.txtNewCategory = new Rynte.WinForms.Controls.RynteTextBox();
         this.label8 = new System.Windows.Forms.Label();
         this.boxCategory = new Rynte.WinForms.Controls.RynteComboBox();
         this.label9 = new System.Windows.Forms.Label();
         this.pnCategory = new System.Windows.Forms.Panel();
         this.colorDialog = new System.Windows.Forms.ColorDialog();
         this.pnCategory.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         resources.ApplyResources(this.label1, "label1");
         this.label1.Name = "label1";
         // 
         // txtName
         // 
         resources.ApplyResources(this.txtName, "txtName");
         this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtName.BorderColor = System.Drawing.Color.Gray;
         this.txtName.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtName.BorderSize = 1;
         this.txtName.DefaultText = "";
         this.txtName.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtName.HoverState.BorderSize = 1;
         this.txtName.Multiline = false;
         this.txtName.Name = "txtName";
         this.txtName.PasswordChar = false;
         this.txtName.Placeholder = null;
         this.txtName.ReadOnly = false;
         // 
         // txtHost
         // 
         resources.ApplyResources(this.txtHost, "txtHost");
         this.txtHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtHost.BorderColor = System.Drawing.Color.Gray;
         this.txtHost.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtHost.BorderSize = 1;
         this.txtHost.DefaultText = "";
         this.txtHost.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtHost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtHost.HoverState.BorderSize = 1;
         this.txtHost.Multiline = false;
         this.txtHost.Name = "txtHost";
         this.txtHost.PasswordChar = false;
         this.txtHost.Placeholder = null;
         this.txtHost.ReadOnly = false;
         // 
         // label2
         // 
         resources.ApplyResources(this.label2, "label2");
         this.label2.Name = "label2";
         // 
         // txtPort
         // 
         resources.ApplyResources(this.txtPort, "txtPort");
         this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtPort.BorderColor = System.Drawing.Color.Gray;
         this.txtPort.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtPort.BorderSize = 1;
         this.txtPort.DefaultText = "0";
         this.txtPort.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtPort.HoverState.BorderSize = 1;
         this.txtPort.Multiline = false;
         this.txtPort.Name = "txtPort";
         this.txtPort.PasswordChar = false;
         this.txtPort.Placeholder = null;
         this.txtPort.ReadOnly = false;
         this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPort_KeyPress);
         // 
         // label3
         // 
         resources.ApplyResources(this.label3, "label3");
         this.label3.Name = "label3";
         // 
         // txtUsername
         // 
         resources.ApplyResources(this.txtUsername, "txtUsername");
         this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtUsername.BorderColor = System.Drawing.Color.Gray;
         this.txtUsername.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtUsername.BorderSize = 1;
         this.txtUsername.DefaultText = "";
         this.txtUsername.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtUsername.HoverState.BorderSize = 1;
         this.txtUsername.Multiline = false;
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.PasswordChar = false;
         this.txtUsername.Placeholder = null;
         this.txtUsername.ReadOnly = false;
         // 
         // label4
         // 
         resources.ApplyResources(this.label4, "label4");
         this.label4.Name = "label4";
         // 
         // txtPassword
         // 
         resources.ApplyResources(this.txtPassword, "txtPassword");
         this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtPassword.BorderColor = System.Drawing.Color.Gray;
         this.txtPassword.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtPassword.BorderSize = 1;
         this.txtPassword.DefaultText = "";
         this.txtPassword.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtPassword.HoverState.BorderSize = 1;
         this.txtPassword.Multiline = false;
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = false;
         this.txtPassword.Placeholder = null;
         this.txtPassword.ReadOnly = false;
         // 
         // label5
         // 
         resources.ApplyResources(this.label5, "label5");
         this.label5.Name = "label5";
         // 
         // btAdd
         // 
         resources.ApplyResources(this.btAdd, "btAdd");
         this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.btAdd.FlatAppearance.BorderSize = 0;
         this.btAdd.Name = "btAdd";
         this.btAdd.UseVisualStyleBackColor = false;
         this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
         // 
         // lbColor
         // 
         resources.ApplyResources(this.lbColor, "lbColor");
         this.lbColor.Name = "lbColor";
         // 
         // btColor
         // 
         resources.ApplyResources(this.btColor, "btColor");
         this.btColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.btColor.FlatAppearance.BorderSize = 0;
         this.btColor.Name = "btColor";
         this.btColor.UseVisualStyleBackColor = false;
         this.btColor.Click += new System.EventHandler(this.BtColor_Click);
         // 
         // label6
         // 
         resources.ApplyResources(this.label6, "label6");
         this.label6.Name = "label6";
         // 
         // txtDescription
         // 
         resources.ApplyResources(this.txtDescription, "txtDescription");
         this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtDescription.BorderColor = System.Drawing.Color.Gray;
         this.txtDescription.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Default;
         this.txtDescription.BorderSize = 1;
         this.txtDescription.DefaultText = "";
         this.txtDescription.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtDescription.HoverState.BorderSize = 1;
         this.txtDescription.Multiline = false;
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.PasswordChar = false;
         this.txtDescription.Placeholder = null;
         this.txtDescription.ReadOnly = false;
         // 
         // label7
         // 
         resources.ApplyResources(this.label7, "label7");
         this.label7.Name = "label7";
         // 
         // btAddCategory
         // 
         resources.ApplyResources(this.btAddCategory, "btAddCategory");
         this.btAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.btAddCategory.FlatAppearance.BorderSize = 0;
         this.btAddCategory.Name = "btAddCategory";
         this.btAddCategory.UseVisualStyleBackColor = false;
         this.btAddCategory.Click += new System.EventHandler(this.BtAddCategory_Click);
         // 
         // txtNewCategory
         // 
         resources.ApplyResources(this.txtNewCategory, "txtNewCategory");
         this.txtNewCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtNewCategory.BorderColor = System.Drawing.Color.Gray;
         this.txtNewCategory.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtNewCategory.BorderSize = 1;
         this.txtNewCategory.DefaultText = "";
         this.txtNewCategory.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtNewCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtNewCategory.HoverState.BorderSize = 1;
         this.txtNewCategory.Multiline = false;
         this.txtNewCategory.Name = "txtNewCategory";
         this.txtNewCategory.PasswordChar = false;
         this.txtNewCategory.Placeholder = null;
         this.txtNewCategory.ReadOnly = false;
         // 
         // label8
         // 
         resources.ApplyResources(this.label8, "label8");
         this.label8.Name = "label8";
         // 
         // boxCategory
         // 
         resources.ApplyResources(this.boxCategory, "boxCategory");
         this.boxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.boxCategory.BorderColor = System.Drawing.Color.Gray;
         this.boxCategory.ButtonColor = System.Drawing.Color.LightGray;
         this.boxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.boxCategory.ForeColor = System.Drawing.Color.Gainsboro;
         this.boxCategory.FormattingEnabled = true;
         this.boxCategory.Name = "boxCategory";
         // 
         // label9
         // 
         resources.ApplyResources(this.label9, "label9");
         this.label9.Name = "label9";
         // 
         // pnCategory
         // 
         resources.ApplyResources(this.pnCategory, "pnCategory");
         this.pnCategory.Controls.Add(this.label9);
         this.pnCategory.Controls.Add(this.boxCategory);
         this.pnCategory.Controls.Add(this.btAddCategory);
         this.pnCategory.Controls.Add(this.txtNewCategory);
         this.pnCategory.Controls.Add(this.label8);
         this.pnCategory.Name = "pnCategory";
         // 
         // colorDialog
         // 
         this.colorDialog.AnyColor = true;
         this.colorDialog.Color = System.Drawing.Color.Gainsboro;
         this.colorDialog.FullOpen = true;
         this.colorDialog.SolidColorOnly = true;
         // 
         // ServerForm
         // 
         resources.ApplyResources(this, "$this");
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.Controls.Add(this.pnCategory);
         this.Controls.Add(this.txtDescription);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.lbColor);
         this.Controls.Add(this.btColor);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.btAdd);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.txtUsername);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtPort);
         this.Controls.Add(this.txtHost);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.label1);
         this.ForeColor = System.Drawing.Color.Gainsboro;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "ServerForm";
         this.pnCategory.ResumeLayout(false);
         this.pnCategory.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private Rynte.WinForms.Controls.RynteTextBox txtName;
      private Rynte.WinForms.Controls.RynteTextBox txtHost;
      private System.Windows.Forms.Label label2;
      private Rynte.WinForms.Controls.RynteTextBox txtPort;
      private System.Windows.Forms.Label label3;
      private Rynte.WinForms.Controls.RynteTextBox txtUsername;
      private System.Windows.Forms.Label label4;
      private Rynte.WinForms.Controls.RynteTextBox txtPassword;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button btAdd;
      private System.Windows.Forms.Label lbColor;
      private System.Windows.Forms.Button btColor;
      private System.Windows.Forms.Label label6;
      private Rynte.WinForms.Controls.RynteTextBox txtDescription;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Button btAddCategory;
      private Rynte.WinForms.Controls.RynteTextBox txtNewCategory;
      private System.Windows.Forms.Label label8;
      private Rynte.WinForms.Controls.RynteComboBox boxCategory;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Panel pnCategory;
      private System.Windows.Forms.ColorDialog colorDialog;
   }
}