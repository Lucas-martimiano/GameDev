using UnityEngine;

public class desafio : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private int jogador1Pontos = 0, jogador2Pontos = 0;
    private int jogador1Dado, jogador2Dado;

    // Update is called once per frame
    void Update()
    {
        // Apertar um botao para iniciar o jogo;
        if(Input.anyKeyDown)
        {
            // Finalizacao do jogo, caso o jogador chegue a 3 pontos
            if (jogador1Pontos == 3)
            {
                print("Quantidade pontos jogador 1: " + jogador1Pontos);
                print("Quantidade pontos jogador 2: " + jogador2Pontos);
                print("Jogador 1 Venceu!!");
                print("Fim.");
                this.enabled = false;
            }
            else if (jogador2Pontos == 3)
            {
                print("Quantidade pontos jogador 1: " + jogador1Pontos);
                print("Quantidade pontos jogador 2: " + jogador2Pontos);
                print("Jogador 2 Venceu!!");
                print("Fim.");
                this.enabled = false;
            }    
            else
            {
                // Lógica dos dados
                jogador1Dado = Random.Range(1, 7);
                jogador2Dado = Random.Range(1, 7);

                // Placar Jogadores
                print("---------------------------------");
                print("Quantidade pontos jogador 1: " + jogador1Pontos);
                print("Quantidade pontos jogador 2: " + jogador2Pontos);
                
                // Sorteio dos dados
                print("Dado jogador1: " + jogador1Dado);
                print("Dado jogador2: " + jogador2Dado);
                
                // Resultado dos dados
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
                    print("Rodada Empatada, Jogue outra Rodada");
                print("---------------------------------");
            }
        }
        
    }
}
