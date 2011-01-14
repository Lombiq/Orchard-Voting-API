using System;
using Orchard.ContentManagement.Records;

namespace Contrib.Voting.Models {
    public class VoteRecord {
        /// <summary>
        /// Votes are averaged
        /// </summary>
        public const int Average = 0;

        /// <summary>
        /// Votes are summed up
        /// </summary>
        public const int Sum = 1;

        /// <summary>
        /// Count of votes for each specific option
        /// </summary>
        public const int Option = 2;


        public virtual int Id { get; set; }
        public virtual DateTime? CreatedUtc { get; set; }
        public virtual ContentItemRecord ContentItemRecord { get; set; }
        public virtual string ContentType { get; set; }
        public virtual string Username { get; set; }


        /// <summary>
        /// The IP address of the host the vote was cast from
        /// </summary>
        public virtual string Hostname { get; set; }

        /// <summary>
        /// The actual vote
        /// </summary>
        public virtual double Value { get; set; }

        /// <summary>
        /// A text representing the axe on which the vote is applied (i.e Quality, Support, ...). 0 is the default value for an 'overall' vote.
        /// </summary>
        public virtual int Axe { get; set; }
    }
}
