﻿
namespace _07.Military_Elite.Models
{
    using _07.Military_Elite.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LieutenantGeneral :Private, ILieutenantGeneral
    {
        private ICollection<ISoldier> privates;
        public LieutenantGeneral(int id,
            string firstName,
            string lastName, 
            decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<ISoldier>();
        }

        public IReadOnlyCollection<ISoldier> Privates 
            => (IReadOnlyCollection<ISoldier>)this.privates;

        public void AddPrivate(ISoldier @private)
        {
            this.privates.Add(@private);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine("Privates:");
            foreach (var privat in this.privates)
            {
                sb.AppendLine($"  {privat.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
