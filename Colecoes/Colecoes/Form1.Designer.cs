namespace Colecoes
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
            this.lista = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnHashSet = new System.Windows.Forms.Button();
            this.btnDictonary = new System.Windows.Forms.Button();
            this.btnSortedList = new System.Windows.Forms.Button();
            this.btnSortedDictionary = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 40;
            this.lista.Location = new System.Drawing.Point(10, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(696, 564);
            this.lista.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(730, 12);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(222, 53);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnHashSet
            // 
            this.btnHashSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashSet.Location = new System.Drawing.Point(730, 71);
            this.btnHashSet.Name = "btnHashSet";
            this.btnHashSet.Size = new System.Drawing.Size(222, 53);
            this.btnHashSet.TabIndex = 2;
            this.btnHashSet.Text = "HashSet";
            this.btnHashSet.UseVisualStyleBackColor = true;
            this.btnHashSet.Click += new System.EventHandler(this.btnHashSet_Click);
            // 
            // btnDictonary
            // 
            this.btnDictonary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDictonary.Location = new System.Drawing.Point(730, 130);
            this.btnDictonary.Name = "btnDictonary";
            this.btnDictonary.Size = new System.Drawing.Size(222, 53);
            this.btnDictonary.TabIndex = 3;
            this.btnDictonary.Text = "Dictionary";
            this.btnDictonary.UseVisualStyleBackColor = true;
            this.btnDictonary.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSortedList
            // 
            this.btnSortedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedList.Location = new System.Drawing.Point(730, 189);
            this.btnSortedList.Name = "btnSortedList";
            this.btnSortedList.Size = new System.Drawing.Size(222, 53);
            this.btnSortedList.TabIndex = 4;
            this.btnSortedList.Text = "SortedList";
            this.btnSortedList.UseVisualStyleBackColor = true;
            this.btnSortedList.Click += new System.EventHandler(this.btnSortedList_Click);
            // 
            // btnSortedDictionary
            // 
            this.btnSortedDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortedDictionary.Location = new System.Drawing.Point(730, 248);
            this.btnSortedDictionary.Name = "btnSortedDictionary";
            this.btnSortedDictionary.Size = new System.Drawing.Size(222, 53);
            this.btnSortedDictionary.TabIndex = 5;
            this.btnSortedDictionary.Text = "SortedDictionary";
            this.btnSortedDictionary.UseVisualStyleBackColor = true;
            this.btnSortedDictionary.Click += new System.EventHandler(this.btnSortedDictionary_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(730, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "SortedSet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnQueue
            // 
            this.btnQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueue.Location = new System.Drawing.Point(730, 366);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(222, 53);
            this.btnQueue.TabIndex = 7;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStack.Location = new System.Drawing.Point(730, 425);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(222, 53);
            this.btnStack.TabIndex = 8;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 580);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSortedDictionary);
            this.Controls.Add(this.btnSortedList);
            this.Controls.Add(this.btnDictonary);
            this.Controls.Add(this.btnHashSet);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas Genéricas";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnHashSet;
        private System.Windows.Forms.Button btnDictonary;
        private System.Windows.Forms.Button btnSortedList;
        private System.Windows.Forms.Button btnSortedDictionary;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;
    }
}

