public class UserOption{
    StoreInformation SI = new StoreInformation();
    public void Option(){
        Console.WriteLine("Plase Select");
        Console.WriteLine("1 InfoShop");
        Console.WriteLine("2 InfoOwner");
        Console.WriteLine("3 InfoStaff");
        Console.WriteLine("4 InfoFinancial");
        string Inp = Console.ReadLine();
        switch(Inp)
        {
            case "1":SI.StoreInformationIs();
            break;
            case "2":SI.StoreOwnerInformationIs();
            break;
            case "3":SI.StoreStaffInformationIs();
            break;
            case "4":SI.Financial();
            break;
            default:Console.WriteLine("Error");
            break;
        }
    }
}