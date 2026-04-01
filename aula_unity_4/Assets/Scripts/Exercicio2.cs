using UnityEngine;

public class Exercicio2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int vida = 100;
    [SerializeField] private int dano = 10;
    
    // Update is called once per frame
    void Update()
    {
         if (vida >= 10)
         {
            vida -= dano;
                print("Vida: " + vida);
         }
         else if (vida > 0)
                print("Vida: " + vida);
         else
                print("Jogador morreu");
    }
}
