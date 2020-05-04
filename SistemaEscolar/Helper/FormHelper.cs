using System.Media;
using System.Windows.Forms;

namespace SistemaEscolar.Helper
{ 
    public class FormHelper
    {
        public static void SetTextEmpty(Control control)
        {

            foreach (Control c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = string.Empty;
                if (c is MaskedTextBox) ((MaskedTextBox)c).Text = string.Empty;
                if (c is RadioButton) ((RadioButton)c).Checked = false;
                if (c is ComboBox) ((ComboBox)c).SelectedIndex = -1;
                SetTextEmpty(c);
            }
        }

        public static bool CheckEmptyField(Control control, ErrorProvider error)
        {
            error.Clear();
            if (control.Text == string.Empty)
            {
                error.SetError(control, "Obrigatório");
                SystemSounds.Beep.Play();
                control.Focus();
                return true;
            }

            if (control.Text == "  /  /" || control.Text == "(  )      -")
            {
                error.SetError(control, "Obrigatório");
                SystemSounds.Beep.Play();
                control.Focus();
                return true;
            }

            //if (control.Checked == false)
            return false;
        }
    }
}
