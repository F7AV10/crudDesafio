using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace crudDesafioAvaliativo
{
    public partial class Form2 : Form
    {
        readonly Form1 instanciaDoForm1;
        public Form2()//CADASTRAR
        {
            InitializeComponent();
            ckdATV = 0;
            checkMTD = "cadastrar";
            textBoxID.BackColor = Color.Tomato;//FEEDBACK VISUAL DE CAMPO id INATIVO
        }
        public Form2(Form1 frm1)//EDITAR
        {
            instanciaDoForm1 = frm1;
            InitializeComponent();
            ckdATV = 0;
            checkMTD = "editar";
            ButtonCadastrarForm2.Text = "Editar";
            textBoxID.BackColor = Color.LightGreen;//FEEDBACK VISUAL DE CAMPO id PREENCHIDO

            //PREENCHE OS TEXTBOX DO Form2 COM VARIAVEIS INSTANCIADAS DO FORM1
            textBoxID.Text = instanciaDoForm1.idSelect;
            //CONVERTE VALOR EM BOOL
            string verificaATVvalue = instanciaDoForm1.ativoSelect;
            if (verificaATVvalue == "1" && checkBoxATV.Checked == false)
            {
                checkBoxATV.Checked = true;//PASSA VALOR COMO BOOL
            }
            else
            {
                checkBoxATV.Checked = false;//PASSA VALOR COMO BOOL
            //----- FIM CONVERTE VALOR EM BOOL -----
            }
            TextBoxNOME.Text = instanciaDoForm1.nomeSelect;
            TextBoxSOBR.Text = instanciaDoForm1.sobrenomeSelect;
            maskedTextBoxALT.Text = instanciaDoForm1.alturaSelect;
            //CONVERTE VALOR EM DATETIME
            string iDate = instanciaDoForm1.dataNascimentoSelect;
            DateTime oDate = Convert.ToDateTime(iDate);
            //----- FIM CONVERTE VALOR EM DATETIME -----
            datePicker1.Value = oDate;//PASSA VALOR COMO DATETIME
            
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

        public void Alert(string msg)
        {
            alerta frm = new alerta();
            frm.ShowAlert(msg);
        }
        //SQLITE CONNECTIONS
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        //--------------------------
        //SET CONNECTION
        private void SetConnection()
        {
            sql_con = new SQLiteConnection
                ("Data Source = bdCrud.db;Version=3;New=False;Compress=True;");
        }
        //--------------------------
        //SET EXECUTEQUERY
        private void ExecuteQuery(String txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        //--------------------------
        public event Action AttForm1;//EVENTO PARA EXECUTAR FUNCAO NA FORM1

        readonly string checkMTD;
        int ckdATV;

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void ButtonCloseForm2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //MOVIMENTAR Form2
        private void Panel1Form2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Panel1Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void Panel1Form2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        //----------------------
        private void CheckBoxATV_CheckedChanged(object sender, EventArgs e)
        {
            if (ckdATV == 0)
            {
                ckdATV = 1;
            }
            else
            {
                ckdATV = 0;
            }
        }
        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            if (TextBoxNOME.Text != "" && TextBoxSOBR.Text != "")
            {
                if (checkMTD == "editar")
                {
                    string txtQuery = "update pessoa set ativo='" + ckdATV + "', nome='" + TextBoxNOME.Text + "', sobrenome='" + TextBoxSOBR.Text + "', datanascimento='" + datePicker1.Value + "', altura='" + maskedTextBoxALT.Text + "' where id=" + textBoxID.Text + "";
                    ExecuteQuery(txtQuery);

                    this.Alert("Cadastro Atualizado!");//EMITE ALERTA PARA FEEDBACK VISUAL DA EDIÇÃO
                    AttForm1?.Invoke();

                    this.Close();//FECHA JANELA APOS CADASTRAR - CRIAR CONDIÇÃO PARA VERIFICAR ERRO/CONCLUIDO
                }
                else
                {
                    string txtQuery = "insert into pessoa (ativo, nome, sobrenome, datanascimento, altura)values('" + ckdATV + "','" + TextBoxNOME.Text + "','" + TextBoxSOBR.Text + "','" + datePicker1.Value + "','" + maskedTextBoxALT.Text + "')";
                    ExecuteQuery(txtQuery);

                    this.Alert("Pessoa Cadastrada!");//EMITE ALERTA PARA FEEDBACK VISUAL DO CADASTRO
                    AttForm1?.Invoke();

                    this.Close();//FECHA JANELA APOS CADASTRAR - CRIAR CONDIÇÃO PARA VERIFICAR ERRO/CONCLUIDO
                }
            }
            else
            {
                string msgErro = "ERRO: Campo NOME e SOBRENOME não podem estar vazios!";
                FormError form3 = new FormError(msgErro);
                form3.ShowDialog();
            }
                       

        }

        private void TextBoxNOME_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

        private void TextBoxSOBR_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar);
        }

    }
}
