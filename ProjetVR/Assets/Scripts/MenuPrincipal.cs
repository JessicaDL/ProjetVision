using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour {

    public void MenuOnClick()
    {
        SceneManager.LoadScene("Introduction");
    }
}
