﻿using DAL.Concrete;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Menu
{
    internal class UserMenu
    {
        private string connectionString;
        private PostDal postDal; 

        public UserMenu(string connectionString) {
            this.connectionString = connectionString;
            this.postDal = new PostDal(connectionString);
        }

        public void start(UserDTO user)
        {
            getPosts(user);
            int step;
            bool flag = true;

            menuList();
            while (flag)
            {
                try
                {
                    step = Convert.ToInt32(Console.ReadLine());
                    switch (step)
                    {
                        case 1:
                            //TODO
                            menuList();
                            break;
                        case 2:
                            //TODO
                            menuList();
                            break;
                        case 3:
                            //TODO
                            menuList();
                            break;
                        case 4:
                            //TODO
                            menuList();
                            break;
                        case 0:
                            flag = false;
                            break;
                        default:
                            throw new Exception("You've inputed wrong data.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Try again, or input 0 to exit.");
                }
            }
        }

        

        private void getPosts(UserDTO user)
        {
            List<UserDTO> friends = getAllFriends(user);
            List<PostDTO> allPosts = postDal.GetAllPosts();
            List<PostDTO> post = new List<PostDTO>();

            foreach(PostDTO p in allPosts)
            {
                foreach(UserDTO u in friends){
                    if(u.UserId == p.UserID) post.Add(p);
                }
            }

            if (post == null) Console.WriteLine("List of posts is empty, your friends don't write anything:(");
            else
            {
                showPosts(post);




            }


        }

        private void showPosts(List<PostDTO> posts)
        {
            Console.WriteLine("\n\t------Posts-----");
            Console.WriteLine($"{"-PostId-"}\t{"-UserId-"}\t{"-Title-"}\t{"-Body-"}\t{"-Likes-"}");
            foreach (var p in posts)
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}\t{4}",
                        p.PostId, p.UserID, p.Title, p.Body, p.Likes);
            }
            Console.WriteLine("\n");
        }

        private void menuList()
        {
            Console.WriteLine("\t\t~MENU~");
            Console.WriteLine("1. Update prifile");
            Console.WriteLine("2. Show all friends");
            Console.WriteLine("3. Add new friend.");
            Console.WriteLine("4. Delete friend.");
            Console.WriteLine("0. Exit.");
        }

        private void updating()
        {
            //TODO
        }

        private List<UserDTO> getAllFriends(UserDTO user)
        {
            //TODO
            return null;
        }

        private void addComment()
        {
            //TODO
        }

    }
}