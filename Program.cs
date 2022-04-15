Console.Write($"\t\t\tOrganisation : {RelianceOrg.OrganisationName}\t\t\t");
RelianceOrg relorg = new (101, "Tejas", 7040481685, "Pravarasangam", "Tejas@Gmail.com");
relorg.Display();
relorg.Update();
relorg.Display();

public class RelianceOrg
{
    public static string OrganisationName = "Reliance";
    int _empId;
    string _empName;
    long _empPhone;
    string _empAddress;
    string _empEmail;

    public RelianceOrg(int empId, string empName, long empPhone, string empAddress, string empEmail)
    {
        this._empId = empId;
        this._empName = empName;
        this._empPhone = empPhone;
        this._empAddress = empAddress;
        this._empEmail = empEmail;
    }

    public void Display()
    {
        Console.WriteLine($"\nEmployee Id : {_empId}, \nEmployee Name : {_empName}, \nEmployee Contact : {_empPhone}, \nEmployee Address : {_empAddress}, \nEmployee Email : {_empEmail}");
    }

    public void Update()
    {
        int choice;
        do{
            Console.WriteLine("\nWhat you want to update : \n1.Name \n2.Phone \n3.Address \n4.Email \n0.Exit");
            choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1 :
                Console.Write("Enter Name : ");
                string Name = Console.ReadLine();
                _empName = Name;
                break;

                case 2 :
                Console.Write("Enter Phone No. : ");
                long Phone = long.Parse(Console.ReadLine());
                _empPhone = Phone;
                break;

                case 3 :
                Console.Write("Enter Address : ");
                string Address = Console.ReadLine();
                _empAddress = Address;
                break;

                case 4 :
                Console.Write("Enter Email : ");
                string Email = Console.ReadLine();
                _empEmail = Email;
                break;

                default :
                Console.WriteLine("Wrong choice. Please check input!!!!");
                break;
               
            }
        }while(choice>0);
    }
}