﻿using Model = NTwitch.Rest.API.Video;

namespace NTwitch.Rest
{
    public class RestSimpleVideo : RestEntity<string>
    {
        /// <summary> The url to this video's page </summary>
        public string Url { get; private set; }

        internal RestSimpleVideo(BaseRestClient client, string id) 
            : base(client, id) { }

        internal static RestVideo Create(BaseRestClient client, Model model)
        {
            var entity = new RestVideo(client, model.Id);
            entity.Update(model);
            return entity;
        }

        internal virtual void Update(Model model)
        {
            Url = model.Url;
        }
    }
}
