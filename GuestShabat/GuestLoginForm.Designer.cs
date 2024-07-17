
namespace GuestShabat
{
    partial class GuestLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestLoginForm));
            label_welcome = new Label();
            label_enterGuestName = new Label();
            listBox_GuestNames = new ListBox();
            textBox_guestName = new TextBox();
            button_login = new Button();
            SuspendLayout();
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.BackColor = Color.Transparent;
            label_welcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label_welcome.Location = new Point(204, 49);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(189, 37);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "ברוכים הבאים";
            // 
            // label_enterGuestName
            // 
            label_enterGuestName.AutoSize = true;
            label_enterGuestName.BackColor = Color.Transparent;
            label_enterGuestName.FlatStyle = FlatStyle.Popup;
            label_enterGuestName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label_enterGuestName.ForeColor = Color.DarkRed;
            label_enterGuestName.Location = new Point(244, 111);
            label_enterGuestName.Name = "label_enterGuestName";
            label_enterGuestName.Size = new Size(118, 21);
            label_enterGuestName.TabIndex = 1;
            label_enterGuestName.Text = "הכנס שם אורח";
            // 
            // listBox_GuestNames
            // 
            listBox_GuestNames.BackColor = Color.Beige;
            listBox_GuestNames.Font = new Font("Segoe UI", 12F);
            listBox_GuestNames.FormattingEnabled = true;
            listBox_GuestNames.ItemHeight = 21;
            listBox_GuestNames.Location = new Point(213, 185);
            listBox_GuestNames.Name = "listBox_GuestNames";
            listBox_GuestNames.Size = new Size(168, 193);
            listBox_GuestNames.TabIndex = 2;
            listBox_GuestNames.DoubleClick += listBox_GuestNames_DoubleClick;
            // 
            // textBox_guestName
            // 
            textBox_guestName.BackColor = Color.FromArgb(217, 210, 183);
            textBox_guestName.Font = new Font("Segoe UI", 15F);
            textBox_guestName.Location = new Point(214, 135);
            textBox_guestName.Name = "textBox_guestName";
            textBox_guestName.Size = new Size(168, 34);
            textBox_guestName.TabIndex = 0;
            textBox_guestName.KeyDown += textBox_guestName_KeyDown;
            // 
            // button_login
            // 
            button_login.BackColor = Color.Olive;
            button_login.Font = new Font("Segoe UI", 14F);
            button_login.ForeColor = Color.SeaShell;
            button_login.Location = new Point(213, 414);
            button_login.Name = "button_login";
            button_login.Size = new Size(168, 45);
            button_login.TabIndex = 3;
            button_login.Text = "אישור";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // GuestLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 208, 188);
            BackgroundImage = Properties.Resources.loginBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(451, 649);
            Controls.Add(button_login);
            Controls.Add(textBox_guestName);
            Controls.Add(listBox_GuestNames);
            Controls.Add(label_enterGuestName);
            Controls.Add(label_welcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GuestLoginForm";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "שבת - אורח";
            FormClosed += GuestLoginForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label_welcome;
        private Label label_enterGuestName;
        private ListBox listBox_GuestNames;
        private TextBox textBox_guestName;
        private Button button_login;
    }
}
