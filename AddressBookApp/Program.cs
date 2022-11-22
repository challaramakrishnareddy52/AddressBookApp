namespace AddressBookApp
{
    internal class Program
    {
        static void Msg()
        {
            Console.WriteLine("Welcome To Address Book App");
        }
        public static void CreatingContact()
        {
            Console.WriteLine("Enter Your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Your Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number");
            double phoneNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Email-Id");
            string emailId = Console.ReadLine();
            Console.WriteLine($"\n First Name : {firstName}\n Last Name : {lastName}\n Address : {address}\n Phone Number : {phoneNo}\n Email Id : {emailId}");
        }
        static void Main(string[] args)
        {
            Msg();
            CreatingContact();
        }
    }
}