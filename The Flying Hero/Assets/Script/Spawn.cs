using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour 
{
    public Transform[] spawns;
    public GameObject[] balas;
    public float timetoSpawn;


private void Awake()
{
        StartCoroutine(Tiro());
}

    public IEnumerator Tiro()
    {
        int spawnPos = Random.Range(0, 4);
        yield return new WaitForSeconds(timetoSpawn);
        switch (spawnPos)
        {
            case 0:
                {
                    Instantiate(balas[Random.Range(0, balas.Length)], spawns[0].position, spawns[0].rotation);
                    Debug.Log("balão 0");
                }
                break;

            case 1:
                {
                    Instantiate(balas[Random.Range(0, balas.Length)], spawns[1].position, spawns[1].rotation);
                    Debug.Log("balão 1");

                }
                break;

            case 2:
                {
                    Instantiate(balas[Random.Range(0, balas.Length)], spawns[2].position, spawns[2].rotation);
                    Debug.Log("balão 2");

                }
                break;

            case 3:
                {
                    Instantiate( balas[Random.Range(0, balas.Length)], spawns[3].position, spawns[3].rotation);
                    Debug.Log("balão 3");

                }
                break;

            case 4:
                {
                    Instantiate(balas[Random.Range(0, balas.Length)], spawns[4].position, spawns[4].rotation);
                    Debug.Log("balão 4");

                }
                break;
        }

        yield return Tiro();
    }

}
