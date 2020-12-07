using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsForum.Data.Interfaces;
using NewsForum.Models.ObjModels;

namespace NewsForum.Data.Repository
{
    public class CommentRepository : IAllComments
    {
        private readonly ApplicationDbContext appDBContent;

        public CommentRepository(ApplicationDbContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Comment> Comments => appDBContent.Comments.Include(c => c.News);

        public void addComment(Comment comment)
        {
            appDBContent.Comments.AddRange(comment);
            appDBContent.SaveChanges();
        }

        public void deleteComment(int commentId)
        {
            Comment c = appDBContent.Comments.Where(c => c.Id == commentId).FirstOrDefault();
            if (c != null)
            {
                appDBContent.Comments.Remove(c);
                appDBContent.SaveChanges();
            }
        }

        public void editComment(int commentId, Comment obj)
        {
            Comment c = appDBContent.Comments.Where(c => c.Id == commentId).FirstOrDefault();
            if (c != null)
            {
                c.Text = obj.Text;
            }
        }

        public Comment getObjectComment(int commentId) =>
           appDBContent.Comments.FirstOrDefault(p => p.Id == commentId);
    }
}
