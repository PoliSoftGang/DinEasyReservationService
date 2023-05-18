namespace Domain.Repositories
{
    public interface IRepositoryManager
    {
        IPeculiarityRepository PeculiarityRepository { get; }

        ITableRepository TableRepository { get; }

        IReservationRepository ReservationRepository { get; }

        IUnitOfWork UnitOfWork { get; }
    }
}
