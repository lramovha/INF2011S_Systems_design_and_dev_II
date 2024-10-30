namespace Project.presentation
{
    partial class GuestForm
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
            this.GuestsDataGridView = new System.Windows.Forms.DataGridView();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddGuestButton = new System.Windows.Forms.Button();
            this.UpdateGuestButton = new System.Windows.Forms.Button();
            this.DeleteGuestButton = new System.Windows.Forms.Button();
            this.LoadGuestsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GuestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GuestsDataGridView
            // 
            this.GuestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GuestsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.GuestsDataGridView.Name = "GuestsDataGridView";
            this.GuestsDataGridView.RowHeadersWidth = 51;
            this.GuestsDataGridView.RowTemplate.Height = 24;
            this.GuestsDataGridView.Size = new System.Drawing.Size(877, 242);
            this.GuestsDataGridView.TabIndex = 0;
            this.GuestsDataGridView.Click += new System.EventHandler(this.GuestsDataGridView_SelectionChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(135, 307);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(254, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(135, 351);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(143, 22);
            this.PhoneTextBox.TabIndex = 2;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(135, 391);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(245, 22);
            this.EmailTextBox.TabIndex = 3;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(135, 432);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(369, 22);
            this.AddressTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.Name_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // AddGuestButton
            // 
            this.AddGuestButton.Location = new System.Drawing.Point(663, 344);
            this.AddGuestButton.Name = "AddGuestButton";
            this.AddGuestButton.Size = new System.Drawing.Size(92, 43);
            this.AddGuestButton.TabIndex = 9;
            this.AddGuestButton.Text = "Add Guest";
            this.AddGuestButton.UseVisualStyleBackColor = true;
            this.AddGuestButton.Click += new System.EventHandler(this.AddGuestButton_Click);
            // 
            // UpdateGuestButton
            // 
            this.UpdateGuestButton.Location = new System.Drawing.Point(774, 344);
            this.UpdateGuestButton.Name = "UpdateGuestButton";
            this.UpdateGuestButton.Size = new System.Drawing.Size(94, 43);
            this.UpdateGuestButton.TabIndex = 10;
            this.UpdateGuestButton.Text = "Update Guest";
            this.UpdateGuestButton.UseVisualStyleBackColor = true;
            this.UpdateGuestButton.Click += new System.EventHandler(this.UpdateGuestButton_Click);
            // 
            // DeleteGuestButton
            // 
            this.DeleteGuestButton.Location = new System.Drawing.Point(663, 422);
            this.DeleteGuestButton.Name = "DeleteGuestButton";
            this.DeleteGuestButton.Size = new System.Drawing.Size(92, 43);
            this.DeleteGuestButton.TabIndex = 11;
            this.DeleteGuestButton.Text = "Delete Guest";
            this.DeleteGuestButton.UseVisualStyleBackColor = true;
            this.DeleteGuestButton.Click += new System.EventHandler(this.DeleteGuestButton_Click);
            // 
            // LoadGuestsButton
            // 
            this.LoadGuestsButton.Location = new System.Drawing.Point(784, 420);
            this.LoadGuestsButton.Name = "LoadGuestsButton";
            this.LoadGuestsButton.Size = new System.Drawing.Size(84, 45);
            this.LoadGuestsButton.TabIndex = 12;
            this.LoadGuestsButton.Text = "Load Guest";
            this.LoadGuestsButton.UseVisualStyleBackColor = true;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 537);
            this.Controls.Add(this.LoadGuestsButton);
            this.Controls.Add(this.DeleteGuestButton);
            this.Controls.Add(this.UpdateGuestButton);
            this.Controls.Add(this.AddGuestButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.GuestsDataGridView);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            ((System.ComponentModel.ISupportInitialize)(this.GuestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GuestsDataGridView;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddGuestButton;
        private System.Windows.Forms.Button UpdateGuestButton;
        private System.Windows.Forms.Button DeleteGuestButton;
        private System.Windows.Forms.Button LoadGuestsButton;
    }
}