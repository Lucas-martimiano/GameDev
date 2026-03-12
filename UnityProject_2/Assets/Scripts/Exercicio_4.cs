using UnityEngine;

public class Exercicio_4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int tempoFase1 = 12, tempoFase2 = 18, tempoFase3 = 9;
    void Start()
    {
        int qntTempoMissao = tempoFase1 + tempoFase2 + tempoFase3;
        print("Tempo da Missao: " + qntTempoMissao + " minutos.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
