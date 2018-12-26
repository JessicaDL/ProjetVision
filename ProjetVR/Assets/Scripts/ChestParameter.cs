using UnityEngine;

public class ChestParameter : MonoBehaviour {

    public static ChestParameter Instance;

    public GameObject chestOpen;
    public GameObject chestClosed;
    public AudioSource openChest;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(this.gameObject);
        }
    }
}
