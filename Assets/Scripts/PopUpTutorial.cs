using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpTutorial : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
    }
}
