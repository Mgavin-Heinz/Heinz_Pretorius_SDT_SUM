namespace MobileStockCapture
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
            lblOutput = new Label();
            lblCode = new Label();
            lblQuantity = new Label();
            lblMake = new Label();
            txtCode = new TextBox();
            txtQuantity = new TextBox();
            txtMake = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnFind = new Button();
            tblMobilePhones = new ListBox();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(471, 52);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(55, 20);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "Output";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(309, 145);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(95, 20);
            lblCode.TabIndex = 1;
            lblCode.Text = "Mobile Code";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(309, 280);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity";
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(309, 211);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(45, 20);
            lblMake.TabIndex = 3;
            lblMake.Text = "Make";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(527, 142);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(527, 273);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 5;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(527, 204);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(125, 27);
            txtMake.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(356, 387);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(490, 387);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(630, 387);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 29);
            btnFind.TabIndex = 9;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // tblMobilePhones
            // 
            tblMobilePhones.FormattingEnabled = true;
            tblMobilePhones.Location = new Point(831, 110);
            tblMobilePhones.Name = "tblMobilePhones";
            tblMobilePhones.Size = new Size(260, 304);
            tblMobilePhones.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 587);
            Controls.Add(tblMobilePhones);
            Controls.Add(btnFind);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtMake);
            Controls.Add(txtQuantity);
            Controls.Add(txtCode);
            Controls.Add(lblMake);
            Controls.Add(lblQuantity);
            Controls.Add(lblCode);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Label lblCode;
        private Label lblQuantity;
        private Label lblMake;
        private TextBox txtCode;
        private TextBox txtQuantity;
        private TextBox txtMake;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnFind;
        private ListBox tblMobilePhones;
    }
}
