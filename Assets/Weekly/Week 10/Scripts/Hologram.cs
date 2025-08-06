using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Responds to events announced by the HologramManager.
/// </summary>
public class Hologram : MonoBehaviour
{
    //HologramManager manager;
    [SerializeField] private int health = 2;
    [SerializeField] private static float speed = 10.1f;

    private void OnEnable()
    {
        //HologramEvents.OnSpacebarPressed.AddListener(HideTheHologram);
        HologramEvents.onSpacebarPressed += HideTheHologram;
        HologramEvents.onReturnPressed += ShowTheHologram;
    }

    private void Start()
    {
        // normal variable
        print("Health of [" + gameObject.name + "] is [" + health + "]. Nice!");

        // static variable
        // set speed to a random value
        speed = Random.Range(1f, 10f);
        // output that random value
        print("Speed static variable set to [" + speed + "].");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            // then output the line below, announcing the speed again
            print("Speed of [" + gameObject.name + "] is [" + speed + "]. Woah!");
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            // then output the line below, announcing the speed again
            print("Current game time is: [" + GameManager.Instance.currentGameTime + "].");
        }
    }

    private void OnDisable()
    {
        //HologramEvents.OnSpacebarPressed.RemoveListener(HideTheHologram);
        HologramEvents.onSpacebarPressed -= HideTheHologram;
        HologramEvents.onReturnPressed -= ShowTheHologram;
    }

    private void HideTheHologram()
    {
        //gameObject.SetActive(false);
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    private void ShowTheHologram()
    {
        //gameObject.SetActive(true);
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
        gameObject.GetComponent<MeshRenderer>().enabled = true;
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }
}
