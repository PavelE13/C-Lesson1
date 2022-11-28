Console.Write("Введите Ваше имя: ");
string username=Console.ReadLine();
if (username.ToLower()=="маша") {
    Console.Write("УРРА! Это Маша! ");
}
else {
    Console.Write("Привет " + username);
}