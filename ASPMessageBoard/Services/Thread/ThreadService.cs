using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASPMessageBoard.Models;
using ASPMessageBoard.Data;

namespace ASPMessageBoard.Services
{
    public class ThreadService : IThreadService
    {
        private ASPMessageBoardDbContext context;

        public ThreadService()
        {
            this.context = new ASPMessageBoardDbContext();
        }

        public void SaveThread(Thread thread)
        {
            this.context.Threads.Add(thread);
            this.context.SaveChanges();
        }

        public List<Thread> GetAll()
        {
          return this.context.Threads.ToList();
        }

        public Thread GetByID(int id)
        {
            return this.context.Threads.Where(x => x.Id == id).SingleOrDefault();
        }
    }
}