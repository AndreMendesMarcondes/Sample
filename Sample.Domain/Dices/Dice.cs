using System;

namespace Sample.Domain.Dices
{
    public class Dice : IDice
    {
        public Dice()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; protected set; }
        public int Number { get; protected set; }

        public int Roll()
        {
            Number = 6;
            return Number;
        }
    }
}
