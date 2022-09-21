
namespace crudDesafioAvaliativo
{
    partial class FormConfirma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfirma));
            this.Panel1FormConfirma = new System.Windows.Forms.Panel();
            this.PictureErrorIcon = new System.Windows.Forms.PictureBox();
            this.LabelNameFormConfirma = new System.Windows.Forms.Label();
            this.PanelDetailForm1 = new System.Windows.Forms.Panel();
            this.labelMsgConfima = new System.Windows.Forms.Label();
            this.buttonCustom1 = new crudDesafioAvaliativo.Controls.ButtonCustom();
            this.buttonCustom2 = new crudDesafioAvaliativo.Controls.ButtonCustom();
            this.Panel1FormConfirma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1FormConfirma
            // 
            this.Panel1FormConfirma.BackColor = System.Drawing.Color.BlueViolet;
            this.Panel1FormConfirma.Controls.Add(this.PictureErrorIcon);
            this.Panel1FormConfirma.Controls.Add(this.LabelNameFormConfirma);
            this.Panel1FormConfirma.Controls.Add(this.PanelDetailForm1);
            this.Panel1FormConfirma.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel1FormConfirma.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1FormConfirma.Location = new System.Drawing.Point(0, 0);
            this.Panel1FormConfirma.Name = "Panel1FormConfirma";
            this.Panel1FormConfirma.Size = new System.Drawing.Size(235, 31);
            this.Panel1FormConfirma.TabIndex = 10;
            this.Panel1FormConfirma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1FormConfirma_MouseDown);
            this.Panel1FormConfirma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1FormConfirma_MouseMove);
            this.Panel1FormConfirma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1FormConfirma_MouseUp);
            // 
            // PictureErrorIcon
            // 
            this.PictureErrorIcon.BackColor = System.Drawing.Color.Tomato;
            this.PictureErrorIcon.BackgroundImage = global::crudDesafioAvaliativo.Properties.Resources.delPeopleIcon;
            this.PictureErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureErrorIcon.Enabled = false;
            this.PictureErrorIcon.Location = new System.Drawing.Point(3, 3);
            this.PictureErrorIcon.Name = "PictureErrorIcon";
            this.PictureErrorIcon.Size = new System.Drawing.Size(25, 25);
            this.PictureErrorIcon.TabIndex = 11;
            this.PictureErrorIcon.TabStop = false;
            // 
            // LabelNameFormConfirma
            // 
            this.LabelNameFormConfirma.BackColor = System.Drawing.Color.Tomato;
            this.LabelNameFormConfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelNameFormConfirma.ForeColor = System.Drawing.Color.GhostWhite;
            this.LabelNameFormConfirma.Location = new System.Drawing.Point(33, 9);
            this.LabelNameFormConfirma.Name = "LabelNameFormConfirma";
            this.LabelNameFormConfirma.Size = new System.Drawing.Size(57, 17);
            this.LabelNameFormConfirma.TabIndex = 9;
            this.LabelNameFormConfirma.Text = "EXCLUIR";
            // 
            // PanelDetailForm1
            // 
            this.PanelDetailForm1.BackColor = System.Drawing.Color.Tomato;
            this.PanelDetailForm1.Enabled = false;
            this.PanelDetailForm1.Location = new System.Drawing.Point(0, 0);
            this.PanelDetailForm1.Name = "PanelDetailForm1";
            this.PanelDetailForm1.Size = new System.Drawing.Size(91, 31);
            this.PanelDetailForm1.TabIndex = 12;
            // 
            // labelMsgConfima
            // 
            this.labelMsgConfima.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMsgConfima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsgConfima.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMsgConfima.Location = new System.Drawing.Point(10, 37);
            this.labelMsgConfima.Name = "labelMsgConfima";
            this.labelMsgConfima.Size = new System.Drawing.Size(213, 87);
            this.labelMsgConfima.TabIndex = 11;
            this.labelMsgConfima.Text = " EXCLUIR linha selecionada?";
            this.labelMsgConfima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCustom1
            // 
            this.buttonCustom1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom1.BorderRadius = 40;
            this.buttonCustom1.BorderSize = 0;
            this.buttonCustom1.FlatAppearance.BorderSize = 0;
            this.buttonCustom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom1.ForeColor = System.Drawing.Color.White;
            this.buttonCustom1.Location = new System.Drawing.Point(17, 127);
            this.buttonCustom1.Name = "buttonCustom1";
            this.buttonCustom1.Size = new System.Drawing.Size(96, 40);
            this.buttonCustom1.TabIndex = 12;
            this.buttonCustom1.Text = "NÃO";
            this.buttonCustom1.TextColor = System.Drawing.Color.White;
            this.buttonCustom1.UseVisualStyleBackColor = false;
            this.buttonCustom1.Click += new System.EventHandler(this.ButtonCustom1_Click);
            // 
            // buttonCustom2
            // 
            this.buttonCustom2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom2.BorderRadius = 40;
            this.buttonCustom2.BorderSize = 0;
            this.buttonCustom2.FlatAppearance.BorderSize = 0;
            this.buttonCustom2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.buttonCustom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonCustom2.ForeColor = System.Drawing.Color.White;
            this.buttonCustom2.Location = new System.Drawing.Point(124, 127);
            this.buttonCustom2.Name = "buttonCustom2";
            this.buttonCustom2.Size = new System.Drawing.Size(95, 40);
            this.buttonCustom2.TabIndex = 13;
            this.buttonCustom2.Text = "SIM";
            this.buttonCustom2.TextColor = System.Drawing.Color.White;
            this.buttonCustom2.UseVisualStyleBackColor = false;
            this.buttonCustom2.Click += new System.EventHandler(this.ButtonCustom2_Click);
            // 
            // FormConfirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(235, 171);
            this.Controls.Add(this.buttonCustom2);
            this.Controls.Add(this.buttonCustom1);
            this.Controls.Add(this.labelMsgConfima);
            this.Controls.Add(this.Panel1FormConfirma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormConfirma";
            this.Panel1FormConfirma.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureErrorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1FormConfirma;
        private System.Windows.Forms.PictureBox PictureErrorIcon;
        private System.Windows.Forms.Label LabelNameFormConfirma;
        private System.Windows.Forms.Panel PanelDetailForm1;
        private System.Windows.Forms.Label labelMsgConfima;
        private Controls.ButtonCustom buttonCustom1;
        private Controls.ButtonCustom buttonCustom2;
    }
}