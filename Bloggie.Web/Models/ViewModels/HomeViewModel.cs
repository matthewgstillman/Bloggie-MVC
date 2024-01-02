using Bloggie.Web.Models.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Bloggie.Web.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<BlogPost> BlogPosts { get; set; }

        public IEnumerable<Tag> Tags { get; set; }
    }
}
