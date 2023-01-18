// See https://aka.ms/new-console-template for more information
int k = 5;
Console.Clear();
for (int i = 1; i <= 3; i++)
{
  Console.WriteLine("This is loop " + i);
  for (int j = 1; j <= 3; j++)
  {
    Console.WriteLine("This is loop " + i.ToString() + "." + j.ToString());
    while (k > i)
    {
      Console.WriteLine("I am K with value " + k.ToString() + ". I am greater than my ancestor " + i.ToString() + " so I will repeat this loop.");
      k--;
    }

  }
}

