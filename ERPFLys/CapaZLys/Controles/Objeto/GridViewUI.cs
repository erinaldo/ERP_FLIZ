using System;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Scrolling;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using System.Windows.Forms;
using FiltroLys.ZLys.Controles.Objeto;

namespace FiltroLys.ZLys.Controles.Objeto
{
    public class GridViewUI : DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    {
        public bool AllowMenu { get; set; }

        public GridViewUI() : this(null) { }
        public GridViewUI(DevExpress.XtraGrid.GridControl grid)
            : base(grid) 
        {
        }

        protected override string ViewName { get { return "GridViewUI"; } }

        
	}
}
