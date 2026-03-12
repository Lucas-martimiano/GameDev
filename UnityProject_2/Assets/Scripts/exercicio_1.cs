using UnityEngine;

public class exercicio_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int xpPequeno = 10, xpMedio = 25, xpChefe = 100;
    [SerializeField] private int qntPequeno, qntMedio, qntChefe;
    void Start()
    {
        int xpTotal;
        xpTotal = (qntPequeno * xpPequeno) + (qntMedio * xpMedio) + (qntChefe * xpChefe);
        Debug.Log("Quantidade de XP ganha: " + xpTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
