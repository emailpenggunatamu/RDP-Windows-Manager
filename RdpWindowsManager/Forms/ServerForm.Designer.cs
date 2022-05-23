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
         this.pnCategory = new System.Windows.Forms.Panel();
         this.boxCategory = new Rynte.WinForms.Controls.RynteComboBox();
         this.label11 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.btAddCategory = new System.Windows.Forms.Button();
         this.txtCategory = new Rynte.WinForms.Controls.RynteTextBox();
         this.label10 = new System.Windows.Forms.Label();
         this.txtDescription = new Rynte.WinForms.Controls.RynteTextBox();
         this.lbColor = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.btColor = new System.Windows.Forms.Button();
         this.label7 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.btAdd = new System.Windows.Forms.Button();
         this.txtPassword = new Rynte.WinForms.Controls.RynteTextBox();
         this.txtPort = new Rynte.WinForms.Controls.RynteTextBox();
         this.txtUsername = new Rynte.WinForms.Controls.RynteTextBox();
         this.txtHost = new Rynte.WinForms.Controls.RynteTextBox();
         this.txtName = new Rynte.WinForms.Controls.RynteTextBox();
         this.colorDialog = new System.Windows.Forms.ColorDialog();
         this.pnCategory.SuspendLayout();
         this.SuspendLayout();
         // 
         // pnCategory
         // 
         this.pnCategory.Controls.Add(this.boxCategory);
         this.pnCategory.Controls.Add(this.label11);
         this.pnCategory.Controls.Add(this.label5);
         this.pnCategory.Controls.Add(this.btAddCategory);
         this.pnCategory.Controls.Add(this.txtCategory);
         this.pnCategory.Location = new System.Drawing.Point(305, 146);
         this.pnCategory.Name = "pnCategory";
         this.pnCategory.Size = new System.Drawing.Size(285, 122);
         this.pnCategory.TabIndex = 42;
         // 
         // boxCategory
         // 
         this.boxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.boxCategory.BorderColor = System.Drawing.Color.DarkGray;
         this.boxCategory.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.boxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.boxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.boxCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.boxCategory.ForeColor = System.Drawing.Color.Gainsboro;
         this.boxCategory.FormattingEnabled = true;
         this.boxCategory.Location = new System.Drawing.Point(4, 23);
         this.boxCategory.Name = "boxCategory";
         this.boxCategory.Size = new System.Drawing.Size(272, 25);
         this.boxCategory.TabIndex = 24;
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label11.ForeColor = System.Drawing.Color.LightGray;
         this.label11.Location = new System.Drawing.Point(1, 1);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(73, 17);
         this.label11.TabIndex = 23;
         this.label11.Text = "Категории:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label5.ForeColor = System.Drawing.Color.LightGray;
         this.label5.Location = new System.Drawing.Point(1, 65);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(142, 17);
         this.label5.TabIndex = 14;
         this.label5.Text = "Имя новой категории:";
         // 
         // btAddCategory
         // 
         this.btAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.btAddCategory.FlatAppearance.BorderSize = 0;
         this.btAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btAddCategory.ForeColor = System.Drawing.Color.LightGray;
         this.btAddCategory.Location = new System.Drawing.Point(203, 86);
         this.btAddCategory.Name = "btAddCategory";
         this.btAddCategory.Size = new System.Drawing.Size(73, 27);
         this.btAddCategory.TabIndex = 13;
         this.btAddCategory.Text = "Добавить";
         this.btAddCategory.UseVisualStyleBackColor = false;
         this.btAddCategory.Click += new System.EventHandler(this.BtAddCategory_Click);
         // 
         // txtCategory
         // 
         this.txtCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtCategory.BorderColor = System.Drawing.Color.DarkGray;
         this.txtCategory.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtCategory.BorderSize = 1;
         this.txtCategory.DefaultText = "";
         this.txtCategory.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtCategory.HoverState.BorderSize = 1;
         this.txtCategory.Location = new System.Drawing.Point(4, 86);
         this.txtCategory.Margin = new System.Windows.Forms.Padding(4);
         this.txtCategory.Multiline = false;
         this.txtCategory.Name = "txtCategory";
         this.txtCategory.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
         this.txtCategory.PasswordChar = false;
         this.txtCategory.Placeholder = null;
         this.txtCategory.ReadOnly = false;
         this.txtCategory.Size = new System.Drawing.Size(192, 26);
         this.txtCategory.TabIndex = 7;
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label10.ForeColor = System.Drawing.Color.LightGray;
         this.label10.Location = new System.Drawing.Point(307, 80);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(93, 17);
         this.label10.TabIndex = 41;
         this.label10.Text = "Комментарий:";
         // 
         // txtDescription
         // 
         this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtDescription.BorderColor = System.Drawing.Color.DarkGray;
         this.txtDescription.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtDescription.BorderSize = 1;
         this.txtDescription.DefaultText = "";
         this.txtDescription.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtDescription.HoverState.BorderSize = 1;
         this.txtDescription.Location = new System.Drawing.Point(310, 101);
         this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
         this.txtDescription.Multiline = false;
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
         this.txtDescription.PasswordChar = false;
         this.txtDescription.Placeholder = null;
         this.txtDescription.ReadOnly = false;
         this.txtDescription.Size = new System.Drawing.Size(272, 26);
         this.txtDescription.TabIndex = 6;
         // 
         // lbColor
         // 
         this.lbColor.AutoSize = true;
         this.lbColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.lbColor.ForeColor = System.Drawing.Color.LightGray;
         this.lbColor.Location = new System.Drawing.Point(526, 13);
         this.lbColor.Name = "lbColor";
         this.lbColor.Size = new System.Drawing.Size(56, 17);
         this.lbColor.TabIndex = 39;
         this.lbColor.Text = "Пример";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label8.ForeColor = System.Drawing.Color.LightGray;
         this.label8.Location = new System.Drawing.Point(307, 13);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(181, 17);
         this.label8.TabIndex = 38;
         this.label8.Text = "Цвет имени в обозревателе:";
         // 
         // btColor
         // 
         this.btColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.btColor.FlatAppearance.BorderSize = 0;
         this.btColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btColor.ForeColor = System.Drawing.Color.LightGray;
         this.btColor.Location = new System.Drawing.Point(310, 34);
         this.btColor.Name = "btColor";
         this.btColor.Size = new System.Drawing.Size(272, 27);
         this.btColor.TabIndex = 37;
         this.btColor.Text = "Выбрать цвет";
         this.btColor.UseVisualStyleBackColor = false;
         this.btColor.Click += new System.EventHandler(this.BtColor_Click);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label7.ForeColor = System.Drawing.Color.LightGray;
         this.label7.Location = new System.Drawing.Point(5, 212);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(57, 17);
         this.label7.TabIndex = 36;
         this.label7.Text = "Пароль:";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label6.ForeColor = System.Drawing.Color.LightGray;
         this.label6.Location = new System.Drawing.Point(5, 145);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(124, 17);
         this.label6.TabIndex = 35;
         this.label6.Text = "Имя пользователя:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label4.ForeColor = System.Drawing.Color.LightGray;
         this.label4.Location = new System.Drawing.Point(222, 77);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(41, 17);
         this.label4.TabIndex = 34;
         this.label4.Text = "Порт:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label3.ForeColor = System.Drawing.Color.LightGray;
         this.label3.Location = new System.Drawing.Point(5, 77);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(38, 17);
         this.label3.TabIndex = 33;
         this.label3.Text = "Хост:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.label2.ForeColor = System.Drawing.Color.LightGray;
         this.label2.Location = new System.Drawing.Point(5, 13);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(91, 17);
         this.label2.TabIndex = 32;
         this.label2.Text = "Имя сервера:";
         // 
         // btAdd
         // 
         this.btAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.btAdd.FlatAppearance.BorderSize = 0;
         this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btAdd.ForeColor = System.Drawing.Color.LightGray;
         this.btAdd.Location = new System.Drawing.Point(8, 267);
         this.btAdd.Name = "btAdd";
         this.btAdd.Size = new System.Drawing.Size(272, 39);
         this.btAdd.TabIndex = 31;
         this.btAdd.Text = "Добавить";
         this.btAdd.UseVisualStyleBackColor = false;
         this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
         // 
         // txtPassword
         // 
         this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtPassword.BorderColor = System.Drawing.Color.DarkGray;
         this.txtPassword.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtPassword.BorderSize = 1;
         this.txtPassword.DefaultText = "";
         this.txtPassword.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtPassword.HoverState.BorderSize = 1;
         this.txtPassword.Location = new System.Drawing.Point(8, 233);
         this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
         this.txtPassword.Multiline = false;
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
         this.txtPassword.PasswordChar = true;
         this.txtPassword.Placeholder = null;
         this.txtPassword.ReadOnly = false;
         this.txtPassword.Size = new System.Drawing.Size(272, 26);
         this.txtPassword.TabIndex = 5;
         // 
         // txtPort
         // 
         this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtPort.BorderColor = System.Drawing.Color.DarkGray;
         this.txtPort.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtPort.BorderSize = 1;
         this.txtPort.DefaultText = "0";
         this.txtPort.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtPort.HoverState.BorderSize = 1;
         this.txtPort.Location = new System.Drawing.Point(225, 98);
         this.txtPort.Margin = new System.Windows.Forms.Padding(4);
         this.txtPort.Multiline = false;
         this.txtPort.Name = "txtPort";
         this.txtPort.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
         this.txtPort.PasswordChar = false;
         this.txtPort.Placeholder = null;
         this.txtPort.ReadOnly = false;
         this.txtPort.Size = new System.Drawing.Size(55, 26);
         this.txtPort.TabIndex = 3;
         this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPort_KeyPress);
         // 
         // txtUsername
         // 
         this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtUsername.BorderColor = System.Drawing.Color.DarkGray;
         this.txtUsername.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtUsername.BorderSize = 1;
         this.txtUsername.DefaultText = "";
         this.txtUsername.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtUsername.HoverState.BorderSize = 1;
         this.txtUsername.Location = new System.Drawing.Point(8, 166);
         this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
         this.txtUsername.Multiline = false;
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
         this.txtUsername.PasswordChar = false;
         this.txtUsername.Placeholder = null;
         this.txtUsername.ReadOnly = false;
         this.txtUsername.Size = new System.Drawing.Size(272, 26);
         this.txtUsername.TabIndex = 4;
         // 
         // txtHost
         // 
         this.txtHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtHost.BorderColor = System.Drawing.Color.DarkGray;
         this.txtHost.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtHost.BorderSize = 1;
         this.txtHost.DefaultText = "";
         this.txtHost.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtHost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtHost.HoverState.BorderSize = 1;
         this.txtHost.Location = new System.Drawing.Point(8, 98);
         this.txtHost.Margin = new System.Windows.Forms.Padding(4);
         this.txtHost.Multiline = false;
         this.txtHost.Name = "txtHost";
         this.txtHost.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
         this.txtHost.PasswordChar = false;
         this.txtHost.Placeholder = null;
         this.txtHost.ReadOnly = false;
         this.txtHost.Size = new System.Drawing.Size(209, 26);
         this.txtHost.TabIndex = 2;
         // 
         // txtName
         // 
         this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtName.BorderColor = System.Drawing.Color.DarkGray;
         this.txtName.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtName.BorderSize = 1;
         this.txtName.DefaultText = "";
         this.txtName.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtName.HoverState.BorderSize = 1;
         this.txtName.Location = new System.Drawing.Point(8, 34);
         this.txtName.Margin = new System.Windows.Forms.Padding(4);
         this.txtName.Multiline = false;
         this.txtName.Name = "txtName";
         this.txtName.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
         this.txtName.PasswordChar = false;
         this.txtName.Placeholder = null;
         this.txtName.ReadOnly = false;
         this.txtName.Size = new System.Drawing.Size(272, 26);
         this.txtName.TabIndex = 1;
         // 
         // colorDialog
         // 
         this.colorDialog.AnyColor = true;
         this.colorDialog.FullOpen = true;
         this.colorDialog.SolidColorOnly = true;
         // 
         // ServerForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.ClientSize = new System.Drawing.Size(639, 456);
         this.Controls.Add(this.pnCategory);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.txtDescription);
         this.Controls.Add(this.lbColor);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.btColor);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.btAdd);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtPort);
         this.Controls.Add(this.txtUsername);
         this.Controls.Add(this.txtHost);
         this.Controls.Add(this.txtName);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.ForeColor = System.Drawing.Color.Gainsboro;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "ServerForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Параметры";
         this.pnCategory.ResumeLayout(false);
         this.pnCategory.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel pnCategory;
      private Rynte.WinForms.Controls.RynteComboBox boxCategory;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button btAddCategory;
      private Rynte.WinForms.Controls.RynteTextBox txtCategory;
      private System.Windows.Forms.Label label10;
      private Rynte.WinForms.Controls.RynteTextBox txtDescription;
      private System.Windows.Forms.Label lbColor;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Button btColor;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btAdd;
      private Rynte.WinForms.Controls.RynteTextBox txtPassword;
      private Rynte.WinForms.Controls.RynteTextBox txtPort;
      private Rynte.WinForms.Controls.RynteTextBox txtUsername;
      private Rynte.WinForms.Controls.RynteTextBox txtHost;
      private Rynte.WinForms.Controls.RynteTextBox txtName;
      private System.Windows.Forms.ColorDialog colorDialog;
   }
}