using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class log : IEntity
    {
        public int Id { get; set; }
        public DateTime date { get; set; }

        [StringLength(50)]
        public string thread { get; set; }

        [StringLength(255)]
        public string logger { get; set; }

        public string level { get; set; }

        [StringLength(4000)]
        public string message { get; set; }

        [StringLength(2000)]
        public string exception { get; set; }
    }
}