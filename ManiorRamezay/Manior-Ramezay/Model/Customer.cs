using Interface;

namespace Model
{

    public class Customer : ICustomer
    {
        public string ID                { get; set; }  
        public string Name              { get; set; }   
        public CustomerGender Gender    { get; set; }  
        public int Age                  { get;set; }   
        public string Phone             { get; set; }  
        public string IDcard            { get; set; }  
        public string RoomID            { get; set; }   
        public string Company           { get; set; }   
        public string Address           { get; set; } 

        public Customer(string id, string name, CustomerGender gender, int age, string phone,
            string idcard, string roomid, string company, string address)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Age = age;
            Phone = phone;

            IDcard = idcard;
            RoomID = roomid;
            Company = company;
            Address = address;
        }
        public Customer()
        {
            ID = IClock.GetCustomerID;
        }

    }
}
