using System;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Registrator;

namespace FiltroLys.ZLys.Controles.Objeto
{
	public class GridControlUI : GridControl {
    
		protected override BaseView CreateDefaultView() {
            return CreateView("GridViewUI");
		}
		protected override void RegisterAvailableViewsCore(InfoCollection collection) {
			base.RegisterAvailableViewsCore(collection);
            collection.Add(new GridRegistrationUI());
		}

	}
}
