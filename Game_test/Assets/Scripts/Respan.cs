using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respan : MonoBehaviour

{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision gameObjectInformation)
    {
        if (gameObjectInformation.gameObject.name == "Sphere")
        {
            Debug.Log("Collision Detected");
            SceneManager.LoadScene("Level1");


        }
    }
}
