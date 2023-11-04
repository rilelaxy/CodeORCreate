using UnityEngine;
using UnityEngine.UI;

public class CharacterController2 : MonoBehaviour
{
    public Image hairImage;
    public Sprite Hair0;
    public Sprite Hair1;
    public Sprite Hair2;
    public Sprite Hair3;
    public Sprite Hair4;
    public Sprite Hair5;
    public Sprite Hair6;
    public Sprite Hair7;
    public Sprite Hair8;
    public Sprite Hair9;
    public Sprite Hair10;
    public Button HairButton;

    private Sprite[] hairOptions;
    private int currentHairIndex = 0;

    private void Start()
    {
        hairOptions = new Sprite[] { Hair0, Hair1, Hair3, Hair4, Hair5, Hair6, Hair7, Hair8, Hair9, Hair10, };
        HairButton.onClick.AddListener(ChangeHair);
    }

    private void ChangeHair()
    {
        currentHairIndex = (currentHairIndex + 1) % hairOptions.Length;
        hairImage.sprite = hairOptions[currentHairIndex];
    }

}
