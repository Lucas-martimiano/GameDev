using System;
using UnityEngine;

public class Exemplo2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] private string funcionario;
    [SerializeField] private float valorHora;
    [SerializeField] private int horasTrabalhadas;
        
    void Start()
    {
        float valorDia = horasTrabalhadas * valorHora;
        float valorMes = valorDia * 20;

        print("O Funcionário " + funcionario + " recebeu R$" + valorDia.ToString("F2") + " no dia");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
