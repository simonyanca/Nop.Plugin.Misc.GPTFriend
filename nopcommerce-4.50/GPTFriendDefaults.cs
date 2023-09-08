using Nop.Core;
using Nop.Core.Caching;

namespace Nop.Plugin.Misc.GPTFriend
{
    //test
    /// <summary>
    /// Represents plugin constants
    /// </summary>
    public static class GPTFriendDefaults
    {
		/// <summary>
		/// Gets a name of the view component to embed tracking script on pages
		/// </summary>
		public const string TRACKING_VIEW_COMPONENT_NAME = "GPTFriend";

		/// <summary>
		/// Gets a plugin system name
		/// </summary>
		public static string SystemName => "Misc.GPTFriend";

        public const string RedirectionsRulesStringKey = "Nop.Plugin.Misc.GPTFriend.Redirections.Rules";
        public static CacheKey RedirectionsRulesCacheKey => new(RedirectionsRulesStringKey);
    }
}