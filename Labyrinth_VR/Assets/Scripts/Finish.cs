using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject FinalDisplay;  

    private void OnCollisionEnter(Collision sphere)
    {

        foreach (ContactPoint contact in sphere.contacts)
        {
            sphere.transform.position = new Vector3(0.0f, -0.70f, 0.0f);

            FinalDisplay.SetActive(true);

        }

    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
