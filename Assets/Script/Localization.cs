using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

namespace Script
{
    public class Localization : MonoBehaviour
    {
        private bool _active = false;
        public int _localID = 0;

        public void Start()
        {
            ChangeLocale();
        }
        
        public void ChangeLocale()
        {
            if(_active == true) return;
            
            StartCoroutine(SetLocale(_localID));
        }

        private IEnumerator SetLocale(int _localId)
        {
            _active = true;
            yield return LocalizationSettings.InitializationOperation;
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localId];

            switch (_localID)
            {
                case 0 :
                    _localID += 1;
                    break;
                case 1 :
                    _localID += 1;
                    break;
                case 2 :
                    _localID += 1;
                    break;
                case 3 :
                    _localID = 0;
                    break;
            }

            _active = false;
        }
    }
}