namespace Convert2PNG
{
    partial class MissingPackages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissingPackages));
            errorLabel = new Label();
            explanationLabel = new Label();
            downloadBTN = new Button();
            okBTN = new Button();
            SuspendLayout();
            // 
            // errorLabel
            // 
            errorLabel.AllowDrop = true;
            errorLabel.AutoEllipsis = true;
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            errorLabel.Location = new Point(12, 9);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(406, 21);
            errorLabel.TabIndex = 0;
            errorLabel.Text = "Convert2PNG did not find ghostscript on your system!";
            // 
            // explanationLabel
            // 
            explanationLabel.AutoSize = true;
            explanationLabel.Location = new Point(12, 45);
            explanationLabel.Name = "explanationLabel";
            explanationLabel.Size = new Size(350, 30);
            explanationLabel.TabIndex = 1;
            explanationLabel.Text = "This program relies on many components to be able \r\nto convert so many files, which is why you got this error message";
            // 
            // downloadBTN
            // 
            downloadBTN.Location = new Point(12, 93);
            downloadBTN.Name = "downloadBTN";
            downloadBTN.Size = new Size(75, 23);
            downloadBTN.TabIndex = 2;
            downloadBTN.Text = "Download";
            downloadBTN.UseVisualStyleBackColor = true;
            downloadBTN.Click += OpenDownloadLink;
            // 
            // okBTN
            // 
            okBTN.Location = new Point(343, 93);
            okBTN.Name = "okBTN";
            okBTN.Size = new Size(75, 23);
            okBTN.TabIndex = 3;
            okBTN.Text = "Ok";
            okBTN.UseVisualStyleBackColor = true;
            okBTN.Click += Ok;
            // 
            // MissingPackages
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(436, 124);
            ControlBox = false;
            Controls.Add(okBTN);
            Controls.Add(downloadBTN);
            Controls.Add(explanationLabel);
            Controls.Add(errorLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(452, 163);
            Name = "MissingPackages";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Convert2PNG Missing packages";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label errorLabel;
        private Label explanationLabel;
        private Button downloadBTN;
        private Button okBTN;
    }
}