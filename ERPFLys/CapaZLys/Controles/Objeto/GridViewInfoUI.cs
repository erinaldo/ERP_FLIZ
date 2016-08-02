using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using FiltroLys.ZLys.Controles.Objeto;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.BandedGrid;
using System.Drawing;
using DevExpress.XtraGrid.Drawing;
using DevExpress.Utils;
using System.Reflection;
using DevExpress.XtraGrid;

namespace FiltroLys.ZLys.Controles.Objeto
{
    class GridViewInfoUI:AdvBandedGridViewInfo
    {
        public GridViewInfoUI(AdvBandedGridView view) : base(view) { }
        //protected override int GetFooterPanelHeight()
        //{
        //    int h = 10;
        //    Graphics g = GInfo.AddGraphics(null);
        //    try
        //    {
        //        int minColumnPanelCount = 1;
        //        FooterPanelInfoArgs info = new FooterPanelInfoArgs(GInfo.Cache, minColumnPanelCount, FooterCellHeight);
        //        h = Painter.ElementsPainter.FooterPanel.CalcObjectMinBounds(info).Height;
        //    }
        //    finally
        //    {
        //        GInfo.ReleaseGraphics();
        //    }
        //    return Math.Max(h, View.FooterPanelHeight);
        //}
        protected override int GetFooterPanelHeight()
        {
            //return base.GetFooterPanelHeight();
            int h = 10;
            Graphics g = GInfo.AddGraphics(null);
            try
            {
                FooterPanelInfoArgs info = new FooterPanelInfoArgs(GInfo.Cache, /*ColumnPanelRowCount **/ GetMaxColumnFooterCount(), FooterCellHeight);
                h = Painter.ElementsPainter.FooterPanel.CalcObjectMinBounds(info).Height;
            }
            finally
            {
                GInfo.ReleaseGraphics();
            }
            return Math.Max(h, View.FooterPanelHeight);

        }
        //public override int FooterCellHeight
        //{
        //    get
        //    {
        //        return 10; //base.FooterCellHeight;
        //    }
        //}

        protected override void CalcFooterDrawInfo()
        {
            FooterInfo.IsDirty = false;
            FooterInfo.Cells.Clear();
            FooterInfo.Bounds = ViewRects.Footer;
            Rectangle maxBounds = Painter.ElementsPainter.FooterPanel.GetObjectClientRectangle(new StyleObjectInfoArgs(null, FooterInfo.Bounds, null, null, ObjectState.Normal));
            int maxFooterCount = GetMaxColumnFooterCount();
            foreach (GridColumnInfoArgs ci in ColumnsInfo)
            {
                if (ci.Type == GridColumnInfoType.Column)
                {
                    int valueCount = Math.Max(1, ci.Column.Summary.ActiveCount);
                    if (valueCount < maxFooterCount) valueCount++;
                    for (int n = 0; n < valueCount; n++)
                    {
                        CreateFooterCell(ci, n, maxFooterCount, maxBounds);
                    }
                }
            }

            //base.CalcFooterDrawInfo();
        }
        void CreateFooterCell(GridColumnInfoArgs ci, int n, int maxFooterCount, Rectangle maxBounds)
        {
            GridFooterCellInfoArgs fci = new GridFooterCellInfoArgs();
            int cellCount = 1;
            MethodInfo mi = ci.Column.Summary.GetType().GetMethod("GetActiveItem", BindingFlags.NonPublic | BindingFlags.Instance);

            fci.SummaryItem = mi.Invoke(ci.Column.Summary, new object[] { n }) as GridSummaryItem;//ci.Column.Summary.GetActiveItem(n);
            if (fci.SummaryItem == null) cellCount = maxFooterCount - n;
            Rectangle r = new Rectangle(ci.Bounds.Left, FooterInfo.Bounds.Top,
                ci.Bounds.Width, /*ci.Info.RowCount **/ FooterCellHeight);
            r = Painter.ElementsPainter.GroupFooterPanel.CalcCellBounds(maxBounds, r, FooterCellHeight, ci.Info.StartRow * maxFooterCount + n /** ci.Info.RowCount*/, /*ci.Info.RowCount **/ cellCount);
            fci.Bounds = r;
            fci.SetAppearance(PaintAppearance.FooterPanel.Clone() as AppearanceObject);
            fci.ColumnInfo = ci;
            if (fci.SummaryItem == null)
            {
                fci.Visible = false;
            }
            else
            {
                fci.Visible = true;
                fci.Value = fci.SummaryItem.SummaryValue;
                fci.DisplayText = GetFooterCellText(fci);
            }
            FooterInfo.Cells.Add(fci);
        }


    }

}
