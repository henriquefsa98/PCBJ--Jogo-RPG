using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public GameObject slotPrefab;                   // Objeto que recebe o prefab Slot

    public const int numSlots = 5;                  // Num. fixo de Slots

    Image[] itemImagens = new Image[numSlots];      // array de imagens

    Item[] itens = new Item[numSlots];              // array de itens

    GameObject[] slots = new GameObject[numSlots];  // array de slots
    
    // Start is called before the first frame update
    void Start()
    {
        // por hora vazio
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CriaSlots()
    {
        if (slotPrefab != null)
        {
            for (int i = 0; i < numSlots; i++)
            {
                GameObject novoSlot = Instantiate(slotPrefab);
                novoSlot.name = "ItemSlot_" + i;
                // continuar daqui ...
            }
        }
    }
}
