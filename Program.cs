string[] arr = { "hello", "2", "world", ":-)" };

string[] arrresult = Array.FindAll(arr, (item) => item.Length < 4);
Console.WriteLine(String.Join(", ", arrresult));