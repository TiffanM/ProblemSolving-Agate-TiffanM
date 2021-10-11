using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void Back()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("problem10");
    }
}
