using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public float currentGameTime = 0;

    private void Awake()
    {
        // Make sure that we only have ONE copy of the GameManager class.
        // Destroy any copies that exist, keeping only one.
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static GameManager Instance
    {
        get { return instance; }
    }

    // Add any additional logic here.

    private void Update()
    {
        currentGameTime += Time.deltaTime;
    }
}
