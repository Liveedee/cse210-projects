using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "The sun is shining";
        video1._author = "olivia harris";
        video1._length = 0;
        video1.vi


        Video video2 = new Video();
        video2._title = "";
        video2._author = "";
        video2._length = 0;



        Comment comment1 = new Comment();
        comment1._comment = "great video!";
        comment1._commenter = "Somebody";
        comment1._commentAmount = 0;

        video1.DisplayAll();
        comment1.DisplayCommentInfo();



    }
}