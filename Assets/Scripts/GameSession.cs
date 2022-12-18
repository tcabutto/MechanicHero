using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameSession : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] float loadDelay = 3f;

    Inventory inventory;

    
    private void Awake()
    {
     int numGameSessions = FindObjectsOfType<GameSession>().Length;
     if (numGameSessions > 1)
     {
        Destroy(gameObject);
     }
     else
     {
        inventory = FindObjectOfType<Inventory>();
        DontDestroyOnLoad(gameObject);
     }
    }

    private void Start() 
    {
        moneyText.text = "$ " + inventory.money.ToString();
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

    public void IncrementMoney(decimal value)
    {
        inventory.money += value;
        moneyText.text = "Money: " + inventory.money.ToString();
    }
}
