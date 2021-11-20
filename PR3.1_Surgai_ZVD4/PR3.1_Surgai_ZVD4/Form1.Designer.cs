
namespace PR3._1_Surgai_ZVD4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.deleteButton = new System.Windows.Forms.Button();
            this.carsNumbersLabel = new System.Windows.Forms.Label();
            this.carsDataLabel = new System.Windows.Forms.Label();
            this.ownersFirstNameLabel = new System.Windows.Forms.Label();
            this.ownersLastNameLabel = new System.Windows.Forms.Label();
            this.carNumberLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.whiteRadioButton = new System.Windows.Forms.RadioButton();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.ownersFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.ownersLastNameTextBox = new System.Windows.Forms.TextBox();
            this.carNumberTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.carsNumbersListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(90, 399);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // carsNumbersLabel
            // 
            this.carsNumbersLabel.AutoSize = true;
            this.carsNumbersLabel.Location = new System.Drawing.Point(38, 28);
            this.carsNumbersLabel.Name = "carsNumbersLabel";
            this.carsNumbersLabel.Size = new System.Drawing.Size(76, 13);
            this.carsNumbersLabel.TabIndex = 1;
            this.carsNumbersLabel.Text = "Car`s Numbers";
            // 
            // carsDataLabel
            // 
            this.carsDataLabel.AutoSize = true;
            this.carsDataLabel.Location = new System.Drawing.Point(269, 28);
            this.carsDataLabel.Name = "carsDataLabel";
            this.carsDataLabel.Size = new System.Drawing.Size(57, 13);
            this.carsDataLabel.TabIndex = 2;
            this.carsDataLabel.Text = "Car`s Data";
            // 
            // ownersFirstNameLabel
            // 
            this.ownersFirstNameLabel.AutoSize = true;
            this.ownersFirstNameLabel.Location = new System.Drawing.Point(312, 71);
            this.ownersFirstNameLabel.Name = "ownersFirstNameLabel";
            this.ownersFirstNameLabel.Size = new System.Drawing.Size(99, 13);
            this.ownersFirstNameLabel.TabIndex = 3;
            this.ownersFirstNameLabel.Text = "Owner`s First Name";
            // 
            // ownersLastNameLabel
            // 
            this.ownersLastNameLabel.AutoSize = true;
            this.ownersLastNameLabel.Location = new System.Drawing.Point(311, 101);
            this.ownersLastNameLabel.Name = "ownersLastNameLabel";
            this.ownersLastNameLabel.Size = new System.Drawing.Size(100, 13);
            this.ownersLastNameLabel.TabIndex = 4;
            this.ownersLastNameLabel.Text = "Owner`s Last Name";
            // 
            // carNumberLabel
            // 
            this.carNumberLabel.AutoSize = true;
            this.carNumberLabel.Location = new System.Drawing.Point(314, 180);
            this.carNumberLabel.Name = "carNumberLabel";
            this.carNumberLabel.Size = new System.Drawing.Size(63, 13);
            this.carNumberLabel.TabIndex = 5;
            this.carNumberLabel.Text = "Car Number";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(314, 212);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 6;
            this.modelLabel.Text = "Model";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(315, 244);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(31, 13);
            this.colorLabel.TabIndex = 7;
            this.colorLabel.Text = "Color";
            // 
            // whiteRadioButton
            // 
            this.whiteRadioButton.AutoSize = true;
            this.whiteRadioButton.Location = new System.Drawing.Point(358, 270);
            this.whiteRadioButton.Name = "whiteRadioButton";
            this.whiteRadioButton.Size = new System.Drawing.Size(53, 17);
            this.whiteRadioButton.TabIndex = 8;
            this.whiteRadioButton.TabStop = true;
            this.whiteRadioButton.Text = "White";
            this.whiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(358, 293);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.blackRadioButton.TabIndex = 9;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(358, 316);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton.TabIndex = 10;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            // 
            // ownersFirstNameTextBox
            // 
            this.ownersFirstNameTextBox.Location = new System.Drawing.Point(426, 68);
            this.ownersFirstNameTextBox.Name = "ownersFirstNameTextBox";
            this.ownersFirstNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.ownersFirstNameTextBox.TabIndex = 11;
            // 
            // ownersLastNameTextBox
            // 
            this.ownersLastNameTextBox.Location = new System.Drawing.Point(426, 98);
            this.ownersLastNameTextBox.Name = "ownersLastNameTextBox";
            this.ownersLastNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.ownersLastNameTextBox.TabIndex = 12;
            // 
            // carNumberTextBox
            // 
            this.carNumberTextBox.Location = new System.Drawing.Point(426, 180);
            this.carNumberTextBox.Name = "carNumberTextBox";
            this.carNumberTextBox.Size = new System.Drawing.Size(159, 20);
            this.carNumberTextBox.TabIndex = 13;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(426, 212);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(159, 20);
            this.modelTextBox.TabIndex = 14;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(467, 399);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // carsNumbersListBox
            // 
            this.carsNumbersListBox.FormattingEnabled = true;
            this.carsNumbersListBox.Location = new System.Drawing.Point(24, 49);
            this.carsNumbersListBox.Name = "carsNumbersListBox";
            this.carsNumbersListBox.Size = new System.Drawing.Size(207, 342);
            this.carsNumbersListBox.TabIndex = 17;
            this.carsNumbersListBox.SelectedIndexChanged += new System.EventHandler(this.carsNumbersListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 433);
            this.Controls.Add(this.carsNumbersListBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.carNumberTextBox);
            this.Controls.Add(this.ownersLastNameTextBox);
            this.Controls.Add(this.ownersFirstNameTextBox);
            this.Controls.Add(this.redRadioButton);
            this.Controls.Add(this.blackRadioButton);
            this.Controls.Add(this.whiteRadioButton);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.carNumberLabel);
            this.Controls.Add(this.ownersLastNameLabel);
            this.Controls.Add(this.ownersFirstNameLabel);
            this.Controls.Add(this.carsDataLabel);
            this.Controls.Add(this.carsNumbersLabel);
            this.Controls.Add(this.deleteButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label carsNumbersLabel;
        private System.Windows.Forms.Label carsDataLabel;
        private System.Windows.Forms.Label ownersFirstNameLabel;
        private System.Windows.Forms.Label ownersLastNameLabel;
        private System.Windows.Forms.Label carNumberLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.RadioButton whiteRadioButton;
        private System.Windows.Forms.RadioButton blackRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.TextBox ownersFirstNameTextBox;
        private System.Windows.Forms.TextBox ownersLastNameTextBox;
        private System.Windows.Forms.TextBox carNumberTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox carsNumbersListBox;
    }
}

