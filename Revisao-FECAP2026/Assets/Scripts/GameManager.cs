using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private bool isStarted = false;
    private float elapsedTime = 0f;
    
    [SerializeField] private UIManager uiManager;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Update()
    {
        if (isStarted == true)
        {
            elapsedTime += Time.deltaTime;
            uiManager.UpdateTimerUI(elapsedTime);
            Debug.Log(elapsedTime);
        }
    }

    public void StartTimer()
    {
        isStarted = true;
    }
}
