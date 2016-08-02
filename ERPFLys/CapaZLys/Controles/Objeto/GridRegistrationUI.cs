using System;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Registrator;
using FiltroLys.ZLys.Controles.Objeto;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.BandedGrid.Drawing;

namespace FiltroLys.ZLys.Controles.Objeto
{
    public class GridRegistrationUI : AdvBandedGridInfoRegistrator
    {
        public override string ViewName { get { return "GridViewUI"; } }
        public override BaseView CreateView(GridControl grid) { return new GridViewUI(grid as GridControl); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return /*base.CreateViewInfo(view);*/ new GridViewInfoUI(view as AdvBandedGridView); }
        //public override BaseViewPainter CreatePainter(BaseView view) { return new AdvBandedGridPainter(view as AdvBandedGridView); }
	}
}
