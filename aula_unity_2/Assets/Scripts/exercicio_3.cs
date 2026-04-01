using UnityEngine;

public class exercicio_3 : MonoBehaviour
{
    [SerializeField] private int pontos, multiplicador;
    void Start()
    {
        Debug.Log("Pontos: " + (pontos * multiplicador));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
