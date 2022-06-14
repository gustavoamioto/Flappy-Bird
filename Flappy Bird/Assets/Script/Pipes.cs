using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime; //Faz com que os Pipes se movimentem para a esquerda baseado na velocidade e tempo
    }
}
