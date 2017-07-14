namespace AspNetUserProfilerStringMach
{
    partial class Form1
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
            this.lbPropertyValuesString = new System.Windows.Forms.Label();
            this.lbPropertyNames = new System.Windows.Forms.Label();
            this.txtPropertyValuesString = new System.Windows.Forms.RichTextBox();
            this.txtPropertyNames = new System.Windows.Forms.RichTextBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPropertyValuesString
            // 
            this.lbPropertyValuesString.AutoSize = true;
            this.lbPropertyValuesString.Location = new System.Drawing.Point(12, 31);
            this.lbPropertyValuesString.Name = "lbPropertyValuesString";
            this.lbPropertyValuesString.Size = new System.Drawing.Size(105, 13);
            this.lbPropertyValuesString.TabIndex = 0;
            this.lbPropertyValuesString.Text = "PropertyValuesString";
            // 
            // lbPropertyNames
            // 
            this.lbPropertyNames.AutoSize = true;
            this.lbPropertyNames.Location = new System.Drawing.Point(12, 153);
            this.lbPropertyNames.Name = "lbPropertyNames";
            this.lbPropertyNames.Size = new System.Drawing.Size(79, 13);
            this.lbPropertyNames.TabIndex = 1;
            this.lbPropertyNames.Text = "PropertyNames";
            // 
            // txtPropertyValuesString
            // 
            this.txtPropertyValuesString.Location = new System.Drawing.Point(75, 31);
            this.txtPropertyValuesString.Name = "txtPropertyValuesString";
            this.txtPropertyValuesString.Size = new System.Drawing.Size(952, 96);
            this.txtPropertyValuesString.TabIndex = 2;
            this.txtPropertyValuesString.Text = "";
            // 
            // txtPropertyNames
            // 
            this.txtPropertyNames.Location = new System.Drawing.Point(75, 153);
            this.txtPropertyNames.Name = "txtPropertyNames";
            this.txtPropertyNames.Size = new System.Drawing.Size(952, 96);
            this.txtPropertyNames.TabIndex = 3;
            this.txtPropertyNames.Text = "";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(326, 295);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(340, 216);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(75, 256);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(952, 23);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(240, 298);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(32, 13);
            this.lbResult.TabIndex = 6;
            this.lbResult.Text = "result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 523);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtPropertyNames);
            this.Controls.Add(this.txtPropertyValuesString);
            this.Controls.Add(this.lbPropertyNames);
            this.Controls.Add(this.lbPropertyValuesString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPropertyValuesString;
        private System.Windows.Forms.Label lbPropertyNames;
        private System.Windows.Forms.RichTextBox txtPropertyValuesString;
        private System.Windows.Forms.RichTextBox txtPropertyNames;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lbResult;
    }
}

