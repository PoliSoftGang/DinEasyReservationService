using System;

namespace Domain.Exceptions
{
    public sealed class TableNotFoundException : NotFoundException
    {
        public TableNotFoundException(int TableId)
            : base($"The table with the identifier {TableId} was not found.")
        {
        }
    }
}
