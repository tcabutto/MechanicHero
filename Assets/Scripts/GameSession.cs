using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameSession : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] float loadDelay = 3f;

    //may make inventory class later and move this into it
    decimal money = 0.00m;
    
    private void Awake()
    {
     int numGameSessions = FindObjectsOfType<GameSession>().Length;
     if (numGameSessions > 1)
     {
        Destroy(gameObject);
     }
     else
     {
        DontDestroyOnLoad(gameObject);
     }
    }

    private void Start() 
    {
        moneyText.text = "$ " + money.ToString();
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
        money += value;
        moneyText.text = "Money: " + money.ToString();
    }
}
