using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Caractere
{
    private void /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coletavel"))
        {
            Item DanoObjeto = collision.gameObject.GetComponent<Consumable>().item;
            if (DanoObjeto != null)
            {
                print ("Acertou" + DanoObjeto.NomeObjeto);

                switch (DanoObjeto.tipoItem)
                {
                    case Item.TipoItem.MOEDA:
                        break;
                    
                    case Item.TipoItem.HEALTH:
                        AjustePontosDano(DanoObjeto.quantidade);
                        break;
                    
                    default:
                        break;
                }

                collision.gameObject.SetActive(false);
            }            
        }
    }

    public void AjustePontosDano (int quantidade)
    {
        PontosDano = PontosDano + quantidade;
        print ("Ajuste Pontos Dano por: " + quantidade + ". Novo Valor = " + PontosDano);
    }
}
