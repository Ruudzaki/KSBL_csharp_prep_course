namespace KSBL_CallWinForm
{
    partial class CallViewer
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
            this.CallListView = new System.Windows.Forms.ListView();
            this.Contacts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.callType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.callTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.callCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.runCallGeneratorButton = new System.Windows.Forms.Button();
            this.callGeneratorGroupBox = new System.Windows.Forms.GroupBox();
            this.callGeneratorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CallListView
            // 
            this.CallListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Contacts,
            this.callType,
            this.callTime,
            this.callCount});
            this.CallListView.Location = new System.Drawing.Point(12, 65);
            this.CallListView.Name = "CallListView";
            this.CallListView.Size = new System.Drawing.Size(606, 235);
            this.CallListView.TabIndex = 0;
            this.CallListView.UseCompatibleStateImageBehavior = false;
            this.CallListView.View = System.Windows.Forms.View.Details;
            // 
            // Contacts
            // 
            this.Contacts.Text = "Contact";
            this.Contacts.Width = 231;
            // 
            // callType
            // 
            this.callType.Text = "Call Type";
            this.callType.Width = 142;
            // 
            // callTime
            // 
            this.callTime.Text = "Call Time";
            this.callTime.Width = 170;
            // 
            // callCount
            // 
            this.callCount.Text = "Call Times";
            // 
            // runCallGeneratorButton
            // 
            this.runCallGeneratorButton.Location = new System.Drawing.Point(34, 19);
            this.runCallGeneratorButton.Name = "runCallGeneratorButton";
            this.runCallGeneratorButton.Size = new System.Drawing.Size(75, 23);
            this.runCallGeneratorButton.TabIndex = 1;
            this.runCallGeneratorButton.Text = "On/Off";
            this.runCallGeneratorButton.UseVisualStyleBackColor = true;
            this.runCallGeneratorButton.Click += new System.EventHandler(this.runCallGeneratorButton_Click);
            // 
            // callGeneratorGroupBox
            // 
            this.callGeneratorGroupBox.Controls.Add(this.runCallGeneratorButton);
            this.callGeneratorGroupBox.Location = new System.Drawing.Point(12, 7);
            this.callGeneratorGroupBox.Name = "callGeneratorGroupBox";
            this.callGeneratorGroupBox.Size = new System.Drawing.Size(151, 52);
            this.callGeneratorGroupBox.TabIndex = 2;
            this.callGeneratorGroupBox.TabStop = false;
            this.callGeneratorGroupBox.Text = "Call Generator";
            // 
            // CallViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 315);
            this.Controls.Add(this.callGeneratorGroupBox);
            this.Controls.Add(this.CallListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CallViewer";
            this.Text = "CallViewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CallViewer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CallViewer_FormClosed);
            this.callGeneratorGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CallListView;
        private System.Windows.Forms.ColumnHeader Contacts;
        private System.Windows.Forms.ColumnHeader callType;
        private System.Windows.Forms.ColumnHeader callTime;
        private System.Windows.Forms.ColumnHeader callCount;
        private System.Windows.Forms.Button runCallGeneratorButton;
        private System.Windows.Forms.GroupBox callGeneratorGroupBox;
    }
}

