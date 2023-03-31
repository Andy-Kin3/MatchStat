using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchStat.DataModel.DataModels
{
    public class MyMatchStoredProcedure: IItemsWithIdField
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int Team1Id { get; set; }
        public int TeamOneScore { get; set; }
        public int TeamTwoScore { get; set; }

        public int Team2Id { get; set; }

        public int? TournamentId { get; set; }

        public int FieldId { get; set; }
    }
}
