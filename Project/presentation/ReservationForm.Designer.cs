namespace Project.presentation
{
    partial class ReservationForm
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
            this.components = new System.ComponentModel.Container();
            this.reservationDataGridView = new System.Windows.Forms.DataGridView();
            this.guestComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkInDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.checkOutDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.AddReservationButton = new System.Windows.Forms.Button();
            this.UpdateReservationButton = new System.Windows.Forms.Button();
            this.DeleteReservationButton = new System.Windows.Forms.Button();
            this.ViewReservationsButton = new System.Windows.Forms.Button();
            this.phumlaKamnandiDataDataSet = new Project.PhumlaKamnandiDataDataSet();
            this.phumlaKamnandiDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDataDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reservationDataGridView
            // 
            this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGridView.Location = new System.Drawing.Point(54, 12);
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.RowHeadersWidth = 51;
            this.reservationDataGridView.RowTemplate.Height = 24;
            this.reservationDataGridView.Size = new System.Drawing.Size(920, 226);
            this.reservationDataGridView.TabIndex = 0;
            // 
            // guestComboBox
            // 
            this.guestComboBox.FormattingEnabled = true;
            this.guestComboBox.Location = new System.Drawing.Point(242, 287);
            this.guestComboBox.Name = "guestComboBox";
            this.guestComboBox.Size = new System.Drawing.Size(121, 24);
            this.guestComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Guest";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Room";
            // 
            // roomComboBox
            // 
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(242, 338);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(121, 24);
            this.roomComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Check-In Date";
            // 
            // checkInDatePicker
            // 
            this.checkInDatePicker.Location = new System.Drawing.Point(242, 391);
            this.checkInDatePicker.Name = "checkInDatePicker";
            this.checkInDatePicker.Size = new System.Drawing.Size(200, 22);
            this.checkInDatePicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Check-Out Date";
            // 
            // checkOutDatePicker
            // 
            this.checkOutDatePicker.Location = new System.Drawing.Point(242, 432);
            this.checkOutDatePicker.Name = "checkOutDatePicker";
            this.checkOutDatePicker.Size = new System.Drawing.Size(200, 22);
            this.checkOutDatePicker.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reservation Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(242, 474);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 24);
            this.statusComboBox.TabIndex = 10;
            // 
            // AddReservationButton
            // 
            this.AddReservationButton.Location = new System.Drawing.Point(662, 287);
            this.AddReservationButton.Name = "AddReservationButton";
            this.AddReservationButton.Size = new System.Drawing.Size(97, 54);
            this.AddReservationButton.TabIndex = 11;
            this.AddReservationButton.Text = "Add Reservation";
            this.AddReservationButton.UseVisualStyleBackColor = true;
            this.AddReservationButton.Click += new System.EventHandler(this.AddReservationButton_Click);
            // 
            // UpdateReservationButton
            // 
            this.UpdateReservationButton.Location = new System.Drawing.Point(841, 287);
            this.UpdateReservationButton.Name = "UpdateReservationButton";
            this.UpdateReservationButton.Size = new System.Drawing.Size(93, 54);
            this.UpdateReservationButton.TabIndex = 12;
            this.UpdateReservationButton.Text = "Update Reservation";
            this.UpdateReservationButton.UseVisualStyleBackColor = true;
            this.UpdateReservationButton.Click += new System.EventHandler(this.UpdateReservationButton_Click);
            // 
            // DeleteReservationButton
            // 
            this.DeleteReservationButton.Location = new System.Drawing.Point(662, 383);
            this.DeleteReservationButton.Name = "DeleteReservationButton";
            this.DeleteReservationButton.Size = new System.Drawing.Size(97, 47);
            this.DeleteReservationButton.TabIndex = 13;
            this.DeleteReservationButton.Text = "Delete Reservation";
            this.DeleteReservationButton.UseVisualStyleBackColor = true;
            this.DeleteReservationButton.Click += new System.EventHandler(this.DeleteReservationButton_Click);
            // 
            // ViewReservationsButton
            // 
            this.ViewReservationsButton.Location = new System.Drawing.Point(841, 383);
            this.ViewReservationsButton.Name = "ViewReservationsButton";
            this.ViewReservationsButton.Size = new System.Drawing.Size(93, 47);
            this.ViewReservationsButton.TabIndex = 14;
            this.ViewReservationsButton.Text = "View All Reservations";
            this.ViewReservationsButton.UseVisualStyleBackColor = true;
            // 
            // phumlaKamnandiDataDataSet
            // 
            this.phumlaKamnandiDataDataSet.DataSetName = "PhumlaKamnandiDataDataSet";
            this.phumlaKamnandiDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phumlaKamnandiDataDataSetBindingSource
            // 
            this.phumlaKamnandiDataDataSetBindingSource.DataSource = this.phumlaKamnandiDataDataSet;
            this.phumlaKamnandiDataDataSetBindingSource.Position = 0;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 559);
            this.Controls.Add(this.ViewReservationsButton);
            this.Controls.Add(this.DeleteReservationButton);
            this.Controls.Add(this.UpdateReservationButton);
            this.Controls.Add(this.AddReservationButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkOutDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkInDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roomComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guestComboBox);
            this.Controls.Add(this.reservationDataGridView);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phumlaKamnandiDataDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reservationDataGridView;
        private System.Windows.Forms.ComboBox guestComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker checkInDatePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker checkOutDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button AddReservationButton;
        private System.Windows.Forms.Button UpdateReservationButton;
        private System.Windows.Forms.Button DeleteReservationButton;
        private System.Windows.Forms.Button ViewReservationsButton;
        private PhumlaKamnandiDataDataSet phumlaKamnandiDataDataSet;
        private System.Windows.Forms.BindingSource phumlaKamnandiDataDataSetBindingSource;
    }
}