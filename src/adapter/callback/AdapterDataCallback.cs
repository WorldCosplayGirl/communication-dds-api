using System;

namespace communication.dds.api.adapter.callback
{
    public abstract class AdapterDataCallback<TDataType> : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public abstract void OnDataReceived(TDataType data);

        public abstract void OnError(Exception exception);

        public abstract void OnCompleted();

        protected virtual void Dispose(bool disposing)
        {
        }
    }
}