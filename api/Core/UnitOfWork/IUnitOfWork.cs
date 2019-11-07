using api.Core.Repository;
using System;

namespace api.Core.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IEmisoresRepository EmisoresRepository { get; set; }
        IReceptoresRepository ReceptoresRepository { get; set; }

        void Complete();
    }
}
