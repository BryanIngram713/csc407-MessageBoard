using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPMessageBoard.Models;
using ASPMessageBoard.Data;

namespace ASPMessageBoard.Services
{
    public class CommentService : ICommentService
    {
        private ASPMessageBoardDbContext context;

        public CommentService()
        {
            this.context = new ASPMessageBoardDbContext();
        }

        public void SaveComment(Comment comment)
        {
            this.context.Comments.Add(comment);
            this.context.SaveChanges();
        }




    }
}