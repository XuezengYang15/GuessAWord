namespace GuessAWord
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
            this.submitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.wordLabel = new System.Windows.Forms.Label();
            this.hiddenWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.debugger = new System.Windows.Forms.TextBox();
            this.ratioOfGuesses = new System.Windows.Forms.Label();
            this.outputMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(304, 239);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 29);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(304, 286);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 29);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Location = new System.Drawing.Point(238, 142);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(48, 20);
            this.wordLabel.TabIndex = 2;
            this.wordLabel.Text = "Word:";
            // 
            // hiddenWord
            // 
            this.hiddenWord.AutoSize = true;
            this.hiddenWord.Location = new System.Drawing.Point(304, 142);
            this.hiddenWord.Name = "hiddenWord";
            this.hiddenWord.Size = new System.Drawing.Size(135, 20);
            this.hiddenWord.TabIndex = 3;
            this.hiddenWord.Text = "_____________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Guess a letter >>";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(347, 187);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(125, 27);
            this.textBox.TabIndex = 5;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // debugger
            // 
            this.debugger.Location = new System.Drawing.Point(568, 131);
            this.debugger.Name = "debugger";
            this.debugger.Size = new System.Drawing.Size(182, 27);
            this.debugger.TabIndex = 6;
            // 
            // ratioOfGuesses
            // 
            this.ratioOfGuesses.AutoSize = true;
            this.ratioOfGuesses.ForeColor = System.Drawing.Color.Red;
            this.ratioOfGuesses.Location = new System.Drawing.Point(543, 295);
            this.ratioOfGuesses.Name = "ratioOfGuesses";
            this.ratioOfGuesses.Size = new System.Drawing.Size(207, 20);
            this.ratioOfGuesses.TabIndex = 7;
            this.ratioOfGuesses.Text = "correct guesses : total guesses";
            // 
            // outputMessage
            // 
            this.outputMessage.AutoSize = true;
            this.outputMessage.Location = new System.Drawing.Point(281, 361);
            this.outputMessage.Name = "outputMessage";
            this.outputMessage.Size = new System.Drawing.Size(0, 20);
            this.outputMessage.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Click to see hidden word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputMessage);
            this.Controls.Add(this.ratioOfGuesses);
            this.Controls.Add(this.debugger);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hiddenWord);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "correct guesses : total guesses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button submitButton;
        private Button startButton;
        private Label wordLabel;
        private Label hiddenWord;
        private Label label1;
        private TextBox textBox;
        private TextBox debugger;
        private Label ratioOfGuesses;
        private Label outputMessage;
        private Button button1;
    }
}