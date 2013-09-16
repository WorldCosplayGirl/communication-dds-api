using System;
using System.Collections.Generic;
using communication.dds.api.adapter.callback;
using communication.dds.api.adapter.publisher;
using communication.dds.api.adapter.qos;
using communication.dds.api.adapter.query;

namespace communication.dds.api.adapter
{
    public abstract class Adapter<TDataType> : IDisposable
    {
        public abstract void Dispose();

        public abstract bool Subscribe(AdapterReaderQos qos, QueryParameters queryParameters,
                                       AdapterDataCallback<TDataType> clientCallback);

        public abstract IEnumerable<TDataType> Snapshot(AdapterReaderQos qos, QueryParameters queryParameters);

        public abstract DataPublisher<TDataType> CreatePublisher(AdapterWriterQos qos, string partitionName);
    }
}