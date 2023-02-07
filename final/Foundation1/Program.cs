using System;

class Program
{
    static void Main(string[] args)
    {
       

        Comment com1 = new Comment();
        com1._username = "kelseyberta";
        com1._text = "Great video really enjoyed it";

        Comment com2 = new Comment();
        com2._username = "shanemarshall";
        com2._text = "Super funny";

        Comment com3 = new Comment();
        com3._username = "bruce2021";
        com3._text = "Gonna hit a million views";
        
        Video vid1 = new Video();
        vid1._title = "Dog jumping on trampoline";
        vid1._author = "Kelsey Berta";
        vid1._length = 30;
        vid1._comments.Add(com1);
        vid1._comments.Add(com2);
        vid1._comments.Add(com3);
        vid1.DisplayVideoInfo();

        Comment com4 = new Comment();
        com4._username = "italianfoodlover";
        com4._text = "That's my grandma";

        Comment com5 = new Comment();
        com5._username = "videowatcher";
        com5._text = "Lol everytime I don't make homemade sauce";

        Comment com6 = new Comment();
        com6._username = "dogmom";
        com6._text = "Wish this was my grandma";
        
        Video vid2 = new Video();
        vid2._title = "Italian grandma yelling at can pasta sauce";
        vid2._author = "ItalyGrammy";
        vid2._length = 70;
        vid2._comments.Add(com4);
        vid2._comments.Add(com5);
        vid2._comments.Add(com6);
        vid2.DisplayVideoInfo();

        Comment com7 = new Comment();
        com7._username = "MiddleNameDanger";
        com7._text = "That's so cool";

        Comment com8 = new Comment();
        com8._username = "CarConverter";
        com8._text = "I wish I had that car.";

        Comment com9 = new Comment();
        com9._username = "karenmom";
        com9._text = "That's so dangerous.";
        
        Video vid3 = new Video();
        vid3._title = "2023 Corvette going 140mph on highway";
        vid3._author = "CorvetteDriver";
        vid3._length = 30;
        vid3._comments.Add(com7);
        vid3._comments.Add(com8);
        vid3._comments.Add(com9);
        vid3.DisplayVideoInfo();
    }
}