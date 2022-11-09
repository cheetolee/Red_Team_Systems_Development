namespace Interface
{

    public interface ICustomer
    {
        string ID               { get; set; }
        string Name             { get; set; }  
        CustomerGender Gender   { get; set; } 
        int Age                 { get; set; }  
        string Phone            { get; set; }  
        string Fax              { get; set; }   
        string IDcard           { get; set; }   
        string RoomID           { get; set; }   
        string Company          { get; set; }   
        string Address          { get; set; }   
    }
}
