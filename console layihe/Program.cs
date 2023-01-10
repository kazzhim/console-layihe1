using ConsoleApp15.Services.Interface;
using ConsoleApp15.Services.implementations;
using ConsoleApp15;

Console.WriteLine("1) Yeni qrup yarat");
Console.WriteLine("2) Qruplarin siyahisini goster");
Console.WriteLine("3) Qrup uzerinde duzelis etmek");
Console.WriteLine("4) Qrupdaki telebelerin siyahisini goster");


Console.Write("Bir reqem yazin : ");
string input = Console.ReadLine();

IGroupService groupService = new GroupManager();


switch (input)
{
    case "1":
        Group group = new Group();

        Console.Write("Group nomresi: ");
        string groupNo = Console.ReadLine();

        while (true)
        {
            Console.Write("Kateqoriyasi(Proqramlasdirma, Dizayn, Sistem Administrasiyasi) : ");
            string category = Console.ReadLine();
            if (category == "Proqramlasdirma")
            {
                group.Category = Category.Programming;
                break;
            }
            else if (category == "Dizayn")
            {
                group.Category = category.Design;
                break;
            }
            else if (category == "Sistem Administrasiyasi")
            {
                object Category = null;
                group.Category = Category.SystemAdministration;
                break;
            }
            else
            {
                Console.WriteLine("Xahis olunur duzgun kateqoriya yazin : ");
                continue;
            }
        }


        while (true)
        {
            Console.Write("Onlayn veya Eyani : ");
            string isOnline = Console.ReadLine();
            if (isOnline == "Onlayn")
            {
                group.IsOnline = true;
                break;
            }
            else if (isOnline == "Eyani")
            {
                group.IsOnline = false;
                break;
            }
            else
            {
                Console.WriteLine("Xahis olunur duzgun secim edin : ");
                continue;
            }
        }

        while (true)
        {
            Console.Write("Telebe sayi : ");
            int studentNumber = Convert.ToInt32(Console.ReadLine());
            if (group.IsOnline = true && studentNumber < 15)
            {
                group.Students = studentNumber;
                break;
            }
            else if (group.IsOnline = false && studentNumber < 10)
            {
                group.Students = studentNumber;
                break;
            }
            else
            {
                Console.WriteLine("Duzgun secim edin(Onlayn qrup ucun limit 15, Eyani qrup ucun limit 10dur) : ");
                continue;
            }
        }

        groupService.Add(group);
        break;


    case "2":
        List<Group> groups = groupService.GetAll();

        foreach (var item in groups)
        {
            Console.WriteLine(item.No + " " + item.Category.ToString() + " " + item.IsOnline + " " + item.Students);
        }
        break;

    case "3":
        Console.Write("Qrup nomresi: ");
        string groupNoforUpdate = Console.ReadLine();
        Console.Write("Yeni qrup nomresi: ");
        string newGroupNo = Console.ReadLine();

        groupService.Update(groupNoforUpdate, newGroupNo);
        break;

    default:
        Console.WriteLine("Duzgun secim edin");
        break;
}