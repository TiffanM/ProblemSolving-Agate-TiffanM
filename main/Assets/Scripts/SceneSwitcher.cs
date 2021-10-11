using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void Back2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    public void Back3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    public void Back4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
    public void Back5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
    public void Back6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
    }
    public void Back7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }
    public void Back8()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }
    public void Back9()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }
}
