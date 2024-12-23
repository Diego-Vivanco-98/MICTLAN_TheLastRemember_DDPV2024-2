using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{

    public GameObject menu_EndGame;

    public GameObject creditos;
    public GameObject creditos2;
    public GameObject creditos3;

    public Button creditsButton;
    public Button exitButton;
    public Button backFromOptionsButton;
    public Button backFromCreditsButton;
    public Button nextCredits2Button;
    public Button nextCredits3Button;
    // Start is called before the first frame update
    void Start()
    {
        creditsButton.onClick.AddListener(MuestraCreditos);
        backFromCreditsButton.onClick.AddListener(MuestraEndGame);
        nextCredits2Button.onClick.AddListener(MuestraCreditos2);
        nextCredits3Button.onClick.AddListener(MuestraCreditos3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Salir()
    {
        Application.Quit();
    }
    public void MuestraEndGame()
    {
        LimpiaPanels();
        menu_EndGame.SetActive(true);
    }
    public void MuestraCreditos()
    {
        //CleanPanels();
        LimpiaPanels();
        creditos.SetActive(true);
    }

    public void MuestraCreditos2()
    {
        LimpiaPanels();
        creditos2.SetActive(true);
    }

    public void MuestraCreditos3()
    {
        LimpiaPanels();
        creditos3.SetActive(true);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LimpiaPanels()
    {
        menu_EndGame.SetActive(false);
        creditos.SetActive(false);
        creditos2.SetActive(false);
        creditos3.SetActive(false);
    }
}
