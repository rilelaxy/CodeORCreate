using UnityEngine;
using UnityEngine.UI;


public class PCH : MonoBehaviour
{
    // Start is called before the first frame update
    public Image hatImage;
    public Sprite Hat0;
    public Sprite Hat1;
    public Sprite Hat2;
    public Sprite Hat3;
    public Sprite Hat4;
    public Sprite Hat5;
    public Sprite Hat6;
    public Sprite Hat7;
    public Sprite Hat8;
    public Sprite Hat9;
    public Sprite Hat10;
    public Button HatButton;

    private Sprite[] hatOptions;
    private int currentHatIndex = 0;

    private void Start()
    {
        hatOptions = new Sprite[] { Hat0, Hat1, Hat3, Hat4, Hat5, Hat6, Hat7, Hat8, Hat9, Hat10, };
        HatButton.onClick.AddListener(ChangeHat);
    }

    private void ChangeHat()
    {
        currentHatIndex = (currentHatIndex + 1) % hatOptions.Length;
        hatImage.sprite = hatOptions[currentHatIndex];
    }

}
