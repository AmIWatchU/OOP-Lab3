
namespace OOP_Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.a1 = new System.Windows.Forms.RadioButton();
            this.a2 = new System.Windows.Forms.RadioButton();
            this.a_3 = new System.Windows.Forms.RadioButton();
            this.dad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_b = new System.Windows.Forms.ComboBox();
            this.z1 = new System.Windows.Forms.CheckBox();
            this.z2 = new System.Windows.Forms.CheckBox();
            this.z3 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // a1
            // 
            resources.ApplyResources(this.a1, "a1");
            this.a1.Name = "a1";
            this.a1.TabStop = true;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // a2
            // 
            resources.ApplyResources(this.a2, "a2");
            this.a2.Name = "a2";
            this.a2.TabStop = true;
            this.a2.UseVisualStyleBackColor = true;
            // 
            // a_3
            // 
            resources.ApplyResources(this.a_3, "a_3");
            this.a_3.Name = "a_3";
            this.a_3.TabStop = true;
            this.a_3.UseVisualStyleBackColor = true;
            // 
            // dad
            // 
            resources.ApplyResources(this.dad, "dad");
            this.dad.Name = "dad";
            this.dad.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // combo_b
            // 
            this.combo_b.DisplayMember = "1";
            this.combo_b.FormattingEnabled = true;
            resources.ApplyResources(this.combo_b, "combo_b");
            this.combo_b.Name = "combo_b";
            this.combo_b.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // z1
            // 
            resources.ApplyResources(this.z1, "z1");
            this.z1.Name = "z1";
            this.z1.UseVisualStyleBackColor = true;
            // 
            // z2
            // 
            resources.ApplyResources(this.z2, "z2");
            this.z2.Name = "z2";
            this.z2.UseVisualStyleBackColor = true;
            this.z2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // z3
            // 
            resources.ApplyResources(this.z3, "z3");
            this.z3.Name = "z3";
            this.z3.UseVisualStyleBackColor = true;
            this.z3.CheckedChanged += new System.EventHandler(this.z3_CheckedChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox_x
            // 
            resources.ApplyResources(this.textBox_x, "textBox_x");
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.combo_b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dad);
            this.Controls.Add(this.a_3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton a1;
        private System.Windows.Forms.RadioButton a2;
        private System.Windows.Forms.RadioButton a_3;
        private System.Windows.Forms.Label dad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_b;
        private System.Windows.Forms.CheckBox z1;
        private System.Windows.Forms.CheckBox z2;
        private System.Windows.Forms.CheckBox z3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}

