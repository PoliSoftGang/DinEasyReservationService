using Domain.Entities;
using System;

namespace Domain.Exceptions
{
    public sealed class ReservationNotFoundException : NotFoundException
    {
        public ReservationNotFoundException(int reservationId)
            : base($"The reservation with the identifier {reservationId} was not found.")
        {
        }
    }
}
