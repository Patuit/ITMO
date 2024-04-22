namespace HW19_1;

class Program
{
    static void Main(string[] args)
    {
        List<Computer> computerList = new List<Computer>()
        {
            new Computer() { Code = 1, Name = "Hyper Computer", AvailableQuantity = 10, FrequencyCPU = 5.5, Price = 100000, TypeCPU = "i5", VolumeHDD = 10000, VolumeRAM = 64, VolumeRamGpu = 32},
            new Computer() { Code = 2, Name = "Science ALL Computer", AvailableQuantity = 15, FrequencyCPU = 3.5, Price = 9029, TypeCPU = "Ryzen 9", VolumeHDD = 1000, VolumeRAM = 4, VolumeRamGpu = 2},
            new Computer() { Code = 3, Name = "Geology Computer", AvailableQuantity = 89, FrequencyCPU = 3.2, Price = 9812, TypeCPU = "Ryzen 5", VolumeHDD = 2000, VolumeRAM = 16, VolumeRamGpu = 16},
            new Computer() { Code = 4, Name = "Biology Computer", AvailableQuantity = 23, FrequencyCPU = 2.2, Price = 5999, TypeCPU = "A8", VolumeHDD = 7000, VolumeRAM = 8, VolumeRamGpu = 6},
            new Computer() { Code = 5, Name = "Mathematics Computer", AvailableQuantity = 46, FrequencyCPU = 3.0, Price = 7800, TypeCPU = "Ryzen 7", VolumeHDD = 6500, VolumeRAM = 16, VolumeRamGpu = 8},
            new Computer() { Code = 6, Name = "Chemistry Computer", AvailableQuantity = 4, FrequencyCPU = 3.5, Price = 7999, TypeCPU = "i5", VolumeHDD = 1000, VolumeRAM = 4, VolumeRamGpu = 2},
            new Computer() { Code = 7, Name = "Language Computer", AvailableQuantity = 19, FrequencyCPU = 3.1, Price = 1293, TypeCPU = "A4", VolumeHDD = 3000, VolumeRAM = 4, VolumeRamGpu = 4},
            new Computer() { Code = 8, Name = "Mathematics Pro Computer", AvailableQuantity = 35, FrequencyCPU = 4.0, Price = 6999, TypeCPU = "i7", VolumeHDD = 15000, VolumeRAM = 32, VolumeRamGpu = 16},
            new Computer() { Code = 9, Name = "Ecology Computer", AvailableQuantity = 99, FrequencyCPU = 3.2, Price = 8143, TypeCPU = "Ryzen 3", VolumeHDD = 2000, VolumeRAM = 8, VolumeRamGpu = 2},
            new Computer() { Code = 10, Name = "Economy Computer", AvailableQuantity = 105, FrequencyCPU = 2.5, Price = 2999, TypeCPU = "i3", VolumeHDD = 4000, VolumeRAM = 8, VolumeRamGpu = 4}
        };

        Console.WriteLine("Введите тип процессора:");
        string inputCPU = Console.ReadLine();
        List<Computer> computerList1 = computerList.Where(x => x.TypeCPU == inputCPU).ToList();
        Print(computerList1);

        Console.WriteLine("Введите объём ОЗУ:");
        int VolumeRAM = Convert.ToInt32(Console.ReadLine());
        List<Computer> computerList2 = computerList.Where(x => x.VolumeRAM >= VolumeRAM).ToList();
        Print(computerList2);

        List<Computer> computerList3 = computerList.OrderBy(x => x.Price).ToList();
        Print(computerList3);

        IEnumerable<IGrouping<string, Computer>> computerList4 = computerList.GroupBy(x => x.TypeCPU);
        foreach (IGrouping<string, Computer> gr in computerList4)
        {
            Console.WriteLine(gr.Key);
            foreach (var item in gr)
            {
                Console.WriteLine($"Номер компьютера {item.Code}, наименование {item.Name}");
            }
            Console.WriteLine();
        }

        Computer computerMaxPrice = computerList.OrderByDescending(x => x.Price).FirstOrDefault();
        Computer computerMinPrice = computerList.OrderBy(x => x.Price).FirstOrDefault();
        Console.WriteLine($"Самая высокая цена у компьютера {computerMaxPrice.Name} = {computerMaxPrice.Price}, самая низкая цена у компьютера {computerMinPrice.Name} = {computerMinPrice.Price}");

        Console.WriteLine($"Есть ли хотя бы один компьютер в количестве не менее 30 штук? Ответ: {(computerList.Any(x => x.AvailableQuantity >= 30) ? "Есть" : "Нет")}");
    }

    static void Print(List<Computer> computerList)
    {
        foreach (var item in computerList)
        {
            Console.WriteLine($"№ {item.Code}, name: {item.Name}, price: {item.Price}, CPU: {item.TypeCPU}, VolumeRAM: {item.VolumeRAM}.");
        }
        Console.WriteLine();
    }
}
