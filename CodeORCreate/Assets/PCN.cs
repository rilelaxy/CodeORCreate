using UnityEngine;
using UnityEngine.UI;


public class PCN: MonoBehaviour
{
    // Start is called before the first frame update
    public Image mouthImage;
    public Sprite Mouth0;
    public Sprite Mouth1;
    public Sprite Mouth2;
    public Sprite Mouth3;
    public Sprite Mouth4;
    public Sprite Mouth5;
    public Sprite Mouth6;
    public Sprite Mouth7;
    public Sprite Mouth8;
    public Sprite Mouth9;
    public Sprite Mouth10;
    public Button MouthButton;

    private Sprite[] mouthOptions;
    private int currentMouthIndex = 0;

    private void Start()
    {
        mouthOptions = new Sprite[] { Mouth0, Mouth1, Mouth3, Mouth4, Mouth5, Mouth6, Mouth7, Mouth8, Mouth9, Mouth10, };
        MouthButton.onClick.AddListener(ChangeMouth);
    }

    private void ChangeMouth()
    {
        currentMouthIndex = (currentMouthIndex + 1) % mouthOptions.Length;
        mouthImage.sprite = mouthOptions[currentMouthIndex];
    }

}

