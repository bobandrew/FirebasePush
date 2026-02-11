namespace FirebasePush
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblProject = new Label();
            txtProjectId = new TextBox();
            txtPushData = new RichTextBox();
            btnSend = new Button();
            txtResult = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Location = new Point(12, 15);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(58, 15);
            lblProject.TabIndex = 3;
            lblProject.Text = "Project ID";
            // 
            // txtProjectId
            // 
            txtProjectId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtProjectId.Location = new Point(91, 12);
            txtProjectId.Name = "txtProjectId";
            txtProjectId.Size = new Size(697, 23);
            txtProjectId.TabIndex = 2;
            txtProjectId.Text = "fitness365-4";
            // 
            // txtPushData
            // 
            txtPushData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPushData.Location = new Point(12, 41);
            txtPushData.Name = "txtPushData";
            txtPushData.Size = new Size(776, 280);
            txtPushData.TabIndex = 4;
            txtPushData.Text = resources.GetString("txtPushData.Text");
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.Location = new Point(713, 397);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtResult
            // 
            txtResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResult.Location = new Point(12, 327);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(776, 49);
            txtResult.TabIndex = 6;
            txtResult.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(12, 401);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 7;
            label1.Text = "newid() - generates new GUID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 432);
            Controls.Add(label1);
            Controls.Add(txtResult);
            Controls.Add(btnSend);
            Controls.Add(txtPushData);
            Controls.Add(lblProject);
            Controls.Add(txtProjectId);
            Name = "Form1";
            Text = "FirebasePush";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblProject;
        private TextBox txtProjectId;
        private RichTextBox txtPushData;
        private Button btnSend;
        private RichTextBox txtResult;
        private Label label1;
    }
}