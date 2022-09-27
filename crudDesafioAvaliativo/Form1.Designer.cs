
namespace crudDesafioAvaliativo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Panel1Form1 = new System.Windows.Forms.Panel();
            this.PicturePeopleIcon = new System.Windows.Forms.PictureBox();
            this.LabelNameForm1 = new System.Windows.Forms.Label();
            this.PanelDetailForm1 = new System.Windows.Forms.Panel();
            this.ButtonMinimizar = new crudDesafioAvaliativo.Controls.ButtonCustom();
            this.ButtonCloseForm1 = new crudDesafioAvaliativo.Controls.ButtonCustom();
            this.labelInfoForm1 = new System.Windows.Forms.Label();
            this.PicturePeople = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButtonAtt = new crudDesafioAvaliativo.Controls.ButtonCustom();
            this.ButtonExcluir = new crudDesafioAvaliativo.Controls.ButtonCustom();
            this.ButtonEditar = new crudDesafioAvaliativo.Controls.ButtonCustom();
            this.ButtonCadastrar = new crudDesafioAvaliativo.Controls.ButtonCustom();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel1Form1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePeopleIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(193, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(518, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // Panel1Form1
            // 
            this.Panel1Form1.BackColor = System.Drawing.Color.BlueViolet;
            this.Panel1Form1.Controls.Add(this.PicturePeopleIcon);
            this.Panel1Form1.Controls.Add(this.LabelNameForm1);
            this.Panel1Form1.Controls.Add(this.PanelDetailForm1);
            this.Panel1Form1.Controls.Add(this.ButtonMinimizar);
            this.Panel1Form1.Controls.Add(this.ButtonCloseForm1);
            this.Panel1Form1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel1Form1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1Form1.Location = new System.Drawing.Point(0, 0);
            this.Panel1Form1.Name = "Panel1Form1";
            this.Panel1Form1.Size = new System.Drawing.Size(723, 31);
            this.Panel1Form1.TabIndex = 7;
            this.Panel1Form1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1Form1_MouseDown);
            this.Panel1Form1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1Form1_MouseMove);
            this.Panel1Form1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1Form1_MouseUp);
            // 
            // PicturePeopleIcon
            // 
            this.PicturePeopleIcon.BackColor = System.Drawing.Color.Indigo;
            this.PicturePeopleIcon.BackgroundImage = global::crudDesafioAvaliativo.Properties.Resources.iconApp;
            this.PicturePeopleIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicturePeopleIcon.Enabled = false;
            this.PicturePeopleIcon.Location = new System.Drawing.Point(3, 3);
            this.PicturePeopleIcon.Name = "PicturePeopleIcon";
            this.PicturePeopleIcon.Size = new System.Drawing.Size(25, 25);
            this.PicturePeopleIcon.TabIndex = 11;
            this.PicturePeopleIcon.TabStop = false;
            // 
            // LabelNameForm1
            // 
            this.LabelNameForm1.BackColor = System.Drawing.Color.Indigo;
            this.LabelNameForm1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNameForm1.ForeColor = System.Drawing.Color.GhostWhite;
            this.LabelNameForm1.Location = new System.Drawing.Point(34, 8);
            this.LabelNameForm1.Name = "LabelNameForm1";
            this.LabelNameForm1.Size = new System.Drawing.Size(156, 17);
            this.LabelNameForm1.TabIndex = 9;
            this.LabelNameForm1.Text = "Informações Cadastrais";
            // 
            // PanelDetailForm1
            // 
            this.PanelDetailForm1.BackColor = System.Drawing.Color.Indigo;
            this.PanelDetailForm1.Enabled = false;
            this.PanelDetailForm1.Location = new System.Drawing.Point(0, 0);
            this.PanelDetailForm1.Name = "PanelDetailForm1";
            this.PanelDetailForm1.Size = new System.Drawing.Size(421, 31);
            this.PanelDetailForm1.TabIndex = 12;
            // 
            // ButtonMinimizar
            // 
            this.ButtonMinimizar.BackColor = System.Drawing.Color.Orange;
            this.ButtonMinimizar.BackgroundColor = System.Drawing.Color.Orange;
            this.ButtonMinimizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonMinimizar.BorderRadius = 15;
            this.ButtonMinimizar.BorderSize = 0;
            this.ButtonMinimizar.FlatAppearance.BorderSize = 0;
            this.ButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonMinimizar.ForeColor = System.Drawing.Color.Black;
            this.ButtonMinimizar.Location = new System.Drawing.Point(668, 3);
            this.ButtonMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMinimizar.Name = "ButtonMinimizar";
            this.ButtonMinimizar.Size = new System.Drawing.Size(22, 22);
            this.ButtonMinimizar.TabIndex = 8;
            this.ButtonMinimizar.Text = "_";
            this.ButtonMinimizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonMinimizar.TextColor = System.Drawing.Color.Black;
            this.ButtonMinimizar.UseVisualStyleBackColor = false;
            this.ButtonMinimizar.Click += new System.EventHandler(this.ButtonMinimizar_Click);
            // 
            // ButtonCloseForm1
            // 
            this.ButtonCloseForm1.BackColor = System.Drawing.Color.Tomato;
            this.ButtonCloseForm1.BackgroundColor = System.Drawing.Color.Tomato;
            this.ButtonCloseForm1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCloseForm1.BorderRadius = 15;
            this.ButtonCloseForm1.BorderSize = 0;
            this.ButtonCloseForm1.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.ButtonCloseForm1.FlatAppearance.BorderSize = 0;
            this.ButtonCloseForm1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCloseForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCloseForm1.ForeColor = System.Drawing.Color.Black;
            this.ButtonCloseForm1.Location = new System.Drawing.Point(693, 3);
            this.ButtonCloseForm1.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCloseForm1.Name = "ButtonCloseForm1";
            this.ButtonCloseForm1.Size = new System.Drawing.Size(22, 22);
            this.ButtonCloseForm1.TabIndex = 8;
            this.ButtonCloseForm1.Text = "X";
            this.ButtonCloseForm1.TextColor = System.Drawing.Color.Black;
            this.ButtonCloseForm1.UseVisualStyleBackColor = false;
            this.ButtonCloseForm1.Click += new System.EventHandler(this.ButtonCloseForm1_Click);
            // 
            // labelInfoForm1
            // 
            this.labelInfoForm1.AutoSize = true;
            this.labelInfoForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelInfoForm1.ForeColor = System.Drawing.Color.White;
            this.labelInfoForm1.Location = new System.Drawing.Point(200, 42);
            this.labelInfoForm1.Name = "labelInfoForm1";
            this.labelInfoForm1.Size = new System.Drawing.Size(281, 31);
            this.labelInfoForm1.TabIndex = 9;
            this.labelInfoForm1.Text = "Pessoas Cadastradas";
            // 
            // PicturePeople
            // 
            this.PicturePeople.BackColor = System.Drawing.Color.Tomato;
            this.PicturePeople.BackgroundImage = global::crudDesafioAvaliativo.Properties.Resources.peopleIcon;
            this.PicturePeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicturePeople.Location = new System.Drawing.Point(23, 93);
            this.PicturePeople.Margin = new System.Windows.Forms.Padding(0);
            this.PicturePeople.Name = "PicturePeople";
            this.PicturePeople.Size = new System.Drawing.Size(150, 150);
            this.PicturePeople.TabIndex = 11;
            this.PicturePeople.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.BlueViolet;
            this.pictureBox1.Location = new System.Drawing.Point(-11, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 116);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ButtonAtt
            // 
            this.ButtonAtt.BackColor = System.Drawing.Color.Indigo;
            this.ButtonAtt.BackgroundColor = System.Drawing.Color.Indigo;
            this.ButtonAtt.BorderColor = System.Drawing.Color.Tomato;
            this.ButtonAtt.BorderRadius = 30;
            this.ButtonAtt.BorderSize = 2;
            this.ButtonAtt.FlatAppearance.BorderSize = 0;
            this.ButtonAtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAtt.ForeColor = System.Drawing.Color.White;
            this.ButtonAtt.Location = new System.Drawing.Point(631, 42);
            this.ButtonAtt.Name = "ButtonAtt";
            this.ButtonAtt.Size = new System.Drawing.Size(78, 30);
            this.ButtonAtt.TabIndex = 13;
            this.ButtonAtt.Text = "Atualizar";
            this.ButtonAtt.TextColor = System.Drawing.Color.White;
            this.ButtonAtt.UseVisualStyleBackColor = false;
            this.ButtonAtt.Click += new System.EventHandler(this.ButtonAtt_Click);
            // 
            // ButtonExcluir
            // 
            this.ButtonExcluir.BackColor = System.Drawing.Color.Indigo;
            this.ButtonExcluir.BackgroundColor = System.Drawing.Color.Indigo;
            this.ButtonExcluir.BorderColor = System.Drawing.Color.Tomato;
            this.ButtonExcluir.BorderRadius = 40;
            this.ButtonExcluir.BorderSize = 2;
            this.ButtonExcluir.FlatAppearance.BorderSize = 0;
            this.ButtonExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.ButtonExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonExcluir.ForeColor = System.Drawing.Color.White;
            this.ButtonExcluir.Location = new System.Drawing.Point(23, 357);
            this.ButtonExcluir.Name = "ButtonExcluir";
            this.ButtonExcluir.Size = new System.Drawing.Size(150, 40);
            this.ButtonExcluir.TabIndex = 10;
            this.ButtonExcluir.Text = "Excluir";
            this.ButtonExcluir.TextColor = System.Drawing.Color.White;
            this.ButtonExcluir.UseVisualStyleBackColor = false;
            this.ButtonExcluir.Click += new System.EventHandler(this.ButtonExcluir_Click);
            // 
            // ButtonEditar
            // 
            this.ButtonEditar.BackColor = System.Drawing.Color.Indigo;
            this.ButtonEditar.BackgroundColor = System.Drawing.Color.Indigo;
            this.ButtonEditar.BorderColor = System.Drawing.Color.Tomato;
            this.ButtonEditar.BorderRadius = 40;
            this.ButtonEditar.BorderSize = 2;
            this.ButtonEditar.FlatAppearance.BorderSize = 0;
            this.ButtonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonEditar.ForeColor = System.Drawing.Color.White;
            this.ButtonEditar.Location = new System.Drawing.Point(23, 311);
            this.ButtonEditar.Name = "ButtonEditar";
            this.ButtonEditar.Size = new System.Drawing.Size(150, 40);
            this.ButtonEditar.TabIndex = 9;
            this.ButtonEditar.Text = "Editar";
            this.ButtonEditar.TextColor = System.Drawing.Color.White;
            this.ButtonEditar.UseVisualStyleBackColor = false;
            this.ButtonEditar.Click += new System.EventHandler(this.ButtonEditar_Click);
            // 
            // ButtonCadastrar
            // 
            this.ButtonCadastrar.BackColor = System.Drawing.Color.Indigo;
            this.ButtonCadastrar.BackgroundColor = System.Drawing.Color.Indigo;
            this.ButtonCadastrar.BorderColor = System.Drawing.Color.Tomato;
            this.ButtonCadastrar.BorderRadius = 40;
            this.ButtonCadastrar.BorderSize = 2;
            this.ButtonCadastrar.FlatAppearance.BorderSize = 0;
            this.ButtonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonCadastrar.ForeColor = System.Drawing.Color.White;
            this.ButtonCadastrar.Location = new System.Drawing.Point(23, 265);
            this.ButtonCadastrar.Name = "ButtonCadastrar";
            this.ButtonCadastrar.Size = new System.Drawing.Size(150, 40);
            this.ButtonCadastrar.TabIndex = 8;
            this.ButtonCadastrar.Text = "Cadastrar";
            this.ButtonCadastrar.TextColor = System.Drawing.Color.White;
            this.ButtonCadastrar.UseVisualStyleBackColor = false;
            this.ButtonCadastrar.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.ButtonAtt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PicturePeople);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonExcluir);
            this.Controls.Add(this.labelInfoForm1);
            this.Controls.Add(this.ButtonEditar);
            this.Controls.Add(this.ButtonCadastrar);
            this.Controls.Add(this.Panel1Form1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel1Form1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePeopleIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel Panel1Form1;
        private Controls.ButtonCustom ButtonCloseForm1;
        private Controls.ButtonCustom ButtonCadastrar;
        private Controls.ButtonCustom ButtonEditar;
        private Controls.ButtonCustom ButtonExcluir;
        private System.Windows.Forms.Label labelInfoForm1;
        private System.Windows.Forms.PictureBox PicturePeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.ButtonCustom ButtonMinimizar;
        private System.Windows.Forms.PictureBox PicturePeopleIcon;
        private System.Windows.Forms.Label LabelNameForm1;
        private System.Windows.Forms.Panel PanelDetailForm1;
        private Controls.ButtonCustom ButtonAtt;
    }
}

