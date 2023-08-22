using Hanssens.Net;
using TheWildNature.MVC.Contracts;

namespace TheWildNature.MVC.Services
{
    public class LocalStorageService : ILocalStorageService
    {
        private LocalStorage _localStorage;
        public LocalStorageService()
        {
                var config = new LocalStorageConfiguration() 
                {
                    AutoLoad= true,
                    AutoSave= true,
                    Filename= "TheWildNature"

                };
            _localStorage = new LocalStorage(config);
        }
        public void ClearStorge(List<string> Keys)
        {
           foreach(var key in Keys)
            {
                _localStorage.Remove(key);
            }
        }
        public void SetStorageValue<T>(string Key, T Value)
        {
            _localStorage.Store(Key, Value);
            _localStorage.Persist();
        }
        public T GetStorageValue<T>(string Key)
        {
           return _localStorage.Get<T>(Key);
        }
        public bool Exists(string Key)
        {
            return _localStorage.Exists(Key);
        }



    }
}
