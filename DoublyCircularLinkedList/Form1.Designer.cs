namespace DoublyCircularLinkedList
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
            label1 = new Label();
            txtValue = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnContains = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 70);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 0;
            label1.Text = "Number:";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(109, 68);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(199, 23);
            txtValue.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(388, 43);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 37);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(388, 86);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(97, 37);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnContains
            // 
            btnContains.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnContains.Location = new Point(388, 129);
            btnContains.Name = "btnContains";
            btnContains.Size = new Size(97, 37);
            btnContains.TabIndex = 4;
            btnContains.Text = "Contains";
            btnContains.UseVisualStyleBackColor = true;
            btnContains.Click += btnContains_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(565, 251);
            Controls.Add(btnContains);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtValue);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtValue;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnContains;
    }
}
