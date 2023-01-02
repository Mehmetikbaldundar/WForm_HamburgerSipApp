using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_1
{
    public class Fonksiyonlar
    {
        public static void Temizle(Control.ControlCollection secimler)
        {
            foreach (Control kontrol in secimler)
            {
                if (kontrol is ComboBox) ((ComboBox)kontrol).SelectedIndex = -1;
                else if (kontrol is RadioButton)
                {
                    if (((RadioButton)kontrol).Name == "rdbKucuk") ((RadioButton)kontrol).Checked = true;
                    else ((RadioButton)kontrol).Checked = false;
                }
                else if (kontrol is NumericUpDown) ((NumericUpDown)kontrol).Value = 1;
                else if (kontrol is CheckBox) ((CheckBox)kontrol).Checked = false;
                else if (kontrol is GroupBox) Temizle(((GroupBox)kontrol).Controls);
                else if (kontrol is FlowLayoutPanel) Temizle(((FlowLayoutPanel)kontrol).Controls);
            }
        }


    }
}
