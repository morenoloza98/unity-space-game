using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{
    PlayerController player;
    SpawnerController spawner;
    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        GameObject goSpawner = GameObject.FindGameObjectWithTag("Spawner");
        player = go.GetComponent<PlayerController>();
        spawner = goSpawner.GetComponent<SpawnerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject == player.gameObject)
        {
            player.health.value -= 0.05f;
        }
        else
        {
            player.score += 5;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}
