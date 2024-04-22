using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldown = 3;
    public float lastKeyPressTime = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Time.time - lastKeyPressTime >= cooldown)
        {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastKeyPressTime = Time.time;
            Debug.Log(lastKeyPressTime);
        }
    }
    }
}
