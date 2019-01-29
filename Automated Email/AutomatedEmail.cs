using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Automated_Email
{
    /// <summary>
    /// The main form of the application. Allows the user to write and send mass emails, save email templates, load email templates, and 
    /// add, edit, and delete email addresses.
    /// </summary>
    public partial class AutomatedEmail : Form
    {
        private string filePath; // the path to the folder where emails and the address list are saved

        public AutomatedEmail()
        {
            InitializeComponent();
            // filePath should be C:\Users\[UserName]\Documents\AutomatedEmails
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Documents\Automated Emails";
            this.InitDirectory();
            this.RefreshAddressList();
        }

        /// <summary>
        /// Toggles the checked status of all addresses (all checked or all unchecked).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GlobalCheckButton_Click(object sender, EventArgs e)
        {
            bool check = this.GlobalCheckButton.Text.Equals("Select All");
            for (int i = 0; i < this.addressList.Items.Count; i++)
            {
                this.addressList.SetItemChecked(i, check);
            }
            this.GlobalCheckButton.Text = check ? "Deselect All" : "Select All";
        }

        /// <summary>
        /// Prompts the user to add an email address.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAddressButton_Click(object sender, EventArgs e)
        {
            this.RunAddressPrompt(true);
        }

        /// <summary>
        /// Prompts user to edit an existing email address.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditAddressButton_Click(object sender, EventArgs e)
        {
            this.RunAddressPrompt(false);
        }

        /// <summary>
        /// Deletes the currently selected email address in the address list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAddressButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + (string)this.addressList.SelectedItem + "?", "Delete email?",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.DeleteSelectedItem();
                this.RefreshAddressList();
            }
        }

        /// <summary>
        /// Deletes the currently selected item, both in UI and in the file.
        /// </summary>
        private void DeleteSelectedItem()
        {
            List<string> data = new List<string>();
            using (StreamReader reader = new StreamReader(this.filePath + @"\email list.txt"))
            {
                while (!reader.EndOfStream)
                {
                    data.Add(reader.ReadLine());
                }
            }
            data.Remove((string)this.addressList.SelectedItem);
            using (StreamWriter writer = new StreamWriter(this.filePath + @"\email list.txt"))
            {
                data.ForEach(c => writer.WriteLine(c));
            }
            this.addressList.Items.Remove(this.addressList.SelectedItem);
        }

        /// <summary>
        /// Creates an AddressPrompt and handles the result. This is used both when adding and editing an email address.
        /// </summary>
        /// <param name="adding">Whether or not the prompt is being created to add an address.</param>
        private void RunAddressPrompt(bool adding)
        {
            using (AddressPrompt prompt = new AddressPrompt(!adding ? (string)this.addressList.SelectedItem : "")
            {
                ShowInTaskbar = false
            })
            {
                if (prompt.ShowDialog() == DialogResult.OK && prompt.Result != null && !this.addressList.Items.Contains(prompt.Result))
                {
                    try
                    {
                        var email = new MailAddress(prompt.Result);
                        using (StreamWriter writer = new StreamWriter(this.filePath + @"\email list.txt", true))
                        {
                            writer.WriteLine(prompt.Result);
                        }
                        if (this.addressList.SelectedItem != null && !adding)
                        {
                            this.DeleteSelectedItem();
                        }
                        this.RefreshAddressList();
                        MessageBox.Show(prompt.Result + " added.");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Invalid input\n\n" + exception.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Refreshes the address list.
        /// </summary>
        private void RefreshAddressList()
        {
            List<string> data = new List<string>();
            using (StreamReader reader = new StreamReader(this.filePath + @"\email list.txt"))
            {
                while (this.addressList.Items.Count > 0)
                {
                    this.addressList.Items.RemoveAt(0);
                }
                while (!reader.EndOfStream)
                {
                    this.addressList.Items.Add(reader.ReadLine());
                }
            }
        }

        /// <summary>
        /// Loads a previously created email from a .txt or .rtf file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadEmailButton_Click(object sender, EventArgs e)
        {
            if (this.LoadEmailDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(this.LoadEmailDialog.OpenFile()))
                {
                    this.emailTextInput.Text = reader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// Saves the contents of the emailTextInput to a .txt or .rtf file for later use.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveEmailButton_Click(object sender, EventArgs e)
        {
            if (this.SaveEmailDialog.ShowDialog() == DialogResult.OK && this.SaveEmailDialog.FileName != "")
            {
                this.emailTextInput.SaveFile(this.SaveEmailDialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        /// <summary>
        /// Sends the contents of the emailTextInput via a gmail address to the checked email addresses by calling SendEmail multiple times.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            if (this.addressList.CheckedItems.Count > 0)
            {
                List<string> failedToSend = new List<string>();
                foreach (string item in this.addressList.CheckedItems)
                {
                    MailAddress from = new MailAddress("tthornung@gmail.com", "Theo Hornung");
                    MailAddress to = new MailAddress(item);
                    if (!SendEmail("Backpack Coalition Donation Drive", from, to))
                    {
                        failedToSend.Add(to.ToString());
                    }
                }
                string boxMsg;
                if (failedToSend.Count > 0)
                {
                    boxMsg = "Failed to send to:\n";
                    failedToSend.ForEach(s => boxMsg += "\t" + s + "\n ");
                }
                else
                {
                    boxMsg = "Emails successfully sent";
                }
                MessageBox.Show(boxMsg);
            }
            else
            {
                MessageBox.Show("Please select recipient(s)");
            }
        }

        /// <summary>
        /// Handles sending emails via a gmail address to a single email address.
        /// </summary>
        /// <param name="subject">The subject line of the email.</param>
        /// <param name="from">The address from which the email is being sent.</param>
        /// <param name="to">The intended recipient of the email.</param>
        /// <returns>True if the email successfully sent.</returns>
        private bool SendEmail(string subject, MailAddress from, MailAddress to)
        {
            bool sent = false;
            SmtpClient mailClient = new SmtpClient
            {
                Port = 587,
                Host = "smtp.gmail.com",
                EnableSsl = true,
                Timeout = 10000,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("tthornung@gmail.com", "jwutlfzefhyhwipx")
            };
            MailMessage msg = new MailMessage(from, to)
            {
                Subject = subject,
                Body = this.emailTextInput.Text
            };
            try
            {
                mailClient.Send(msg);
                sent = true;
            }
            catch (Exception)
            {
                sent = false;
            }
            msg.Dispose();
            return sent;
        }

        /// <summary>
        /// Creates folder structure for the project.
        /// </summary>
        private void InitDirectory()
        {
            List<string> directory =
                    new List<string>(System.IO.Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Documents"));
            if (!directory.Contains(this.filePath))
            {
                System.IO.Directory.CreateDirectory(filePath);
                var file = File.Create(filePath + @"\email list.txt");
                file.Close();
            }
        }
    }
}
