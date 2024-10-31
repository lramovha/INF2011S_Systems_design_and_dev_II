namespace Project.presentation
{
    partial class RoomForm
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
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.isAvailableCheckBox = new System.Windows.Forms.CheckBox();
            this.AddRoomButton = new System.Windows.Forms.Button();
            this.UpdateRoomButton = new System.Windows.Forms.Button();
            this.DeleteRoomButton = new System.Windows.Forms.Button();
            this.ViewRoomsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Location = new System.Drawing.Point(32, 12);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.RowHeadersWidth = 51;
            this.roomDataGridView.RowTemplate.Height = 24;
            this.roomDataGridView.Size = new System.Drawing.Size(930, 243);
            this.roomDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price                   R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "IsAvailable";
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Location = new System.Drawing.Point(195, 303);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.roomNumberTextBox.TabIndex = 5;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Select Room Type",
            "Single",
            "Double",
            "Suite"});
            this.typeComboBox.Location = new System.Drawing.Point(195, 351);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 24);
            this.typeComboBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(195, 387);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.priceTextBox.TabIndex = 7;
            // 
            // isAvailableCheckBox
            // 
            this.isAvailableCheckBox.AutoSize = true;
            this.isAvailableCheckBox.Location = new System.Drawing.Point(195, 432);
            this.isAvailableCheckBox.Name = "isAvailableCheckBox";
            this.isAvailableCheckBox.Size = new System.Drawing.Size(95, 20);
            this.isAvailableCheckBox.TabIndex = 8;
            this.isAvailableCheckBox.Text = "checkBox1";
            this.isAvailableCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddRoomButton
            // 
            this.AddRoomButton.Location = new System.Drawing.Point(549, 301);
            this.AddRoomButton.Name = "AddRoomButton";
            this.AddRoomButton.Size = new System.Drawing.Size(109, 47);
            this.AddRoomButton.TabIndex = 9;
            this.AddRoomButton.Text = "Add Room";
            this.AddRoomButton.UseVisualStyleBackColor = true;
            this.AddRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // UpdateRoomButton
            // 
            this.UpdateRoomButton.Location = new System.Drawing.Point(721, 301);
            this.UpdateRoomButton.Name = "UpdateRoomButton";
            this.UpdateRoomButton.Size = new System.Drawing.Size(98, 47);
            this.UpdateRoomButton.TabIndex = 10;
            this.UpdateRoomButton.Text = "Update Room";
            this.UpdateRoomButton.UseVisualStyleBackColor = true;
            this.UpdateRoomButton.Click += new System.EventHandler(this.UpdateRoomButton_Click);
            // 
            // DeleteRoomButton
            // 
            this.DeleteRoomButton.Location = new System.Drawing.Point(549, 387);
            this.DeleteRoomButton.Name = "DeleteRoomButton";
            this.DeleteRoomButton.Size = new System.Drawing.Size(109, 45);
            this.DeleteRoomButton.TabIndex = 11;
            this.DeleteRoomButton.Text = "Delete Room";
            this.DeleteRoomButton.UseVisualStyleBackColor = true;
            this.DeleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // ViewRoomsButton
            // 
            this.ViewRoomsButton.Location = new System.Drawing.Point(721, 387);
            this.ViewRoomsButton.Name = "ViewRoomsButton";
            this.ViewRoomsButton.Size = new System.Drawing.Size(98, 45);
            this.ViewRoomsButton.TabIndex = 12;
            this.ViewRoomsButton.Text = "View Room";
            this.ViewRoomsButton.UseVisualStyleBackColor = true;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 544);
            this.Controls.Add(this.ViewRoomsButton);
            this.Controls.Add(this.DeleteRoomButton);
            this.Controls.Add(this.UpdateRoomButton);
            this.Controls.Add(this.AddRoomButton);
            this.Controls.Add(this.isAvailableCheckBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomDataGridView);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView roomDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.CheckBox isAvailableCheckBox;
        private System.Windows.Forms.Button AddRoomButton;
        private System.Windows.Forms.Button UpdateRoomButton;
        private System.Windows.Forms.Button DeleteRoomButton;
        private System.Windows.Forms.Button ViewRoomsButton;
    }
}