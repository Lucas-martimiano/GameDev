using UnityEngine;

public class exercicio_8 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int vida = 100;
    public int dano;
    void Start()
    {
        Debug.Log("Vida: " + (vida - dano));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
