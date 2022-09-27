using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;//USAR DB SQLITE

namespace crudDesafioAvaliativo
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            LoadData();//LE O BANCO DE DADOS AO INICIAR O Form1
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
        }//------------------------------

        public void Alert(string msg)
        {
            alerta frm = new alerta();
            frm.ShowAlert(msg);
        }

        //SQLITE CONNECTIONS
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private readonly DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
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
            sql_cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells[0].Value);
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        //--------------------------
        //SET LOAD DB
        public void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();            
            string CommandText = "select * from pessoa ORDER BY id asc";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }
        //--------------------------
        
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void ButtonCloseForm1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //MOVIMENTACAO DO FORM1
        private void Panel1Form1_MouseDown(object sender, MouseEventArgs e)//VERIFICAR SE CLIQUE DO MOUSE ESTA PRECIOSADO SOBRE panel
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void Panel1Form1_MouseMove(object sender, MouseEventArgs e)//VERIFICAR SE MOUSE ESTA SENDO ARRASTADO COM CLIQUE PRECIONADO SOBRE panel
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }        
        private void Panel1Form1_MouseUp(object sender, MouseEventArgs e)//VERIFICAR SE CLIQUE DO MOUSE FOI SOLTO
        {
            dragging = false;
        }

        //---------------------------

        private void ButtonCadastrar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.AttForm1 += LoadData;
            form2.ShowDialog();
        }
        

        //VARIAVEIS LINHA SELECIONADA PARA EDICAO
        public string idSelect;
        public bool ativoSelect;
        public string nomeSelect;
        public string sobrenomeSelect;
        public string dataNascimentoSelect;
        public string alturaSelect;
        //---------------------------------------

        private void ButtonEditar_Click(object sender, EventArgs e)
        {            
            try//VARIAVEIS PARA ENVIAR AOS TEXTBOX NO FORM2
            {
                idSelect = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ativoSelect = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[1].Value);
                nomeSelect = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                sobrenomeSelect = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dataNascimentoSelect = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                alturaSelect = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                Form2 form2 = new Form2(this);
                form2.AttForm1 += LoadData;
                form2.ShowDialog();
            }
            catch (Exception)
            {
                string msgErro = "ERRO : É necessário antes selecionar uma linha na tabela para ser EDITADA.";
                FormError form3 = new FormError(msgErro);
                form3.ShowDialog();
            }
        }
        private void ButtonExcluir_Click(object sender, EventArgs e)
        {

            try//VERIFICA CONDIÇÃO DE ERRO NA AÇÃO EXCLUIR
            {
                FormConfirma form3 = new FormConfirma();
                form3.DelDados1 += ExcluirDados;
                form3.ShowDialog();                
            }
            catch (Exception)
            {
                string msgErro = "ERRO : É necessário antes selecionar uma linha na tabela para ser DELETADA.";
                FormError form3 = new FormError(msgErro);
                form3.ShowDialog();
            }
        }

        private void ButtonAtt_Click(object sender, EventArgs e)
        {
            LoadData();
            this.Alert("Tabela Atualizada :)");
        }
        private void ExcluirDados()
        {            
            try//VERIFICA CONDIÇÃO DE ERRO NA AÇÃO EXCLUIR
            {
                string txtQuery = "delete from pessoa where id =@id";//PEGA O id DA LINHA SELECIONADA E EXECUTA O delete
                ExecuteQuery(txtQuery);
                LoadData();
            }
            catch (Exception)
            {
                string msgErro = "ERRO : É necessário antes selecionar uma linha na tabela para ser deletada.";
                FormError form3 = new FormError(msgErro);
                form3.ShowDialog();
            }
        }
    }
}
