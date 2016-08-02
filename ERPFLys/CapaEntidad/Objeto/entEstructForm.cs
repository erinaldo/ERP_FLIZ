using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltroLys.Model.Objeto
{
    public class entEstructForm
    {
        private String _isoperacionX="";
        private List<String> _strX = new List<String>();
        private List<int> _numX = new List<int>();
        private List<DateTime> _datX = new List<DateTime>();
        private List<Decimal> _decX = new List<Decimal>();
        private List<Double> _douX = new List<Double>();
        private List<Object> _objX = new List<Object>();
        private Boolean _ok = true;

        public String OperacionX {
            get { return _isoperacionX; }
            set { _isoperacionX = value; }
        }

        public List<String> StrX {
            get { return _strX; }
            set { _strX = value; }
        }

        public List<int> NumX {
            get { return _numX; }
            set { _numX = value; }
        }

        public List<DateTime> DateX {
            get { return _datX; }
            set { _datX = value; }
        }

        public List<Decimal> DecX {
            get { return _decX; }
            set { _decX = value; }
        }

        public List<Double> DouX {
            get { return _douX; }
            set { _douX = value; }
        }

        public List<Object> ObjX
        {
            get { return _objX; }
            set { _objX = value; }
        }

        public Boolean VbOK {
            get { return _ok; }
            set { _ok = value; }
        }

    }
}
