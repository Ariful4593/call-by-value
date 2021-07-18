using System;
namespace CallByValue{
	public class NumberManifulator{
		
		public void Swap(int a, int b){
			int temp;
			temp = a;
			a = b;
			b = temp;
			
		}		
		
		public static void Main(string[] args){
			NumberManifulator n = new NumberManifulator();
			int num1, num2;
			num1 = 10;
			num2 = 20;
			Console.WriteLine("{0}, {1}", num1, num2);
			n.Swap(num1, num2);
			
			Console.WriteLine("{0}, {1}", num1, num2);
		}
	}
}

