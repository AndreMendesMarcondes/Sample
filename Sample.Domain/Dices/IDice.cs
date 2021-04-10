namespace Sample.Domain.Dices
{
    public interface IDice : IAggregateRoot
    {
        int Roll();
    }
}
