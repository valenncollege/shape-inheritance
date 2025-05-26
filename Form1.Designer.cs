namespace ShapeInheritance
{
    partial class Form1
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.radioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxShape = new System.Windows.Forms.GroupBox();
            this.numericUpDownTop = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLeft = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDisplayAll = new System.Windows.Forms.Button();
            this.numericUpDownDiameter = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.groupBoxRectangle = new System.Windows.Forms.GroupBox();
            this.groupBoxCircle = new System.Windows.Forms.GroupBox();
            this.groupBoxShape.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.groupBoxRectangle.SuspendLayout();
            this.groupBoxCircle.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(130, 235);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(314, 235);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 16;
            this.buttonRemove.Text = "REMOVE";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // radioButtonRectangle
            // 
            this.radioButtonRectangle.AutoSize = true;
            this.radioButtonRectangle.Location = new System.Drawing.Point(226, 112);
            this.radioButtonRectangle.Name = "radioButtonRectangle";
            this.radioButtonRectangle.Size = new System.Drawing.Size(74, 17);
            this.radioButtonRectangle.TabIndex = 12;
            this.radioButtonRectangle.Text = "Rectangle";
            this.radioButtonRectangle.UseVisualStyleBackColor = true;
            this.radioButtonRectangle.CheckedChanged += new System.EventHandler(this.radioButtonRectangle_CheckedChanged);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.Location = new System.Drawing.Point(41, 275);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.Size = new System.Drawing.Size(348, 147);
            this.listBoxInfo.TabIndex = 17;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(41, 235);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxShape
            // 
            this.groupBoxShape.Controls.Add(this.numericUpDownTop);
            this.groupBoxShape.Controls.Add(this.numericUpDownLeft);
            this.groupBoxShape.Controls.Add(this.label7);
            this.groupBoxShape.Controls.Add(this.label3);
            this.groupBoxShape.Location = new System.Drawing.Point(41, 12);
            this.groupBoxShape.Name = "groupBoxShape";
            this.groupBoxShape.Size = new System.Drawing.Size(354, 82);
            this.groupBoxShape.TabIndex = 8;
            this.groupBoxShape.TabStop = false;
            this.groupBoxShape.Text = "Shape:";
            // 
            // numericUpDownTop
            // 
            this.numericUpDownTop.Location = new System.Drawing.Point(55, 52);
            this.numericUpDownTop.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTop.Name = "numericUpDownTop";
            this.numericUpDownTop.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownTop.TabIndex = 1;
            // 
            // numericUpDownLeft
            // 
            this.numericUpDownLeft.Location = new System.Drawing.Point(55, 19);
            this.numericUpDownLeft.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownLeft.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Top:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Left:";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(314, 428);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDisplayAll
            // 
            this.buttonDisplayAll.Location = new System.Drawing.Point(214, 235);
            this.buttonDisplayAll.Name = "buttonDisplayAll";
            this.buttonDisplayAll.Size = new System.Drawing.Size(89, 23);
            this.buttonDisplayAll.TabIndex = 15;
            this.buttonDisplayAll.Text = "DISPLAY ALL";
            this.buttonDisplayAll.UseVisualStyleBackColor = true;
            this.buttonDisplayAll.Click += new System.EventHandler(this.buttonDisplayAll_Click);
            // 
            // numericUpDownDiameter
            // 
            this.numericUpDownDiameter.Location = new System.Drawing.Point(67, 27);
            this.numericUpDownDiameter.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDiameter.Name = "numericUpDownDiameter";
            this.numericUpDownDiameter.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownDiameter.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Diameter:";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(51, 56);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownHeight.TabIndex = 1;
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(51, 24);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(82, 20);
            this.numericUpDownWidth.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height:";
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.AutoSize = true;
            this.radioButtonCircle.Checked = true;
            this.radioButtonCircle.Location = new System.Drawing.Point(47, 112);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(51, 17);
            this.radioButtonCircle.TabIndex = 10;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = "Circle";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            this.radioButtonCircle.CheckedChanged += new System.EventHandler(this.radioButtonCircle_CheckedChanged);
            // 
            // groupBoxRectangle
            // 
            this.groupBoxRectangle.Controls.Add(this.numericUpDownHeight);
            this.groupBoxRectangle.Controls.Add(this.numericUpDownWidth);
            this.groupBoxRectangle.Controls.Add(this.label4);
            this.groupBoxRectangle.Controls.Add(this.label2);
            this.groupBoxRectangle.Location = new System.Drawing.Point(217, 135);
            this.groupBoxRectangle.Name = "groupBoxRectangle";
            this.groupBoxRectangle.Size = new System.Drawing.Size(178, 93);
            this.groupBoxRectangle.TabIndex = 11;
            this.groupBoxRectangle.TabStop = false;
            this.groupBoxRectangle.Text = "Rectangle Data";
            // 
            // groupBoxCircle
            // 
            this.groupBoxCircle.Controls.Add(this.numericUpDownDiameter);
            this.groupBoxCircle.Controls.Add(this.label6);
            this.groupBoxCircle.Location = new System.Drawing.Point(41, 135);
            this.groupBoxCircle.Name = "groupBoxCircle";
            this.groupBoxCircle.Size = new System.Drawing.Size(170, 93);
            this.groupBoxCircle.TabIndex = 9;
            this.groupBoxCircle.TabStop = false;
            this.groupBoxCircle.Text = "Circle Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 489);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.radioButtonRectangle);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxShape);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDisplayAll);
            this.Controls.Add(this.radioButtonCircle);
            this.Controls.Add(this.groupBoxRectangle);
            this.Controls.Add(this.groupBoxCircle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxShape.ResumeLayout(false);
            this.groupBoxShape.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.groupBoxRectangle.ResumeLayout(false);
            this.groupBoxRectangle.PerformLayout();
            this.groupBoxCircle.ResumeLayout(false);
            this.groupBoxCircle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.RadioButton radioButtonRectangle;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxShape;
        private System.Windows.Forms.NumericUpDown numericUpDownTop;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDisplayAll;
        private System.Windows.Forms.NumericUpDown numericUpDownDiameter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.GroupBox groupBoxRectangle;
        private System.Windows.Forms.GroupBox groupBoxCircle;
    }
}

