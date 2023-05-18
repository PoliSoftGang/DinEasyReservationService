using System;

namespace Domain.Exceptions
{
    public sealed class PeculiarityNotFoundException : NotFoundException
    {
        public PeculiarityNotFoundException(Guid tableId)
            : base($"The table with the identifier {tableId} was not found.")
        {
        }
    }
}
