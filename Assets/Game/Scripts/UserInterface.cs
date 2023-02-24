using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using Unity.VisualScripting;

public class UserInterface : MonoBehaviour
{
    private static UserInterface userInterfaceInstance;

    [SerializeField] GameObject canvasBackground;
    [Space(15)]
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject levelsMenu;
    [SerializeField] private GameObject shopMenu;
    [SerializeField] private GameObject settingsMenu;
    [SerializeField] private GameObject gameMenu;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject deadMenu;


    private void Start()
    {
        DontDestroyOnLoad(this);

        if(userInterfaceInstance == null)
        {
            userInterfaceInstance = this;
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }

    #region MainMenu
    public void btn_PlayButton() 
    {
        GetObjectComponent(mainMenu).SetTrigger("HideMenu");
        GetObjectComponent(levelsMenu).SetTrigger("ShowMenu");
    }

    public void btn_ShopButton() 
    {
        GetObjectComponent(mainMenu).SetTrigger("HideMenu");
        GetObjectComponent(shopMenu).SetTrigger("ShowMenu");
    }

    public void btn_Settings()
    {
        GetObjectComponent(mainMenu).SetTrigger("HideMenu");
        GetObjectComponent(settingsMenu).SetTrigger("ShowMenu");
    }

    public void btn_AllGames()
    {
        //Open confirmation menu;
    }

    public  void btn_RateGame()
    {
        //Rate the game;
    }
    #endregion

    #region LevelsMenu
    public void btn_ExitLevels()
    {
        GetObjectComponent(levelsMenu).SetTrigger("HideMenu");
        GetObjectComponent(mainMenu).SetTrigger("ShowMenu");
    }

    public void btn_LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
        canvasBackground.SetActive(false);
        GetObjectComponent(levelsMenu).SetTrigger("HideMenu");
        GetObjectComponent(gameMenu).SetTrigger("ShowMenu");
    }
    #endregion

    #region ShopMenu
    public void btn_ExitShop()
    {
        GetObjectComponent(shopMenu).SetTrigger("HideMenu");
        GetObjectComponent(mainMenu).SetTrigger("ShowMenu");
    }
    #endregion

    #region SettingsMenu
    public void btn_ExitSettings()
    {
        GetObjectComponent(settingsMenu).SetTrigger("HideMenu");
        GetObjectComponent(mainMenu).SetTrigger("ShowMenu");
    }
    #endregion

    #region GameMenu
    public void btn_Pause()
    {
        GetObjectComponent(gameMenu).SetTrigger("HideMenu");
        GetObjectComponent(pauseMenu).SetTrigger("ShowMenu");
    }
    #endregion

    #region PauseMenu
    public void btn_Continue()
    {

    }

    public void btn_Restart()
    {

    }

    public void btn_Home()
    {

    }

    public void btn_Sounds()
    {

    }

    public void btn_Music()
    {

    }

    public void btn_AD()
    {

    }
    #endregion

    #region DeadMenu

    #endregion

    private Animator GetObjectComponent(GameObject obj)
    {
        Animator animator = obj.GetComponent<Animator>();
        return animator;
    }
}
