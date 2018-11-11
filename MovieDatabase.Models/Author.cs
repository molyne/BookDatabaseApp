using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MovieDatabase.Models
{
    [DataContract]
    public class Author
    {
        public Author()
        {
            Books = new List<Book>();
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<Book> Books { get; set; }
    }
}