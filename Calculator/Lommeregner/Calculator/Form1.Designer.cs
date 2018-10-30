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
      this.textBox_tal_1 = new System.Windows.Forms.TextBox();
      this.textBox_tal_2 = new System.Windows.Forms.TextBox();
      this.textBox_result = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.button_plus = new System.Windows.Forms.Button();
      this.button_minus = new System.Windows.Forms.Button();
      this.button_multiply = new System.Windows.Forms.Button();
      this.button_divide = new System.Windows.Forms.Button();
      this.Result = new System.Windows.Forms.Label();
      this.button_clear = new System.Windows.Forms.Button();
      this.button_percentage = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox_tal_1
      // 
      this.textBox_tal_1.Location = new System.Drawing.Point(86, 41);
      this.textBox_tal_1.Name = "textBox_tal_1";
      this.textBox_tal_1.Size = new System.Drawing.Size(100, 20);
      this.textBox_tal_1.TabIndex = 0;
      // 
      // textBox_tal_2
      // 
      this.textBox_tal_2.Location = new System.Drawing.Point(86, 90);
      this.textBox_tal_2.Name = "textBox_tal_2";
      this.textBox_tal_2.Size = new System.Drawing.Size(100, 20);
      this.textBox_tal_2.TabIndex = 1;
      // 
      // textBox_result
      // 
      this.textBox_result.Enabled = false;
      this.textBox_result.Location = new System.Drawing.Point(86, 229);
      this.textBox_result.Name = "textBox_result";
      this.textBox_result.Size = new System.Drawing.Size(100, 20);
      this.textBox_result.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(41, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "1st no:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(37, 90);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(43, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "2nd no:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(71, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(103, 24);
      this.label3.TabIndex = 5;
      this.label3.Text = "Calculator";
      // 
      // button_plus
      // 
      this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button_plus.Location = new System.Drawing.Point(86, 126);
      this.button_plus.Name = "button_plus";
      this.button_plus.Size = new System.Drawing.Size(48, 44);
      this.button_plus.TabIndex = 6;
      this.button_plus.Text = "+";
      this.button_plus.UseVisualStyleBackColor = true;
      this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
      // 
      // button_minus
      // 
      this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button_minus.Location = new System.Drawing.Point(140, 126);
      this.button_minus.Name = "button_minus";
      this.button_minus.Size = new System.Drawing.Size(48, 44);
      this.button_minus.TabIndex = 7;
      this.button_minus.Text = "-";
      this.button_minus.UseVisualStyleBackColor = true;
      this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
      // 
      // button_multiply
      // 
      this.button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button_multiply.Location = new System.Drawing.Point(86, 176);
      this.button_multiply.Name = "button_multiply";
      this.button_multiply.Size = new System.Drawing.Size(48, 44);
      this.button_multiply.TabIndex = 8;
      this.button_multiply.Text = "x";
      this.button_multiply.UseVisualStyleBackColor = true;
      this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
      // 
      // button_divide
      // 
      this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button_divide.Location = new System.Drawing.Point(140, 176);
      this.button_divide.Name = "button_divide";
      this.button_divide.Size = new System.Drawing.Size(48, 44);
      this.button_divide.TabIndex = 9;
      this.button_divide.Text = "÷";
      this.button_divide.UseVisualStyleBackColor = true;
      this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
      // 
      // Result
      // 
      this.Result.AutoSize = true;
      this.Result.Location = new System.Drawing.Point(45, 229);
      this.Result.Name = "Result";
      this.Result.Size = new System.Drawing.Size(40, 13);
      this.Result.TabIndex = 10;
      this.Result.Text = "Result:";
      // 
      // button_clear
      // 
      this.button_clear.Location = new System.Drawing.Point(193, 90);
      this.button_clear.Name = "button_clear";
      this.button_clear.Size = new System.Drawing.Size(75, 23);
      this.button_clear.TabIndex = 11;
      this.button_clear.Text = "Clear both";
      this.button_clear.UseVisualStyleBackColor = true;
      this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
      // 
      // button_percentage
      // 
      this.button_percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button_percentage.Location = new System.Drawing.Point(194, 126);
      this.button_percentage.Name = "button_percentage";
      this.button_percentage.Size = new System.Drawing.Size(48, 44);
      this.button_percentage.TabIndex = 12;
      this.button_percentage.Text = "%";
      this.button_percentage.UseVisualStyleBackColor = true;
      this.button_percentage.Click += new System.EventHandler(this.button_percentage_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.button_percentage);
      this.Controls.Add(this.button_clear);
      this.Controls.Add(this.Result);
      this.Controls.Add(this.button_divide);
      this.Controls.Add(this.button_multiply);
      this.Controls.Add(this.button_minus);
      this.Controls.Add(this.button_plus);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox_result);
      this.Controls.Add(this.textBox_tal_2);
      this.Controls.Add(this.textBox_tal_1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox_tal_1;
    private System.Windows.Forms.TextBox textBox_tal_2;
    private System.Windows.Forms.TextBox textBox_result;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button_plus;
    private System.Windows.Forms.Button button_minus;
    private System.Windows.Forms.Button button_multiply;
    private System.Windows.Forms.Button button_divide;
    private System.Windows.Forms.Label Result;
    private System.Windows.Forms.Button button_clear;
    private System.Windows.Forms.Button button_percentage;
  }
}

