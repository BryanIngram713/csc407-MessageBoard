using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPMessageBoard.Models;

namespace ASPMessageBoard.Services
{
    public interface ICommentService
    {
        void SaveComment(Comment comment);


    }
}
