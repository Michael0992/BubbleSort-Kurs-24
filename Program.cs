namespace BubbleSort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Erstellen Sie ein int Array mit den Werten 4, 33, 7, 1, 23, 12 in genau dieser Reihenfolge.
			//Schreiben Sie dann einen Bubblesort um die Zahlen aufsteigend, von der kleinsten bis zur größten Zahl, zu sortieren. 
			//Lassen Sie sich zur Kontrolle dann das sortierte Array ausgeben. 
			//Keine verwendung der .Sort() Methode oder ähnlichen Methoden sind zulässig!


			int[] bubbleArray = { 4, 33, 7, 1, 23, 12 };
            
			Console.WriteLine($"Array vor der Sortierung: {string.Join('-', bubbleArray)}");

			for(int elementIndex = 0; elementIndex < bubbleArray.Length; elementIndex++)
			{
				for(int sortierschleife = 0; sortierschleife < bubbleArray.Length -1; sortierschleife ++)
				{
					if (bubbleArray[sortierschleife] > bubbleArray[sortierschleife+1])
					{
                        Console.WriteLine("Der Wert von sortierschleife ist größer");
						int temp = bubbleArray[sortierschleife+1];
						bubbleArray[sortierschleife+1] = bubbleArray[sortierschleife];
						bubbleArray[sortierschleife] = temp;
                    }
				}
			}

            Console.WriteLine($"Sortiert: {string.Join('-',bubbleArray)}");

        }
	}
}
