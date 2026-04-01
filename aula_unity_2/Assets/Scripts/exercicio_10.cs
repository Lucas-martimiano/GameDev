using UnityEngine;

public class exercicio_10 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float salario = 1000f;
    [SerializeField] private float aumento;
    void Start()
    {
        aumento = (aumento / 100) * salario + salario;
        Debug.Log("Aumento salario: " + aumento);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
