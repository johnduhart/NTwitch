﻿using Model = NTwitch.Rest.API.CheerImage;

namespace NTwitch.Rest
{
    public class RestCheerImage
    {
        /// <summary> An instance of the client that created this entity </summary>
        public BaseRestClient Client { get; }
        /// <summary> The dark theme version of this cheer </summary>
        public RestCheerScale Dark { get; private set; }
        /// <summary> The light theme version of this cheer </summary>
        public RestCheerScale Light { get; private set; }

        internal RestCheerImage(BaseRestClient client, Model model)
        {
            Client = client;
        }
        
        internal virtual void Update(Model model)
        {
            Dark = new RestCheerScale(Client, model.Dark);
            Light = new RestCheerScale(Client, model.Light);
        }
    }
}
