using UnityEngine;

public class exercicio_2 : MonoBehaviour
{
    [SerializeField] private int vida, dano;
    void Start()
    {
        Debug.Log("Vida: " + (vida - dano));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
