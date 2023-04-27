namespace Ward_PR04_BasicTree2022 {
    partial class BasicTree {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.listBoxPreOrder = new System.Windows.Forms.ListBox();
            this.listBoxInOrder = new System.Windows.Forms.ListBox();
            this.listBoxPostOrder = new System.Windows.Forms.ListBox();
            this.labelPreOrder = new System.Windows.Forms.Label();
            this.labelInOrder = new System.Windows.Forms.Label();
            this.labelPostOrder = new System.Windows.Forms.Label();
            this.listBoxCount = new System.Windows.Forms.ListBox();
            this.listBoxMinMax = new System.Windows.Forms.ListBox();
            this.listBoxCountTraversal = new System.Windows.Forms.ListBox();
            this.buttonProcessFile = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelMinMax = new System.Windows.Forms.Label();
            this.labelTraversal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(91, 21);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(479, 20);
            this.textBoxFileName.TabIndex = 0;
           
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(28, 24);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(57, 13);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "File Name:";
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(576, 19);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFile.TabIndex = 2;
            this.buttonSelectFile.Text = "Select File";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // listBoxPreOrder
            // 
            this.listBoxPreOrder.FormattingEnabled = true;
            this.listBoxPreOrder.Location = new System.Drawing.Point(31, 81);
            this.listBoxPreOrder.Name = "listBoxPreOrder";
            this.listBoxPreOrder.Size = new System.Drawing.Size(245, 264);
            this.listBoxPreOrder.TabIndex = 3;
            // 
            // listBoxInOrder
            // 
            this.listBoxInOrder.FormattingEnabled = true;
            this.listBoxInOrder.Location = new System.Drawing.Point(302, 81);
            this.listBoxInOrder.Name = "listBoxInOrder";
            this.listBoxInOrder.Size = new System.Drawing.Size(268, 264);
            this.listBoxInOrder.TabIndex = 4;
            // 
            // listBoxPostOrder
            // 
            this.listBoxPostOrder.FormattingEnabled = true;
            this.listBoxPostOrder.Location = new System.Drawing.Point(612, 81);
            this.listBoxPostOrder.Name = "listBoxPostOrder";
            this.listBoxPostOrder.Size = new System.Drawing.Size(248, 264);
            this.listBoxPostOrder.TabIndex = 5;
            
            // 
            // labelPreOrder
            // 
            this.labelPreOrder.AutoSize = true;
            this.labelPreOrder.Location = new System.Drawing.Point(28, 56);
            this.labelPreOrder.Name = "labelPreOrder";
            this.labelPreOrder.Size = new System.Drawing.Size(49, 13);
            this.labelPreOrder.TabIndex = 6;
            this.labelPreOrder.Text = "PreOrder";
            // 
            // labelInOrder
            // 
            this.labelInOrder.AutoSize = true;
            this.labelInOrder.Location = new System.Drawing.Point(299, 56);
            this.labelInOrder.Name = "labelInOrder";
            this.labelInOrder.Size = new System.Drawing.Size(42, 13);
            this.labelInOrder.TabIndex = 7;
            this.labelInOrder.Text = "InOrder";
            // 
            // labelPostOrder
            // 
            this.labelPostOrder.AutoSize = true;
            this.labelPostOrder.Location = new System.Drawing.Point(609, 56);
            this.labelPostOrder.Name = "labelPostOrder";
            this.labelPostOrder.Size = new System.Drawing.Size(54, 13);
            this.labelPostOrder.TabIndex = 8;
            this.labelPostOrder.Text = "PostOrder";
            // 
            // listBoxCount
            // 
            this.listBoxCount.FormattingEnabled = true;
            this.listBoxCount.Location = new System.Drawing.Point(56, 363);
            this.listBoxCount.Name = "listBoxCount";
            this.listBoxCount.Size = new System.Drawing.Size(190, 30);
            this.listBoxCount.TabIndex = 9;
            // 
            // listBoxMinMax
            // 
            this.listBoxMinMax.FormattingEnabled = true;
            this.listBoxMinMax.Location = new System.Drawing.Point(333, 363);
            this.listBoxMinMax.Name = "listBoxMinMax";
            this.listBoxMinMax.Size = new System.Drawing.Size(190, 30);
            this.listBoxMinMax.TabIndex = 10;
            // 
            // listBoxCountTraversal
            // 
            this.listBoxCountTraversal.FormattingEnabled = true;
            this.listBoxCountTraversal.Location = new System.Drawing.Point(640, 363);
            this.listBoxCountTraversal.Name = "listBoxCountTraversal";
            this.listBoxCountTraversal.Size = new System.Drawing.Size(190, 30);
            this.listBoxCountTraversal.TabIndex = 11;
            // 
            // buttonProcessFile
            // 
            this.buttonProcessFile.Location = new System.Drawing.Point(657, 18);
            this.buttonProcessFile.Name = "buttonProcessFile";
            this.buttonProcessFile.Size = new System.Drawing.Size(75, 23);
            this.buttonProcessFile.TabIndex = 12;
            this.buttonProcessFile.Text = "Process File";
            this.buttonProcessFile.UseVisualStyleBackColor = true;
            this.buttonProcessFile.Click += new System.EventHandler(this.buttonProcessFile_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(135, 396);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(38, 13);
            this.labelCount.TabIndex = 13;
            this.labelCount.Text = "Count:";
            // 
            // labelMinMax
            // 
            this.labelMinMax.AutoSize = true;
            this.labelMinMax.Location = new System.Drawing.Point(371, 396);
            this.labelMinMax.Name = "labelMinMax";
            this.labelMinMax.Size = new System.Drawing.Size(106, 13);
            this.labelMinMax.TabIndex = 14;
            this.labelMinMax.Text = "Min and Max Values:";
            // 
            // labelTraversal
            // 
            this.labelTraversal.AutoSize = true;
            this.labelTraversal.Location = new System.Drawing.Point(695, 396);
            this.labelTraversal.Name = "labelTraversal";
            this.labelTraversal.Size = new System.Drawing.Size(82, 13);
            this.labelTraversal.TabIndex = 15;
            this.labelTraversal.Text = "Count Traversal";
            // 
            // BasicTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.labelTraversal);
            this.Controls.Add(this.labelMinMax);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonProcessFile);
            this.Controls.Add(this.listBoxCountTraversal);
            this.Controls.Add(this.listBoxMinMax);
            this.Controls.Add(this.listBoxCount);
            this.Controls.Add(this.labelPostOrder);
            this.Controls.Add(this.labelInOrder);
            this.Controls.Add(this.labelPreOrder);
            this.Controls.Add(this.listBoxPostOrder);
            this.Controls.Add(this.listBoxInOrder);
            this.Controls.Add(this.listBoxPreOrder);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.textBoxFileName);
            this.Name = "BasicTree";
            this.Text = "BasicTree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.ListBox listBoxPreOrder;
        private System.Windows.Forms.ListBox listBoxInOrder;
        private System.Windows.Forms.ListBox listBoxPostOrder;
        private System.Windows.Forms.Label labelPreOrder;
        private System.Windows.Forms.Label labelInOrder;
        private System.Windows.Forms.Label labelPostOrder;
        private System.Windows.Forms.ListBox listBoxCount;
        private System.Windows.Forms.ListBox listBoxMinMax;
        private System.Windows.Forms.ListBox listBoxCountTraversal;
        private System.Windows.Forms.Button buttonProcessFile;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelMinMax;
        private System.Windows.Forms.Label labelTraversal;
    }
}

