using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using iService.Properties;
using iService.Class;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace iService
{
    public partial class iServiceMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public iServiceMain()
        {
            InitializeComponent();
            InitData();
            SetupView();
            InitOrientationDropDown();
            repositoryItemZoomTrackBar1.EditValueChanged += repositoryItemZoomTrackBar1_EditValueChanged;
            bCIAvailable.CheckedChanged += bCIAvailable_CheckedChanged;
        }

        private void SetupView()
        {
            try
            {
                // Setup tiles options
                tileViewTable.BeginUpdate();
                tileViewTable.OptionsTiles.RowCount = 3;
                tileViewTable.OptionsTiles.Padding = new Padding(20);
                tileViewTable.OptionsTiles.ItemPadding = new Padding(10);
                tileViewTable.OptionsTiles.IndentBetweenItems = 20;
                tileViewTable.OptionsTiles.ItemSize = new Size(340, 190);
                tileViewTable.Appearance.ItemNormal.ForeColor = Color.White;
                tileViewTable.Appearance.ItemNormal.BorderColor = Color.Transparent;
                //Setup tiles template
                TileViewItemElement leftPanel = new TileViewItemElement();
                TileViewItemElement splitLine = new TileViewItemElement();
                TileViewItemElement tableCaption = new TileViewItemElement();
                TileViewItemElement tableValue = new TileViewItemElement();
                TileViewItemElement guestCaption = new TileViewItemElement();
                TileViewItemElement guestValue = new TileViewItemElement();
                TileViewItemElement amount = new TileViewItemElement();
                TileViewItemElement image = new TileViewItemElement();
                tileViewTable.TileTemplate.Add(leftPanel);
                tileViewTable.TileTemplate.Add(splitLine);
                tileViewTable.TileTemplate.Add(tableCaption);
                tileViewTable.TileTemplate.Add(tableValue);
                tileViewTable.TileTemplate.Add(guestCaption);
                tileViewTable.TileTemplate.Add(guestValue);
                tileViewTable.TileTemplate.Add(amount);
                tileViewTable.TileTemplate.Add(image);
                //
                leftPanel.StretchVertical = true;
                leftPanel.Width = 122;
                leftPanel.TextLocation = new Point(-10, 0);
                leftPanel.Appearance.Normal.BackColor = Color.FromArgb(58, 166, 101);
                //
                splitLine.StretchVertical = true;
                splitLine.Width = 3;
                splitLine.TextAlignment = TileItemContentAlignment.Manual;
                splitLine.TextLocation = new Point(110, 0);
                splitLine.Appearance.Normal.BackColor = Color.White;
                //
                tableCaption.Text = Resources.ResourceManager.GetString("TableCaption");
                tableCaption.TextAlignment = TileItemContentAlignment.TopLeft;
                tableCaption.Appearance.Normal.FontSizeDelta = -1;
                //
                tableValue.Column = tileViewTable.Columns["TableName"];
                tableValue.AnchorElement = tableCaption;
                tableValue.AnchorIndent = 2;
                tableValue.MaxWidth = 100;
                tableValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                //
                guestCaption.Text = Resources.ResourceManager.GetString("GuestCaption");
                guestCaption.AnchorElement = tableValue;
                guestCaption.AnchorIndent = 14;
                guestCaption.Appearance.Normal.FontSizeDelta = -1;
                //
                guestValue.Column = tileViewTable.Columns["TableName"];
                guestValue.AnchorElement = guestCaption;
                guestValue.AnchorIndent = 2;
                guestValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                //
                amount.Column = tileViewTable.Columns["TableID"];
                amount.TextAlignment = TileItemContentAlignment.BottomLeft;
                amount.Appearance.Normal.Font = new Font("Segoe UI Semilight", 25.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //
                image.Column = tileViewTable.Columns["Picture"];
                image.ImageSize = new Size(280, 220);
                image.ImageAlignment = TileItemContentAlignment.MiddleRight;
                image.ImageScaleMode = TileItemImageScaleMode.ZoomOutside;
                image.ImageLocation = new Point(10, 10);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                tileViewTable.EndUpdate();
            }
        }

        private void InitData()
        {
            try
            {
                this.Text = Resources.ResourceManager.GetString("AppName");
                List<iTable> allTable = new List<iTable>();
                iTable table = new iTable();
                allTable = table.getAllTable();
                grdTable.DataSource = allTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void InitOrientationDropDown()
        {
            foreach (Orientation orientation in Enum.GetValues(typeof(Orientation)))
            {
                ImageComboBoxItem cbItem = new ImageComboBoxItem(orientation.ToString(), orientation);
                repositoryItemImageComboBox1.Items.Add(cbItem);
            }
            bEIOrientation.EditValue = Orientation.Horizontal;
            bEIOrientation.EditValueChanged += barEditItem2_EditValueChanged;
        }

        void barEditItem2_EditValueChanged(object sender, EventArgs e)
        {
            var orientation = (Orientation)bEIOrientation.EditValue;
            tileViewTable.OptionsTiles.Orientation = orientation;
        }

        void repositoryItemZoomTrackBar1_EditValueChanged(object sender, EventArgs e)
        {
            int h = (int)(sender as BaseEdit).EditValue;
            int w = (int)(h * 1.78);
            tileViewTable.OptionsTiles.ItemSize = new Size(w, h);
        }

        void bCIAvailable_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((sender as BarCheckItem).Checked)
                tileViewTable.ColumnSet.GroupColumn = tileViewTable.Columns["TableType"];
            else
                tileViewTable.ColumnSet.GroupColumn = null;
        } 
    }
}