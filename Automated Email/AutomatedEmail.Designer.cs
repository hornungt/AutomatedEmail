namespace Automated_Email
{
    partial class AutomatedEmail
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
            this.SaveEmailDialog = new System.Windows.Forms.SaveFileDialog();
            this.LoadEmailDialog = new System.Windows.Forms.OpenFileDialog();
            this.GlobalCheckButton = new System.Windows.Forms.Button();
            this.emailTextInput = new System.Windows.Forms.RichTextBox();
            this.addressList = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SendEmailButton = new System.Windows.Forms.Button();
            this.SaveEmailButton = new System.Windows.Forms.Button();
            this.LoadEmailButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addressControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteAddressButton = new System.Windows.Forms.Button();
            this.EditAddressButton = new System.Windows.Forms.Button();
            this.AddAddressButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.addressControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveEmailDialog
            // 
            this.SaveEmailDialog.FileName = "email.rtf";
            this.SaveEmailDialog.Filter = "Rich Text Format|*.rtf|Text Files (.txt)|*.txt";
            this.SaveEmailDialog.Title = "Save email...";
            // 
            // LoadEmailDialog
            // 
            this.LoadEmailDialog.Filter = "\"Rich Text Format|*.rtf|Text Files (.txt)|*.txt\"";
            // 
            // GlobalCheckButton
            // 
            this.GlobalCheckButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalCheckButton.Location = new System.Drawing.Point(3, 571);
            this.GlobalCheckButton.Name = "GlobalCheckButton";
            this.GlobalCheckButton.Size = new System.Drawing.Size(357, 65);
            this.GlobalCheckButton.TabIndex = 7;
            this.GlobalCheckButton.Text = "Select All";
            this.GlobalCheckButton.UseVisualStyleBackColor = true;
            this.GlobalCheckButton.Click += new System.EventHandler(this.GlobalCheckButton_Click);
            // 
            // emailTextInput
            // 
            this.emailTextInput.AcceptsTab = true;
            this.emailTextInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTextInput.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextInput.Location = new System.Drawing.Point(366, 3);
            this.emailTextInput.Name = "emailTextInput";
            this.tableLayoutPanel.SetRowSpan(this.emailTextInput, 2);
            this.emailTextInput.Size = new System.Drawing.Size(903, 633);
            this.emailTextInput.TabIndex = 4;
            this.emailTextInput.Text = "Type email here...";
            // 
            // addressList
            // 
            this.addressList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressList.FormattingEnabled = true;
            this.addressList.Location = new System.Drawing.Point(3, 3);
            this.addressList.Name = "addressList";
            this.addressList.Size = new System.Drawing.Size(357, 562);
            this.addressList.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.SendEmailButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SaveEmailButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoadEmailButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(366, 642);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(903, 66);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendEmailButton.Location = new System.Drawing.Point(605, 3);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(295, 60);
            this.SendEmailButton.TabIndex = 2;
            this.SendEmailButton.Text = "Send Email";
            this.SendEmailButton.UseVisualStyleBackColor = true;
            this.SendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // SaveEmailButton
            // 
            this.SaveEmailButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveEmailButton.Location = new System.Drawing.Point(304, 3);
            this.SaveEmailButton.Name = "SaveEmailButton";
            this.SaveEmailButton.Size = new System.Drawing.Size(295, 60);
            this.SaveEmailButton.TabIndex = 1;
            this.SaveEmailButton.Text = "Save as...";
            this.SaveEmailButton.UseVisualStyleBackColor = true;
            this.SaveEmailButton.Click += new System.EventHandler(this.SaveEmailButton_Click);
            // 
            // LoadEmailButton
            // 
            this.LoadEmailButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadEmailButton.Location = new System.Drawing.Point(3, 3);
            this.LoadEmailButton.Name = "LoadEmailButton";
            this.LoadEmailButton.Size = new System.Drawing.Size(295, 60);
            this.LoadEmailButton.TabIndex = 0;
            this.LoadEmailButton.Text = "Load...";
            this.LoadEmailButton.UseVisualStyleBackColor = true;
            this.LoadEmailButton.Click += new System.EventHandler(this.LoadEmailButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel.Controls.Add(this.addressControlPanel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.addressList, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.emailTextInput, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.GlobalCheckButton, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1272, 711);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // addressControlPanel
            // 
            this.addressControlPanel.ColumnCount = 3;
            this.addressControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.addressControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.addressControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.addressControlPanel.Controls.Add(this.DeleteAddressButton, 2, 0);
            this.addressControlPanel.Controls.Add(this.EditAddressButton, 1, 0);
            this.addressControlPanel.Controls.Add(this.AddAddressButton, 0, 0);
            this.addressControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressControlPanel.Location = new System.Drawing.Point(3, 642);
            this.addressControlPanel.Name = "addressControlPanel";
            this.addressControlPanel.RowCount = 1;
            this.addressControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addressControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.addressControlPanel.Size = new System.Drawing.Size(357, 66);
            this.addressControlPanel.TabIndex = 11;
            // 
            // DeleteAddressButton
            // 
            this.DeleteAddressButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteAddressButton.Location = new System.Drawing.Point(241, 3);
            this.DeleteAddressButton.Name = "DeleteAddressButton";
            this.DeleteAddressButton.Size = new System.Drawing.Size(113, 60);
            this.DeleteAddressButton.TabIndex = 2;
            this.DeleteAddressButton.Text = "Delete";
            this.DeleteAddressButton.UseVisualStyleBackColor = true;
            this.DeleteAddressButton.Click += new System.EventHandler(this.DeleteAddressButton_Click);
            // 
            // EditAddressButton
            // 
            this.EditAddressButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditAddressButton.Location = new System.Drawing.Point(122, 3);
            this.EditAddressButton.Name = "EditAddressButton";
            this.EditAddressButton.Size = new System.Drawing.Size(113, 60);
            this.EditAddressButton.TabIndex = 1;
            this.EditAddressButton.Text = "Edit";
            this.EditAddressButton.UseVisualStyleBackColor = true;
            this.EditAddressButton.Click += new System.EventHandler(this.EditAddressButton_Click);
            // 
            // AddAddressButton
            // 
            this.AddAddressButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddAddressButton.Location = new System.Drawing.Point(3, 3);
            this.AddAddressButton.Name = "AddAddressButton";
            this.AddAddressButton.Size = new System.Drawing.Size(113, 60);
            this.AddAddressButton.TabIndex = 0;
            this.AddAddressButton.Text = "Add";
            this.AddAddressButton.UseVisualStyleBackColor = true;
            this.AddAddressButton.Click += new System.EventHandler(this.AddAddressButton_Click);
            // 
            // AutomatedEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 711);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "AutomatedEmail";
            this.Text = "Backpack Coalition Automated Email";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.addressControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog SaveEmailDialog;
        private System.Windows.Forms.OpenFileDialog LoadEmailDialog;
        private System.Windows.Forms.Button GlobalCheckButton;
        private System.Windows.Forms.RichTextBox emailTextInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel addressControlPanel;
        private System.Windows.Forms.Button DeleteAddressButton;
        private System.Windows.Forms.Button EditAddressButton;
        private System.Windows.Forms.Button AddAddressButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SendEmailButton;
        private System.Windows.Forms.Button SaveEmailButton;
        private System.Windows.Forms.Button LoadEmailButton;
        private System.Windows.Forms.CheckedListBox addressList;
    }
}

