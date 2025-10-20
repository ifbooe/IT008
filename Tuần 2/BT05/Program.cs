using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Property
{
    public string Location { get; set; }
    public long Price { get; set; }
    public double Area { get; set; }

    public Property(string location, long price, double area)
    {
        Location = location;
        Price = price;
        Area = area;
    }

    public virtual string Display()
    {
        return $"Dia diem: {Location} | Gia: {Price} VND | Dien tich: {Area} m2";
    }
}

class Land : Property
{
    public Land(string location, long price, double area) : base(location, price, area) { }

    public override string Display()
    {
        return "Khu dat | " + base.Display();
    }
}

class House : Property
{
    public int YearBuilt { get; set; }
    public int Floors { get; set; }

    public House(string location, long price, double area, int yearBuilt, int floors)
        : base(location, price, area)
    {
        YearBuilt = yearBuilt;
        Floors = floors;
    }

    public override string Display()
    {
        return $"Nha pho | {base.Display()} | Nam xay dung: {YearBuilt} | So tang: {Floors}";
    }
}

class Apartment : Property
{
    public int Floor { get; set; }

    public Apartment(string location, long price, double area, int floor)
        : base(location, price, area)
    {
        Floor = floor;
    }

    public override string Display()
    {
        return $"Chung cu | {base.Display()} | Tang: {Floor}";
    }
}

class Program
{
    static string SanitizeString(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return "";

        string s = Regex.Replace(input.Trim(), @"[^\w\s\-]", " ");
        s = Regex.Replace(s, @"\s+", " ");
        return s;
    }

    static long CheckIntInput(string message, long min = long.MinValue, long max = long.MaxValue)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine().Trim().Replace(",", "");
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Khong duoc de trong. Vui long nhap lai.");
                continue;
            }
            if (!Regex.IsMatch(input, @"^-?\d+$"))
            {
                Console.WriteLine("Chi duoc nhap so nguyen. Vui long nhap lai.");
                continue;
            }
            if (!long.TryParse(input, out long val))
            {
                Console.WriteLine("Gia tri khong hop le. Vui long nhap lai.");
                continue;
            }
            if (val == 0)
            {
                Console.WriteLine("Gia tri khong duoc la 0. Vui long nhap lai.");
                continue;
            }
            if (val < 0)
            {
                Console.WriteLine("Gia tri khong duoc am. Vui long nhap lai.");
                continue;
            }
            if (val < min)
            {
                Console.WriteLine($"Gia tri qua nho (toi thieu {min}). Vui long nhap lai.");
                continue;
            }
            if (val > max)
            {
                Console.WriteLine($"Gia tri qua lon (toi da {max}). Vui long nhap lai.");
                continue;
            }
            return val;
        }
    }

    static double CheckDoubleInput(string message, double min = double.MinValue, double max = double.MaxValue)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine().Trim().Replace(",", "");
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Khong duoc de trong. Vui long nhap lai.");
                continue;
            }
            if (!double.TryParse(input, out double val))
            {
                Console.WriteLine("Nhap khong hop le. Vui long nhap lai.");
                continue;
            }
            if (val == 0)
            {
                Console.WriteLine("Gia tri khong duoc la 0. Vui long nhap lai.");
                continue;
            }
            if (val < 0)
            {
                Console.WriteLine("Gia tri khong duoc am. Vui long nhap lai.");
                continue;
            }
            if (val < min)
            {
                Console.WriteLine($"Gia tri qua nho (toi thieu {min}). Vui long nhap lai.");
                continue;
            }
            if (val > max)
            {
                Console.WriteLine($"Gia tri qua lon (toi da {max}). Vui long nhap lai.");
                continue;
            }
            return val;
        }
    }

    static string InputLocation(string message)
    {
        while (true)
        {
            Console.Write(message);
            string s = SanitizeString(Console.ReadLine());
            if (string.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("Dia diem khong duoc bo trong. Vui long nhap lai.");
                continue;
            }
            return s;
        }
    }

    static Land InputLand()
    {
        string location = InputLocation("Nhap dia diem khu dat: ");
        long price = CheckIntInput("Nhap gia ban (VND): ", 1, 1000000000000000);
        double area = CheckDoubleInput("Nhap dien tich (m2): ", 0.01, 1000000);
        return new Land(location, price, area);
    }

    static House InputHouse()
    {
        string location = InputLocation("Nhap dia diem nha pho: ");
        long price = CheckIntInput("Nhap gia ban (VND): ", 1, 1000000000000000);
        double area = CheckDoubleInput("Nhap dien tich (m2): ", 0.1, 100000);
        int year = (int)CheckIntInput("Nhap nam xay dung: ", 1800, 2025);
        int floors = (int)CheckIntInput("Nhap so tang: ", 1, 100);
        return new House(location, price, area, year, floors);
    }

    static Apartment InputApartment()
    {
        string location = InputLocation("Nhap dia diem chung cu: ");
        long price = CheckIntInput("Nhap gia ban (VND): ", 1, 1000000000000000);
        double area = CheckDoubleInput("Nhap dien tich (m2): ", 0.1, 100000);
        int floor = (int)CheckIntInput("Nhap tang: ", 1, 200);
        return new Apartment(location, price, area, floor);
    }

    static void ExportList(List<Land> lands, List<House> houses, List<Apartment> apartments)
    {
        Console.WriteLine("DANH SACH KHU DAT");
        if (lands.Count == 0) Console.WriteLine("Khong co khu dat");
        foreach (var l in lands) Console.WriteLine(l.Display());

        Console.WriteLine("DANH SACH NHA PHO");
        if (houses.Count == 0) Console.WriteLine("Khong co nha pho");
        foreach (var h in houses) Console.WriteLine(h.Display());

        Console.WriteLine("DANH SACH CHUNG CU");
        if (apartments.Count == 0) Console.WriteLine("Khong co chung cu");
        foreach (var a in apartments) Console.WriteLine(a.Display());
    }

    static void TotalPrices(List<Land> lands, List<House> houses, List<Apartment> apartments)
    {
        long totalLand = 0, totalHouse = 0, totalApartment = 0;
        foreach (var l in lands) totalLand += l.Price;
        foreach (var h in houses) totalHouse += h.Price;
        foreach (var a in apartments) totalApartment += a.Price;

        Console.WriteLine($"Tong gia ban - Khu dat: {totalLand} VND");
        Console.WriteLine($"Tong gia ban - Nha pho: {totalHouse} VND");
        Console.WriteLine($"Tong gia ban - Chung cu: {totalApartment} VND");
    }

    static void FilterSpecial(List<Land> lands, List<House> houses)
    {
        var result = new List<Property>();
        foreach (var l in lands)
            if (l.Area > 100) result.Add(l);
        foreach (var h in houses)
            if (h.Area > 60 && h.YearBuilt >= 2019) result.Add(h);

        if (result.Count == 0)
            Console.WriteLine("Khong co ket qua phu hop");
        else
        {
            Console.WriteLine("DANH SACH DAC BIET");
            foreach (var p in result) Console.WriteLine(p.Display());
        }
    }

    static void SearchProperties(List<House> houses, List<Apartment> apartments)
    {
        Console.Write("Nhap dia diem tim kiem (chuoi): ");
        string query = SanitizeString(Console.ReadLine()).ToLower();
        long maxPrice = CheckIntInput("Nhap gia toi da (VND): ", 1, 1000000000000000);
        double minArea = CheckDoubleInput("Nhap dien tich toi thieu (m2): ", 0.01, 1000000);

        var matched = new List<Property>();

        foreach (var h in houses)
            if (h.Location.ToLower().Contains(query) && h.Price <= maxPrice && h.Area >= minArea)
                matched.Add(h);

        foreach (var a in apartments)
            if (a.Location.ToLower().Contains(query) && a.Price <= maxPrice && a.Area >= minArea)
                matched.Add(a);

        if (matched.Count == 0)
            Console.WriteLine("Khong co ket qua phu hop");
        else
        {
            Console.WriteLine("KET QUA TIM KIEM");
            foreach (var m in matched)
                Console.WriteLine(m.Display());
        }
    }

    static void Menu()
    {
        List<Land> lands = new List<Land>();
        List<House> houses = new List<House>();
        List<Apartment> apartments = new List<Apartment>();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. Nhap khu dat");
            Console.WriteLine("2. Nhap nha pho");
            Console.WriteLine("3. Nhap chung cu");
            Console.WriteLine("4. Xuat danh sach");
            Console.WriteLine("5. Xuat tong gia ban");
            Console.WriteLine("6. Xuat danh sach dac biet");
            Console.WriteLine("7. Tim kiem nha pho hoac chung cu");
            Console.WriteLine("8. Thoat");
            Console.Write("Nhap lua chon (1-8): ");

            string choice = Console.ReadLine().Trim();

            switch (choice)
            {
                case "1":
                    lands.Add(InputLand());
                    Console.WriteLine("Da them khu dat.");
                    break;
                case "2":
                    houses.Add(InputHouse());
                    Console.WriteLine("Da them nha pho.");
                    break;
                case "3":
                    apartments.Add(InputApartment());
                    Console.WriteLine("Da them chung cu.");
                    break;
                case "4":
                    ExportList(lands, houses, apartments);
                    break;
                case "5":
                    TotalPrices(lands, houses, apartments);
                    break;
                case "6":
                    FilterSpecial(lands, houses);
                    break;
                case "7":
                    SearchProperties(houses, apartments);
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon tu 1 den 8.");
                    break;
            }
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Menu();
    }
}
