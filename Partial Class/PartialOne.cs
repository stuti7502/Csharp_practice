namespace Partial_Class
{
    public partial class PartialCustomer
    {
        private string _firstName = "S";
        private string _lastName = "V";

        //public string FirstName { get => _firstName; set => _firstName = value; }
        //public string LastName { get => _lastName; set => _lastName = value; }

        static void Main() {
            PartialCustomer pc = new PartialCustomer();
            pc.getfullname();
        }
    }
}   