using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// abstract indica que a classe não pode ser instanciada, e sim, heradada
public abstract class Caractere : MonoBehaviour
{
    // public int PontosDano;       // versão anterior do valor de "dano"
    public PontosDano pontosDano;   // novo tipo que tem o valor do objeto script
    // public int MaxPontosDano;    // versão anterior do valor max. de "dano"

    public float inicioPontosDano;  // valor minimo de "saúde" do player
    public float MaxPontosDano;     // valor max. permitido de "saúde" do player   
}
