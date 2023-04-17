
namespace TodoList
{
    partial class frmToDo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToDo));
            this.gbTasks = new System.Windows.Forms.GroupBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.tbxNewTask = new System.Windows.Forms.TextBox();
            this.lblNewTask = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cblTaskList = new System.Windows.Forms.CheckedListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.gbTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTasks
            // 
            this.gbTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.gbTasks.Controls.Add(this.lblDueDate);
            this.gbTasks.Controls.Add(this.dtpDueDate);
            this.gbTasks.Controls.Add(this.cbxSubject);
            this.gbTasks.Controls.Add(this.lblSubject);
            this.gbTasks.Controls.Add(this.tbxNewTask);
            this.gbTasks.Controls.Add(this.lblNewTask);
            this.gbTasks.Controls.Add(this.btnClear);
            this.gbTasks.Controls.Add(this.btnAdd);
            this.gbTasks.Controls.Add(this.cblTaskList);
            this.gbTasks.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTasks.ForeColor = System.Drawing.SystemColors.Control;
            this.gbTasks.Location = new System.Drawing.Point(37, 18);
            this.gbTasks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTasks.Name = "gbTasks";
            this.gbTasks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTasks.Size = new System.Drawing.Size(830, 583);
            this.gbTasks.TabIndex = 0;
            this.gbTasks.TabStop = false;
            this.gbTasks.Text = "Tasks";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "MM/dd/yyyy ddd";
            this.dtpDueDate.Font = new System.Drawing.Font("Dubai", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(133, 522);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDueDate.Size = new System.Drawing.Size(211, 41);
            this.dtpDueDate.TabIndex = 9;
            // 
            // cbxSubject
            // 
            this.cbxSubject.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbxSubject.ForeColor = System.Drawing.SystemColors.Window;
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(133, 429);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(181, 48);
            this.cbxSubject.TabIndex = 8;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(176, 479);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(95, 40);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Subject";
            // 
            // tbxNewTask
            // 
            this.tbxNewTask.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxNewTask.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxNewTask.Location = new System.Drawing.Point(320, 428);
            this.tbxNewTask.Name = "tbxNewTask";
            this.tbxNewTask.Size = new System.Drawing.Size(471, 48);
            this.tbxNewTask.TabIndex = 5;
            // 
            // lblNewTask
            // 
            this.lblNewTask.AutoSize = true;
            this.lblNewTask.Location = new System.Drawing.Point(7, 431);
            this.lblNewTask.Name = "lblNewTask";
            this.lblNewTask.Size = new System.Drawing.Size(120, 40);
            this.lblNewTask.TabIndex = 4;
            this.lblNewTask.Text = "New Task:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(451, 515);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 46);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(628, 515);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 46);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cblTaskList
            // 
            this.cblTaskList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cblTaskList.ForeColor = System.Drawing.SystemColors.Window;
            this.cblTaskList.FormattingEnabled = true;
            this.cblTaskList.Location = new System.Drawing.Point(7, 49);
            this.cblTaskList.Name = "cblTaskList";
            this.cblTaskList.Size = new System.Drawing.Size(806, 409);
            this.cblTaskList.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnExit.Location = new System.Drawing.Point(670, 622);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 46);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(7, 523);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(117, 40);
            this.lblDueDate.TabIndex = 10;
            this.lblDueDate.Text = "Due Date:";
            // 
            // frmToDo
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(896, 680);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbTasks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmToDo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.frmToDo_Load);
            this.gbTasks.ResumeLayout(false);
            this.gbTasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTasks;
        private System.Windows.Forms.CheckedListBox cblTaskList;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxNewTask;
        private System.Windows.Forms.Label lblNewTask;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cbxSubject;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
    }
}

