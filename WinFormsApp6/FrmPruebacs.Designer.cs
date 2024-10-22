namespace WinFormsApp6
{
    partial class FrmPruebacs
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
            listBox1 = new ListBox();
            checkBox1 = new CheckBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(241, 225);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(323, 139);
            listBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(331, 172);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(201, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Selecciona si fueron mas de 1 vez";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(179, 49);
            label2.Name = "label2";
            label2.Size = new Size(510, 50);
            label2.TabIndex = 3;
            label2.Text = "Registra si tambien te engaño";
            // 
            // FrmPruebacs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(checkBox1);
            Controls.Add(listBox1);
            Name = "FrmPruebacs";
            Text = "FrmPruebacs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox1;
        private CheckBox checkBox1;
        private Label label2;
    }
}