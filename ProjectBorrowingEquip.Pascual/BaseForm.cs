using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBorrowingEquip.Pascual
{
    public class BaseForm : Form
    {
        
        public virtual void OpenForm(Form formToOpen)
        {
            formToOpen.StartPosition = FormStartPosition.CenterScreen;
            formToOpen.Show();
            this.Close();
        }
    }
}
