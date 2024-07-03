namespace NoteTakingApp
{
    partial class NoteTaker
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleBox = new System.Windows.Forms.TextBox();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.previousNotes = new System.Windows.Forms.DataGridView();
            this.NoteTaker_Load = new System.Windows.Forms.Button();
            this.deleteButton_Click = new System.Windows.Forms.Button();
            this.newNoteButton = new System.Windows.Forms.Button();
            this.saveButton_Click = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(446, 36);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(342, 20);
            this.titleBox.TabIndex = 0;
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(446, 87);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(342, 351);
            this.noteBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            // 
            // previousNotes
            // 
            this.previousNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.previousNotes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.previousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousNotes.Location = new System.Drawing.Point(12, 36);
            this.previousNotes.Name = "previousNotes";
            this.previousNotes.Size = new System.Drawing.Size(425, 308);
            this.previousNotes.TabIndex = 4;
            this.previousNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotes_CellContentClick);
            this.previousNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotes_CellDoubleClick);
            // 
            // NoteTaker_Load
            // 
            this.NoteTaker_Load.Location = new System.Drawing.Point(12, 350);
            this.NoteTaker_Load.Name = "NoteTaker_Load";
            this.NoteTaker_Load.Size = new System.Drawing.Size(210, 35);
            this.NoteTaker_Load.TabIndex = 5;
            this.NoteTaker_Load.Text = "Load";
            this.NoteTaker_Load.UseVisualStyleBackColor = true;
            this.NoteTaker_Load.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton_Click
            // 
            this.deleteButton_Click.Location = new System.Drawing.Point(228, 350);
            this.deleteButton_Click.Name = "deleteButton_Click";
            this.deleteButton_Click.Size = new System.Drawing.Size(209, 35);
            this.deleteButton_Click.TabIndex = 6;
            this.deleteButton_Click.Text = "Delete";
            this.deleteButton_Click.UseVisualStyleBackColor = true;
            this.deleteButton_Click.Click += new System.EventHandler(this.button2_Click);
            // 
            // newNoteButton
            // 
            this.newNoteButton.Location = new System.Drawing.Point(12, 402);
            this.newNoteButton.Name = "newNoteButton";
            this.newNoteButton.Size = new System.Drawing.Size(210, 35);
            this.newNoteButton.TabIndex = 7;
            this.newNoteButton.Text = "New Note";
            this.newNoteButton.UseVisualStyleBackColor = true;
            this.newNoteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveButton_Click
            // 
            this.saveButton_Click.Location = new System.Drawing.Point(228, 402);
            this.saveButton_Click.Name = "saveButton_Click";
            this.saveButton_Click.Size = new System.Drawing.Size(210, 35);
            this.saveButton_Click.TabIndex = 8;
            this.saveButton_Click.Text = "Save";
            this.saveButton_Click.UseVisualStyleBackColor = true;
            this.saveButton_Click.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Note:";
            // 
            // NoteTaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveButton_Click);
            this.Controls.Add(this.newNoteButton);
            this.Controls.Add(this.deleteButton_Click);
            this.Controls.Add(this.NoteTaker_Load);
            this.Controls.Add(this.previousNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.titleBox);
            this.Name = "NoteTaker";
            this.Text = "Note Taker";
            this.Load += new System.EventHandler(this.NoteTaker_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.previousNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView previousNotes;
        private System.Windows.Forms.Button NoteTaker_Load;
        private System.Windows.Forms.Button deleteButton_Click;
        private System.Windows.Forms.Button saveButton_Click;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newNoteButton;
    }
}

