using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Spawner : MonoBehaviour
{
    public GameObject PipePrefab;
    float time = 0;
    public float spawn_time = 1;
    public float upper_limit = -2;
    public float lower_limit = -9;
    void Update()
    {
        time += Time.deltaTime;
        if (time >= spawn_time)
        {
            GameObject PipeClone = Instantiate(PipePrefab);
            PipeClone.transform.position = new Vector3(13, Random.Range(lower_limit, upper_limit));
            time = 0;
        }
    }
}
