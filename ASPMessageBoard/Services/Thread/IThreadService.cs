using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASPMessageBoard.Models;

namespace ASPMessageBoard.Services
{
    public interface IThreadService
    {
        void SaveThread(Thread thread);
        List<Thread> GetAll();
        Thread GetByID(int id);
    }

}
