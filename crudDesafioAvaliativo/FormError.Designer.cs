
namespace crudDesafioAvaliativo
{
    partial class FormError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormError));
            this.Panel1Form2 = new System.Windows.Forms.Panel();
            this.PictureErrorIcon = new System.Windows.Forms.PictureBox();
            this.LabelNameFormError = new System.Windows.Forms.Label();
            this.PanelDetailForm1 = new System.Windows.Forms.Panel();
            this.ButtonCloseForm2 = new crudDesafioAvaliativo.Controls.ButtonCustom();
            this.labelMsgErro = new System.Windows.Forms.Label();
            this.Panel1Form2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1Form2
            // 
            this.Panel1Form2.BackColor = System.Drawing.Color.BlueViolet;
            this.Panel1Form2.Controls.Add(this.PictureErrorIcon);
            this.Panel1Form2.Controls.Add(this.LabelNameFormError);
            this.Panel1Form2.Controls.Add(this.PanelDetailForm1);
            this.Panel1Form2.Controls.Add(this.ButtonCloseForm2);
            this.Panel1Form2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel1Form2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1Form2.Location = new System.Drawing.Point(0, 0);
            this.Panel1Form2.Name = "Panel1Form2";
            this.Panel1Form2.Size = new System.Drawing.Size(235, 31);
            this.Panel1Form2.TabIndex = 9;
            // 
            // PictureErrorIcon
            // 
            this.PictureErrorIcon.BackColor = System.Drawing.Color.Tomato;
            this.PictureErrorIcon.BackgroundImage = global::crudDesafioAvaliativo.Properties.Resources.errorIcon;
            this.PictureErrorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureErrorIcon.Enabled = false;
            this.PictureErrorIcon.Location = new System.Drawing.Point(3, 3);
            this.PictureErrorIcon.Name = "PictureErrorIcon";
            this.PictureErrorIcon.Size = new System.Drawing.Size(25, 25);
            this.PictureErrorIcon.TabIndex = 11;
            this.PictureErrorIcon.TabStop = false;
            // 
            // LabelNameFormError
            // 
            this.LabelNameFormError.BackColor = System.Drawing.Color.Tomato;
            this.LabelNameFormError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LabelNameFormError.ForeColor = System.Drawing.Color.GhostWhite;
            this.LabelNameFormError.Location = new System.Drawing.Point(34, 9);
            this.LabelNameFormError.Name = "LabelNameFormError";
            this.LabelNameFormError.Size = new System.Drawing.Size(57, 17);
            this.LabelNameFormError.TabIndex = 9;
            this.LabelNameFormError.Text = "ERRO";
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
            this.ButtonCloseForm2.Location = new System.Drawing.Point(208, 3);
            this.ButtonCloseForm2.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCloseForm2.Name = "ButtonCloseForm2";
            this.ButtonCloseForm2.Size = new System.Drawing.Size(22, 22);
            this.ButtonCloseForm2.TabIndex = 8;
            this.ButtonCloseForm2.Text = "X";
            this.ButtonCloseForm2.TextColor = System.Drawing.Color.Black;
            this.ButtonCloseForm2.UseVisualStyleBackColor = false;
            this.ButtonCloseForm2.Click += new System.EventHandler(this.ButtonCloseForm2_Click);
            // 
            // labelMsgErro
            // 
            this.labelMsgErro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMsgErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMsgErro.Location = new System.Drawing.Point(5, 48);
            this.labelMsgErro.Name = "labelMsgErro";
            this.labelMsgErro.Size = new System.Drawing.Size(225, 114);
            this.labelMsgErro.TabIndex = 10;
            this.labelMsgErro.Text = "label1";
            this.labelMsgErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(235, 171);
            this.Controls.Add(this.labelMsgErro);
            this.Controls.Add(this.Panel1Form2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormError";
            this.Panel1Form2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureErrorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1Form2;
        private System.Windows.Forms.PictureBox PictureErrorIcon;
        private System.Windows.Forms.Label LabelNameFormError;
        private System.Windows.Forms.Panel PanelDetailForm1;
        private Controls.ButtonCustom ButtonCloseForm2;
        private System.Windows.Forms.Label labelMsgErro;
    }
}