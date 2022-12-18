using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections.Generic;

public class GameSession : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] float loadDelay = 3f;

    Inventory PlayerInventory;

    public List<GarageInventory> GarageInventories;

    
    private void Awake()
    {
     int numGameSessions = FindObjectsOfType<GameSession>().Length;
     if (numGameSessions > 1)
     {
        Destroy(gameObject);
     }
     else
     {
          // Load the size of the player inventory from a file or a database.
        int playerInventorySize = LoadPlayerInventorySize();

        // Create an instance of the PlayerInventory class with the loaded size.
        PlayerInventory = new PlayerInventory(playerInventorySize);

        // Load the sizes of the garage inventories from a file or a database.
        List<int> GarageInventorySizes = LoadGarageInventorySizes();

        // Create a list of garage base inventories.
        GarageInventories = new List<GarageInventory>();

        // Add instances of the GarageInventory class with the loaded sizes to the list.
        foreach (int size in GarageInventorySizes)
        {
            GarageInventories.Add(new GarageInventory(size));
        }
            // Loads the size of the player inventory from a file or a database.
    int LoadPlayerInventorySize()
    {
        // TODO: Load the size of the player inventory from a file or a database.
        return 0;
    }

    // Loads the sizes of the garage base inventories from a file or a database.
    List<int> LoadGarageInventorySizes()
    {
        // TODO: Load the sizes of the garage base inventories from a file or a database.
        return new List<int>();
    }

        DontDestroyOnLoad(gameObject);
     }
    }

    private void Start() 
    {
        moneyText.text = "$ " + PlayerInventory.GetMoney().ToString();
    }

    public void ProcessPlayerDeath()
    {
        Invoke("ResetGameSession", loadDelay);
    }

    private void ResetGameSession()
    {
        FindObjectOfType<ScenePersist>().ResetScenePersist();
        SceneManager.LoadScene(0);
        Destroy(gameObject);
    }

    
}
