using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Fall : MonoBehaviour
{
    [SerializeField]
    public int number;
    [SerializeField]
    public UpdateScore currentScore;

    private void OnCollisionEnter(Collision sphere)
    {

        foreach (ContactPoint contact in sphere.contacts)
        {
            sphere.transform.position = new Vector3(0.0f, -0.70f, 0.0f);
            
            

            currentScore.NewScore(number);
            

        }

    }
}
