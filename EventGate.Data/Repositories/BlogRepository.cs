using EventGate.Data.Entity;
using EventGate.Data.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventGate.Data.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AppDbContext _appDbContext;

        public BlogRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        //Get All Blog
        public async Task<List<Blog>> GetAllAsync()
        {
            var list = await _appDbContext.Blogs.Where(x => x.DeletedTime == null)
                .Include(ev => ev.Author)
                .Include(ev => ev.Event).ToListAsync();
            return list;
        }

        //Get All Deleted Blog
        public async Task<List<Blog>> GetAllDeletedAsync()
        {
            var list = await _appDbContext.Blogs.Where(x => x.DeletedTime != null)
                 .Include(ev => ev.Author)
                 .Include(ev => ev.Event)
                .ToListAsync();
            return list;
        }

        //Get EventFeedBack By Id
        public async Task<Blog> GetByIdAsync(string id)
        {
            var existUserEvent = await _appDbContext.Blogs
                .Where(user => user.DeletedTime == null)
                .Include(ev => ev.Author)
                .Include(ev => ev.Event)
                .FirstOrDefaultAsync(user => user.AuthorID == id);
            return existUserEvent;
        }

        //Add EventFeedBack
        public async Task<int> AddEventFeedBackAsync(Blog blog)
        {
            _appDbContext.Blogs.Add(blog);
            return await _appDbContext.SaveChangesAsync();
        }

        //Update Blog
        public async Task<int> UpdateAsync(Blog Blog)
        {
            _appDbContext.Blogs.Update(Blog);
            return await _appDbContext.SaveChangesAsync();
        }

        //Delete Blog
        public async Task<int> DeleteAsync(Blog Blog)
        {
            Blog.DeletedTime = DateTime.Now;
            return await _appDbContext.SaveChangesAsync();
        }
    }
}
