namespace Assignment4._1._1THIS
{
    public partial class Form1 : Form
    {
        static Dictionary<string, Person> contactBook = new Dictionary<string, Person>(); //<string(key), Person(value)> is just the key and value
                                                                                                //key is the data type I want to find, value is data type what Im looking for alltogether?)
                                                                                                //Dont forget that person is a data type right now.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person();    //instantiate person class.  Here we made a new data type called newPerson

            newPerson.FirstName = FNametextBox.Text;                 // Link the textbox to here. Make sure to use >text
            newPerson.LastName = LNametextBox.Text;
            newPerson.MobilePhoneNumer = MobilePhoneTextBox.Text;
            newPerson.WorkPhoneNumber = WorkPhoneTextBox.Text;
            newPerson.Email = EmailTextBox.Text;
            newPerson.Address = AddresstextBox.Text;

            string fullName = LNametextBox.Text + FNametextBox.Text;
            contactBook.Add(fullName, newPerson);                   //fullname is the key (first half of the dictionary collection)

           

        }
    }
}
