using UnityEngine;

public class Exercicio_2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int danoBase = 15, bonusArma = 5, bonusTemporario = 2;
    void Start()
    {
        int danoTotal = (danoBase + bonusArma) * bonusTemporario;
        Debug.Log("Dano total ao inimigo: " + danoTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
