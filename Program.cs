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



}
}