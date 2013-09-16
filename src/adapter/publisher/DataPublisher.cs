using System;

namespace communication.dds.api.adapter.publisher
{
    public abstract class DataPublisher<TDataType> : IDisposable
    {
        public abstract void Dispose();
        public abstract string Publish(TDataType data);
    }
}