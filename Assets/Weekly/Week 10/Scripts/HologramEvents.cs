using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Holds a variety of events that can be called to do with holograms.
/// </summary>
public static class HologramEvents
{
    //public UnityEvent OnSpacebarPressed;

    // A kind of template for our events
    public delegate void DelegateThatDoesNotPassDataForward();
    public delegate void DelegateThatReturnsAnEnemy(Enemy enemy);

    // Our event, to be called when spacebar is pressed
    public static DelegateThatDoesNotPassDataForward onSpacebarPressed;
    public static DelegateThatDoesNotPassDataForward onReturnPressed;
    public static DelegateThatDoesNotPassDataForward onPlayerCharacterDetected;
    public static DelegateThatReturnsAnEnemy onEnemySpawned;
}

public class Enemy : MonoBehaviour
{

}