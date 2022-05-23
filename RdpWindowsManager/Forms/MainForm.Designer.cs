namespace RdpWindowsManager.Forms
{
   partial class MainForm
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.panel1 = new System.Windows.Forms.Panel();
         this.btEdit = new System.Windows.Forms.Button();
         this.btRemove = new System.Windows.Forms.Button();
         this.btAdd = new System.Windows.Forms.Button();
         this.btConnect = new System.Windows.Forms.Button();
         this.panel4 = new System.Windows.Forms.Panel();
         this.txtSearch = new Rynte.WinForms.Controls.RynteTextBox();
         this.tabControl = new Rynte.WinForms.Controls.RynteTabControl();
         this.panel3 = new System.Windows.Forms.Panel();
         this.serverTreeView = new Rynte.WinForms.Controls.RynteTreeView();
         this.imageList1 = new System.Windows.Forms.ImageList(this.components);
         this.panel2 = new System.Windows.Forms.Panel();
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.TabDisconnect = new System.Windows.Forms.ToolStripMenuItem();
         this.panel1.SuspendLayout();
         this.panel3.SuspendLayout();
         this.contextMenuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.panel1.Controls.Add(this.btEdit);
         this.panel1.Controls.Add(this.btRemove);
         this.panel1.Controls.Add(this.btAdd);
         this.panel1.Controls.Add(this.btConnect);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.ForeColor = System.Drawing.Color.Gainsboro;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(800, 30);
         this.panel1.TabIndex = 6;
         // 
         // btEdit
         // 
         this.btEdit.FlatAppearance.BorderSize = 0;
         this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btEdit.Location = new System.Drawing.Point(240, 5);
         this.btEdit.Name = "btEdit";
         this.btEdit.Size = new System.Drawing.Size(94, 20);
         this.btEdit.TabIndex = 4;
         this.btEdit.TabStop = false;
         this.btEdit.Text = "Редактировать";
         this.btEdit.UseVisualStyleBackColor = true;
         this.btEdit.Click += new System.EventHandler(this.BtEdit_Click);
         // 
         // btRemove
         // 
         this.btRemove.FlatAppearance.BorderSize = 0;
         this.btRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btRemove.Location = new System.Drawing.Point(177, 5);
         this.btRemove.Name = "btRemove";
         this.btRemove.Size = new System.Drawing.Size(57, 20);
         this.btRemove.TabIndex = 3;
         this.btRemove.TabStop = false;
         this.btRemove.Text = "Удалить";
         this.btRemove.UseVisualStyleBackColor = true;
         this.btRemove.Click += new System.EventHandler(this.BtRemove_Click);
         // 
         // btAdd
         // 
         this.btAdd.FlatAppearance.BorderSize = 0;
         this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btAdd.Location = new System.Drawing.Point(104, 5);
         this.btAdd.Name = "btAdd";
         this.btAdd.Size = new System.Drawing.Size(67, 20);
         this.btAdd.TabIndex = 2;
         this.btAdd.TabStop = false;
         this.btAdd.Text = "Добавить";
         this.btAdd.UseVisualStyleBackColor = true;
         this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
         // 
         // btConnect
         // 
         this.btConnect.FlatAppearance.BorderSize = 0;
         this.btConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btConnect.Location = new System.Drawing.Point(5, 5);
         this.btConnect.Name = "btConnect";
         this.btConnect.Size = new System.Drawing.Size(93, 20);
         this.btConnect.TabIndex = 1;
         this.btConnect.TabStop = false;
         this.btConnect.Text = "Подключиться";
         this.btConnect.UseVisualStyleBackColor = true;
         this.btConnect.Click += new System.EventHandler(this.BtConnect_Click);
         // 
         // panel4
         // 
         this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel4.Location = new System.Drawing.Point(201, 31);
         this.panel4.Name = "panel4";
         this.panel4.Size = new System.Drawing.Size(1, 419);
         this.panel4.TabIndex = 9;
         // 
         // txtSearch
         // 
         this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.txtSearch.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Default;
         this.txtSearch.BorderSize = 0;
         this.txtSearch.DefaultText = "";
         this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
         this.txtSearch.ForeColor = System.Drawing.Color.Gainsboro;
         this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtSearch.HoverState.BorderSize = 1;
         this.txtSearch.Location = new System.Drawing.Point(0, 0);
         this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
         this.txtSearch.Multiline = false;
         this.txtSearch.Name = "txtSearch";
         this.txtSearch.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
         this.txtSearch.PasswordChar = false;
         this.txtSearch.Placeholder = "Search...";
         this.txtSearch.ReadOnly = false;
         this.txtSearch.Size = new System.Drawing.Size(201, 26);
         this.txtSearch.TabIndex = 0;
         this.txtSearch.DefaultTextChanged += new System.EventHandler(this.RynteTextBox1_DefaultTextChanged);
         // 
         // tabControl
         // 
         this.tabControl.BorderPageColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tabControl.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.tabControl.ItemSize = new System.Drawing.Size(240, 16);
         this.tabControl.Location = new System.Drawing.Point(201, 31);
         this.tabControl.Name = "tabControl";
         this.tabControl.SelectedIndex = 0;
         this.tabControl.SelectTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.tabControl.SelectTextTabColor = System.Drawing.Color.White;
         this.tabControl.Size = new System.Drawing.Size(599, 419);
         this.tabControl.TabColor = System.Drawing.Color.Gray;
         this.tabControl.TabIndex = 10;
         this.tabControl.TextTabColor = System.Drawing.Color.White;
         this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TabControl_MouseClick);
         // 
         // panel3
         // 
         this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.panel3.Controls.Add(this.serverTreeView);
         this.panel3.Controls.Add(this.txtSearch);
         this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
         this.panel3.Location = new System.Drawing.Point(0, 31);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(201, 419);
         this.panel3.TabIndex = 8;
         // 
         // serverTreeView
         // 
         this.serverTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.serverTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.serverTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.serverTreeView.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
         this.serverTreeView.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.serverTreeView.ForeColor = System.Drawing.Color.LightGray;
         this.serverTreeView.ImageIndex = 0;
         this.serverTreeView.ImageList = this.imageList1;
         this.serverTreeView.Indent = 15;
         this.serverTreeView.ItemHeight = 18;
         this.serverTreeView.LineColor = System.Drawing.Color.Gray;
         this.serverTreeView.Location = new System.Drawing.Point(0, 34);
         this.serverTreeView.Name = "serverTreeView";
         this.serverTreeView.SelectedImageIndex = 0;
         this.serverTreeView.SelectFullRow = false;
         this.serverTreeView.SelectNodeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(93)))));
         this.serverTreeView.SelectNodeForeColor = System.Drawing.Color.Gainsboro;
         this.serverTreeView.ShowNodeToolTips = true;
         this.serverTreeView.ShowRootLines = false;
         this.serverTreeView.Size = new System.Drawing.Size(201, 385);
         this.serverTreeView.TabIndex = 0;
         // 
         // imageList1
         // 
         this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
         this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
         this.imageList1.Images.SetKeyName(0, "image0.bmp");
         this.imageList1.Images.SetKeyName(1, "image1.bmp");
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel2.Location = new System.Drawing.Point(0, 30);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(800, 1);
         this.panel2.TabIndex = 7;
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TabDisconnect});
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
         // 
         // TabDisconnect
         // 
         this.TabDisconnect.Name = "TabDisconnect";
         this.TabDisconnect.Size = new System.Drawing.Size(148, 22);
         this.TabDisconnect.Text = "Отключиться";
         this.TabDisconnect.Click += new System.EventHandler(this.TabDisconnect_Click);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.panel4);
         this.Controls.Add(this.tabControl);
         this.Controls.Add(this.panel3);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.ForeColor = System.Drawing.Color.Black;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "RDP Windows Manager";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.MainForm_Load);
         this.panel1.ResumeLayout(false);
         this.panel3.ResumeLayout(false);
         this.contextMenuStrip1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btEdit;
      private System.Windows.Forms.Button btRemove;
      private System.Windows.Forms.Button btAdd;
      private System.Windows.Forms.Button btConnect;
      private System.Windows.Forms.Panel panel4;
      private Rynte.WinForms.Controls.RynteTextBox txtSearch;
      private Rynte.WinForms.Controls.RynteTabControl tabControl;
      private System.Windows.Forms.Panel panel3;
      private Rynte.WinForms.Controls.RynteTreeView serverTreeView;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.ImageList imageList1;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem TabDisconnect;
   }
}