using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuManager : MonoBehaviour
{
    public static MainMenuManager scene1;
    public TMP_InputField inputField;

    public string player_name_key = "player_name";
    public string player_name;
    // Start is called before the first frame update

    private void Start()
    {
        player_name = PlayerPrefs.GetString(player_name_key, "");
        inputField.text = player_name;
    }

    private void Update()
    {
        
    }
    /*private void Awake()
    {
        if(scene1 == null)
        {
            scene1 = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }*/
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

    public void StartNew()
    {
        PlayerPrefs.SetString(player_name_key, inputField.text);
        PlayerPrefs.Save();
        SceneManager.LoadScene(1);
    }

}
