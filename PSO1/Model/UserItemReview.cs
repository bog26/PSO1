using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO1.Model
{
    public class UserItemReview : IPSOEntity, ISearchProductId, ISearchUserId
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        User User { get; set; }
        public int ProductId { get; set; }
        Product Product { get; set; }
        public string Title { get; set; }
        public string Review { get; set; }
        public int UserItemScore { get; set; }
        public DateTime ReviewTime { get; set; }

        public UserItemReview()
        {
            ReviewTime = DateTime.Now;
        }
    }
}
