﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;


namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    public static class FacebookServiceSession
    {
        private static LoginResult s_LoginResult = null;

        static FacebookServiceSession()
        {
            FacebookService.s_CollectionLimit = 50;
        }

        public static User LoggedFacebookUser
        {
            get
            {
                return s_LoginResult.LoggedInUser;
            }
        }

        public static bool IsConnected
        {
            get
            {
                return s_LoginResult != null ? !string.IsNullOrEmpty(s_LoginResult.AccessToken) : false;
            }
        }

        public static string AccessToken
        {
            get
            {
                return s_LoginResult.AccessToken;
            }
        }

        public static string ErrorMessage
        {
            get
            {
                return s_LoginResult.ErrorMessage;
            }
        }

        public static bool TryToLogIn()
        {
            s_LoginResult = FacebookService.Login("909882489077378", "user_birthday", "email", "user_hometown", "user_about_me", "user_photos", "publish_actions", "user_status", "user_tagged_places", "read_stream", "user_groups", "user_friends");//, "user_about_me", "user_friends", "publish_actions", "user_events", "user_posts", "user_photos", "user_birthday",
                                                                                                                                                                                                                                                      // "user_status", "read_stream", "user_posts", "user_birthday", "email", "user_hometown", "user_about_me", "user_photos", "publish_actions", "user_status", "user_tagged_places", "read_stream", "user_groups", "user_friends");

            return IsConnected;

        }

        public static void Logout()
        {
            FacebookService.Logout(null);
            s_LoginResult = null;
        }
    }

}