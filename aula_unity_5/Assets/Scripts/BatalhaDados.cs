using UnityEngine;

public class BatalhaDados : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [Header("Distribua os 5 pontos entre seus atributos, nenhum pode estar zerado.")]
    [SerializeField] private int vida_jogador, ataque_jogador, defesa_jogador;
    private int vida_cpu, ataque_cpu, defesa_cpu;
    int dado1, dado2;
    int defesa_temp_jogador = 0, defesa_temp_cpu = 0;
    bool atributos_distribuidos = false;
    bool turno_jogador = true, turno_cpu = false;


    void Start()
    {
        print("********************");
        print("* Batalha de Dados *");
        print("********************");
    }

    // Update is called once per frame
    void Update()
    {
        // Distribuindo os atributos da CPU aleatoriamente
        if (atributos_distribuidos == false)
        {
            vida_cpu = Random.Range(1,4);
            ataque_cpu = Random.Range(1,4);
            defesa_cpu = Random.Range(1,4);

            // Atualizando o status de distribuição
            if ((vida_cpu + ataque_cpu + defesa_cpu) == 5)
            {
               atributos_distribuidos=true;
                // Mostrando Estatísticas:
                print("---------------------");
                print("- Atributos Jogador -");
                print("- Vida: " + vida_jogador + " -");
                print("- Ataque: " + ataque_jogador + " -");
                print("- Defesa: " + defesa_jogador + " -");
                print("---------------------");

                print("---------------------");
                print("- Atributos CPU -");
                print("- Vida: " + vida_cpu + " -");
                print("- Ataque: " + ataque_cpu + " -");
                print("- Defesa: " + defesa_cpu + " -");
                print("---------------------");
            }
        }

        // Core Loop Do Jogo
        if (Input.anyKeyDown && vida_jogador > 0 && vida_cpu > 0)
        {
            // Define o Turno do Jogo
            dado1 = Random.Range(1,3);

            // Define a Intensidade do Ataque
            dado2 = Random.Range(1,7);

            // Turno ATAQUE (Dado1 = Numero Par)
            if (dado1 == 2)
            {
                // Turno Jogador
                if (turno_jogador)
                {
                    // Dano do Jogador
                    int dano = (ataque_jogador + dado2) - (defesa_cpu + defesa_temp_cpu);
                    if (dano > vida_cpu)
                        vida_cpu = 0;
                    else if (dano < 0)
                    {
                        dano = 0;
                        vida_cpu -= dano;
                    }
                    else
                        vida_cpu -= dano;

                    // Troca de Turnos
                    turno_jogador = false;
                    turno_cpu = true;

                    // Mostrando Turno
                    print("___________________");
                    print("_ Turno de Ataque _");
                    print("_ Vez do Jogador  _");
                    print("_ Dano JOGADOR: " + dano + " _");
                    print("_ Vida CPU: " + vida_cpu + " _");
                    print("___________________");
                }

                // Turno Cpu
                else if (turno_cpu)
                {
                    // Dano do Jogador
                    int dano = (ataque_cpu + dado2) - (defesa_jogador + defesa_temp_jogador);
                    if (dano > vida_jogador)
                        vida_jogador = 0;
                    else if (dano < 0)
                    {
                        dano = 0;
                        vida_jogador -= dano;
                    }
                    else
                        vida_jogador -= dano;

                    // Troca de Turnos
                    turno_cpu = false;
                    turno_jogador = true;

                    // Mostrando Turno
                    print("___________________");
                    print("_ Turno de Ataque _");
                    print("_ Vez da CPU  _");
                    print("_ Dano CPU: " + dano + " _");
                    print("_ Vida JOGADOR: " + vida_jogador + " _");
                    print("___________________");
                }
            }

            // Turno DEFESA
            else if(dado1 == 1)
            {
                // Turno Jogador
                if (turno_jogador)
                {
                    // Defesa Temporaria Jogador
                    defesa_temp_jogador = 0;
                    defesa_temp_jogador += Random.Range(1, 7);
                  
                    // Troca de Turnos
                    turno_jogador = false;
                    turno_cpu = true;

                    // Mostrando Turno
                    print("___________________");
                    print("_ Turno de DEFESA _");
                    print("_ Vez do JOGADOR  _");
                    print("_ Defesa Temp Jogador: " + defesa_temp_jogador + " _");
                    print("___________________");
                }

                // Turno Cpu
                else if (turno_cpu)
                {
                    // Dano do Jogador
                    defesa_temp_cpu = 0;
                    defesa_temp_cpu += Random.Range(1,7);

                    // Troca de Turnos
                    turno_cpu = false;
                    turno_jogador = true;

                    print("___________________");
                    print("_ Turno de DEFESA _");
                    print("_    Vez da CPU   _");
                    print("_ Defesa Temp CPU: " + defesa_temp_cpu + " _");
                    print("___________________");
                }
            }
        }

        // Mensagem de Finalização
        if (Input.anyKeyDown && (vida_jogador == 0 || vida_cpu == 0))
        {
            if (vida_jogador == 0)
                print("VOCÊ PERDEU!!!");
            else
                print("VOCÊ VENCEU!!!");
            print("Fim do Jogo");
        }
    }
}
