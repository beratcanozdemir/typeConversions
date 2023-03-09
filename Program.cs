Console.WriteLine("*****Implicit Conversion*****");
//Implicit Conversion (Bilinçsiz Dönüşüm)

byte a = 5;
sbyte b = 30;
short c = 10;

int d = a + b + c;
Console.WriteLine("d:" + d);

long h = d;
Console.WriteLine("h:" + h);

float e = h;
Console.WriteLine("e:" + e);

string s = "berat";
char r = 'c';
object k = (s + r + e); 
Console.WriteLine("k:" + k);



Console.WriteLine("*****Explicit Conversion*****");
//Explicit Conversion (Bilinçli Dönüşüm)

int x = 4;
byte y = (byte)x;
Console.WriteLine("y:" + y);

int z = 50;
byte t = (byte)z;
Console.WriteLine("z:" + z);

float w = 10.3f;
byte v = (byte)w;
Console.WriteLine("v:" + v);

Console.WriteLine("*****ToString Metodu*****");
//ToString Metodu

int aa = 6;
string bb = aa.ToString();
Console.WriteLine("bb:" + bb);

string cc = 12.5f.ToString();
Console.WriteLine("cc:" + cc);

Console.WriteLine("*****System.Convert Sinifi*****");
//System.Convert Sınıfı

string s1 = "10", s2 = "20";
int sayi1, sayi2;
int toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);
toplam = sayi1 + sayi2;
Console.WriteLine("Toplam:" + toplam);

Console.WriteLine("*****Parse Metodu*****");
//Parse Metodu

string m1 = "10";
string m2 = "10.25";

int i1;
double d1;

i1 = Int32.Parse(m1);
Console.WriteLine("i1:" + i1);

d1 = Double.Parse(m2);
Console.WriteLine("d1:" + d1);