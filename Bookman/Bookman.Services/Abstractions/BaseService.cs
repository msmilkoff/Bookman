using Bookman.Data;

namespace Bookman.Services.Abstractions
{
    public abstract class BaseService
    {
        protected IBookmanData Data;

        protected BaseService(IBookmanData data)
        {
            this.Data = data;
        }
    }
}
