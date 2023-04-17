using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class frmToDo : Form
    {
        public frmToDo()
        {
            InitializeComponent();
        }

        private void frmToDo_Load(object sender, EventArgs e)
        {
            //Read in task lines from fixed file
            string[] taskArray = File.ReadAllLines("C:\\Users\\mtran\\OneDrive\\Documents\\Personal Projects\\TodoList\\TodoList\\Tasks.txt");
            string[] subjectArray = File.ReadAllLines("C:\\Users\\mtran\\OneDrive\\Documents\\Personal Projects\\TodoList\\TodoList\\Subjects.txt");
            
            //Add to combobox upon form load to have "memory"
            foreach(string s in taskArray)
            {
                cblTaskList.Items.Add(s, false);
            }

            foreach (string s in subjectArray)
            {
                cbxSubject.Items.Add(s);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Creates a new task entry from the text box
            if (tbxNewTask.Text != "" && cbxSubject.Text != "")
            {
                //no duplicate tasks
                if (!cblTaskList.Items.Contains(cbxSubject.Text + ": " + tbxNewTask.Text + " - " + dtpDueDate.Text))
                    cblTaskList.Items.Add(cbxSubject.Text + ": " + tbxNewTask.Text + " - " + dtpDueDate.Text, false);

                //no duplicate subjects
                if (!cbxSubject.Items.Contains(cbxSubject.Text))
                    cbxSubject.Items.Add(cbxSubject.Text);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            List<object> removal = new List<object>();

            //accumulate the checked objects to be deleted
            for (int i = cblTaskList.Items.Count - 1; i >= 0; i--)
            {
                
                if (cblTaskList.GetItemChecked(i))
                {
                    removal.Add(cblTaskList.Items[i]);
                }
            }

            foreach (object o in removal)
            {
                cblTaskList.Items.Remove(o);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            List<string> tasks = new List<string>();
            List<string> subjects = new List<string>();

            //Get a string for every object to be written into the task file
            foreach (object o in cblTaskList.Items)
            {
                tasks.Add(o.ToString());
            }

            foreach (object i in cbxSubject.Items)
            {
                subjects.Add(i.ToString());
            }

            //Overwrite file with all the current items in the list to save progress of the list
            File.WriteAllLines("C:\\Users\\mtran\\OneDrive\\Documents\\Personal Projects\\TodoList\\TodoList\\Tasks.txt", tasks);
            File.WriteAllLines("C:\\Users\\mtran\\OneDrive\\Documents\\Personal Projects\\TodoList\\TodoList\\Subjects.txt", subjects);

            Application.Exit();
        }

    }
}
