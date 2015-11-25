﻿namespace OptimisationCat
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.answerTextBox = new MaterialSkin.Controls.MaterialLabel();
            this.iterationTextBox = new MaterialSkin.Controls.MaterialLabel();
            this.startingPointTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.precisionTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.functionComboBox = new System.Windows.Forms.ComboBox();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.showGraphButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.alphaMethodComboBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.testAllButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 92);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(506, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Enter a function in the box below or choose it from the list*";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 308);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(123, 24);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Starting point";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(282, 308);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(89, 24);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Precision";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 163);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(398, 24);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Choose the desired OPTIMISATION METHOD*";
            // 
            // answerTextBox
            // 
            this.answerTextBox.Depth = 0;
            this.answerTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerTextBox.Font = new System.Drawing.Font("Roboto", 11F);
            this.answerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.answerTextBox.Location = new System.Drawing.Point(552, 92);
            this.answerTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(99, 206);
            this.answerTextBox.TabIndex = 0;
            this.answerTextBox.Text = "Answer:";
            // 
            // iterationTextBox
            // 
            this.iterationTextBox.Depth = 0;
            this.iterationTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iterationTextBox.Font = new System.Drawing.Font("Roboto", 11F);
            this.iterationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iterationTextBox.Location = new System.Drawing.Point(552, 308);
            this.iterationTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.iterationTextBox.Name = "iterationTextBox";
            this.iterationTextBox.Size = new System.Drawing.Size(99, 28);
            this.iterationTextBox.TabIndex = 0;
            this.iterationTextBox.Text = "Iterations:";
            // 
            // startingPointTextBox
            // 
            this.startingPointTextBox.Depth = 0;
            this.startingPointTextBox.Hint = "";
            this.startingPointTextBox.Location = new System.Drawing.Point(141, 308);
            this.startingPointTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.startingPointTextBox.Name = "startingPointTextBox";
            this.startingPointTextBox.PasswordChar = '\0';
            this.startingPointTextBox.SelectedText = "";
            this.startingPointTextBox.SelectionLength = 0;
            this.startingPointTextBox.SelectionStart = 0;
            this.startingPointTextBox.Size = new System.Drawing.Size(120, 28);
            this.startingPointTextBox.TabIndex = 3;
            this.startingPointTextBox.Text = "0";
            this.startingPointTextBox.UseSystemPasswordChar = false;
            // 
            // precisionTextBox
            // 
            this.precisionTextBox.Depth = 0;
            this.precisionTextBox.Hint = "";
            this.precisionTextBox.Location = new System.Drawing.Point(377, 308);
            this.precisionTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.precisionTextBox.Name = "precisionTextBox";
            this.precisionTextBox.PasswordChar = '\0';
            this.precisionTextBox.SelectedText = "";
            this.precisionTextBox.SelectionLength = 0;
            this.precisionTextBox.SelectionStart = 0;
            this.precisionTextBox.Size = new System.Drawing.Size(122, 28);
            this.precisionTextBox.TabIndex = 4;
            this.precisionTextBox.Text = "1e-5";
            this.precisionTextBox.UseSystemPasswordChar = false;
            // 
            // functionComboBox
            // 
            this.functionComboBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.functionComboBox.FormattingEnabled = true;
            this.functionComboBox.Location = new System.Drawing.Point(16, 119);
            this.functionComboBox.Name = "functionComboBox";
            this.functionComboBox.Size = new System.Drawing.Size(502, 31);
            this.functionComboBox.TabIndex = 1;
            this.functionComboBox.Text = "Enter a function here...";
            this.functionComboBox.SelectedIndexChanged += new System.EventHandler(this.functionComboBox_SelectedIndexChanged);
            this.functionComboBox.TextChanged += new System.EventHandler(this.functionComboBox_TextChanged);
            // 
            // methodComboBox
            // 
            this.methodComboBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Location = new System.Drawing.Point(16, 190);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(502, 31);
            this.methodComboBox.TabIndex = 2;
            this.methodComboBox.Text = "Choose method...";
            this.methodComboBox.SelectedIndexChanged += new System.EventHandler(this.methodComboBox_SelectedIndexChanged);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(543, 64);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1, 290);
            this.materialDivider1.TabIndex = 10;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(9, 365);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(119, 30);
            this.materialCheckBox1.TabIndex = 12;
            this.materialCheckBox1.Text = "Dark theme";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // showGraphButton
            // 
            this.showGraphButton.AutoSize = true;
            this.showGraphButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showGraphButton.Depth = 0;
            this.showGraphButton.Enabled = false;
            this.showGraphButton.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showGraphButton.Location = new System.Drawing.Point(439, 359);
            this.showGraphButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.showGraphButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.showGraphButton.Name = "showGraphButton";
            this.showGraphButton.Primary = false;
            this.showGraphButton.Size = new System.Drawing.Size(124, 36);
            this.showGraphButton.TabIndex = 16;
            this.showGraphButton.Text = "SHOW GRAPH";
            this.showGraphButton.UseVisualStyleBackColor = true;
            this.showGraphButton.Click += new System.EventHandler(this.showGraphButton_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 233);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(321, 24);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "Choose the desired ALPHA-METHOD";
            // 
            // alphaMethodComboBox
            // 
            this.alphaMethodComboBox.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alphaMethodComboBox.FormattingEnabled = true;
            this.alphaMethodComboBox.Location = new System.Drawing.Point(16, 260);
            this.alphaMethodComboBox.Name = "alphaMethodComboBox";
            this.alphaMethodComboBox.Size = new System.Drawing.Size(502, 31);
            this.alphaMethodComboBox.TabIndex = 2;
            this.alphaMethodComboBox.Text = "Choose alpha method...";
            this.alphaMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.alphaMethodComboBox_SelectedIndexChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.calculateButton.Depth = 0;
            this.calculateButton.Enabled = false;
            this.calculateButton.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(543, 359);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.calculateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Primary = false;
            this.calculateButton.Size = new System.Drawing.Size(108, 36);
            this.calculateButton.TabIndex = 17;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-3, 353);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(826, 1);
            this.materialDivider2.TabIndex = 18;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // testAllButton
            // 
            this.testAllButton.AutoSize = true;
            this.testAllButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.testAllButton.Depth = 0;
            this.testAllButton.Enabled = false;
            this.testAllButton.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.testAllButton.Location = new System.Drawing.Point(366, 359);
            this.testAllButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.testAllButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.testAllButton.Name = "testAllButton";
            this.testAllButton.Primary = false;
            this.testAllButton.Size = new System.Drawing.Size(88, 36);
            this.testAllButton.TabIndex = 16;
            this.testAllButton.Text = "TEST ALL";
            this.testAllButton.UseVisualStyleBackColor = true;
            this.testAllButton.Click += new System.EventHandler(this.testAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(664, 403);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.testAllButton);
            this.Controls.Add(this.showGraphButton);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.alphaMethodComboBox);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.functionComboBox);
            this.Controls.Add(this.precisionTextBox);
            this.Controls.Add(this.startingPointTextBox);
            this.Controls.Add(this.iterationTextBox);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Font = new System.Drawing.Font("Roboto", 12F);
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optimisation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel answerTextBox;
        private MaterialSkin.Controls.MaterialLabel iterationTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField startingPointTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField precisionTextBox;
        private System.Windows.Forms.ComboBox functionComboBox;
        private System.Windows.Forms.ComboBox methodComboBox;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBox1;
        private MaterialSkin.Controls.MaterialFlatButton showGraphButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ComboBox alphaMethodComboBox;
        private MaterialSkin.Controls.MaterialFlatButton calculateButton;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialFlatButton testAllButton;
    }
}
