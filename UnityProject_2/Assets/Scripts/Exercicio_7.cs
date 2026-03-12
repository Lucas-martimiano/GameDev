using UnityEngine;

public class Exercicio_7 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int vidaPersonagem = 150;
    [SerializeField] private int atkInimigo1 = 20, atkInimigo2 = 35, atkinimigo3 = 15;
    void Start()
    {
        int vidaRestante = vidaPersonagem - atkInimigo1 - atkInimigo2 - atkinimigo3;
        print("Vida restante do Personagem: " + vidaRestante);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
