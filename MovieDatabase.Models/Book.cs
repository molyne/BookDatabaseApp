using System.Runtime.Serialization;

namespace MovieDatabase.Models
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public string Genre { get; set; }
    }
}
