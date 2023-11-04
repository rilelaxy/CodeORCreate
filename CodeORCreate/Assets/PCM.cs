using UnityEngine;
using UnityEngine.UI;


public class PCM : MonoBehaviour
{
    // Start is called before the first frame update
    public Image noseImage;
    public Sprite Nose0;
    public Sprite Nose1;
    public Sprite Nose2;
    public Sprite Nose3;
    public Sprite Nose4;
    public Sprite Nose5;
    public Sprite Nose6;
    public Sprite Nose7;
    public Sprite Nose8;
    public Sprite Nose9;
    public Sprite Nose10;
    public Button NoseButton;

    private Sprite[] noseOptions;
    private int currentNoseIndex = 0;

    private void Start()
    {
        noseOptions = new Sprite[] { Nose0, Nose1, Nose3, Nose4, Nose5, Nose6, Nose7, Nose8, Nose9, Nose10, };
        NoseButton.onClick.AddListener(ChangeNose);
    }

    private void ChangeNose()
    {
        currentNoseIndex = (currentNoseIndex + 1) % noseOptions.Length;
        noseImage.sprite = noseOptions[currentNoseIndex];
    }

}
