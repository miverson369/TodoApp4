using System.Drawing.Text;

namespace TodoApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e, string newTextBox)

        {
            DateTime date = DateTime.Parse(newTextBox);

            //where we handle the add event
            Todo mytodo = new Todo(newTextBox, new DateTime(), false); }
        
        //where we gather the user input from textbox
        private void BtnAdd_Click(object sender, EventArgs e, string newTextBox, object listBoxDisplay)
        {
            string userInput = GetUserInput(newTextBox);
            //add the text to the listbox
            object value = listBoxDisplay.Items.Add(userInput);
            //Clear the Textbox for new input
          
            


            //MessageBox.Show(mytodo.ToString());

            //check if the todo is valid
            //if it is not, display an error
            //exit

        }

        private static object GetUserInput(string newTextBox)
        {
            return newTextBox.Text;
        }

        private void BtnClear_Clear
            (object sender, EventArgs e)
        {
            TaskDescription.Clear();
            DueDate.Clear();
            MessageBox.Show("Form Cleared");

        }

        private void BtnAdd_Add
            (object sender, EventArgs e)
        {

        }
    }
}
