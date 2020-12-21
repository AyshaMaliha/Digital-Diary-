
namespace Digital_Diary_Version_2
{
    partial class Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.eventNameAddButton = new System.Windows.Forms.Button();
            this.eventEntryTextBox = new System.Windows.Forms.TextBox();
            this.eventEntryPictureBox = new System.Windows.Forms.PictureBox();
            this.eventEntrySaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventEntryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameLabel.Location = new System.Drawing.Point(12, 22);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(114, 24);
            this.eventNameLabel.TabIndex = 1;
            this.eventNameLabel.Text = "Event Name";
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.Location = new System.Drawing.Point(132, 22);
            this.eventNameTextBox.Multiline = true;
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(351, 24);
            this.eventNameTextBox.TabIndex = 2;
            // 
            // eventNameAddButton
            // 
            this.eventNameAddButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.eventNameAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventNameAddButton.ForeColor = System.Drawing.Color.Transparent;
            this.eventNameAddButton.Location = new System.Drawing.Point(501, 22);
            this.eventNameAddButton.Name = "eventNameAddButton";
            this.eventNameAddButton.Size = new System.Drawing.Size(96, 24);
            this.eventNameAddButton.TabIndex = 3;
            this.eventNameAddButton.Text = "Add";
            this.eventNameAddButton.UseVisualStyleBackColor = false;
            // 
            // eventEntryTextBox
            // 
            this.eventEntryTextBox.Location = new System.Drawing.Point(12, 62);
            this.eventEntryTextBox.Multiline = true;
            this.eventEntryTextBox.Name = "eventEntryTextBox";
            this.eventEntryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.eventEntryTextBox.Size = new System.Drawing.Size(1126, 397);
            this.eventEntryTextBox.TabIndex = 4;
            // 
            // eventEntryPictureBox
            // 
            this.eventEntryPictureBox.BackColor = System.Drawing.Color.Lavender;
            this.eventEntryPictureBox.Location = new System.Drawing.Point(889, 71);
            this.eventEntryPictureBox.Name = "eventEntryPictureBox";
            this.eventEntryPictureBox.Size = new System.Drawing.Size(222, 322);
            this.eventEntryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eventEntryPictureBox.TabIndex = 5;
            this.eventEntryPictureBox.TabStop = false;
            this.eventEntryPictureBox.Click += new System.EventHandler(this.eventEntryPictureBox_Click);
            // 
            // eventEntrySaveButton
            // 
            this.eventEntrySaveButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.eventEntrySaveButton.ForeColor = System.Drawing.Color.Transparent;
            this.eventEntrySaveButton.Location = new System.Drawing.Point(1144, 419);
            this.eventEntrySaveButton.Name = "eventEntrySaveButton";
            this.eventEntrySaveButton.Size = new System.Drawing.Size(86, 40);
            this.eventEntrySaveButton.TabIndex = 6;
            this.eventEntrySaveButton.Text = "Save";
            this.eventEntrySaveButton.UseVisualStyleBackColor = false;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 471);
            this.Controls.Add(this.eventEntrySaveButton);
            this.Controls.Add(this.eventEntryPictureBox);
            this.Controls.Add(this.eventEntryTextBox);
            this.Controls.Add(this.eventNameAddButton);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.eventNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Event";
            this.Text = "Event";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Event_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventEntryPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Button eventNameAddButton;
        private System.Windows.Forms.TextBox eventEntryTextBox;
        private System.Windows.Forms.PictureBox eventEntryPictureBox;
        private System.Windows.Forms.Button eventEntrySaveButton;
    }
}