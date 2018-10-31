namespace Calculator
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
      this.textBox_number1 = new System.Windows.Forms.TextBox();
      this.textBox2_number2 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button_add = new System.Windows.Forms.Button();
      this.button_percentage = new System.Windows.Forms.Button();
      this.button_multiply = new System.Windows.Forms.Button();
      this.button_divide = new System.Windows.Forms.Button();
      this.button_minus = new System.Windows.Forms.Button();
      this.button_clear = new System.Windows.Forms.Button();
      this.textBox_result = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // textBox_number1
      // 
      this.textBox_number1.Location = new System.Drawing.Point(110, 81);
      this.textBox_number1.Name = "textBox_number1";
      this.textBox_number1.Size = new System.Drawing.Size(100, 20);
      this.textBox_number1.TabIndex = 0;
      // 
      // textBox2_number2
      // 
      this.textBox2_number2.Location = new System.Drawing.Point(110, 120);
      this.textBox2_number2.Name = "textBox2_number2";
      this.textBox2_number2.Size = new System.Drawing.Size(100, 20);
      this.textBox2_number2.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(48, 84);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Number 1:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(48, 120);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(56, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Number 2:";
      // 
      // button_add
      // 
      this.button_add.Location = new System.Drawing.Point(72, 161);
      this.button_add.Name = "button_add";
      this.button_add.Size = new System.Drawing.Size(35, 23);
      this.button_add.TabIndex = 4;
      this.button_add.Text = "+";
      this.button_add.UseVisualStyleBackColor = true;
      this.button_add.Click += new System.EventHandler(this.button_add_Click);
      // 
      // button_percentage
      // 
      this.button_percentage.Location = new System.Drawing.Point(154, 161);
      this.button_percentage.Name = "button_percentage";
      this.button_percentage.Size = new System.Drawing.Size(35, 23);
      this.button_percentage.TabIndex = 5;
      this.button_percentage.Text = "%";
      this.button_percentage.UseVisualStyleBackColor = true;
      this.button_percentage.Click += new System.EventHandler(this.button_percentage_Click);
      // 
      // button_multiply
      // 
      this.button_multiply.Location = new System.Drawing.Point(116, 190);
      this.button_multiply.Name = "button_multiply";
      this.button_multiply.Size = new System.Drawing.Size(35, 23);
      this.button_multiply.TabIndex = 6;
      this.button_multiply.Text = "*";
      this.button_multiply.UseVisualStyleBackColor = true;
      this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
      // 
      // button_divide
      // 
      this.button_divide.Location = new System.Drawing.Point(113, 161);
      this.button_divide.Name = "button_divide";
      this.button_divide.Size = new System.Drawing.Size(35, 23);
      this.button_divide.TabIndex = 7;
      this.button_divide.Text = "/";
      this.button_divide.UseVisualStyleBackColor = true;
      this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
      // 
      // button_minus
      // 
      this.button_minus.Location = new System.Drawing.Point(75, 190);
      this.button_minus.Name = "button_minus";
      this.button_minus.Size = new System.Drawing.Size(35, 23);
      this.button_minus.TabIndex = 8;
      this.button_minus.Text = "-";
      this.button_minus.UseVisualStyleBackColor = true;
      this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
      // 
      // button_clear
      // 
      this.button_clear.Location = new System.Drawing.Point(216, 81);
      this.button_clear.Name = "button_clear";
      this.button_clear.Size = new System.Drawing.Size(44, 23);
      this.button_clear.TabIndex = 9;
      this.button_clear.Text = "Clear";
      this.button_clear.UseVisualStyleBackColor = true;
      this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
      // 
      // textBox_result
      // 
      this.textBox_result.Location = new System.Drawing.Point(101, 219);
      this.textBox_result.Name = "textBox_result";
      this.textBox_result.Size = new System.Drawing.Size(100, 20);
      this.textBox_result.TabIndex = 10;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.textBox_result);
      this.Controls.Add(this.button_clear);
      this.Controls.Add(this.button_minus);
      this.Controls.Add(this.button_divide);
      this.Controls.Add(this.button_multiply);
      this.Controls.Add(this.button_percentage);
      this.Controls.Add(this.button_add);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox2_number2);
      this.Controls.Add(this.textBox_number1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox_number1;
    private System.Windows.Forms.TextBox textBox2_number2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button_add;
    private System.Windows.Forms.Button button_percentage;
    private System.Windows.Forms.Button button_multiply;
    private System.Windows.Forms.Button button_divide;
    private System.Windows.Forms.Button button_minus;
    private System.Windows.Forms.Button button_clear;
    private System.Windows.Forms.TextBox textBox_result;
  }
}

