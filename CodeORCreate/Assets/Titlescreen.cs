using UnityEngine;
using UnityEngine.SceneManagement;

public class Titlescreen : MonoBehaviour
{   

    // Control menu panel
    public GameObject ControlMenuPanel;
    void Start()
    {
        // Hides control menu
        ControlMenuPanel.SetActive(false);
    }
    // Open control menu
    public void OnControls()
    {
        ControlMenuPanel.SetActive(true);
    }

    // Close control menu
    public void OnBack()
    {
        ControlMenuPanel.SetActive(false);
    }
    // Called when we click play
    public void OnPlay ()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Called when we click quit
    public void OnQuit ()
    {
        Application.Quit();
    }
}
