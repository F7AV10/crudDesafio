
namespace crudDesafioAvaliativo
{
    partial class alerta
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
            this.components = new System.ComponentModel.Container();
            this.labelInfo = new System.Windows.Forms.Label();
            this.TimerAlert = new System.Windows.Forms.Timer(this.components);
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(52, 19);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(91, 22);
            this.labelInfo.TabIndex = 11;
            this.labelInfo.Text = "message";
            // 
            // TimerAlert
            // 
            this.TimerAlert.Tick += new System.EventHandler(this.TimerAlert_Tick);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.BlueViolet;
            this.ButtonClose.BackgroundImage = global::crudDesafioAvaliativo.Properties.Resources.xIcon;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonClose.Location = new System.Drawing.Point(268, 5);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(25, 25);
            this.ButtonClose.TabIndex = 12;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::crudDesafioAvaliativo.Properties.Resources.sucessIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Location = new System.Drawing.Point(262, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 63);
            this.panel1.TabIndex = 14;
            // 
            // alerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(297, 61);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alerta";
            this.Text = "alerta";
            this.Load += new System.EventHandler(this.Alerta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Timer TimerAlert;
        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}