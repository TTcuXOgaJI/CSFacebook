using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    public class PostRecord
    {
        private readonly Post r_Post;

        public PostRecord(Post i_Post)
        {
            r_Post = i_Post;
        }

        //public Post getPost
        //{
        //    get
        //    {
        //        return r_Post;
        //    }
        //}
        public string Message
        {
            get
            {
                return r_Post.Message != null ? r_Post.Message : string.Empty;
            }
        }

        public string From
        {
            get
            {
                return r_Post.From != null ? r_Post.From.Name : string.Empty;
            }
        }

        public string Name
        {
            get
            {
                return r_Post.Name != null ? r_Post.Name : string.Empty;
            }
        }

        public string Type
        {
            get
            {
                return r_Post.Type != null ? r_Post.Type.ToString() : string.Empty;
            }
        }

        public string Link
        {
            get
            {
                return r_Post.Link != null ? r_Post.Link : string.Empty;
            }
        }

        public DateTime? CreatedTime
        {
            get
            {
                return r_Post.CreatedTime;
            }
        }

        public DateTime? UpdateTime
        {
            get
            {
                return r_Post.UpdateTime;
            }
        }
    }
}
