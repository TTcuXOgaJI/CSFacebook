using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A16_Ex01_Stephan_321178253_Alex_323260620
{
    public abstract class PostConverter
    {
        private readonly List<PostRecord> r_PostRecords = new List<PostRecord>();

        public void RequestPostRecordsUpdate()
        {
            RequestPostRecordsFromConverter();
        }

        public List<PostRecord> PostRecords
        {
            get
            {
                return r_PostRecords;
            }
        }

        protected abstract void RequestPostRecordsFromConverter();

        protected void PostsToPostRecordsConverter(ICollection<Post> i_Posts)
        {
            r_PostRecords.Clear();
            foreach (Post post in i_Posts)
            {
                r_PostRecords.Add(new PostRecord(post));
            }
        }

    }
}
