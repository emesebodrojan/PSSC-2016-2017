using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{

    public abstract class Entity<T> : IEquatable<T>
    {
        public T Id { get; protected set; }

        public Entity(T id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            return this.Equals((T) obj);
        }

        public bool Equals(T other)
        {
            return Id.Equals(other);
        }

        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode();
        }
    }
}
