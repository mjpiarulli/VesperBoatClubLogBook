using System;

namespace DataAccess
{
    public class UowHelper<TUow> where TUow : UnitOfWorkBase
    {
        private readonly Func<TUow> _creator;

        public UowHelper()
        {
            _creator = null;
        }

        public UowHelper(Func<TUow> creator)
        {
            _creator = creator;
        }

        public T Uow<T>(Func<TUow, T> func)
        {
            using (var uow = _creator())
            {
                return func(uow);
            }
        }
    }
}
