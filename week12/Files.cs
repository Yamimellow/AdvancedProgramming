using System;
using System.IO;

namespace Files
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			//Writing Files using File Streams
			FileStream t_fs = new FileStream("TextFile.txt",FileMode.Create);			
			//streams only write bytes of data , so we use a helper class to convert our 
			//texts into binary seamlesly .
			StreamWriter sw = new StreamWriter(t_fs);
			
			
			//consider that all this data will be converted into their ascii representation 
			// so numbers are converted to charcters and can be read normaly
			sw.WriteLine("Line 1{0}",5);
			sw.WriteLine("Line two , this is fairly similar to console.writeline");
			sw.WriteLine(521.0);
			
			sw.Flush();
			sw.Close();
			
			
			// while in binary the numbers are not converted and put as they were.
			FileStream b_fs = new FileStream("BinaryFile.bin",FileMode.Create);
			BinaryWriter bw = new BinaryWriter(b_fs);
			//bw.Write("Hello world , this data is in binary\n");
			//bw.Write("testing testing testing");
			bw.Write (-50);
			bw.Write (60);
			bw.Write (50.5);
			bw.Write (50.5);
			
			bw.Flush();
			bw.Close();
			
			
			
			//Reading Files using File Streams
			FileStream r_t_fs = new FileStream("Text_ToRead.txt",FileMode.Open);
			//TextReading
			StreamReader sr = new StreamReader(r_t_fs);
			
			string line1 = sr.ReadLine();
			string line2 = sr.ReadLine();			
			sr.Close();
			
			Console.WriteLine(line1);
			Console.WriteLine(line2);
			
			
			
			//Reading Binary Data 
			FileStream b_t_fs = new FileStream("BinaryFile.bin",FileMode.Open);
			BinaryReader br = new BinaryReader(b_t_fs);
			
			int i1 = br.ReadInt32();
			int i2 = br.ReadInt32();
			double d1 = br.ReadDouble();
			double d2 = br.ReadDouble();
			
			Console.WriteLine(i1);
			Console.WriteLine(i2);
			Console.WriteLine(d1);
			Console.WriteLine(d2);
			
			br.Close();
			
			
		}
	}
}
