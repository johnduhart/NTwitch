﻿using Model = NTwitch.Rest.API.Ingest;

namespace NTwitch.Rest
{
    public class RestIngest : RestEntity<ulong>
    {
        /// <summary> The percentage availability of this ingest server </summary>
        public double Availability { get; private set; }
        /// <summary> True if this ingest server is default </summary>
        public bool IsDefault { get; private set; }
        /// <summary> The name of this ingest server </summary>
        public string Name { get; private set; }
        /// <summary> The url template of this ingest server </summary>
        public string UrlTemplate { get; private set; }

        internal RestIngest(BaseRestClient client, ulong id)
            : base(client, id) { }
        
        internal static RestIngest Create(BaseRestClient client, Model model)
        {
            var entity = new RestIngest(client, model.Id);
            entity.Update(model);
            return entity;
        }

        internal virtual void Update(Model model)
        {
            Availability = model.Availability;
            IsDefault = model.IsDefault;
            Name = model.Name;
            UrlTemplate = model.UrlTemplate;
        }
    }
}
