namespace Tax_Calculator
{
    partial class WarningForm
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
            labelWarningText = new Label();
            buttonOkay = new Button();
            SuspendLayout();
            // 
            // labelWarningText
            // 
            labelWarningText.AutoSize = true;
            labelWarningText.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWarningText.Location = new Point(45, 38);
            labelWarningText.Name = "labelWarningText";
            labelWarningText.Size = new Size(193, 25);
            labelWarningText.TabIndex = 0;
            labelWarningText.Text = "Please fill in all fields";
            labelWarningText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonOkay
            // 
            buttonOkay.Location = new Point(94, 79);
            buttonOkay.Name = "buttonOkay";
            buttonOkay.Size = new Size(75, 23);
            buttonOkay.TabIndex = 1;
            buttonOkay.Text = "Okay";
            buttonOkay.UseVisualStyleBackColor = true;
            buttonOkay.Click += buttonOkay_Click;
            // 
            // WarningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 134);
            Controls.Add(buttonOkay);
            Controls.Add(labelWarningText);
            Name = "WarningForm";
            Text = "WarningForm";
            Load += WarningForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWarningText;
        private Button buttonOkay;
    }
}