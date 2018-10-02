namespace BMI
{
  partial class bmi_beregner
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
      this.hoejde = new System.Windows.Forms.TextBox();
      this.vaegt = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.udregn = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.bmi_label = new System.Windows.Forms.Label();
      this.bmi_result = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // hoejde
      // 
      this.hoejde.Location = new System.Drawing.Point(100, 89);
      this.hoejde.Name = "hoejde";
      this.hoejde.Size = new System.Drawing.Size(100, 20);
      this.hoejde.TabIndex = 0;
      // 
      // vaegt
      // 
      this.vaegt.Location = new System.Drawing.Point(100, 124);
      this.vaegt.Name = "vaegt";
      this.vaegt.Size = new System.Drawing.Size(100, 20);
      this.vaegt.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(59, 92);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Højde:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(59, 124);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(36, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Vægt:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(207, 95);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(21, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "cm";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(207, 130);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(19, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "kg";
      // 
      // udregn
      // 
      this.udregn.Location = new System.Drawing.Point(100, 151);
      this.udregn.Name = "udregn";
      this.udregn.Size = new System.Drawing.Size(100, 23);
      this.udregn.TabIndex = 6;
      this.udregn.Text = "Udregn din BMI";
      this.udregn.UseVisualStyleBackColor = true;
      this.udregn.Click += new System.EventHandler(this.udregn_Click);
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(0, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(100, 23);
      this.label5.TabIndex = 11;
      // 
      // bmi_label
      // 
      this.bmi_label.AutoSize = true;
      this.bmi_label.Location = new System.Drawing.Point(58, 187);
      this.bmi_label.Name = "bmi_label";
      this.bmi_label.Size = new System.Drawing.Size(60, 13);
      this.bmi_label.TabIndex = 9;
      this.bmi_label.Text = "Din BMI er:";
      // 
      // bmi_result
      // 
      this.bmi_result.Enabled = false;
      this.bmi_result.Location = new System.Drawing.Point(125, 187);
      this.bmi_result.Name = "bmi_result";
      this.bmi_result.Size = new System.Drawing.Size(70, 20);
      this.bmi_result.TabIndex = 10;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(83, 23);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(143, 25);
      this.label6.TabIndex = 12;
      this.label6.Text = "BMI Beregner";
      // 
      // bmi_beregner
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.bmi_result);
      this.Controls.Add(this.bmi_label);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.udregn);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.vaegt);
      this.Controls.Add(this.hoejde);
      this.Name = "bmi_beregner";
      this.Text = "BMI Beregner";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox hoejde;
    private System.Windows.Forms.TextBox vaegt;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button udregn;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label bmi_label;
    private System.Windows.Forms.TextBox bmi_result;
    private System.Windows.Forms.Label label6;
  }
}

