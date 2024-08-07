using TestKib3;

// your tests

var birthday = new DateTime(2002, 10, 19);
var day = DateTime.Now;

var age = AgeHelper.GetAge(birthday, day);

Console.WriteLine(age);


/// our tests
birthday = new DateTime(2002, 10, 19);

bool test1Success = AgeHelper.GetAge(birthday, new DateTime(2024, 10, 18)) == 21;
bool test2Success = AgeHelper.GetAge(birthday, new DateTime(2024, 10, 20)) == 22;
bool test3Success = AgeHelper.GetAge(birthday, new DateTime(2024, 9, 1)) == 21;
bool test4Success = AgeHelper.GetAge(birthday, new DateTime(2024, 11, 1)) == 22;

Console.WriteLine($"Test 1: {test1Success}");
Console.WriteLine($"Test 2: {test2Success}");
Console.WriteLine($"Test 3: {test3Success}");
Console.WriteLine($"Test 4: {test4Success}");