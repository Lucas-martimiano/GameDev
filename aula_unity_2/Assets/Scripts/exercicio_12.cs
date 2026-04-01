using UnityEngine;

public class exercicio_12 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int pontosBase;
    public int inimigosDerrotados;
    public int bonus;
    void Start()
    {
        float pontuacaoFinal = (pontosBase * inimigosDerrotados) + bonus;
        Debug.Log("Pontuacao: " + pontuacaoFinal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
