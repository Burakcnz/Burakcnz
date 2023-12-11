namespace Proje02_Classes
{
    internal class Person
    {
        int age;
        string firstName;
        string lastName;
        string idNumber;
        string gender;

        public int Age
        {
            get
            {
                return age - 10;
            }
            set
            {
                age = value;
            }
        }
        public string Gender
        {
            get { return gender == "E" ? "Erkek" : "Kadın"; }
            set { gender = value; }
        }
        public string FirstName
        {
            get { return firstName.ToUpper(); }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

    }
}
