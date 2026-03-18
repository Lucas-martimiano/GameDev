using UnityEngine;

public class Exercicio1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private int num1, num2;
    
    void Start()
    {
        if (num1 > num2)
            Debug.Log(num1 + " > " + num2);
        else if (num1 < num2)
            Debug.Log(num2 + " > " + num1);
        else
            Debug.Log(num1 + " = " + num2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
