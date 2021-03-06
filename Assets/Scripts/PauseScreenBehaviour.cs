using UnityEngine;
using UnityEngine.SceneManagement; // SceneManager 

public class PauseScreenBehaviour : MainMenuBehaviour
{

    public static bool paused;

    [Tooltip("Reference to the pause menu object to turn on/off")]
    public GameObject pauseMenu;
    private Animator pauseAnimator;
    /// <summary> 
    /// Reloads our current level, effectively "restarting" the     
    /// game 
    /// </summary> 
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary> 
    /// Will turn our pause menu on or off 
    /// </summary> 
    /// <param name="isPaused"></param> 
    public void SetPauseMenu(bool isPaused)
    {
        paused = isPaused;

        // If the game is paused, timeScale is 0, otherwise 1 
        Time.timeScale = (paused) ? 0 : 1;
        //pauseMenu.SetActive(paused);
        if (paused) pauseAnimator.SetTrigger("Show");
        else pauseAnimator.SetTrigger("Hide");
    }

    private void Start()
    {
        if(!UnityAdController.showAds)
        {
            // If not showing ads, just start the game
            SetPauseMenu(false);
        }
        pauseAnimator = pauseMenu.GetComponent<Animator>();
        pauseAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;
    }

}