class Radio
{
    public Radio() { }
    public void TurnOn(bool On)
    {
        if (On)
            Console.WriteLine("Увiмкнули радiо...");
        else
            Console.WriteLine("Виключили радiо...");
    }
}
class Car
{
    private int СurrentSpeed;
    private int MaxSpeed;
    private string CarName;
    private Radio TheMusicBox; public Car(string CarName,
    int MaxSpeed, int СurrentSpeed)
    {
        this.CarName = CarName;
        this.MaxSpeed = MaxSpeed;
        this.СurrentSpeed = СurrentSpeed;
        TheMusicBox = new Radio();
    }
    public void ControlMusic(bool State)
    {
        TheMusicBox.TurnOn(State);
    }
    public void SpeedUp(int Delta)
    {
        СurrentSpeed += Delta;
        if (СurrentSpeed >= MaxSpeed)
{
            Console.WriteLine("Швидкiсть автомобiля " +CarName+ " бiльше максимальноi!");
            Console.WriteLine("Швидкiсть буде примусово знижена на " +(2 * Delta));
            СurrentSpeed -= 2 * Delta;
        }
        else
            Console.WriteLine("\tскорость автомобiля = " +СurrentSpeed);
    }
}
class CarApp
{
    public static void Main()
    {
        Car C1;

        C1 = new Car("Копiйка ", 100, 10);
        C1.ControlMusic(true);
        for (int i = 0; i < 10; i++)
        {
            C1.SpeedUp(20);
        }
        C1.ControlMusic(false);
    }
}
