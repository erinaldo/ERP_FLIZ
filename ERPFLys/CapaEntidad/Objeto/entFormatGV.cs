using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiltroLys.Type;

namespace FiltroLys.Model.Objeto
{
    public class entFormatGV
    {
        private fnEnum.EditOcxShow nValAnt = fnEnum.EditOcxShow.Normal;
        private fnEnum.EditOcxShow nValNvo = fnEnum.EditOcxShow.Normal;

        public fnEnum.EditOcxShow ValorAnt {
            get { return nValAnt; }
            set { nValAnt = value; }
        }

        public fnEnum.EditOcxShow ValorNvo
        {
            get { return nValNvo; }
            set { nValNvo = value; }
        }

    }
}
