Console.WriteLine("Введите 7 слов через Enter :");
int n = 7;

string[] wordsInArray = new string[n];

for (int i = 0; i < wordsInArray.Length; i++) wordsInArray[i] = Console.ReadLine();

int count = 0;

foreach (var item in wordsInArray)
    if (item.Length<=3) count++;

string[] wordsOutArray = new string[count];

count=0;
for (int i = 0; i < wordsInArray.Length; i++)
{
    if (wordsInArray[i].Length <= 3) 
    {
        wordsOutArray[count] = wordsInArray[i];
        count++;
    }
}
Console.Write("Результат сортировки : ");
string str = string.Join(" ", wordsOutArray);
Console.WriteLine($"{str}\n");