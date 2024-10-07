namespace TimeLogger
{
    partial class TimeEntryForm
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
            titleLabel = new Label();
            sundayHrsLabel = new Label();
            mondayHrsLabel = new Label();
            tuesdayHrsLabel = new Label();
            wednesdayHrsLabel = new Label();
            thursdayHrsLabel = new Label();
            fridayHrsLabel = new Label();
            saturdayHrsLabel = new Label();
            enterHrLabel = new Label();
            verticalSeparatorPanel = new Panel();
            saturdayHrBox = new TextBox();
            mondayHrBox = new TextBox();
            tuesdayHrBox = new TextBox();
            wednesdayHrBox = new TextBox();
            thursdayHrBox = new TextBox();
            fridayHrBox = new TextBox();
            sundayHrBox = new TextBox();
            selectLabel = new Label();
            resetBtn = new Button();
            searchBtn = new Button();
            submitBtn = new Button();
            searchOutput = new Label();
            dayDropdown = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            titleLabel.Location = new Point(300, 53);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(196, 46);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Time Sheet";
            // 
            // sundayHrsLabel
            // 
            sundayHrsLabel.AutoSize = true;
            sundayHrsLabel.Location = new Point(39, 177);
            sundayHrsLabel.Name = "sundayHrsLabel";
            sundayHrsLabel.Size = new Size(60, 20);
            sundayHrsLabel.TabIndex = 1;
            sundayHrsLabel.Text = "Sunday:";
            // 
            // mondayHrsLabel
            // 
            mondayHrsLabel.AutoSize = true;
            mondayHrsLabel.Location = new Point(39, 210);
            mondayHrsLabel.Name = "mondayHrsLabel";
            mondayHrsLabel.Size = new Size(66, 20);
            mondayHrsLabel.TabIndex = 2;
            mondayHrsLabel.Text = "Monday:";
            // 
            // tuesdayHrsLabel
            // 
            tuesdayHrsLabel.AutoSize = true;
            tuesdayHrsLabel.Location = new Point(39, 243);
            tuesdayHrsLabel.Name = "tuesdayHrsLabel";
            tuesdayHrsLabel.Size = new Size(66, 20);
            tuesdayHrsLabel.TabIndex = 3;
            tuesdayHrsLabel.Text = "Tuesday:";
            // 
            // wednesdayHrsLabel
            // 
            wednesdayHrsLabel.AutoSize = true;
            wednesdayHrsLabel.Location = new Point(39, 276);
            wednesdayHrsLabel.Name = "wednesdayHrsLabel";
            wednesdayHrsLabel.Size = new Size(88, 20);
            wednesdayHrsLabel.TabIndex = 4;
            wednesdayHrsLabel.Text = "Wednesday:";
            // 
            // thursdayHrsLabel
            // 
            thursdayHrsLabel.AutoSize = true;
            thursdayHrsLabel.Location = new Point(39, 310);
            thursdayHrsLabel.Name = "thursdayHrsLabel";
            thursdayHrsLabel.Size = new Size(71, 20);
            thursdayHrsLabel.TabIndex = 5;
            thursdayHrsLabel.Text = "Thursday:";
            // 
            // fridayHrsLabel
            // 
            fridayHrsLabel.AutoSize = true;
            fridayHrsLabel.Location = new Point(39, 343);
            fridayHrsLabel.Name = "fridayHrsLabel";
            fridayHrsLabel.Size = new Size(52, 20);
            fridayHrsLabel.TabIndex = 6;
            fridayHrsLabel.Text = "Friday:";
            // 
            // saturdayHrsLabel
            // 
            saturdayHrsLabel.AutoSize = true;
            saturdayHrsLabel.Location = new Point(39, 376);
            saturdayHrsLabel.Name = "saturdayHrsLabel";
            saturdayHrsLabel.Size = new Size(70, 20);
            saturdayHrsLabel.TabIndex = 7;
            saturdayHrsLabel.Text = "Saturday:";
            // 
            // enterHrLabel
            // 
            enterHrLabel.AutoSize = true;
            enterHrLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            enterHrLabel.Location = new Point(102, 102);
            enterHrLabel.Name = "enterHrLabel";
            enterHrLabel.Size = new Size(167, 25);
            enterHrLabel.TabIndex = 8;
            enterHrLabel.Text = "Enter Hours Here";
            // 
            // verticalSeparatorPanel
            // 
            verticalSeparatorPanel.BackColor = Color.Black;
            verticalSeparatorPanel.Location = new Point(388, 102);
            verticalSeparatorPanel.Name = "verticalSeparatorPanel";
            verticalSeparatorPanel.Size = new Size(4, 270);
            verticalSeparatorPanel.TabIndex = 9;
            // 
            // saturdayHrBox
            // 
            saturdayHrBox.Location = new Point(134, 369);
            saturdayHrBox.Name = "saturdayHrBox";
            saturdayHrBox.Size = new Size(125, 27);
            saturdayHrBox.TabIndex = 10;
            saturdayHrBox.TextChanged += DayBoxs_TextChanged;
            // 
            // mondayHrBox
            // 
            mondayHrBox.Location = new Point(134, 203);
            mondayHrBox.Name = "mondayHrBox";
            mondayHrBox.Size = new Size(125, 27);
            mondayHrBox.TabIndex = 11;
            mondayHrBox.TextChanged += DayBoxs_TextChanged;
            // 
            // tuesdayHrBox
            // 
            tuesdayHrBox.Location = new Point(134, 236);
            tuesdayHrBox.Name = "tuesdayHrBox";
            tuesdayHrBox.Size = new Size(125, 27);
            tuesdayHrBox.TabIndex = 12;
            tuesdayHrBox.TextChanged += DayBoxs_TextChanged;
            // 
            // wednesdayHrBox
            // 
            wednesdayHrBox.Location = new Point(134, 269);
            wednesdayHrBox.Name = "wednesdayHrBox";
            wednesdayHrBox.Size = new Size(125, 27);
            wednesdayHrBox.TabIndex = 13;
            wednesdayHrBox.TextChanged += DayBoxs_TextChanged;
            // 
            // thursdayHrBox
            // 
            thursdayHrBox.Location = new Point(134, 303);
            thursdayHrBox.Name = "thursdayHrBox";
            thursdayHrBox.Size = new Size(125, 27);
            thursdayHrBox.TabIndex = 14;
            thursdayHrBox.TextChanged += DayBoxs_TextChanged;
            // 
            // fridayHrBox
            // 
            fridayHrBox.Location = new Point(134, 336);
            fridayHrBox.Name = "fridayHrBox";
            fridayHrBox.Size = new Size(125, 27);
            fridayHrBox.TabIndex = 15;
            fridayHrBox.TextChanged += DayBoxs_TextChanged;
            // 
            // sundayHrBox
            // 
            sundayHrBox.Location = new Point(134, 170);
            sundayHrBox.Name = "sundayHrBox";
            sundayHrBox.Size = new Size(125, 27);
            sundayHrBox.TabIndex = 16;
            sundayHrBox.TextChanged += DayBoxs_TextChanged;
            // 
            // selectLabel
            // 
            selectLabel.AutoSize = true;
            selectLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            selectLabel.Location = new Point(443, 102);
            selectLabel.Name = "selectLabel";
            selectLabel.Size = new Size(323, 25);
            selectLabel.TabIndex = 17;
            selectLabel.Text = "Select Day To See Hours Submitted";
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.Black;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            resetBtn.ForeColor = Color.White;
            resetBtn.Location = new Point(340, 376);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(94, 40);
            resetBtn.TabIndex = 18;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.FlatStyle = FlatStyle.Flat;
            searchBtn.Location = new Point(666, 178);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(73, 28);
            searchBtn.TabIndex = 20;
            searchBtn.Text = "Search";
            searchBtn.Click += searchBtn_Click;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Black;
            submitBtn.FlatStyle = FlatStyle.Flat;
            submitBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            submitBtn.ForeColor = Color.White;
            submitBtn.Location = new Point(150, 409);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(94, 40);
            submitBtn.TabIndex = 21;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // searchOutput
            // 
            searchOutput.AutoSize = true;
            searchOutput.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            searchOutput.ForeColor = SystemColors.HotTrack;
            searchOutput.Location = new Point(600, 236);
            searchOutput.Name = "searchOutput";
            searchOutput.Size = new Size(0, 25);
            searchOutput.TabIndex = 22;
            // 
            // dayDropdown
            // 
            dayDropdown.DataSource = Enum.GetValues(typeof(Day));
            dayDropdown.FormattingEnabled = true;
            dayDropdown.Location = new Point(518, 178);
            dayDropdown.Name = "dayDropdown";
            dayDropdown.Size = new Size(151, 28);
            dayDropdown.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 137);
            label1.Name = "label1";
            label1.Size = new Size(189, 17);
            label1.TabIndex = 24;
            label1.Text = "*Only Accepts Numbers As Input";
            // 
            // TimeEntryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dayDropdown);
            Controls.Add(searchOutput);
            Controls.Add(submitBtn);
            Controls.Add(searchBtn);
            Controls.Add(resetBtn);
            Controls.Add(selectLabel);
            Controls.Add(sundayHrBox);
            Controls.Add(fridayHrBox);
            Controls.Add(thursdayHrBox);
            Controls.Add(wednesdayHrBox);
            Controls.Add(tuesdayHrBox);
            Controls.Add(mondayHrBox);
            Controls.Add(saturdayHrBox);
            Controls.Add(enterHrLabel);
            Controls.Add(saturdayHrsLabel);
            Controls.Add(fridayHrsLabel);
            Controls.Add(thursdayHrsLabel);
            Controls.Add(wednesdayHrsLabel);
            Controls.Add(tuesdayHrsLabel);
            Controls.Add(mondayHrsLabel);
            Controls.Add(sundayHrsLabel);
            Controls.Add(titleLabel);
            Controls.Add(verticalSeparatorPanel);
            Name = "TimeEntryForm";
            Text = "TimeEntryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label sundayHrsLabel;
        private Label mondayHrsLabel;
        private Label tuesdayHrsLabel;
        private Label wednesdayHrsLabel;
        private Label thursdayHrsLabel;
        private Label fridayHrsLabel;
        private Label saturdayHrsLabel;
        private Label enterHrLabel;
        private Panel verticalSeparatorPanel;
        private TextBox saturdayHrBox;
        private TextBox mondayHrBox;
        private TextBox tuesdayHrBox;
        private TextBox wednesdayHrBox;
        private TextBox thursdayHrBox;
        private TextBox fridayHrBox;
        private TextBox sundayHrBox;
        private Label selectLabel;
        private Button resetBtn;
        private Button searchBtn;
        private Button submitBtn;
        private Label searchOutput;
        private ComboBox dayDropdown;
        private Label label1;
    }
}
