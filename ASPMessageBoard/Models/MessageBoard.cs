using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPMessageBoard.Models
{
    public class Thread
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public string Username { get; set; }
        public DateTime DatePosted { get; set; }
    }

    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public string Username { get; set; }
        public DateTime DatePosted { get; set; }
        public int ThreadId { get; set; }
    }
}