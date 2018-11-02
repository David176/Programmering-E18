namespace Kontrolstrukturer
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
      this.textBox_month1 = new System.Windows.Forms.TextBox();
      this.textbox_month2 = new System.Windows.Forms.TextBox();
      this.textBox_month3 = new System.Windows.Forms.TextBox();
      this.textBox_month4 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.textBox_resultat = new System.Windows.Forms.TextBox();
      this.button_biggestNumber = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox_month1
      // 
      this.textBox_month1.Location = new System.Drawing.Point(91, 12);
      this.textBox_month1.Name = "textBox_month1";
      this.textBox_month1.Size = new System.Drawing.Size(147, 20);
      this.textBox_month1.TabIndex = 0;
      // 
      // textbox_month2
      // 
      this.textbox_month2.Location = new System.Drawing.Point(377, 12);
      this.textbox_month2.Name = "textbox_month2";
      this.textbox_month2.Size = new System.Drawing.Size(147, 20);
      this.textbox_month2.TabIndex = 1;
      // 
      // textBox_month3
      // 
      this.textBox_month3.Location = new System.Drawing.Point(91, 48);
      this.textBox_month3.Name = "textBox_month3";
      this.textBox_month3.Size = new System.Drawing.Size(147, 20);
      this.textBox_month3.TabIndex = 2;
      // 
      // textBox_month4
      // 
      this.textBox_month4.Location = new System.Drawing.Point(377, 48);
      this.textBox_month4.Name = "textBox_month4";
      this.textBox_month4.Size = new System.Drawing.Size(147, 20);
      this.textBox_month4.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(50, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "No 1:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(336, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(33, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "No 2:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(50, 48);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(33, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "No 3:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(335, 48);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(33, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "No 4:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(53, 102);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(83, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Biggest number:";
      // 
      // textBox_resultat
      // 
      this.textBox_resultat.Enabled = false;
      this.textBox_resultat.Location = new System.Drawing.Point(143, 102);
      this.textBox_resultat.Name = "textBox_resultat";
      this.textBox_resultat.Size = new System.Drawing.Size(100, 20);
      this.textBox_resultat.TabIndex = 9;
      // 
      // button_biggestNumber
      // 
      this.button_biggestNumber.Location = new System.Drawing.Point(249, 102);
      this.button_biggestNumber.Name = "button_biggestNumber";
      this.button_biggestNumber.Size = new System.Drawing.Size(120, 23);
      this.button_biggestNumber.TabIndex = 10;
      this.button_biggestNumber.Text = "Find biggest number";
      this.button_biggestNumber.UseVisualStyleBackColor = true;
      this.button_biggestNumber.Click += new System.EventHandler(this.button_biggestNumber_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(687, 261);
      this.Controls.Add(this.button_biggestNumber);
      this.Controls.Add(this.textBox_resultat);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox_month4);
      this.Controls.Add(this.textBox_month3);
      this.Controls.Add(this.textbox_month2);
      this.Controls.Add(this.textBox_month1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox_month1;
    private System.Windows.Forms.TextBox textbox_month2;
    private System.Windows.Forms.TextBox textBox_month3;
    private System.Windows.Forms.TextBox textBox_month4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox_resultat;
    private System.Windows.Forms.Button button_biggestNumber;
  }
}

