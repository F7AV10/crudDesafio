
namespace crudDesafioAvaliativo
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Panel1Form2 = new System.Windows.Forms.Panel();
            this.PicturePeopleIcon = new System.Windows.Forms.PictureBox();
            this.LabelNameForm2 = new System.Windows.Forms.Label();
            this.PanelDetailForm1 = new System.Windows.Forms.Panel();
            this.labelInfoForm2 = new System.Windows.Forms.Label();
            this.PictureNew = new System.Windows.Forms.PictureBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxNOME = new System.Windows.Forms.TextBox();
            this.LabelNOME = new System.Windows.Forms.Label();
            this.TextBoxSOBR = new System.Windows.Forms.TextBox();
            this.LabelSOBR = new System.Windows.Forms.Label();
            this.LabelDATA = new System.Windows.Forms.Label();
            this.labelALTURA = new System.Windows.Forms.Label();
            this.checkBoxATV = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxALT = new System.Windows.Forms.MaskedTextBox();
            this.datePicker1 = new crudDesafioAvaliativo.DatePicker();
            this.ButtonCadastrarForm2 = new crudDesafioAvaliativo.Controls.ButtonCustom();
            this.ButtonCloseForm2 = new crudDesafioAvaliativo.Controls.ButtonCustom();
            this.Panel1Form2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePeopleIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1Form2
            // 
            this.Panel1Form2.BackColor = System.Drawing.Color.BlueViolet;
            this.Panel1Form2.Controls.Add(this.PicturePeopleIcon);
            this.Panel1Form2.Controls.Add(this.LabelNameForm2);
            this.Panel1Form2.Controls.Add(this.PanelDetailForm1);
            this.Panel1Form2.Controls.Add(this.ButtonCloseForm2);
            this.Panel1Form2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel1Form2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1Form2.Location = new System.Drawing.Point(0, 0);
            this.Panel1Form2.Name = "Panel1Form2";
            this.Panel1Form2.Size = new System.Drawing.Size(623, 31);
            this.Panel1Form2.TabIndex = 8;
            this.Panel1Form2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1Form2_MouseDown);
            this.Panel1Form2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1Form2_MouseMove);
            this.Panel1Form2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1Form2_MouseUp);
            // 
            // PicturePeopleIcon
            // 
            this.PicturePeopleIcon.BackColor = System.Drawing.Color.Indigo;
            this.PicturePeopleIcon.BackgroundImage = global::crudDesafioAvaliativo.Properties.Resources.newPeopleIcon;
            this.PicturePeopleIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicturePeopleIcon.Enabled = false;
            this.PicturePeopleIcon.Location = new System.Drawing.Point(3, 3);
            this.PicturePeopleIcon.Name = "PicturePeopleIcon";
            this.PicturePeopleIcon.Size = new System.Drawing.Size(25, 25);
            this.PicturePeopleIcon.TabIndex = 11;
            this.PicturePeopleIcon.TabStop = false;
            // 
            // LabelNameForm2
            // 
            this.LabelNameForm2.BackColor = System.Drawing.Color.Indigo;
            this.LabelNameForm2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNameForm2.ForeColor = System.Drawing.Color.GhostWhite;
            this.LabelNameForm2.Location = new System.Drawing.Point(34, 8);
            this.LabelNameForm2.Name = "LabelNameForm2";
            this.LabelNameForm2.Size = new System.Drawing.Size(66, 17);
            this.LabelNameForm2.TabIndex = 9;
            this.LabelNameForm2.Text = "Cadastro";
            // 
            // PanelDetailForm1
            // 
            this.PanelDetailForm1.BackColor = System.Drawing.Color.Indigo;
            this.PanelDetailForm1.Enabled = false;
            this.PanelDetailForm1.Location = new System.Drawing.Point(0, 0);
            this.PanelDetailForm1.Name = "PanelDetailForm1";
            this.PanelDetailForm1.Size = new System.Drawing.Size(407, 31);
            this.PanelDetailForm1.TabIndex = 12;
            // 
            // labelInfoForm2
            // 
            this.labelInfoForm2.AutoSize = true;
            this.labelInfoForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelInfoForm2.ForeColor = System.Drawing.Color.White;
            this.labelInfoForm2.Location = new System.Drawing.Point(275, 47);
            this.labelInfoForm2.Name = "labelInfoForm2";
            this.labelInfoForm2.Size = new System.Drawing.Size(282, 31);
            this.labelInfoForm2.TabIndex = 10;
            this.labelInfoForm2.Text = "Informações Pessoais";
            // 
            // PictureNew
            // 
            this.PictureNew.BackColor = System.Drawing.Color.DarkOrange;
            this.PictureNew.BackgroundImage = global::crudDesafioAvaliativo.Properties.Resources.newPeopleIcon;
            this.PictureNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureNew.Location = new System.Drawing.Point(28, 93);
            this.PictureNew.Margin = new System.Windows.Forms.Padding(0);
            this.PictureNew.Name = "PictureNew";
            this.PictureNew.Size = new System.Drawing.Size(150, 150);
            this.PictureNew.TabIndex = 12;
            this.PictureNew.TabStop = false;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(221, 110);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(41, 20);
            this.textBoxID.TabIndex = 13;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(216, 82);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 25);
            this.labelID.TabIndex = 14;
            this.labelID.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.BlueViolet;
            this.pictureBox1.Location = new System.Drawing.Point(17, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 285);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // TextBoxNOME
            // 
            this.TextBoxNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBoxNOME.ForeColor = System.Drawing.Color.Indigo;
            this.TextBoxNOME.Location = new System.Drawing.Point(221, 161);
            this.TextBoxNOME.Name = "TextBoxNOME";
            this.TextBoxNOME.Size = new System.Drawing.Size(372, 23);
            this.TextBoxNOME.TabIndex = 13;
            this.TextBoxNOME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNOME_KeyPress);
            // 
            // LabelNOME
            // 
            this.LabelNOME.AutoSize = true;
            this.LabelNOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LabelNOME.ForeColor = System.Drawing.Color.White;
            this.LabelNOME.Location = new System.Drawing.Point(216, 133);
            this.LabelNOME.Name = "LabelNOME";
            this.LabelNOME.Size = new System.Drawing.Size(64, 25);
            this.LabelNOME.TabIndex = 14;
            this.LabelNOME.Text = "Nome";
            // 
            // TextBoxSOBR
            // 
            this.TextBoxSOBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TextBoxSOBR.ForeColor = System.Drawing.Color.Indigo;
            this.TextBoxSOBR.Location = new System.Drawing.Point(221, 214);
            this.TextBoxSOBR.Name = "TextBoxSOBR";
            this.TextBoxSOBR.Size = new System.Drawing.Size(372, 23);
            this.TextBoxSOBR.TabIndex = 13;
            this.TextBoxSOBR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSOBR_KeyPress);
            // 
            // LabelSOBR
            // 
            this.LabelSOBR.AutoSize = true;
            this.LabelSOBR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LabelSOBR.ForeColor = System.Drawing.Color.White;
            this.LabelSOBR.Location = new System.Drawing.Point(216, 186);
            this.LabelSOBR.Name = "LabelSOBR";
            this.LabelSOBR.Size = new System.Drawing.Size(114, 25);
            this.LabelSOBR.TabIndex = 14;
            this.LabelSOBR.Text = "Sobrenome";
            // 
            // LabelDATA
            // 
            this.LabelDATA.AutoSize = true;
            this.LabelDATA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LabelDATA.ForeColor = System.Drawing.Color.White;
            this.LabelDATA.Location = new System.Drawing.Point(218, 245);
            this.LabelDATA.Name = "LabelDATA";
            this.LabelDATA.Size = new System.Drawing.Size(188, 25);
            this.LabelDATA.TabIndex = 14;
            this.LabelDATA.Text = "Data de Nascimento";
            // 
            // labelALTURA
            // 
            this.labelALTURA.AutoSize = true;
            this.labelALTURA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelALTURA.ForeColor = System.Drawing.Color.White;
            this.labelALTURA.Location = new System.Drawing.Point(414, 246);
            this.labelALTURA.Name = "labelALTURA";
            this.labelALTURA.Size = new System.Drawing.Size(63, 25);
            this.labelALTURA.TabIndex = 14;
            this.labelALTURA.Text = "Altura";
            // 
            // checkBoxATV
            // 
            this.checkBoxATV.AutoSize = true;
            this.checkBoxATV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxATV.ForeColor = System.Drawing.Color.White;
            this.checkBoxATV.Location = new System.Drawing.Point(295, 107);
            this.checkBoxATV.Name = "checkBoxATV";
            this.checkBoxATV.Size = new System.Drawing.Size(59, 24);
            this.checkBoxATV.TabIndex = 17;
            this.checkBoxATV.Text = "ATV";
            this.checkBoxATV.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxALT
            // 
            this.maskedTextBoxALT.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.maskedTextBoxALT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maskedTextBoxALT.Location = new System.Drawing.Point(419, 274);
            this.maskedTextBoxALT.Mask = "0.00";
            this.maskedTextBoxALT.Name = "maskedTextBoxALT";
            this.maskedTextBoxALT.PromptChar = '0';
            this.maskedTextBoxALT.Size = new System.Drawing.Size(58, 23);
            this.maskedTextBoxALT.TabIndex = 20;
            this.maskedTextBoxALT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxALT.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // datePicker1
            // 
            this.datePicker1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePicker1.BorderSize = 0;
            this.datePicker1.CustomFormat = "dd MMMM, yyy";
            this.datePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker1.Location = new System.Drawing.Point(223, 275);
            this.datePicker1.MinimumSize = new System.Drawing.Size(4, 20);
            this.datePicker1.Name = "datePicker1";
            this.datePicker1.Size = new System.Drawing.Size(183, 22);
            this.datePicker1.SkinColor = System.Drawing.Color.White;
            this.datePicker1.TabIndex = 18;
            this.datePicker1.TextColor = System.Drawing.Color.Indigo;
            this.datePicker1.Value = new System.DateTime(2022, 8, 17, 11, 51, 0, 0);
            // 
            // ButtonCadastrarForm2
            // 
            this.ButtonCadastrarForm2.BackColor = System.Drawing.Color.Indigo;
            this.ButtonCadastrarForm2.BackgroundColor = System.Drawing.Color.Indigo;
            this.ButtonCadastrarForm2.BorderColor = System.Drawing.Color.DarkOrange;
            this.ButtonCadastrarForm2.BorderRadius = 40;
            this.ButtonCadastrarForm2.BorderSize = 2;
            this.ButtonCadastrarForm2.FlatAppearance.BorderSize = 0;
            this.ButtonCadastrarForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCadastrarForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonCadastrarForm2.ForeColor = System.Drawing.Color.White;
            this.ButtonCadastrarForm2.Location = new System.Drawing.Point(471, 320);
            this.ButtonCadastrarForm2.Name = "ButtonCadastrarForm2";
            this.ButtonCadastrarForm2.Size = new System.Drawing.Size(140, 51);
            this.ButtonCadastrarForm2.TabIndex = 16;
            this.ButtonCadastrarForm2.Text = "Cadastrar";
            this.ButtonCadastrarForm2.TextColor = System.Drawing.Color.White;
            this.ButtonCadastrarForm2.UseVisualStyleBackColor = false;
            this.ButtonCadastrarForm2.Click += new System.EventHandler(this.ButtonCadastrar_Click);
            // 
            // ButtonCloseForm2
            // 
            this.ButtonCloseForm2.BackColor = System.Drawing.Color.Tomato;
            this.ButtonCloseForm2.BackgroundColor = System.Drawing.Color.Tomato;
            this.ButtonCloseForm2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCloseForm2.BorderRadius = 15;
            this.ButtonCloseForm2.BorderSize = 0;
            this.ButtonCloseForm2.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.ButtonCloseForm2.FlatAppearance.BorderSize = 0;
            this.ButtonCloseForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCloseForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCloseForm2.ForeColor = System.Drawing.Color.Black;
            this.ButtonCloseForm2.Location = new System.Drawing.Point(595, 3);
            this.ButtonCloseForm2.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCloseForm2.Name = "ButtonCloseForm2";
            this.ButtonCloseForm2.Size = new System.Drawing.Size(22, 22);
            this.ButtonCloseForm2.TabIndex = 8;
            this.ButtonCloseForm2.Text = "X";
            this.ButtonCloseForm2.TextColor = System.Drawing.Color.Black;
            this.ButtonCloseForm2.UseVisualStyleBackColor = false;
            this.ButtonCloseForm2.Click += new System.EventHandler(this.ButtonCloseForm2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(623, 383);
            this.Controls.Add(this.maskedTextBoxALT);
            this.Controls.Add(this.datePicker1);
            this.Controls.Add(this.checkBoxATV);
            this.Controls.Add(this.ButtonCadastrarForm2);
            this.Controls.Add(this.labelALTURA);
            this.Controls.Add(this.LabelDATA);
            this.Controls.Add(this.LabelSOBR);
            this.Controls.Add(this.LabelNOME);
            this.Controls.Add(this.TextBoxSOBR);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.TextBoxNOME);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.PictureNew);
            this.Controls.Add(this.labelInfoForm2);
            this.Controls.Add(this.Panel1Form2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Panel1Form2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePeopleIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel1Form2;
        private System.Windows.Forms.PictureBox PicturePeopleIcon;
        private System.Windows.Forms.Label LabelNameForm2;
        private System.Windows.Forms.Panel PanelDetailForm1;
        private Controls.ButtonCustom ButtonCloseForm2;
        private System.Windows.Forms.Label labelInfoForm2;
        private System.Windows.Forms.PictureBox PictureNew;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TextBoxNOME;
        private System.Windows.Forms.Label LabelNOME;
        private System.Windows.Forms.TextBox TextBoxSOBR;
        private System.Windows.Forms.Label LabelSOBR;
        private System.Windows.Forms.Label LabelDATA;
        private System.Windows.Forms.Label labelALTURA;
        private Controls.ButtonCustom ButtonCadastrarForm2;
        private System.Windows.Forms.CheckBox checkBoxATV;
        private DatePicker datePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxALT;
    }
}