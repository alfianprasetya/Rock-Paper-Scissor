using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject creditsCanvas;
    [SerializeField] GameObject optionsCanvas;
  public void Player1()
  {
    SceneManager.LoadScene("Battle");
  }

  public void Player2()
  {
    SceneManager.LoadScene("Battle2");
  }

  public void Quit()
  {
    Application.Quit();
  }
}
