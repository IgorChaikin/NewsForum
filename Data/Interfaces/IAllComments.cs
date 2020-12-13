using NewsForum.Models.ObjModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsForum.Data.Interfaces
{
    public interface IAllComments
    {
        IEnumerable<Comment> Comments { get; }
        Comment getObjectComment(int commentId);
        void addComment(Comment comment);
        void deleteComment(int commentId);
        void editComment(int commentId, Comment obj);
    }
}
