using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour {

    public GameObject menu;
	
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3);
        menu.SetActive(true);
    }

    public void StartButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("AR"); 
    }

    public void CloseButton()
    {
        Application.Quit();
    }
}
