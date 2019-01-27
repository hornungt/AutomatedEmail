namespace Automated_Email
{
    partial class AddressPrompt
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddressTextInput = new System.Windows.Forms.TextBox();
            this.SubmitAddressButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.AddressTextInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SubmitAddressButton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 251);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AddressTextInput
            // 
            this.AddressTextInput.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddressTextInput.Location = new System.Drawing.Point(82, 100);
            this.AddressTextInput.Name = "AddressTextInput";
            this.AddressTextInput.Size = new System.Drawing.Size(388, 22);
            this.AddressTextInput.TabIndex = 0;
            // 
            // SubmitAddressButton
            // 
            this.SubmitAddressButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubmitAddressButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitAddressButton.Location = new System.Drawing.Point(229, 160);
            this.SubmitAddressButton.Margin = new System.Windows.Forms.Padding(3, 35, 3, 3);
            this.SubmitAddressButton.Name = "SubmitAddressButton";
            this.SubmitAddressButton.Size = new System.Drawing.Size(95, 46);
            this.SubmitAddressButton.TabIndex = 1;
            this.SubmitAddressButton.Text = "OK";
            this.SubmitAddressButton.UseVisualStyleBackColor = true;
            this.SubmitAddressButton.Click += new System.EventHandler(this.SubmitAddressButton_Click);
            // 
            // AddressPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 251);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddressPrompt";
            this.Text = "Enter an address...";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox AddressTextInput;
        private System.Windows.Forms.Button SubmitAddressButton;
    }
}