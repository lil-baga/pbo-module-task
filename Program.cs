namespace vga
{
    class Vga
    {
        public string merk;

    }

    class Nvidia : Vga
    {
        public Nvidia()
        {
            merk = "Nvidia";
        }
    }

    class AMD : Vga
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
}

class Processor
{
    public string merk;
    public string tipe;
}

class Intel : Processor
{
    public Intel()
    {
        merk = "Intel";
    }
}

class AMD : Processor
{
    public AMD()
    {
        merk = "AMD";
    }
}

class Corei3 : Intel
{
    public Corei3()
    {
        tipe = "Core i3";
    }
}

class Corei5 : Intel
{
    public Corei5()
    {
        tipe = "Core i5";
    }
}

class Corei7 : Intel
{
    public Corei7()
    {
        tipe = "Core i7";
    }
}


class Ryzen : AMD
{
    public Ryzen()
    {
        tipe = "RAYZEN";
    }
}


class Athlon : AMD
{
    public Athlon()
    {
        tipe = "ATHLON";
    }
}

class Laptop
{
public string merk;
public string tipe;
public vga.Vga vga;
public Processor processor;

public void LaptopDinyalakan()
{
    Console.WriteLine($"Laptop {merk} Tipe {tipe} menyala");
}

public void LaptopDimatikan()
{
    Console.WriteLine($"Laptop {merk} Tipe {tipe} mati");
}
}

class ASUS : Laptop
{
public ASUS()
{
    merk = "ASUS";
}
}

class ROG : ASUS
{
public ROG()
{
    tipe = "ROG";
}
}
class Vivobook : ASUS
{
public Vivobook()
{
    tipe = "Vivobook";
}

public void Ngoding()
{
    Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
}
}

class ACER : Laptop
{
public ACER()
{
    merk = "ACER";
}
}

class Swift : ACER
{
public Swift()
{
    tipe = "Swift";
}
}

class Predator : ACER
{
public Predator()
{
    tipe = "Predator";
}

public void BermainGame()
{
    Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
}
}

class Lenovo : Laptop
{
public Lenovo()
{
    merk = "Lenovo";
}
}

class IdeaPad : Lenovo
{
public IdeaPad()
{
    tipe = "IdeaPad";
}
}

class Legion : Lenovo
{
public Legion()
{
    tipe = "Legion";
}
}

class Program
{
    static void Main(string[] args)
    {
        Processor processor1 = new Processor();
        processor1 = new Corei5();

        vga.Vga vga1 = new vga.Vga();
        vga1 = new vga.Nvidia();

        Laptop laptop1 = new Laptop();
        laptop1 = new Vivobook();
        laptop1.vga = vga1;
        laptop1.processor = processor1;
        Console.WriteLine($"Laptop: {laptop1.merk} {laptop1.tipe}");
        Console.WriteLine($"VGA: {laptop1.vga.merk}");
        Console.WriteLine($"Processor: {laptop1.processor.merk} {laptop1.processor.tipe}\n");
        //laptop1.Ngoding()
        //--------------------------------------------------------------------------------------------------------------------
        Processor processor2 = new Processor();
        processor2 = new Ryzen();

        vga.Vga vga2 = new vga.Vga();
        vga2 = new vga.AMD();

        Laptop laptop2 = new Laptop();
        laptop2 = new IdeaPad();
        laptop2.vga = vga2;
        laptop2.processor = processor2;
        Console.WriteLine($"Laptop: {laptop2.merk} {laptop2.tipe}");
        Console.WriteLine($"VGA: {laptop2.vga.merk}");
        Console.WriteLine($"Processor: {laptop2.processor.merk} {laptop2.processor.tipe}\n");
        //laptop2.LaptopDinyalakan();
        //laptop2.LaptopDimatikan();
        //--------------------------------------------------------------------------------------------------------------------
        Processor processor3 = new Processor();
        processor3 = new Corei7();

        vga.Vga vga3 = new vga.Vga();
        vga3 = new vga.AMD();

        Predator predator = new Predator();
        predator.vga = vga3;
        predator.processor = processor3;
        Console.WriteLine($"Laptop: {predator.merk} {predator.tipe}");
        Console.WriteLine($"VGA: {predator.vga.merk}");
        Console.WriteLine($"Processor: {predator.processor.merk} {predator.processor.tipe}\n");
        //predator.BermainGame();

        //ACER acer = new Predator();
        //acer.BermainGame();
    }
}