﻿using Newtonsoft.Json;
using System;

namespace NTwitch.Rest.API
{
    internal class Channel
    {
        [JsonProperty("_id")]
        public ulong Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        [JsonProperty("mature")]
        public bool? IsMature { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("broadcaster_language")]
        public string BroadcasterLanguage { get; set; }
        [JsonProperty("game")]
        public string Game { get; set; }
        [JsonProperty("language")]
        public string Language { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("logo")]
        public string LogoUrl { get; set; }
        [JsonProperty("video_banner")]
        public string VideoBannerUrl { get; set; }
        [JsonProperty("profile_banner")]
        public string ProfileBannerUrl { get; set; }
        [JsonProperty("profile_banner_background_color")]
        public string ProfileBannerBackgroundColor { get; set; }
        [JsonProperty("partner")]
        public bool? IsPartner { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("views")]
        public uint Views { get; set; }
        [JsonProperty("followers")]
        public uint Followers { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("stream_key")]
        public string StreamKey { get; set; }
    }
}
