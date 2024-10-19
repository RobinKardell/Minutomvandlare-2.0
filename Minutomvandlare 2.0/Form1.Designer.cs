namespace Minutomvandlare_2._0
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
            label1 = new Label();
            pageSetupDialog1 = new PageSetupDialog();
            txtMinutes = new TextBox();
            btnConvert = new Button();
            label2 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 0;
            label1.Text = "Write in minute you will converts ";
            // 
            // txtMinutes
            // 
            txtMinutes.Location = new Point(12, 26);
            txtMinutes.Name = "txtMinutes";
            txtMinutes.Size = new Size(172, 23);
            txtMinutes.TabIndex = 1;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(12, 55);
            btnConvert.Name = "btnConvert";
            btnConvert.RightToLeft = RightToLeft.Yes;
            btnConvert.Size = new Size(172, 23);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Calculate";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 8);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Result";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(233, 29);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(34, 15);
            lblResult.TabIndex = 4;
            lblResult.Text = "none";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 192);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(btnConvert);
            Controls.Add(txtMinutes);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Minutomvandlare 2.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PageSetupDialog pageSetupDialog1;
        private TextBox txtMinutes;
        private Button btnConvert;
        private Label label2;
        private Label lblResult;
    }
}
