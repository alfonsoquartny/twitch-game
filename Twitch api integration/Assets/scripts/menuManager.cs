using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuManager : MonoBehaviour
{
    public playerInformations informations;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
  public void Buttonlar(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);

    }
    public void exit()
    {
        Application.Quit();
    }
}
