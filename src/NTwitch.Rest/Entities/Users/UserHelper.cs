﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTwitch.Rest
{
    internal static class UserHelper
    {
        internal static async Task<RestChannelFollow> GetFollowAsync(BaseRestClient client, ulong userId, ulong channelId)
        {
            var token = TokenHelper.GetSingleToken(client);
            var model = await client.RestClient.GetFollowInternalAsync(token, userId, channelId);
            if (model == null) return null;

            var entity = new RestChannelFollow(client);
            entity.Update(model);
            return entity;
        }

        internal static async Task<IReadOnlyCollection<RestChannelFollow>> GetFollowsAsync(BaseRestClient client, ulong userId, SortMode sort, bool ascending, uint limit, uint offset)
        {
            var token = TokenHelper.GetSingleToken(client);
            var model = await client.RestClient.GetFollowsInternalAsync(token, userId, sort, ascending, limit, offset);
            var entity = model.Follows.Select(x =>
            {
                var follow = new RestChannelFollow(client);
                follow.Update(x);
                return follow;
            });
            return entity.ToArray();
        }

        internal static async Task<IReadOnlyDictionary<string, IEnumerable<RestEmote>>> GetEmotesAsync(BaseRestClient client, ulong userId)
        {
            var token = TokenHelper.GetSingleToken(client);
            var model = await client.RestClient.GetEmotesInternalAsync(token, userId);
            var entity = model.Emotes.Select(x =>
            {
                var values = x.Value.Select(y =>
                {
                    var emote = new RestEmote(client, y.Id);
                    emote.Update(y);
                    return emote;
                });
                return new KeyValuePair<string, IEnumerable<RestEmote>>(x.Key, values);
            });
            return entity.ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
