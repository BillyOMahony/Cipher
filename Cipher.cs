using System;

public class Cypher{

	public static void Main(){
		while(1==1){
			char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz_-!?/~#:=+,.;:@|<>{}[]()*&^%$€£".ToCharArray();
			int length = alphabet.Length;

			int offset = GetOffset();

			Console.WriteLine("Enter word to change");

			string input;
			input = Console.ReadLine();

			char[] inputArray = input.ToCharArray();

			for(int x = 0; x <= inputArray.Length - 1; x++){

				int index = Array.IndexOf(alphabet, inputArray[x]);

				int newIndex = index + offset;

				int alphabetLength = alphabet.Length;
				
				while(newIndex >= alphabetLength){
					newIndex = newIndex - alphabetLength;
				}

				while(newIndex < 0){
					newIndex = newIndex + alphabetLength;
				}

				inputArray[x] = alphabet[newIndex];

			}

			string output = new string(inputArray);
			Console.WriteLine(output);

			Console.ReadKey();       	

		}
	}	

	public static int GetOffset(){

		int num = 0;

		string input;
		
		while(num < 1){
			Console.WriteLine("Enter Offset Value");
			input = Console.ReadLine();
			Int32.TryParse(input, out num);
		}

		return num;
	}

}