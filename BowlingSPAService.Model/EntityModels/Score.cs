//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BowlingSPAService.Model.EntityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Score
    {
        public int Id { get; set; }
        public Nullable<int> BowlerId { get; set; }
        public Nullable<int> MatchId { get; set; }
        public Nullable<int> TeamId { get; set; }
        public Nullable<int> Pins { get; set; }
        public Nullable<int> Handicap { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> GameNumber { get; set; }
    
        public virtual Bowler Bowler { get; set; }
        public virtual Match Match { get; set; }
        public virtual Team Team { get; set; }
    }
}