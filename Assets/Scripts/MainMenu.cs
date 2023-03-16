using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject button;
    private int nextScene;

    void Start() 
    {
        button.transform.GetComponent<Button>().onClick.AddListener(StartTutorial); 
    }

    void StartTutorial()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextScene);
    }
}
