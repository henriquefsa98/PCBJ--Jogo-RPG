using UnityEngine;

[CreateAssetMenu(menuName = "Item")]

public class Item : ScriptableObject
{
    public string NomeObjeto;
    public Sprite sprite;
    public int quantidade;
    public bool empilhavel;

    public enum TipoItem
    {
        MOEDA,
        HEALTH,
        CRISTAL_AZUL,

        CRISTAL_PRATA,
        CRISTAL_VERDE,
        CRISTAL_VERMELHO
    }

    public TipoItem tipoItem;
}
