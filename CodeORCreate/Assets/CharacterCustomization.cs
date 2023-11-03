using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomization : MonoBehaviour
{
    public Image eyeImage;  
    public Sprite Eye0;
    public Sprite Eye1;
    public Button EyeButton;

    private Sprite[] eyeOptions; 
    private int currentEyeIndex = 0; 

    private void Start()
    {
        eyeOptions = new Sprite[] {Eye0, Eye1};
        EyeButton.onClick.AddListener(ChangeEye);
    }

    private void ChangeEye()
    {
        currentEyeIndex = (currentEyeIndex + 1) % eyeOptions.Length;
        eyeImage.sprite = eyeOptions[currentEyeIndex];
    }

}

