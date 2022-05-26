namespace RdpWindowsManager.Forms
{
   partial class CategoryForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryForm));
         this.label1 = new System.Windows.Forms.Label();
         this.txtName = new Rynte.WinForms.Controls.RynteTextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.btColor = new System.Windows.Forms.Button();
         this.lbColor = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.txtDescription = new Rynte.WinForms.Controls.RynteTextBox();
         this.btSave = new System.Windows.Forms.Button();
         this.colorDialog = new System.Windows.Forms.ColorDialog();
         this.SuspendLayout();
         // 
         // label1
         // 
         resources.ApplyResources(this.label1, "label1");
         this.label1.Name = "label1";
         // 
         // txtName
         // 
         this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtName.BorderColor = System.Drawing.Color.Gray;
         this.txtName.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Underline;
         this.txtName.BorderSize = 1;
         this.txtName.DefaultText = "";
         this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtName.HoverState.BorderSize = 1;
         resources.ApplyResources(this.txtName, "txtName");
         this.txtName.Multiline = false;
         this.txtName.Name = "txtName";
         this.txtName.PasswordChar = false;
         this.txtName.Placeholder = null;
         this.txtName.ReadOnly = false;
         // 
         // label2
         // 
         resources.ApplyResources(this.label2, "label2");
         this.label2.Name = "label2";
         // 
         // btColor
         // 
         this.btColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.btColor.FlatAppearance.BorderSize = 0;
         resources.ApplyResources(this.btColor, "btColor");
         this.btColor.Name = "btColor";
         this.btColor.UseVisualStyleBackColor = false;
         this.btColor.Click += new System.EventHandler(this.BtColor_Click);
         // 
         // lbColor
         // 
         resources.ApplyResources(this.lbColor, "lbColor");
         this.lbColor.Name = "lbColor";
         // 
         // label4
         // 
         resources.ApplyResources(this.label4, "label4");
         this.label4.Name = "label4";
         // 
         // txtDescription
         // 
         this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtDescription.BorderColor = System.Drawing.Color.Gray;
         this.txtDescription.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Default;
         this.txtDescription.BorderSize = 1;
         this.txtDescription.DefaultText = "";
         this.txtDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtDescription.HoverState.BorderSize = 1;
         resources.ApplyResources(this.txtDescription, "txtDescription");
         this.txtDescription.Multiline = true;
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.PasswordChar = false;
         this.txtDescription.Placeholder = null;
         this.txtDescription.ReadOnly = false;
         // 
         // btSave
         // 
         this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.btSave.FlatAppearance.BorderSize = 0;
         resources.ApplyResources(this.btSave, "btSave");
         this.btSave.Name = "btSave";
         this.btSave.UseVisualStyleBackColor = false;
         this.btSave.Click += new System.EventHandler(this.BtSave_Click);
         // 
         // colorDialog
         // 
         this.colorDialog.AnyColor = true;
         this.colorDialog.Color = System.Drawing.Color.Gainsboro;
         this.colorDialog.FullOpen = true;
         this.colorDialog.SolidColorOnly = true;
         // 
         // CategoryForm
         // 
         resources.ApplyResources(this, "$this");
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.Controls.Add(this.btSave);
         this.Controls.Add(this.txtDescription);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.lbColor);
         this.Controls.Add(this.btColor);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.label1);
         this.ForeColor = System.Drawing.Color.Gainsboro;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "CategoryForm";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private Rynte.WinForms.Controls.RynteTextBox txtName;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btColor;
      private System.Windows.Forms.Label lbColor;
      private System.Windows.Forms.Label label4;
      private Rynte.WinForms.Controls.RynteTextBox txtDescription;
      private System.Windows.Forms.Button btSave;
      private System.Windows.Forms.ColorDialog colorDialog;
   }
}