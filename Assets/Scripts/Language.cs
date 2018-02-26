using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Language : MonoBehaviour {

    public const int LANG_EN = 0;
    public const int LANG_RU = 1;
    public const int LANG_DE = 2;

    [SerializeField] private string english;
    [SerializeField] private string russian;
    [SerializeField] private string german;

    public static implicit operator string(Language language)
    {
        int languageId = PlayerPrefs.GetInt("language_id");
        switch (languageId)
        {
            case LANG_EN:
                return language.english;
            case LANG_RU:
                return language.russian;
            case LANG_DE:
                return language.german;
            default:
                return language.english;
        }
    }
}
