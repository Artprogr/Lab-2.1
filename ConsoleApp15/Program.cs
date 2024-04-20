
abstract class Figure
{
    public abstract double Area();
    public abstract string Color();
    public virtual void PrintInfo()
    {
        Console.WriteLine($"Тип фигуры: {this.GetType().Name}");
    }
}

class Четырехугольник : Figure
{
    double side1, side2;
    public Четырехугольник(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public override double Area()
    {
        return side1 * side2;
    }
    public override string Color()
    {
        string s;
        string[] color = { "Красный", "Синий", "Зелёный", "Жёлтый", "Оранжевый" };
        Random random = new Random();
        s = color[random.Next(4)];
        return s;
    }
}

class Круг : Figure
{
    double radius;

    public Круг(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }
    public override string Color()
    {
        string s;
        string[] color = { "Красный", "Синий", "Зелёный", "Жёлтый", "Оранжевый" };
        Random random = new Random();
        s = color[random.Next(4)];
        return s;
    }
}

class Квадрат : Figure
{
    double side;

    public Квадрат(double side)
    {
        this.side = side;
    }

    public override double Area()
    {
        return side * side;
    }
    public override string Color()
    {
        string s;
        string[] color = { "Красный", "Синий", "Зелёный", "Жёлтый", "Оранжевый" };
        Random random = new Random();
        s = color[random.Next(4)];
        return s;
    }
}

class Ромб : Figure
{
    double side;
    double height;

    public Ромб(double side, double height)
    {
        this.side = side;
        this.height = height;
    }

    public override double Area()
    {
        return side * height;
    }
    public override string Color()
    {
        string s;
        string[] color = { "Красный", "Синий", "Зелёный", "Жёлтый", "Оранжевый" };
        Random random = new Random();
        s = color[random.Next(4)];
        return s;
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool a, b;
        int a1, b1; 
        Console.Write("Введите длинну 1: ");
        a = int.TryParse(Console.ReadLine(), out a1);
        Console.Write("Введите длинну 2: ");
        b = int.TryParse(Console.ReadLine(), out b1);
        if (a & b)
        {
            Четырехугольник quadrilateral = new Четырехугольник(a1, b1);
            Круг circle = new Круг(a1);
            Квадрат square = new Квадрат(a1);
            Ромб rhombus = new Ромб(a1, b1);

            Figure[] figures = { quadrilateral, circle, square, rhombus };

            foreach (Figure figure in figures)
            {
                double area = figure.Area();
                string color = figure.Color();
                figure.PrintInfo();
                Console.WriteLine($"Площадь: {area}");
                Console.WriteLine($"Цвет: {color}");
            }
        }
        else
        {
            Console.WriteLine("Неверный формат");
        }
    }
}