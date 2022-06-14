using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameController controller;

    private void Start()
    {
        controller = FindObjectOfType<GameController>(); // Procurando qualquer objeto que possui um script gamecontroller
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        controller.Score++;
        controller.scoreText.text = controller.Score.ToString();
    }
}
