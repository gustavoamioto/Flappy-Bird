using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipes : MonoBehaviour
{
    public GameObject Pipe;
    public float height;
    public float maxTime = 1f;
    private float timer = 0f;

    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate(Pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0); //Define uma altura aleatória entre o valor de Height para os Pipes
            Destroy(newPipe, 10f); //Destrói o Pipe depois de 10 segundos.
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
