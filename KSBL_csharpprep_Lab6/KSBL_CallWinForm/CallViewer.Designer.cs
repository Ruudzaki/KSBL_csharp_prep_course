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
            this.phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.callType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.callTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CallListView
            // 
            this.CallListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.phoneNumber,
            this.callType,
            this.callTime});
            this.CallListView.Location = new System.Drawing.Point(12, 29);
            this.CallListView.Name = "CallListView";
            this.CallListView.Size = new System.Drawing.Size(426, 271);
            this.CallListView.TabIndex = 0;
            this.CallListView.UseCompatibleStateImageBehavior = false;
            this.CallListView.View = System.Windows.Forms.View.Details;
            this.CallListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Phone Number";
            this.phoneNumber.Width = 118;
            // 
            // callType
            // 
            this.callType.Text = "Call Type";
            this.callType.Width = 120;
            // 
            // callTime
            // 
            this.callTime.Text = "Call Time";
            this.callTime.Width = 112;
            // 
            // CallViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 312);
            this.Controls.Add(this.CallListView);
            this.Name = "CallViewer";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CallListView;
        private System.Windows.Forms.ColumnHeader phoneNumber;
        private System.Windows.Forms.ColumnHeader callType;
        private System.Windows.Forms.ColumnHeader callTime;
    }
}

