namespace iService
{
    partial class iServiceMain
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bEIOrientation = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.bEIZoom = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.bCIAvailable = new DevExpress.XtraBars.BarCheckItem();
            this.rbPFirst = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPGToolbar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grdTable = new DevExpress.XtraGrid.GridControl();
            this.tileViewTable = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bEIOrientation,
            this.bEIZoom,
            this.bCIAvailable});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbPFirst});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemZoomTrackBar1});
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(442, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // bEIOrientation
            // 
            this.bEIOrientation.Caption = "Orientation";
            this.bEIOrientation.Edit = this.repositoryItemImageComboBox1;
            this.bEIOrientation.Id = 1;
            this.bEIOrientation.Name = "bEIOrientation";
            this.bEIOrientation.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bEIOrientation.Width = 140;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // bEIZoom
            // 
            this.bEIZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bEIZoom.Caption = "Zoom Size";
            this.bEIZoom.Edit = this.repositoryItemZoomTrackBar1;
            this.bEIZoom.EditValue = "190";
            this.bEIZoom.Id = 2;
            this.bEIZoom.Name = "bEIZoom";
            this.bEIZoom.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bEIZoom.Width = 140;
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemZoomTrackBar1.Maximum = 200;
            this.repositoryItemZoomTrackBar1.Middle = 5;
            this.repositoryItemZoomTrackBar1.Minimum = 170;
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            this.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            // 
            // bCIAvailable
            // 
            this.bCIAvailable.Caption = "Group by Available";
            this.bCIAvailable.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText;
            this.bCIAvailable.Id = 3;
            this.bCIAvailable.Name = "bCIAvailable";
            // 
            // rbPFirst
            // 
            this.rbPFirst.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPGToolbar,
            this.ribbonPageGroup2});
            this.rbPFirst.Name = "rbPFirst";
            this.rbPFirst.Text = "Menu";
            // 
            // ribbonPGToolbar
            // 
            this.ribbonPGToolbar.ItemLinks.Add(this.bEIOrientation);
            this.ribbonPGToolbar.ItemLinks.Add(this.bEIZoom);
            this.ribbonPGToolbar.ItemLinks.Add(this.bCIAvailable);
            this.ribbonPGToolbar.Name = "ribbonPGToolbar";
            this.ribbonPGToolbar.ShowCaptionButton = false;
            this.ribbonPGToolbar.Text = "ToolBar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 31);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.navigationPane1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 143);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(442, 275);
            this.panelControl1.TabIndex = 2;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Location = new System.Drawing.Point(2, 2);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPage[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(438, 271);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.SelectedPageIndex = 0;
            this.navigationPane1.Size = new System.Drawing.Size(442, 271);
            this.navigationPane1.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Expanded;
            this.navigationPane1.TabIndex = 0;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.grdTable);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(328, 211);
            // 
            // grdTable
            // 
            this.grdTable.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.grdTable.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdTable.Location = new System.Drawing.Point(0, 0);
            this.grdTable.MainView = this.tileViewTable;
            this.grdTable.MenuManager = this.ribbon;
            this.grdTable.Name = "grdTable";
            this.grdTable.Size = new System.Drawing.Size(328, 211);
            this.grdTable.TabIndex = 0;
            this.grdTable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileViewTable});
            // 
            // tileViewTable
            // 
            this.tileViewTable.GridControl = this.grdTable;
            this.tileViewTable.Name = "tileViewTable";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(328, 211);
            // 
            // iServiceMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "iServiceMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "iServiceMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileViewTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbPFirst;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPGToolbar;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraGrid.GridControl grdTable;
        private DevExpress.XtraGrid.Views.Tile.TileView tileViewTable;
        private DevExpress.XtraBars.BarEditItem bEIOrientation;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraBars.BarEditItem bEIZoom;
        private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private DevExpress.XtraBars.BarCheckItem bCIAvailable;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}