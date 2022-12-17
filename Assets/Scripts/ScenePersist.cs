using UnityEngine;

public class ScenePersist : MonoBehaviour
{
    private void Awake()
    {
        int numScenePersists = FindObjectsOfType<ScenePersist>().Length;
        if (numScenePersists > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject); 
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ResetScenePersist()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
