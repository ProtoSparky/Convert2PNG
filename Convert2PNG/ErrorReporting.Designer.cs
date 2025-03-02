namespace Convert2PNG
{
    partial class ErrorReporting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorReporting));
            ErrorBox = new RichTextBox();
            okBtn = new Button();
            errorReportLabel = new Label();
            label1 = new Label();
            copyErrorBTN = new Button();
            SuspendLayout();
            // 
            // ErrorBox
            // 
            ErrorBox.BorderStyle = BorderStyle.FixedSingle;
            ErrorBox.Location = new Point(31, 95);
            ErrorBox.Name = "ErrorBox";
            ErrorBox.ReadOnly = true;
            ErrorBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            ErrorBox.Size = new Size(467, 182);
            ErrorBox.TabIndex = 0;
            ErrorBox.Text = "";
            // 
            // okBtn
            // 
            okBtn.DialogResult = DialogResult.OK;
            okBtn.Location = new Point(423, 283);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 1;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okPressed;
            // 
            // errorReportLabel
            // 
            errorReportLabel.AutoSize = true;
            errorReportLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            errorReportLabel.Location = new Point(31, 9);
            errorReportLabel.Name = "errorReportLabel";
            errorReportLabel.Size = new Size(368, 28);
            errorReportLabel.TabIndex = 2;
            errorReportLabel.Text = "Convert2PNG seems to have crashed :(";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 47);
            label1.Name = "label1";
            label1.Size = new Size(437, 45);
            label1.TabIndex = 3;
            label1.Text = "Below is the error that caused the crash\r\nIf you didn't expect this to happen, please copy and sumbit this error.\r\nDon't forget to explain what you did to cause it (what file you tried to convert etc)";
            // 
            // copyErrorBTN
            // 
            copyErrorBTN.Location = new Point(31, 283);
            copyErrorBTN.Name = "copyErrorBTN";
            copyErrorBTN.Size = new Size(164, 23);
            copyErrorBTN.TabIndex = 5;
            copyErrorBTN.Text = "Copy error and submit";
            copyErrorBTN.UseVisualStyleBackColor = true;
            copyErrorBTN.Click += submitError;
            // 
            // ErrorReporting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(521, 314);
            ControlBox = false;
            Controls.Add(copyErrorBTN);
            Controls.Add(label1);
            Controls.Add(errorReportLabel);
            Controls.Add(okBtn);
            Controls.Add(ErrorBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(537, 353);
            Name = "ErrorReporting";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Convert2PNG";
            TopMost = true;
            Load += ErrorReporting_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox ErrorBox;
        private Button okBtn;
        private Label errorReportLabel;
        private Label label1;
        private Button copyErrorBTN;
    }
}