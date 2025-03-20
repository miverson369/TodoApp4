namespace TodoApp4
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            TaskDescription = new TextBox();
            DueDate = new TextBox();
            btnClear = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            TaskListBox = new ListBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(DueDate);
            groupBox1.Controls.Add(TaskDescription);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create Task";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 44);
            label1.Name = "label1";
            label1.Size = new Size(29, 14);
            label1.TabIndex = 0;
            label1.Text = "Task";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 75);
            label2.Name = "label2";
            label2.Size = new Size(54, 14);
            label2.TabIndex = 1;
            label2.Text = "Due Date";
            // 
            // TaskDescription
            // 
            TaskDescription.Location = new Point(99, 36);
            TaskDescription.MaxLength = 100;
            TaskDescription.Name = "TaskDescription";
            TaskDescription.Size = new Size(303, 22);
            TaskDescription.TabIndex = 1;
            // 
            // DueDate
            // 
            DueDate.Location = new Point(99, 67);
            DueDate.Name = "DueDate";
            DueDate.Size = new Size(303, 22);
            DueDate.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(198, 113);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 27);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(301, 113);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(97, 27);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(TaskListBox);
            groupBox2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 178);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(423, 330);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Task To Do";
            // 
            // TaskListBox
            // 
            TaskListBox.FormattingEnabled = true;
            TaskListBox.Location = new Point(0, 46);
            TaskListBox.Name = "TaskListBox";
            TaskListBox.Size = new Size(423, 284);
            TaskListBox.Sorted = true;
            TaskListBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 18);
            label3.Name = "label3";
            label3.Size = new Size(127, 14);
            label3.TabIndex = 1;
            label3.Text = "Click to Complete a Task";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 532);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "To Do App";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TaskDescription;
        private Label label2;
        private Label label1;
        private Button btnClear;
        private TextBox DueDate;
        private Button btnAdd;
        private GroupBox groupBox2;
        private Label label3;
        private ListBox TaskListBox;
    }
}
