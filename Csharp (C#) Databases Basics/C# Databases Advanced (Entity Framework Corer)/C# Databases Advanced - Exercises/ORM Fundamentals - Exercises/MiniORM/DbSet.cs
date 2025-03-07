﻿namespace MiniORM
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using System.Collections;

    public class DbSet<TEntity> : ICollection<TEntity>
        where TEntity : class, new()
    {


        internal DbSet(IEnumerable<TEntity> entitites)
        {
            this.Entities = entitites.ToList();

            this.ChangeTracker = new ChangeTracker<TEntity>(entitites);
        }

        internal ChangeTracker<TEntity> ChangeTracker { get; set; }

        internal IList<TEntity> Entities { get; set; }

        public int Count => this.Entities.Count;

        public bool IsReadOnly => this.Entities.IsReadOnly;

        public void Add(TEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "Item cannot be null.");
            }

            this.Entities.Add(item);
            this.ChangeTracker.Add(item);
        }

        public void Clear()
        {
            while (this.Entities.Any())
            {
                var entity = this.Entities.First();
                this.Remove(entity);
            }
        }

        public bool Contains(TEntity item)
        {
            return this.Entities.Contains(item);
        }

        public void CopyTo(TEntity[] array, int arrayIndex)
        {
            this.Entities.CopyTo(array, arrayIndex);
        }

        public bool Remove(TEntity item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "item cannot be null!");
            }

            var removedSuccessfuly = this.Entities.Remove(item);
            if (removedSuccessfuly)
            {
                this.ChangeTracker.Remove(item);
            }

            return removedSuccessfuly;
        }

        public IEnumerator<TEntity> GetEnumerator()
        {
            return this.Entities.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities.ToArray())
            {
                this.Remove(entity);
            }
        }
    }
}