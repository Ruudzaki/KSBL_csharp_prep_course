﻿namespace KSBL_SmsWinForms_app
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
            this.UserComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.startWithDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endWithDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AllFilterOnCheckBox = new System.Windows.Forms.CheckBox();
            this.Filtering = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Filtering.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formatComboBox
            // 
            this.formatComboBox.DisplayMember = "None";
            this.formatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Location = new System.Drawing.Point(6, 19);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(125, 21);
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
            this.MessageListView.Location = new System.Drawing.Point(12, 135);
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
            // UserComboBox
            // 
            this.UserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.Location = new System.Drawing.Point(87, 17);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(128, 21);
            this.UserComboBox.TabIndex = 3;
            this.UserComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(87, 44);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(128, 20);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // startWithDateTimePicker
            // 
            this.startWithDateTimePicker.Location = new System.Drawing.Point(87, 70);
            this.startWithDateTimePicker.Name = "startWithDateTimePicker";
            this.startWithDateTimePicker.Size = new System.Drawing.Size(128, 20);
            this.startWithDateTimePicker.TabIndex = 5;
            this.startWithDateTimePicker.ValueChanged += new System.EventHandler(this.startWithDateTimePicker_ValueChanged);
            // 
            // endWithDateTimePicker
            // 
            this.endWithDateTimePicker.Location = new System.Drawing.Point(221, 70);
            this.endWithDateTimePicker.Name = "endWithDateTimePicker";
            this.endWithDateTimePicker.Size = new System.Drawing.Size(128, 20);
            this.endWithDateTimePicker.TabIndex = 6;
            this.endWithDateTimePicker.ValueChanged += new System.EventHandler(this.endWithDateTimePicker_ValueChanged);
            // 
            // AllFilterOnCheckBox
            // 
            this.AllFilterOnCheckBox.AutoSize = true;
            this.AllFilterOnCheckBox.Checked = true;
            this.AllFilterOnCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllFilterOnCheckBox.Location = new System.Drawing.Point(237, 21);
            this.AllFilterOnCheckBox.Name = "AllFilterOnCheckBox";
            this.AllFilterOnCheckBox.Size = new System.Drawing.Size(112, 17);
            this.AllFilterOnCheckBox.TabIndex = 7;
            this.AllFilterOnCheckBox.Text = "Filter Intersection?";
            this.AllFilterOnCheckBox.UseVisualStyleBackColor = true;
            this.AllFilterOnCheckBox.CheckedChanged += new System.EventHandler(this.AllFilterOnCheckBox_CheckedChanged);
            // 
            // Filtering
            // 
            this.Filtering.Controls.Add(this.label3);
            this.Filtering.Controls.Add(this.label2);
            this.Filtering.Controls.Add(this.label1);
            this.Filtering.Controls.Add(this.AllFilterOnCheckBox);
            this.Filtering.Controls.Add(this.endWithDateTimePicker);
            this.Filtering.Controls.Add(this.startWithDateTimePicker);
            this.Filtering.Controls.Add(this.searchTextBox);
            this.Filtering.Controls.Add(this.UserComboBox);
            this.Filtering.Location = new System.Drawing.Point(292, 12);
            this.Filtering.Name = "Filtering";
            this.Filtering.Size = new System.Drawing.Size(364, 117);
            this.Filtering.TabIndex = 8;
            this.Filtering.TabStop = false;
            this.Filtering.Text = "Filtering";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.formatComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 60);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formatting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date";
            // 
            // SmsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Filtering);
            this.Controls.Add(this.MessageListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SmsViewer";
            this.Text = "SMS Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SmsViewer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SmsViewer_FormClosed);
            this.Filtering.ResumeLayout(false);
            this.Filtering.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.ListView MessageListView;
        private System.Windows.Forms.ColumnHeader Sender;
        private System.Windows.Forms.ColumnHeader SmsText;
        private System.Windows.Forms.ComboBox UserComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DateTimePicker startWithDateTimePicker;
        private System.Windows.Forms.DateTimePicker endWithDateTimePicker;
        private System.Windows.Forms.CheckBox AllFilterOnCheckBox;
        private System.Windows.Forms.GroupBox Filtering;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

