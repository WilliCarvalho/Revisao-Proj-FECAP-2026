using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        //transform.Rotate(0, rotationSpeed * Time.deltaTime, 0); - Outra opção de código
    }
}
