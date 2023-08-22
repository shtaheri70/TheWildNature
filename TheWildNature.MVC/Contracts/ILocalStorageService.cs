namespace TheWildNature.MVC.Contracts
{
    public interface ILocalStorageService
    {
        void ClearStorge(List<string> Keys);
        bool Exists(string Key);
        T GetStorageValue<T> (string Key);
        void SetStorageValue<T>(string Key, T Value);


    }
}
