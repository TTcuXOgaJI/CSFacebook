using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    class WallPostsConverter : PostConverter
    {
        protected override void RequestPostRecordsFromConverter()
        {
            if (FacebookServiceSession.IsConnected)
            {
                FacebookServiceSession.LoggedFacebookUser.ReFetch();
                PostsToPostRecordsConverter(FacebookServiceSession.LoggedFacebookUser.WallPosts);
            }
        }
    }
}
