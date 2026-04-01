using UnityEngine;

public class JogoApostas : MonoBehaviour
{
    [Header("Escolha um Jogador para Apostar")]
    [SerializeField] private bool guerreiroA, guerreiroB;
    [Header("Escolha o valor da sua Aposta")]
    [SerializeField] private int aposta;

    private int jogadorMoedas = 100;
    private int forcaGuerreiroA, forcaGuerreiroB;
    private bool jogando = true;
    

    void Start()
    {
        print("*********************");
        print("* Sistema de Aposta *");
        print("*********************");
    }


    void Update()
    {
        if (Input.anyKeyDown && aposta > jogadorMoedas)
            print("Insira uma aposta valida");
        else if (jogando && Input.anyKeyDown)
        {
            forcaGuerreiroA = Random.Range(1, 101);
            forcaGuerreiroB = Random.Range(1, 101);

            if (guerreiroA)
            {
                if (forcaGuerreiroA > forcaGuerreiroB)
                {
                    jogadorMoedas += (aposta * 2);
                    jogadorMoedas -= aposta;
                    print("Você Apostou no Vencedor!!");
                    print("Suas Moedas: " + jogadorMoedas);
                }

                else
                {
                    jogadorMoedas -= aposta;
                    print("Você Apostou no Perdedor!!");
                    print("Suas Moedas: " + jogadorMoedas);
                }
            }
            else if (guerreiroB)
            {
                if (forcaGuerreiroB > forcaGuerreiroA)
                {
                    jogadorMoedas += (aposta * 2);
                    print("Você Apostou no Vencedor!!");
                    print("Suas Moedas: " + jogadorMoedas);
                }

                else
                {
                    jogadorMoedas -= aposta;
                    print("Você Apostou no Perdedor!!");
                    print("Suas Moedas: " + jogadorMoedas);
                }
            }
            jogando = false;
        }
        else if (Input.anyKeyDown)
        {
            print("Fim de Jogo");
        }

    }
}
