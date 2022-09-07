class program
{

static void Main(string[]args)
{
Console.WriteLine(DateTime.Now); //Günün tarihini yazdırır.
Console.WriteLine(DateTime.Now.Date); 
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(2));
Console.WriteLine(DateTime.Now.AddSeconds(2));
Console.WriteLine(DateTime.Now.AddMonths(2));
Console.WriteLine(DateTime.Now.AddYears(2));
Console.WriteLine(DateTime.Now.AddMilliseconds(50));

//DataTime Format

Console.WriteLine(DateTime.Now.ToString("dd")); //24
Console.WriteLine(DateTime.Now.ToString("ddd")); //sat
Console.WriteLine(DateTime.Now.ToString("dddd")); //saturday

Console.WriteLine(DateTime.Now.ToString("MM")); //04  ayn no
Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr  ay kısaltma
Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

Console.WriteLine(DateTime.Now.ToString("yy")); //22  yıl
Console.WriteLine(DateTime.Now.ToString("yyyy")); //yıl


Console.WriteLine("***Math Kütüphanesi***"); 
//Math Kütüphanesi
Console.WriteLine(Math.Abs(-25)); // mutlak değer alır
Console.WriteLine(Math.Sin(10)); // sin verir
Console.WriteLine(Math.Cos(10)); 
Console.WriteLine(Math.Tan(10)); 

Console.WriteLine(Math.Ceiling(22.3)); // üste yuvarla 23 
Console.WriteLine(Math.Round(22.3)); //alta veya üste yuvarla
Console.WriteLine(Math.Round(22.7)); //alta veya üste yuvarla
Console.WriteLine(Math.Floor(22.3)); // alta yuvarla 22

Console.WriteLine(Math.Min(2,6)); //Min değeri verir
Console.WriteLine(Math.Max(2,6)); //Min değeri verir

Console.WriteLine(Math.Pow(3,4)); //3 üzeri 4 ü verir 81
Console.WriteLine(Math.Sqrt(9)); //kare kök alır
Console.WriteLine(Math.Log(9)); //Logaritmik 9 u verir
Console.WriteLine(Math.Exp(3)); //e üzeri 3 ü verir
Console.WriteLine(Math.Log10(10)); //10 sayısının log 10 tabanındaki karşılığını verir



}
}