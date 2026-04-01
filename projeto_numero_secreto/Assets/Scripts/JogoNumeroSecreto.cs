using UnityEngine;

public class JogoNumeroSecreto : MonoBehaviour
{
    [SerializeField] private int tentativaJogador;
    [SerializeField] private int dificuldadeJogo;

    int numeroSecreto;
    int quantidadeTentativas = 3;
    bool jogando = true;

    void Start()
    {
        // MENU JOGO

        print("JOGO - ADVINHE O NÚMERO SECRETO!");
        print("*****************************");
        if (dificuldadeJogo == 1)
        {
            print("Você escolheu Fácil");
            numeroSecreto = Random.Range(0, 51);
        }

        else if (dificuldadeJogo == 2)
        {
            print("Você escolheu Médio");
            numeroSecreto = Random.Range(0, 101);
        }
        else
        {
            print("Você escolheu Difícil");
            numeroSecreto = Random.Range(0, 501);
        }

        // DICA
        if (numeroSecreto > 50)
            print("DICA: numero entre " + (numeroSecreto - 20) + " e " + (numeroSecreto + 20));
        else if (numeroSecreto > 20)
            print("DICA: numero entre " + (numeroSecreto - 10) + " e " + (numeroSecreto + 10));
        else
            print("Sem DICA para você");
        print("*****************************");
    }

    // Update is called once per frame
    void Update()
    {
        // INICIA O JOGO
        if (jogando)
        {
            if (Input.anyKeyDown)
            {
                if (quantidadeTentativas > 0)
                {
                    // DIMINUI UMA TENTATIVA
                    quantidadeTentativas--;

                    // MOSTRA A TENTATIVA DO JOGADOR
                    print("--------------------");
                    print("Tentativa: " +  tentativaJogador);

                    // COMPARA A TENTATIVA DO JOGADOR
                    if (tentativaJogador > numeroSecreto)
                    {
                        print("Muito Alto");
                    }
                    else if (tentativaJogador < numeroSecreto)
                    {
                        print("Muito Baixo");
                    }
                    // TERMINA O JOGO SE O JOGADOR ACERTAR
                    else
                    {
                        print("ACERTOU!!");
                        print("Quantidade de Tentativas: " + quantidadeTentativas);
                        print("FIM DE JOGO");
                        jogando = false;
                    }
                }
                // TERMINA O JOGO SE O JOGADOR ERRAR
                else
                {
                    print("VOCÊ PERDEU");
                    print("FIM DE JOGO");
                    jogando = false;
                }
                print("--------------------");
            }
        }
    }
}
