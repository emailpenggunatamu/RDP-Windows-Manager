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
         this.pnButtons = new System.Windows.Forms.Panel();
         this.btSetting = new System.Windows.Forms.Button();
         this.btAddServer = new System.Windows.Forms.Button();
         this.btConnect = new System.Windows.Forms.Button();
         this.separator1 = new System.Windows.Forms.Panel();
         this.pnExplorer = new System.Windows.Forms.Panel();
         this.serverView = new Rynte.WinForms.Controls.RynteTreeView();
         this.imageList = new System.Windows.Forms.ImageList(this.components);
         this.txtSearch = new Rynte.WinForms.Controls.RynteTextBox();
         this.separator2 = new System.Windows.Forms.Panel();
         this.menuCategory = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.btCategoryEdit = new System.Windows.Forms.ToolStripMenuItem();
         this.btCategoryDelete = new System.Windows.Forms.ToolStripMenuItem();
         this.menuServer = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.btServerConnect = new System.Windows.Forms.ToolStripMenuItem();
         this.btServerEdit = new System.Windows.Forms.ToolStripMenuItem();
         this.btServerDelete = new System.Windows.Forms.ToolStripMenuItem();
         this.serverTabControl = new Rynte.WinForms.Controls.RynteTabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.pnButtons.SuspendLayout();
         this.pnExplorer.SuspendLayout();
         this.menuCategory.SuspendLayout();
         this.menuServer.SuspendLayout();
         this.serverTabControl.SuspendLayout();
         this.SuspendLayout();
         // 
         // pnButtons
         // 
         this.pnButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.pnButtons.Controls.Add(this.btSetting);
         this.pnButtons.Controls.Add(this.btAddServer);
         this.pnButtons.Controls.Add(this.btConnect);
         resources.ApplyResources(this.pnButtons, "pnButtons");
         this.pnButtons.Name = "pnButtons";
         // 
         // btSetting
         // 
         this.btSetting.FlatAppearance.BorderSize = 0;
         resources.ApplyResources(this.btSetting, "btSetting");
         this.btSetting.Name = "btSetting";
         this.btSetting.UseVisualStyleBackColor = true;
         this.btSetting.Click += new System.EventHandler(this.BtSetting_Click);
         // 
         // btAddServer
         // 
         this.btAddServer.FlatAppearance.BorderSize = 0;
         resources.ApplyResources(this.btAddServer, "btAddServer");
         this.btAddServer.Name = "btAddServer";
         this.btAddServer.UseVisualStyleBackColor = true;
         this.btAddServer.Click += new System.EventHandler(this.BtAddServer_Click);
         // 
         // btConnect
         // 
         this.btConnect.FlatAppearance.BorderSize = 0;
         resources.ApplyResources(this.btConnect, "btConnect");
         this.btConnect.Name = "btConnect";
         this.btConnect.UseVisualStyleBackColor = true;
         this.btConnect.Click += new System.EventHandler(this.ConnectServer);
         // 
         // separator1
         // 
         this.separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         resources.ApplyResources(this.separator1, "separator1");
         this.separator1.Name = "separator1";
         // 
         // pnExplorer
         // 
         this.pnExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.pnExplorer.Controls.Add(this.serverView);
         this.pnExplorer.Controls.Add(this.txtSearch);
         resources.ApplyResources(this.pnExplorer, "pnExplorer");
         this.pnExplorer.Name = "pnExplorer";
         // 
         // serverView
         // 
         resources.ApplyResources(this.serverView, "serverView");
         this.serverView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
         this.serverView.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.serverView.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
         this.serverView.ForeColor = System.Drawing.Color.LightGray;
         this.serverView.ImageList = this.imageList;
         this.serverView.ItemHeight = 18;
         this.serverView.LineColor = System.Drawing.Color.Gray;
         this.serverView.Name = "serverView";
         this.serverView.SelectFullRow = false;
         this.serverView.SelectNodeBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(84)))), ((int)(((byte)(93)))));
         this.serverView.SelectNodeForeColor = System.Drawing.Color.Gainsboro;
         this.serverView.ShowNodeToolTips = true;
         this.serverView.ShowRootLines = false;
         this.serverView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ServerView_NodeMouseClick);
         // 
         // imageList
         // 
         this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
         this.imageList.TransparentColor = System.Drawing.Color.Transparent;
         this.imageList.Images.SetKeyName(0, "serverIcon.png");
         this.imageList.Images.SetKeyName(1, "desktopIcon.png");
         // 
         // txtSearch
         // 
         this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         this.txtSearch.BorderMode = Rynte.WinForms.Controls.Enums.BorderMode.Default;
         this.txtSearch.BorderSize = 1;
         this.txtSearch.DefaultText = "";
         resources.ApplyResources(this.txtSearch, "txtSearch");
         this.txtSearch.ForeColor = System.Drawing.Color.LightGray;
         this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.txtSearch.HoverState.BorderSize = 1;
         this.txtSearch.Multiline = false;
         this.txtSearch.Name = "txtSearch";
         this.txtSearch.PasswordChar = false;
         this.txtSearch.Placeholder = "Search...";
         this.txtSearch.ReadOnly = false;
         this.txtSearch.DefaultTextChanged += new System.EventHandler(this.TxtSearch_DefaultTextChanged);
         // 
         // separator2
         // 
         this.separator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
         resources.ApplyResources(this.separator2, "separator2");
         this.separator2.Name = "separator2";
         // 
         // menuCategory
         // 
         this.menuCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         resources.ApplyResources(this.menuCategory, "menuCategory");
         this.menuCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCategoryEdit,
            this.btCategoryDelete});
         this.menuCategory.Name = "menuCategory";
         this.menuCategory.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
         // 
         // btCategoryEdit
         // 
         this.btCategoryEdit.ForeColor = System.Drawing.Color.Gainsboro;
         this.btCategoryEdit.Image = global::RdpWindowsManager.Properties.Resources.editIcon;
         this.btCategoryEdit.Name = "btCategoryEdit";
         this.btCategoryEdit.Padding = new System.Windows.Forms.Padding(0);
         resources.ApplyResources(this.btCategoryEdit, "btCategoryEdit");
         this.btCategoryEdit.Click += new System.EventHandler(this.BtCategoryEdit_Click);
         // 
         // btCategoryDelete
         // 
         this.btCategoryDelete.ForeColor = System.Drawing.Color.Gainsboro;
         this.btCategoryDelete.Image = global::RdpWindowsManager.Properties.Resources.deleteIcon;
         this.btCategoryDelete.Name = "btCategoryDelete";
         this.btCategoryDelete.Padding = new System.Windows.Forms.Padding(0);
         resources.ApplyResources(this.btCategoryDelete, "btCategoryDelete");
         this.btCategoryDelete.Click += new System.EventHandler(this.RemoveServerTreeNode);
         // 
         // menuServer
         // 
         this.menuServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         resources.ApplyResources(this.menuServer, "menuServer");
         this.menuServer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btServerConnect,
            this.btServerEdit,
            this.btServerDelete});
         this.menuServer.Name = "menuCategory";
         this.menuServer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
         // 
         // btServerConnect
         // 
         this.btServerConnect.ForeColor = System.Drawing.Color.Gainsboro;
         this.btServerConnect.Image = global::RdpWindowsManager.Properties.Resources.connectIcon;
         this.btServerConnect.Name = "btServerConnect";
         this.btServerConnect.Padding = new System.Windows.Forms.Padding(0);
         resources.ApplyResources(this.btServerConnect, "btServerConnect");
         this.btServerConnect.Click += new System.EventHandler(this.ConnectServer);
         // 
         // btServerEdit
         // 
         this.btServerEdit.ForeColor = System.Drawing.Color.Gainsboro;
         this.btServerEdit.Image = global::RdpWindowsManager.Properties.Resources.editIcon;
         this.btServerEdit.Name = "btServerEdit";
         this.btServerEdit.Padding = new System.Windows.Forms.Padding(0);
         resources.ApplyResources(this.btServerEdit, "btServerEdit");
         this.btServerEdit.Click += new System.EventHandler(this.BtServerEdit_Click);
         // 
         // btServerDelete
         // 
         this.btServerDelete.ForeColor = System.Drawing.Color.Gainsboro;
         this.btServerDelete.Image = global::RdpWindowsManager.Properties.Resources.deleteIcon;
         this.btServerDelete.Name = "btServerDelete";
         this.btServerDelete.Padding = new System.Windows.Forms.Padding(0);
         resources.ApplyResources(this.btServerDelete, "btServerDelete");
         this.btServerDelete.Click += new System.EventHandler(this.RemoveServerTreeNode);
         // 
         // serverTabControl
         // 
         this.serverTabControl.BorderPageColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.serverTabControl.Controls.Add(this.tabPage1);
         resources.ApplyResources(this.serverTabControl, "serverTabControl");
         this.serverTabControl.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.serverTabControl.Name = "serverTabControl";
         this.serverTabControl.SelectedIndex = 0;
         this.serverTabControl.SelectTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(156)))), ((int)(((byte)(215)))));
         this.serverTabControl.SelectTextTabColor = System.Drawing.Color.White;
         this.serverTabControl.TabColor = System.Drawing.Color.Gray;
         this.serverTabControl.TextTabColor = System.Drawing.Color.White;
         // 
         // tabPage1
         // 
         this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         resources.ApplyResources(this.tabPage1, "tabPage1");
         this.tabPage1.Name = "tabPage1";
         // 
         // MainForm
         // 
         resources.ApplyResources(this, "$this");
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
         this.Controls.Add(this.serverTabControl);
         this.Controls.Add(this.separator2);
         this.Controls.Add(this.pnExplorer);
         this.Controls.Add(this.separator1);
         this.Controls.Add(this.pnButtons);
         this.DoubleBuffered = true;
         this.ForeColor = System.Drawing.Color.Gainsboro;
         this.Name = "MainForm";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.MainForm_Load);
         this.pnButtons.ResumeLayout(false);
         this.pnExplorer.ResumeLayout(false);
         this.menuCategory.ResumeLayout(false);
         this.menuServer.ResumeLayout(false);
         this.serverTabControl.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel pnButtons;
      private System.Windows.Forms.Button btSetting;
      private System.Windows.Forms.Button btAddServer;
      private System.Windows.Forms.Button btConnect;
      private System.Windows.Forms.Panel separator1;
      private System.Windows.Forms.Panel pnExplorer;
      private Rynte.WinForms.Controls.RynteTextBox txtSearch;
      private System.Windows.Forms.Panel separator2;
      private System.Windows.Forms.ContextMenuStrip menuCategory;
      private System.Windows.Forms.ToolStripMenuItem btCategoryEdit;
      private System.Windows.Forms.ToolStripMenuItem btCategoryDelete;
      private System.Windows.Forms.ContextMenuStrip menuServer;
      private System.Windows.Forms.ToolStripMenuItem btServerConnect;
      private System.Windows.Forms.ToolStripMenuItem btServerEdit;
      private System.Windows.Forms.ToolStripMenuItem btServerDelete;
      private Rynte.WinForms.Controls.RynteTreeView serverView;
      private System.Windows.Forms.ImageList imageList;
      private Rynte.WinForms.Controls.RynteTabControl serverTabControl;
      private System.Windows.Forms.TabPage tabPage1;
   }
}