using UnityEngine;

public class exercicio_4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int moedas, quantidadePersonagens;
    void Start()
    {
        Debug.Log("Cada jogador recebe: " + (moedas / quantidadePersonagens));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
