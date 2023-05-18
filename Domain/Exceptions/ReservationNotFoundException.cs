using Domain.Entities;
using System;

namespace Domain.Exceptions
{
    public sealed class ReservationNotFoundException : NotFoundException
    {
        public ReservationNotFoundException(Guid reservationId)
            : base($"The reservation with the identifier {reservationd} was not found.")
        {
        }
    }
}
