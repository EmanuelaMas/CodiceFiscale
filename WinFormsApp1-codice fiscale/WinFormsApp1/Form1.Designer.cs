namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataNascitaPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.buttonCF = new System.Windows.Forms.Button();
            this.comboBoxComune = new System.Windows.Forms.ComboBox();
            this.labelGenere = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(260, 52);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(150, 31);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxCognome
            // 
            this.textBoxCognome.Location = new System.Drawing.Point(260, 105);
            this.textBoxCognome.Name = "textBoxCognome";
            this.textBoxCognome.Size = new System.Drawing.Size(150, 31);
            this.textBoxCognome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cognome";
            // 
            // dataNascitaPicker
            // 
            this.dataNascitaPicker.Location = new System.Drawing.Point(260, 162);
            this.dataNascitaPicker.Name = "dataNascitaPicker";
            this.dataNascitaPicker.Size = new System.Drawing.Size(300, 31);
            this.dataNascitaPicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data di Nascita";
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(260, 221);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(53, 29);
            this.radioButtonM.TabIndex = 6;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "M";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(348, 221);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(46, 29);
            this.radioButtonF.TabIndex = 7;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "F";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // buttonCF
            // 
            this.buttonCF.Location = new System.Drawing.Point(507, 355);
            this.buttonCF.Name = "buttonCF";
            this.buttonCF.Size = new System.Drawing.Size(245, 55);
            this.buttonCF.TabIndex = 8;
            this.buttonCF.Text = "calcolo codice fiscale";
            this.buttonCF.UseVisualStyleBackColor = true;
            this.buttonCF.Click += new System.EventHandler(this.buttonCF_Click);
            // 
            // comboBoxComune
            // 
            this.comboBoxComune.FormattingEnabled = true;
            this.comboBoxComune.Location = new System.Drawing.Point(260, 276);
            this.comboBoxComune.Name = "comboBoxComune";
            this.comboBoxComune.Size = new System.Drawing.Size(182, 33);
            this.comboBoxComune.TabIndex = 9;
            // 
            // labelGenere
            // 
            this.labelGenere.AutoSize = true;
            this.labelGenere.Location = new System.Drawing.Point(82, 225);
            this.labelGenere.Name = "labelGenere";
            this.labelGenere.Size = new System.Drawing.Size(67, 25);
            this.labelGenere.TabIndex = 10;
            this.labelGenere.Text = "Genere";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Comune di nascita";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelGenere);
            this.Controls.Add(this.comboBoxComune);
            this.Controls.Add(this.buttonCF);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataNascitaPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCognome);
            this.Controls.Add(this.textBoxNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxCognome;
        private Label label1;
        private Label label2;
        private DateTimePicker dataNascitaPicker;
        private Label label3;
        private RadioButton radioButtonM;
        private RadioButton radioButtonF;
        private Button buttonCF;
        private ComboBox comboBoxComune;
        private Label labelGenere;
        private Label label4;
    }
}