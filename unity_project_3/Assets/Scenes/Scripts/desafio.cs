using UnityEngine;

public class desafio : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private int jogador1Pontos = 0, jogador2Pontos = 0;
    private int jogador1Dado, jogador2Dado;

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            if (jogador1Pontos == 3)
                print("Jogador 1 Venceu!!");
            else if (jogador2Pontos == 3)
                print("Jogador 2 Venceu!!");
            else
            {
                print("Quantidade pontos jogador 1: " + jogador1Pontos);
                print("Quantidade pontos jogador 2: " + jogador2Pontos);
                jogador1Dado = Random.Range(1, 7);
                jogador2Dado = Random.Range(1, 7);
                print("Dado jogador1: " + jogador1Dado);
                print("Dado jogador2: " + jogador2Dado);
                if (jogador1Dado > jogador2Dado)
                {
                    print("Jogador 1 ganhou um ponto");
                    jogador1Pontos++;
                }
                else if (jogador2Dado > jogador1Dado)
                {
                    print("Jogador 2 ganhou um ponto");
                    jogador2Pontos++;
                }
                    
                else
                    print("Jogue outra rodada");
            }
        }
        
    }
}
