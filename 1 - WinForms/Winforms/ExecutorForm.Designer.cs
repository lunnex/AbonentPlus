namespace Abonent
{
    partial class ExecutorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idtb = new System.Windows.Forms.TextBox();
            this.fiotb = new System.Windows.Forms.TextBox();
            this.fioError = new System.Windows.Forms.Label();
            this.donebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО";
            // 
            // idtb
            // 
            this.idtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idtb.Enabled = false;
            this.idtb.ForeColor = System.Drawing.Color.White;
            this.idtb.Location = new System.Drawing.Point(103, 10);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(175, 20);
            this.idtb.TabIndex = 2;
            // 
            // fiotb
            // 
            this.fiotb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fiotb.ForeColor = System.Drawing.Color.White;
            this.fiotb.Location = new System.Drawing.Point(103, 36);
            this.fiotb.Name = "fiotb";
            this.fiotb.Size = new System.Drawing.Size(175, 20);
            this.fiotb.TabIndex = 3;
            // 
            // fioError
            // 
            this.fioError.AutoSize = true;
            this.fioError.ForeColor = System.Drawing.Color.Red;
            this.fioError.Location = new System.Drawing.Point(103, 63);
            this.fioError.Name = "fioError";
            this.fioError.Size = new System.Drawing.Size(172, 13);
            this.fioError.TabIndex = 4;
            this.fioError.Text = "Это поле не может быть пустым";
            this.fioError.Visible = false;
            // 
            // donebtn
            // 
            this.donebtn.Location = new System.Drawing.Point(199, 80);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(75, 23);
            this.donebtn.TabIndex = 5;
            this.donebtn.Text = "Готово";
            this.donebtn.UseVisualStyleBackColor = true;
            this.donebtn.Click += new System.EventHandler(this.donebtn_Click);
            // 
            // ExecutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(291, 112);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.fioError);
            this.Controls.Add(this.fiotb);
            this.Controls.Add(this.idtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ExecutorForm";
            this.Text = "ExecutorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox idtb;
        public System.Windows.Forms.TextBox fiotb;
        public System.Windows.Forms.Label fioError;
        public System.Windows.Forms.Button donebtn;
    }
}