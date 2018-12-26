using UnityEngine;

public class EndButton : MonoBehaviour
{
    string boutonName;
    public GameObject effect1, effect2, menu, coffre;
    public AudioSource son;

    void Start () {
    }

    void Update() {
		if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray, out Hit))
            {
                boutonName = Hit.transform.name;
                switch(boutonName)
                {
                    case "BoutonCoffre":
                        ChestParameter.Instance.chestClosed.SetActive(false);
                        ChestParameter.Instance.chestOpen.SetActive(true);
                        effect1.SetActive(true);
                        effect2.SetActive(true);
                        menu.SetActive(true);
                        ChestParameter.Instance.openChest.Play();
                        son.PlayDelayed(1.0f);
                        coffre.GetComponent<BoxCollider>().enabled = false;
                        break;
                }
            }
        }

        if (son.time > 5.0f)
        {
            son.Stop();
        }
    }
}
