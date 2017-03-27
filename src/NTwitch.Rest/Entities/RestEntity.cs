﻿using System;

namespace NTwitch.Rest
{
    public class RestEntity<T> : IEntity<T>
    {
        /// <summary> An instance of the client that created this entity </summary>
        public BaseRestClient Client { get; }
        /// <summary> The unique identifier for this entity </summary>
        public T Id { get; }

        public RestEntity(BaseRestClient client, T id)
        {
            Client = client;
            Id = id;
        }
        
        ITwitchClient IEntity<T>.Client 
            => throw new NotImplementedException();
    }
}
