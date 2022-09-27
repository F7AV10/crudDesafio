using System;
using System.Drawing;
using System.Windows.Forms;

namespace crudDesafioAvaliativo
{
    public partial class alerta : Form
    {
        public alerta()
        {
            InitializeComponent();            
        }
        public enum EnmAction
        {
            wait,
            start,
            close
        }
        private alerta.EnmAction action;

        private int x, y;
        public void ShowAlert(string msg)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 0; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                alerta frm = (alerta)Application.OpenForms[fname];

                if(frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = (Screen.PrimaryScreen.WorkingArea.Height - 100) - this.Height * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            this.labelInfo.Text = msg;

            this.Show();
            this.action = EnmAction.start;
            this.TimerAlert.Interval = 1;
            TimerAlert.Start();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            TimerAlert.Interval = 1;
            action = EnmAction.close;
        }

        private void TimerAlert_Tick(object sender, EventArgs e)
        {
            switch(this.action)
            {
                case EnmAction.wait:
                    TimerAlert.Interval = 5000;
                    action = EnmAction.close;
                    break;
                case EnmAction.start:
                    TimerAlert.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = EnmAction.wait;
                        }
                    }
                    break;
                case EnmAction.close:
                    TimerAlert.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void Alerta_Load(object sender, EventArgs e)
        {
            //TROCA DA COR DE FUNDO DEPENDENDO DA MSG
            if (labelInfo.Text == "Pessoa Cadastrada!")
            {
                this.BackColor = Color.SeaGreen;
            }
            else if (labelInfo.Text == "Cadastro Atualizado!")
            {
                this.BackColor = Color.Chocolate;
            }
        }
    }
}
