// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int intValue = 48769414;
string strValue = "hello";
byte[] byteArray = { 47, 129, 0, 116 };
float floatValue = 491.695F;
char charValue = 'E';

using (FileStream output = File.Create("binarydata.dat"))
using(BinaryWriter writer = new BinaryWriter(output))
{
    writer.Write(intValue); 
    writer.Write(strValue);
    writer.Write(byteArray);
    writer.Write(floatValue);
    writer.Write(charValue);
}

