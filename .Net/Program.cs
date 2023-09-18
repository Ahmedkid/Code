class Customer //43
{
   int Id;
   string Name;
   double Bal;
   string Spouse;
   public Customer()
   {
       Console.WriteLine("Default Constructor");
   }
   public Customer(int Id, string Name, double Bal):this()
   {
       this.Id = Id;
       this.Name = Name;
       this.Bal = Bal;
   }
   public Customer(int Id, string Name, double Bal, string Spouse):this(Id,Name,Bal)
   {
       this.Id = Id;
       this.Name = Name;
       this.Bal = Bal;
       this.Spouse = Spouse;
   }
   public void Details()
   {
       Console.WriteLine($"Id:{Id} Name:{Name}  Bal:{Bal} Spouse:{Spouse}");
   }
   public void Deposite(double amt)
   {
       Bal = Bal + amt;
   }
   public void Deposite(double amt, bool showDetails)
   {
       Bal = Bal + amt;
       if (showDetails == true)
       {
           Console.WriteLine($"Id:{Id} Name:{Name}  Bal:{Bal} Spouse:{Spouse}");
       }
   } 
   public void Withdraw(double amt)
   {
       Bal = Bal - amt;
   }
}