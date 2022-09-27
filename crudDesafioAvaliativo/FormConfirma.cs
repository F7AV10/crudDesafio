using System;
using System.Drawing;
using System.Windows.Forms;

namespace crudDesafioAvaliativo
{
    public partial class FormConfirma : Form
    {
        public FormConfirma()
        {
            InitializeComponent();
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

        public event Action DelDados1;//EVENTO PARA EXECUTAR FUNCAO NA FORM1

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void ButtonCustom2_Click(object sender, EventArgs e)
        {            
            DelDados1?.Invoke();//CHAMA ACTION PARA CONFIRMAR EXCLUSÃO
            this.Close();//FECHA JANELA DE CONFIRMACAO
        }

        private void ButtonCustom1_Click(object sender, EventArgs e)
        {
            this.Close();//FECHA JANELA DE CONFIRMACAO
        }

        private void Panel1FormConfirma_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Panel1FormConfirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
        private void Panel1FormConfirma_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
