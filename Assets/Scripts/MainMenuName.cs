using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuName : MonoBehaviour
{
    public static MainMenuName Instance;
    public InputField nickname;
    // Start is called before the first frame update

    private void Awake()
    {
        
    }
    [System.Serializable]
    class SaveData
    {
        public InputField nickname;
    }
    public void SaveNickname()
    {
        SaveData data = new SaveData();
        data.nickname = nickname;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
}
