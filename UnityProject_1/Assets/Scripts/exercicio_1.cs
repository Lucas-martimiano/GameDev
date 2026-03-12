using UnityEngine;

public class exercicio_1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private int a, b;
    void Start()
    {
        Debug.Log("resultado: " + (a + b));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
