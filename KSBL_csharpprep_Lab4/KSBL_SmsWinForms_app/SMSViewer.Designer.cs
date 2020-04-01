namespace KSBL_SmsWinForms_app
{
    partial class SmsViewer
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
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.MessageListView = new System.Windows.Forms.ListView();
            this.Sender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SmsText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // formatComboBox
            // 
            this.formatComboBox.DisplayMember = "None";
            this.formatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Location = new System.Drawing.Point(13, 68);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(183, 21);
            this.formatComboBox.TabIndex = 1;
            this.formatComboBox.SelectedIndexChanged += new System.EventHandler(this.formatComboBox_SelectedIndexChanged);
            // 
            // MessageListView
            // 
            this.MessageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sender,
            this.SmsText});
            this.MessageListView.GridLines = true;
            this.MessageListView.LabelWrap = false;
            this.MessageListView.Location = new System.Drawing.Point(13, 106);
            this.MessageListView.Name = "MessageListView";
            this.MessageListView.Size = new System.Drawing.Size(643, 343);
            this.MessageListView.TabIndex = 2;
            this.MessageListView.UseCompatibleStateImageBehavior = false;
            this.MessageListView.View = System.Windows.Forms.View.Details;
            // 
            // Sender
            // 
            this.Sender.Text = "Sender";
            this.Sender.Width = 127;
            // 
            // SmsText
            // 
            this.SmsText.Text = "Sms Text";
            this.SmsText.Width = 342;
            // 
            // SmsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 458);
            this.Controls.Add(this.MessageListView);
            this.Controls.Add(this.formatComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SmsViewer";
            this.Text = "SMS Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SmsViewer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SmsViewer_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.ListView MessageListView;
        private System.Windows.Forms.ColumnHeader Sender;
        private System.Windows.Forms.ColumnHeader SmsText;
    }
}

