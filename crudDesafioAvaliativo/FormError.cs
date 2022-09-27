using System;
using System.Windows.Forms;

namespace crudDesafioAvaliativo
{
    public partial class FormError : Form
    {
        public FormError(string msgErro)
        {
            InitializeComponent();
            labelMsgErro.Text = msgErro;
        }
        private const int _DropShadown = 0x00020000;//ADICIONAR SOMBRA AO FORM
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams sombra = base.CreateParams;
                sombra.ClassStyle |= _DropShadown;
                return sombra;
            }
        }//--- FIM ADICIONAR SOMBRA AO FORM ------
        private void ButtonCloseForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
