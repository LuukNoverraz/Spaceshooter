using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleClick : MonoBehaviour
{
    public Button titleButton;
    void Start()
    {
        titleButton.GetComponent<Button>().onClick.AddListener(LoadGame);
    }
    void LoadGame()
    {
        Debug.Log("ok");
        SceneManager.LoadScene("Main");
    }
}
