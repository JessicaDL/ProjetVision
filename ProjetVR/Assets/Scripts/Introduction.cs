using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Introduction : MonoBehaviour {

    public GameObject debut, intro;
    public Text uiText;

    private float showSpeed = 0.05f;

    private string showText, uiTextCopy;

    private bool coroutineProtect, loadText;

    private void OnEnable() { uiTextCopy = null; }

    // Use this for initialization
    void Start () {
        //TextInformations();
        uiText.text = "Vous sortez d'une visite au musée dédié à la reine Victoria. \n" +
            "En vérifiant vos photos, vous remarquez que 3 nouvelles sont apparues. \n" +
            "En les regardant sur votre ordinateur via la caméra de votre téléphone, \n" +
            "vous découvrerez peut-être un trésor...";
    }
	
	// Update is called once per frame
	void Update () {
        if(intro.activeSelf == true)
        {
            if (loadText && !coroutineProtect)
            {
                StartCoroutine(LoadLetters(uiTextCopy));
                coroutineProtect = true;
            }

            else if (loadText && coroutineProtect) { uiText.text = showText; }

            else if (!loadText && !coroutineProtect)
            {
                if (uiText.text != uiTextCopy) { TextInformations(); }
                if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
                {
                    SceneManager.LoadScene("GameScene");
                }
            }
        }
    }

    public void OnClick()
    {
        debut.SetActive(false);
        intro.SetActive(true);
        TextInformations();
    }

    private void TextInformations()
    {
        uiTextCopy = uiText.text;
        showText = null;
        uiText.text = null;

        loadText = true;
        coroutineProtect = false;
    }

    private IEnumerator LoadLetters(string completeText)
    {
        int textSize = 0;

        while (textSize < completeText.Length)
        {
            showText += completeText[textSize++];
            yield return new WaitForSeconds(showSpeed);
        }

        coroutineProtect = false;
        loadText = false;
    }
}
