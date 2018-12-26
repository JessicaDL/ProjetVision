using UnityEngine;
using UnityEngine.UI;

public class ProgressTouch : MonoBehaviour {

    public Text textProgression;
    private int clicCount;

	// Use this for initialization
	void Start () {
        clicCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        clicCount++;

        if(clicCount == 1)
        {
            textProgression.fontSize = 30;
            textProgression.text = "Vous avez trouvé " + GameConstants.FindClues + " / " + GameConstants.TotalClues + " indices";
            clicCount = 1;
        }

        if(clicCount == 2)
        {
            textProgression.text = "";
            clicCount = 0;
        }
    }       
}
