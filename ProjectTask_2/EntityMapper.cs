using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgectTask_2
{
    public class EntityMapper
    {
        public Dictionary<int, List<Entity>> MapIntoDictionary(List<Entity> entities)
        {
            var dictionary = new Dictionary<int, List<Entity>>();

            foreach (var entity in entities)
            {
                dictionary.TryAdd(entity.ParentId, entities
                    .Where(e => e.ParentId == entity.ParentId)
                    .ToList());
            }

            return dictionary;
        }
    }
}