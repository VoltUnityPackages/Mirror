using Mirror.Cloud.Core;

namespace Mirror.Cloud.ListServer
{
    public abstract class ListServerBaseApi : BaseApi
    {
        protected ListServerBaseApi(ICoroutineRunner runner, IRequestCreator requestCreator) : base(runner, requestCreator)
        {
        }
    }
}
