using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FiltroLys.Type;
using FiltroLys.Model.Objeto;

namespace FiltroLys.ZLys.Funciones
{
    public class fnControl
    {
        public static void KeyNextFocus(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        public static void KeySoloDecimal(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int DECIMAL_POINT = 46;
            const int ZERO = 48;
            const int NINE = 57;
            const int NOT_FOUND = -1;            
            
            int keyvalue = e.KeyChar;            
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;

            TextBox txt = (sender as TextBox);
            
            if (keyvalue == DECIMAL_POINT){
                if (txt.SelectedText.Length == 0){if (txt.Text.IndexOf(".") == NOT_FOUND) return;}
                else{ return;}
            }
            e.Handled = true;
        }

        public static void KeySoloDecimalNeg(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int NEGATIVE = 45;
            const int DECIMAL_POINT = 46;
            const int ZERO = 48;
            const int NINE = 57;
            const int NOT_FOUND = -1;

            int keyvalue = e.KeyChar;
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;

            TextBox txt = (sender as TextBox);
            if (keyvalue == DECIMAL_POINT){
                if (txt.SelectedText.Length == 0){if (txt.Text.IndexOf(".") == NOT_FOUND) return;}
                else{ return;}
            }

            if (keyvalue == NEGATIVE){
                if (txt.SelectedText.Length == 0){if (txt.SelectionStart == 0) { return; }}
                else{ return;}
            }

            e.Handled = true;
        }

        public static void KeySoloNumero(object sender, KeyPressEventArgs e){
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;
            
            int keyvalue = e.KeyChar;
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            
            e.Handled = true;
        }

        public static void KeySoloNumeroNeg(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int NEGATIVE = 45;
            const int ZERO = 48;
            const int NINE = 57;
            
            int keyvalue = e.KeyChar;
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;

            TextBox txt = (sender as TextBox);
            if (keyvalue == NEGATIVE){
                if (txt.SelectedText.Length == 0) { if (txt.SelectionStart == 0) { return; } }
                else { return; }
            }

            e.Handled = true;
        }
        
        public static void GVCellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            /*FiltroLys.ZLys.Controles.Controles.GridLista Grid = (FiltroLys.ZLys.Controles.Controles.GridLista)((sender));
            String sColName = Grid.Columns[e.ColumnIndex].Name;

            System.TypeCode typecode = System.Type.GetTypeCode(Grid.Columns[e.ColumnIndex].ValueType);
            switch (typecode)
            {
                case TypeCode.Int32:
                    if ((Int32)e.Value == Int32.MinValue)
                    {
                        e.Value = String.Empty;
                        e.FormattingApplied = true;
                    }
                    break;
                case TypeCode.Decimal:
                    break;
                case TypeCode.DateTime:
                    if ((DateTime)e.Value == DateTime.MinValue)
                    {
                        e.Value = String.Empty;
                        e.FormattingApplied = true;
                    }
                    break;
            }    */        
        }
        
    }
}
