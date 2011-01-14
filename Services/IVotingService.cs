using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Contrib.Voting.Models;
using Orchard;
using Orchard.ContentManagement;

namespace Contrib.Voting.Services {
    public interface IVotingService : IDependency {
        VoteRecord Get(int voteId);
        IEnumerable<VoteRecord> Get(Expression<Func<VoteRecord, bool>> predicate);
        void RemoveVote(VoteRecord vote);
        void RemoveVote(IEnumerable<VoteRecord> votes);
        void Vote(ContentItem contentItem, string userName, string hostname, double value, int axe = 0);
        void ChangeVote(VoteRecord vote, double value);

        IEnumerable<ResultRecord> GetResults(int contentItemId, int axe = 0, string[] functions = null);
    }
}