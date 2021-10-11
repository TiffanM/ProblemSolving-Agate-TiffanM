using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenProblem : MonoBehaviour
{
    //agar tombolnya ada efek scalenya
    public void Scale(float scale)
    {
        transform.localScale = new Vector2(1 / scale, 1 * scale);
    }

    public void Scene(string scene)
    {
        Application.LoadLevel(scene);
    }
}