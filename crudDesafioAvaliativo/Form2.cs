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
            checkMTD = "cadastrar";
            textBoxID.BackColor = Color.Tomato;//FEEDBACK VISUAL DE CAMPO id INATIVO
        }
        public Form2(Form1 frm1)//EDITAR
        {
            instanciaDoForm1 = frm1;
            InitializeComponent();
            checkMTD = "editar";
            ButtonCadastrarForm2.Text = "Editar";
            textBoxID.BackColor = Color.DarkGray;//FEEDBACK VISUAL DE CAMPO id PREENCHIDO

            //PREENCHE OS TEXTBOX DO Form2 COM VARIAVEIS INSTANCIADAS DO FORM1
            textBoxID.Text = instanciaDoForm1.idSelect.ToString();
            checkBoxATV.Checked = instanciaDoForm1.ativoSelect;
            TextBoxNOME.Text = instanciaDoForm1.nomeSelect;
            TextBoxSOBR.Text = instanciaDoForm1.sobrenomeSelect;
            maskedTextBoxALT.Text = instanciaDoForm1.alturaSelect.ToString();
            //CONVERTE VALOR EM DATETIME
            string iDate = instanciaDoForm1.dataNascimentoSelect;
            DateTime oDate = Convert.ToDateTime(iDate);
            datePicker1.Value = oDate;//PASSA VALOR COMO DATETIME
            //----------------------------

        }
        //ADICIONAR SOMBRA AO FORM
        private const int _DropShadown = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams sombra = base.CreateParams;
                sombra.ClassStyle |= _DropShadown;
                return sombra;
            }
        }//-----------------------------

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
                ("Data Source = databaseCrud.db;Version=3;New=False;Compress=True;");
        }
        //--------------------------
        //SET EXECUTEQUERY
        private void ExecuteQuery(String txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;            
            sql_cmd.Parameters.AddWithValue("@id", textBoxID.Text);//int
            sql_cmd.Parameters.AddWithValue("@ativo", checkBoxATV.CheckState);//bool
            sql_cmd.Parameters.AddWithValue("@nome", TextBoxNOME.Text);//string
            sql_cmd.Parameters.AddWithValue("@sobrenome", TextBoxSOBR.Text);//strng
            sql_cmd.Parameters.AddWithValue("@datanascimento", Convert.ToDateTime(datePicker1.Text));//datetime
            sql_cmd.Parameters.AddWithValue("@altura", Convert.ToDecimal(maskedTextBoxALT.Text));//decimal
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        //--------------------------
        public event Action AttForm1;//EVENTO PARA EXECUTAR FUNCAO NA FORM1

        readonly string checkMTD;

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

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

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            if (TextBoxNOME.Text != "" && TextBoxSOBR.Text != "")
            {
                if (checkMTD == "editar")
                {
                    string txtQuery = "update pessoa set ativo=@ativo, nome=@nome, sobrenome=@sobrenome, datanascimento=@datanascimento, altura=@altura where id=@id";
                    ExecuteQuery(txtQuery);

                    this.Alert("Cadastro Atualizado!");//EMITE ALERTA PARA FEEDBACK VISUAL DA EDIÇÃO
                    AttForm1?.Invoke();

                    this.Close();//FECHA JANELA APOS ATUALIZAR
                }
                else
                {
                    string txtQuery = "insert into pessoa (ativo, nome, sobrenome, datanascimento, altura)values(@ativo,@nome,@sobrenome,@datanascimento,@altura)";
                    ExecuteQuery(txtQuery);

                    this.Alert("Pessoa Cadastrada!");//EMITE ALERTA PARA FEEDBACK VISUAL DO CADASTRO
                    AttForm1?.Invoke();

                    this.Close();//FECHA JANELA APOS CADASTRAR
                }
            }
            else
            {
                string msgErro = "ERRO: Campo NOME e SOBRENOME não podem estar vazios!";
                FormError form3 = new FormError(msgErro);
                form3.ShowDialog();
            }
        }

        private void ButtonCloseForm2_Click(object sender, EventArgs e)
        {
            this.Close();
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
