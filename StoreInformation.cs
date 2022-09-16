public class StoreInformation{
    private int Investment = 1000000;
    private string StoreName = "KFC Bang Khun Thian Chai Talay";
    private string StoreAddress = "Chai Talay Road Bang Khun Thian Soi 27";
    private string[] StoreOwnerName = {"Mr. Thawee", "Mr. Yuttadee", "Mr. James"};
    private string[] StoreOwnerSurname = {"Jaideedee", "Tangjaireiyn","Rakrongreรyn"};
    private string [] IDCard = {"153-698-4561237", "742-112-5687412","541-772-3215689"};
    private string [] StaffType = {"store staff", "store staff", "store staff", "food delivery man", "food delivery man"};
    private string [] StaffName = {"Mr. chaydee", "Mr. nondee", "Mr. Arphaydee", "Mr. Tumdee", "Mr. nondee"};
    private string [] StaffSurname = {"Rakdee", "Jaidee", "Reiyndee", "Ngandee", "Reiybdee"};
    private string [] StaffAge = {"20", "18", "22", "25", "23"};
    private static double [] StaffPay = {15000, 15000, 15000, 12500, 12500};
    private static double[] SaleInStoreWeek = {26, 27, 35, 50};
    private static double SaleInStorePrice = 127;
    private static double[] SaleDeliveryWeek = {78, 96, 159, 271};
    private static double SaleDeliveryPrice = 357;
    private static double[] StaffSaleInStore = {25, 52, 61, 0, 0};
    private static double[] StaffSaleDelivery = {201, 201, 202, 300, 304};
    private static double SalesShare = 0.025;
    private static double[] StaffExpenses = {8250, 8250, 8250, 8250, 8250};
    private static double[] StaffSaleDeliveryCost = {0, 0, 0, 45000, 45600};
    private static double ShareSaleInStore = 3.175;
    private static double ShareSaleDelivery = 8.925;

    

    
    public void StoreInformationIs(){
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Investment is {0}",Investment);
        Console.WriteLine("StoreName is {0}",StoreName);
        Console.WriteLine("StoreAddress is {0}",StoreAddress);
        Console.WriteLine("----------------------------------");
    }
    public void StoreOwnerInformationIs(){
            Console.WriteLine("----------------------------------");
        for(int i=0;i<3;i++){
            Console.WriteLine("Name and Surname is {0} {1}",StoreOwnerName[i],StoreOwnerSurname[i]);
            Console.WriteLine("ID Card is {0}",IDCard[i]);
            Console.WriteLine("----------------------------------");
        }
    }
    public void StoreStaffInformationIs(){
            Console.WriteLine("-------------------------------------------------");
        for(int i=0;i<5;i++){
            Console.WriteLine("StaffType is {0}",StaffType[i]);
            Console.WriteLine("Name and Surname is {0} {1}",StaffName[i],StaffSurname[i]);
            Console.WriteLine("Age is {0}",StaffAge[i]);
            Console.WriteLine("Salary is {0}",StaffPay[i]);
            Console.WriteLine("-------------------------------------------------");
        }
    }
    public void Financial(){
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Income per Month is {0}",Income());
            Console.WriteLine("All employee payroll is {0}",EmployeePayroll());
            Console.WriteLine("Profit is {0}",Profit());
            Console.WriteLine("-------------------------------------------------");
    }
    static double Income(){
        double sum = 0;
        for(int i = 0;i<4;i++){
            sum += SaleInStoreWeek[i] * SaleInStorePrice+SaleDeliveryWeek[i] * SaleDeliveryPrice;
        }
        return sum;
    }
    static double EmployeePayroll(){
        double sum = 0;
        for(int i = 0;i<5;i++){
            sum += StaffSaleInStore[i] * ShareSaleInStore + StaffSaleDelivery[i] * ShareSaleDelivery + StaffPay[i] + StaffExpenses[i] + StaffSaleDeliveryCost[i];
        }
        return sum;
    }
    static double Profit(){
        return Income()-EmployeePayroll();
    }
}