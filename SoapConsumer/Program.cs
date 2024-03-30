Console.WriteLine("Soap Consumer Demo!");

SoapServiceReference.MathServiceClient mathServiceClient = new SoapServiceReference.MathServiceClient();

int a = 20;
int b = 10;
int res;

Console.WriteLine("Test add ...");
res = await mathServiceClient.AddAsync(a, b);
Console.WriteLine($"{a} + {b} = {res}");

Console.WriteLine("Test subtract ...");
res = await mathServiceClient.SubtractAsync(a, b);
Console.WriteLine($"{a} - {b} = {res}");

Console.WriteLine("Test multiply ...");
res = await mathServiceClient.MultiplyAsync(a, b);
Console.WriteLine($"{a} * {b} = {res}");

Console.WriteLine("Test devide ...");
res = await mathServiceClient.DevideAsync(a, b);
Console.WriteLine($"{a} / {b} = {res}");
