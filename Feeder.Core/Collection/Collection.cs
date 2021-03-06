﻿namespace Feeder.Core.Collection
{
    using System.Collections.Generic;
    using Feed;

    public class Collection
    {
        public long Id { get; private set; }

        public string Name { get; private set; }

        public ICollection<Feed> Feeds { get; private set; }

        public static Collection New(string collectionName)
        {
            return new Collection
            {
                Name = collectionName
            };
        }

        public void UpdateCollection(string name)
        {
            Name = name;
        }
    }
}
