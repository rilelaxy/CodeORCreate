using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomization : MonoBehaviour
{
    public Image eyeImage;  
    public Sprite Eye0;
    public Sprite Eye1;
    public Sprite Eye2;
    public Sprite Eye3;
    public Sprite Eye4;
    public Sprite Eye5;
    public Sprite Eye6;
    public Sprite Eye7;
    public Sprite Eye8;
    public Sprite Eye9;
    public Sprite Eye10;
    public Button EyeButton;

    private Sprite[] eyeOptions; 
    private int currentEyeIndex = 0; 

    private void Start()
    {
        eyeOptions = new Sprite[] {Eye0, Eye1, Eye3, Eye4, Eye5, Eye6, Eye7, Eye8, Eye9, Eye10,};
        EyeButton.onClick.AddListener(ChangeEye);
    }

    private void ChangeEye()
    {
        currentEyeIndex = (currentEyeIndex + 1) % eyeOptions.Length;
        eyeImage.sprite = eyeOptions[currentEyeIndex];
    }

}

