﻿Console.WriteLine("Bilgi yarışmasına hoşgeldiniz! Aşağıdaki soruları sırayla cevaplayınız...");
int falseAnswers = 0;
Console.WriteLine("Soru 1: Türkiye Cumhuriyeti'nin başkenti neresidir? ");
Console.WriteLine("A) Ankara B) Bursa");
string answerOne = Console.ReadLine().ToLower(); //lowercasing answer to prevent case related errors
if (answerOne == "a")
{
    Console.WriteLine("Doğru cevap!");
}
else
{
    Console.WriteLine("Yanlış cevap :/");
    falseAnswers++; //increasing the number of false answers
}
Console.Write("Soru 2: 2*5-4/2=? ");
Console.WriteLine("A) 8 B) 7");
string answerTwo = Console.ReadLine().ToLower(); 
if (answerTwo == "a")
{
    Console.WriteLine("Doğru cevap!");
}
else
{
    Console.WriteLine("Yanlış cevap :/");
    falseAnswers++;
}
if (falseAnswers == 2)
{
    Console.WriteLine("Üzgünüm! Yarışmayı kaybettiniz...");
}
else //if user gave less than 2 false answers else statement runs below:
{
    Console.Write("Soru 3: Türkiye Cumhuriyeti'nin kurucusunun soyadı nedir? ");
    Console.WriteLine("A) İnönü B) Atatürk");
    string answerThree = Console.ReadLine().ToLower();
    if (answerThree == "b" && falseAnswers <= 1)
    {
        Console.WriteLine("Büyük ödülü kazandınız!"); //if user gives at least two correct answers, wins
    }
    else if (answerThree == "b" && falseAnswers > 1) 
    {
        Console.WriteLine("Doğru cevap! Ancak yarışmayı maalesef kaybettiniz...");
    }
    else
    {
        Console.WriteLine("Yanlış cevap :/ Yarışmayı kaybettiniz...");
        falseAnswers++;
    }
}