
namespace Resebokning
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxAntalDagar = new System.Windows.Forms.TextBox();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            this.tbxKund = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSök = new System.Windows.Forms.Button();
            this.lbxSökResultat = new System.Windows.Forms.ListBox();
            this.tbxSökKund = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBoka = new System.Windows.Forms.Button();
            this.btnRensa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kund";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Antal dagar";
            // 
            // tbxAntalDagar
            // 
            this.tbxAntalDagar.Location = new System.Drawing.Point(305, 188);
            this.tbxAntalDagar.Name = "tbxAntalDagar";
            this.tbxAntalDagar.Size = new System.Drawing.Size(100, 20);
            this.tbxAntalDagar.TabIndex = 3;
            // 
            // tbxDestination
            // 
            this.tbxDestination.Location = new System.Drawing.Point(305, 160);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(100, 20);
            this.tbxDestination.TabIndex = 4;
            // 
            // tbxKund
            // 
            this.tbxKund.Location = new System.Drawing.Point(305, 135);
            this.tbxKund.Name = "tbxKund";
            this.tbxKund.Size = new System.Drawing.Size(100, 20);
            this.tbxKund.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRensa);
            this.groupBox1.Controls.Add(this.btnSök);
            this.groupBox1.Controls.Add(this.lbxSökResultat);
            this.groupBox1.Controls.Add(this.tbxSökKund);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(207, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sök kund";
            // 
            // btnSök
            // 
            this.btnSök.Location = new System.Drawing.Point(188, 17);
            this.btnSök.Name = "btnSök";
            this.btnSök.Size = new System.Drawing.Size(75, 23);
            this.btnSök.TabIndex = 8;
            this.btnSök.Text = "Sök";
            this.btnSök.UseVisualStyleBackColor = true;
            this.btnSök.Click += new System.EventHandler(this.btnSök_Click);
            // 
            // lbxSökResultat
            // 
            this.lbxSökResultat.FormattingEnabled = true;
            this.lbxSökResultat.Location = new System.Drawing.Point(6, 49);
            this.lbxSökResultat.Name = "lbxSökResultat";
            this.lbxSökResultat.Size = new System.Drawing.Size(214, 95);
            this.lbxSökResultat.TabIndex = 7;
            // 
            // tbxSökKund
            // 
            this.tbxSökKund.Location = new System.Drawing.Point(73, 19);
            this.tbxSökKund.Name = "tbxSökKund";
            this.tbxSökKund.Size = new System.Drawing.Size(100, 20);
            this.tbxSökKund.TabIndex = 6;
            this.tbxSökKund.TextChanged += new System.EventHandler(this.tbxSökKund_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Namn";
            // 
            // btnBoka
            // 
            this.btnBoka.Location = new System.Drawing.Point(411, 186);
            this.btnBoka.Name = "btnBoka";
            this.btnBoka.Size = new System.Drawing.Size(75, 23);
            this.btnBoka.TabIndex = 7;
            this.btnBoka.Text = "Boka";
            this.btnBoka.UseVisualStyleBackColor = true;
            this.btnBoka.Click += new System.EventHandler(this.btnBoka_Click);
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(226, 121);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(48, 23);
            this.btnRensa.TabIndex = 8;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBoka);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxKund);
            this.Controls.Add(this.tbxDestination);
            this.Controls.Add(this.tbxAntalDagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "v";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxAntalDagar;
        private System.Windows.Forms.TextBox tbxDestination;
        private System.Windows.Forms.TextBox tbxKund;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxSökResultat;
        private System.Windows.Forms.TextBox tbxSökKund;
        private System.Windows.Forms.Button btnBoka;
        private System.Windows.Forms.Button btnSök;
        private System.Windows.Forms.Button btnRensa;
    }
}

