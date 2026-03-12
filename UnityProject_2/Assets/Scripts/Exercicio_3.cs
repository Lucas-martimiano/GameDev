using UnityEngine;

public class Exercicio_3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int magoMana = 100, manaBolaDeFogo = 30, manaRaioEletrico = 20, manaEscudoMagico = 25;

    void Start()
    {
        int qntMana = magoMana - manaBolaDeFogo - manaRaioEletrico - manaEscudoMagico;
        print("Quantidade Mana: " + qntMana);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
