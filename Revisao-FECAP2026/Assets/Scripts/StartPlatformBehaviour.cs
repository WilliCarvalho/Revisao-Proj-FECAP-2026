using UnityEngine;

public class StartPlatformBehaviour : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Iniciando Contador de tempo!");
            GameManager.Instance.StartTimer();
        }
    }
}
