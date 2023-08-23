namespace last
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            rtbValidation = new RichTextBox();
            btnHasPunctuation = new Button();
            btnNumeric = new Button();
            btnAlphabetic = new Button();
            btnMinLength = new Button();
            btnRequired = new Button();
            groupBox2 = new GroupBox();
            rtbManipulation = new RichTextBox();
            btnSplit = new Button();
            btnLeaveAlphanumeric = new Button();
            groupBox3 = new GroupBox();
            txtValue = new TextBox();
            txtSuit = new TextBox();
            label3 = new Label();
            label2 = new Label();
            rtbPayingCards = new RichTextBox();
            btnValidatePlayingCard = new Button();
            btnWriteToFile = new Button();
            label1 = new Label();
            txtInputText = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbValidation);
            groupBox1.Controls.Add(btnHasPunctuation);
            groupBox1.Controls.Add(btnNumeric);
            groupBox1.Controls.Add(btnAlphabetic);
            groupBox1.Controls.Add(btnMinLength);
            groupBox1.Controls.Add(btnRequired);
            groupBox1.Location = new Point(12, 235);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 584);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Validation";
            // 
            // rtbValidation
            // 
            rtbValidation.Location = new Point(6, 235);
            rtbValidation.Name = "rtbValidation";
            rtbValidation.Size = new Size(452, 292);
            rtbValidation.TabIndex = 5;
            rtbValidation.Text = "";
            // 
            // btnHasPunctuation
            // 
            btnHasPunctuation.Location = new Point(16, 173);
            btnHasPunctuation.Name = "btnHasPunctuation";
            btnHasPunctuation.Size = new Size(161, 37);
            btnHasPunctuation.TabIndex = 4;
            btnHasPunctuation.Text = "Has Punctuation";
            btnHasPunctuation.UseVisualStyleBackColor = true;
            // 
            // btnNumeric
            // 
            btnNumeric.Location = new Point(246, 106);
            btnNumeric.Name = "btnNumeric";
            btnNumeric.Size = new Size(161, 37);
            btnNumeric.TabIndex = 3;
            btnNumeric.Text = "Numeric Only";
            btnNumeric.UseVisualStyleBackColor = true;
            // 
            // btnAlphabetic
            // 
            btnAlphabetic.Location = new Point(16, 106);
            btnAlphabetic.Name = "btnAlphabetic";
            btnAlphabetic.Size = new Size(161, 37);
            btnAlphabetic.TabIndex = 2;
            btnAlphabetic.Text = "Alphabetic Only";
            btnAlphabetic.UseVisualStyleBackColor = true;
            // 
            // btnMinLength
            // 
            btnMinLength.Location = new Point(246, 42);
            btnMinLength.Name = "btnMinLength";
            btnMinLength.Size = new Size(161, 37);
            btnMinLength.TabIndex = 1;
            btnMinLength.Text = "Minimum Length";
            btnMinLength.UseVisualStyleBackColor = true;
            // 
            // btnRequired
            // 
            btnRequired.Location = new Point(16, 42);
            btnRequired.Name = "btnRequired";
            btnRequired.Size = new Size(161, 37);
            btnRequired.TabIndex = 0;
            btnRequired.Text = "Required";
            btnRequired.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtbManipulation);
            groupBox2.Controls.Add(btnSplit);
            groupBox2.Controls.Add(btnLeaveAlphanumeric);
            groupBox2.Location = new Point(571, 244);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(480, 575);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manipulation";
            // 
            // rtbManipulation
            // 
            rtbManipulation.Location = new Point(26, 214);
            rtbManipulation.Name = "rtbManipulation";
            rtbManipulation.Size = new Size(435, 289);
            rtbManipulation.TabIndex = 7;
            rtbManipulation.Text = "";
            // 
            // btnSplit
            // 
            btnSplit.Location = new Point(26, 47);
            btnSplit.Name = "btnSplit";
            btnSplit.Size = new Size(435, 37);
            btnSplit.TabIndex = 5;
            btnSplit.Text = "Split On whiteSpace";
            btnSplit.UseVisualStyleBackColor = true;
            btnSplit.Click += btnSplit_Click;
            // 
            // btnLeaveAlphanumeric
            // 
            btnLeaveAlphanumeric.Location = new Point(26, 97);
            btnLeaveAlphanumeric.Name = "btnLeaveAlphanumeric";
            btnLeaveAlphanumeric.Size = new Size(435, 37);
            btnLeaveAlphanumeric.TabIndex = 6;
            btnLeaveAlphanumeric.Text = "Leave AlphaNumeric";
            btnLeaveAlphanumeric.UseVisualStyleBackColor = true;
            btnLeaveAlphanumeric.Click += btnLeaveAlphanumeric_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtValue);
            groupBox3.Controls.Add(txtSuit);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(rtbPayingCards);
            groupBox3.Controls.Add(btnValidatePlayingCard);
            groupBox3.Controls.Add(btnWriteToFile);
            groupBox3.Location = new Point(1163, 244);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(635, 575);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "playing Card";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(95, 120);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(508, 31);
            txtValue.TabIndex = 13;
            // 
            // txtSuit
            // 
            txtSuit.Location = new Point(95, 46);
            txtSuit.Name = "txtSuit";
            txtSuit.Size = new Size(508, 31);
            txtSuit.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 120);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 11;
            label3.Text = "Value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 47);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 10;
            label2.Text = "Suit";
            // 
            // rtbPayingCards
            // 
            rtbPayingCards.Location = new Point(50, 243);
            rtbPayingCards.Name = "rtbPayingCards";
            rtbPayingCards.Size = new Size(553, 260);
            rtbPayingCards.TabIndex = 9;
            rtbPayingCards.Text = "";
            // 
            // btnValidatePlayingCard
            // 
            btnValidatePlayingCard.Location = new Point(50, 176);
            btnValidatePlayingCard.Name = "btnValidatePlayingCard";
            btnValidatePlayingCard.Size = new Size(198, 37);
            btnValidatePlayingCard.TabIndex = 7;
            btnValidatePlayingCard.Text = "Validate Playing Card";
            btnValidatePlayingCard.UseVisualStyleBackColor = true;
            btnValidatePlayingCard.Click += btnValidatePlayingCard_Click;
            // 
            // btnWriteToFile
            // 
            btnWriteToFile.Location = new Point(442, 176);
            btnWriteToFile.Name = "btnWriteToFile";
            btnWriteToFile.Size = new Size(161, 37);
            btnWriteToFile.TabIndex = 8;
            btnWriteToFile.Text = "Write to file";
            btnWriteToFile.UseVisualStyleBackColor = true;
            btnWriteToFile.Click += btnWriteToFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 62);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 3;
            label1.Text = "Input Text";
            // 
            // txtInputText
            // 
            txtInputText.Location = new Point(190, 61);
            txtInputText.Name = "txtInputText";
            txtInputText.Size = new Size(794, 31);
            txtInputText.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1852, 842);
            Controls.Add(txtInputText);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox txtInputText;
        private RichTextBox rtbValidation;
        private Button btnHasPunctuation;
        private Button btnNumeric;
        private Button btnAlphabetic;
        private Button btnMinLength;
        private Button btnRequired;
        private RichTextBox rtbManipulation;
        private Button btnSplit;
        private Button btnLeaveAlphanumeric;
        private TextBox txtValue;
        private TextBox txtSuit;
        private Label label3;
        private Label label2;
        private RichTextBox rtbPayingCards;
        private Button btnValidatePlayingCard;
        private Button btnWriteToFile;
    }
}