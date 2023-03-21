using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "The sun is shining";
        video1._author = "Kitty Katz";
        video1._length = 0;
        video1.Videos.Add(video1);
        

        Video video2 = new Video();
        video2._title = "Oh No, It's Raining!";
        video2._author = "Joe Finger";
        video2._length = 0;
        video2.Videos.Add(video2);


        Comment comment1video = new Comment();
        comment1video._comment = "Great Video!";
        comment1video._commenter = "Chris P. Bacon";
        comment1video._commentAmount = 0;




        Comment comment2video = new Comment();
        comment2video._comment = "Awful Video!";
        comment2video._commenter = "Mopey Longbottoms";
        comment2video._commentAmount = 0;

        video1.DisplayAll();
        comment1video.DisplayCommentInfo();
        video2.DisplayAll();
        comment2video.DisplayCommentInfo();




    }
}