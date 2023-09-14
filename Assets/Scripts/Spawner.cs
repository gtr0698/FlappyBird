using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    [SerializeField] float time = 2f;
    [SerializeField] float minY = -2f, maxY = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), time, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn(){
        GameObject newPipes = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        newPipes.transform.position += new Vector3(0, Random.Range(minY, maxY));
    }
}
