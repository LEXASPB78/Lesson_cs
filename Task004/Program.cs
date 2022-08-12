int number = new Random().Next(100, 1000); // [100,999] == [100,1000)
System.Console.WriteLine(number);
string str_number = number.ToString();
char digit1 = str_number [0];
char digit3 = str_number [2];
string  new_str_number = digit1.ToString()+digit3.ToString();
int  new_number = Convert.ToInt32(new_str_number);
System.Console.WriteLine(new_number);