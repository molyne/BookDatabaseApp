using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MovieDatabase.Models
{
    [DataContract]
    public class Book
    {
        public Book()
        {
            Authors = new List<Author>();
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public List<Author> Authors { get; set; }
    }
}
