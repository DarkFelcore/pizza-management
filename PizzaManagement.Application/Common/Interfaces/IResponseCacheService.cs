namespace PizzaManagement.Application.Common.Interfaces
{
    public interface IResponseCacheService
    {
        Task CacheResponseAsync(string cacheKey, object response, TimeSpan timeToLive);
        Task<string?> GetCachedResponseAsync(string cacheKey);
        Task DeleteCacheKey(string cacheKey);
        void SetResetAllRecipeCache(bool status);
        bool GetResetAllRecipeCache();
    }
}