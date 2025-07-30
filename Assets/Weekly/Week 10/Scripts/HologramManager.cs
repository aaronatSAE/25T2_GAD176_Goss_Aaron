using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Announces events to show and hide and manage holograms.
/// </summary>
public class HologramManager : MonoBehaviour
{
    // access modifier          type          name                 value
    //public UnityEvent OnSpacebarPressed;   // often empty for events

    Enemy enemyPrefab;

    private void Start()
    {
        Enemy newEnemy = Instantiate(enemyPrefab);
        HologramEvents.onEnemySpawned?.Invoke(newEnemy);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Attempting to hide the cubes!");
            HologramEvents.onSpacebarPressed?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Attempting to show the cubes!");
            HologramEvents.onReturnPressed?.Invoke();
        }
    }
}
