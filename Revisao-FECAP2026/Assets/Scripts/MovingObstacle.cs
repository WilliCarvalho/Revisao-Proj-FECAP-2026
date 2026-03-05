using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float waitTime;
    [SerializeField] private Vector3 distanceOffset;

    private Vector3 startPos;
    
    private float elapsedTime = 0;
    private bool canMove = true;


    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        HandleMovement();

        CheckDistance();

        HandleTimer();

        CheckTimer();
    }

    private void HandleMovement()
    {
        print($"New position: {startPos + distanceOffset}");
        if (canMove)
        {
            //Debug.Log("Moving");
            transform.position = 
                Vector3.MoveTowards(transform.position, startPos + distanceOffset, 
                    moveSpeed * Time.deltaTime);
        }
    }

    private void CheckDistance()
    {
        if (Vector3.Distance(transform.position, startPos + distanceOffset) <= 0.1f)
        {
            canMove = false;
        }
    }
    
    private void HandleTimer()
    {
        if (canMove == false)
        {
            elapsedTime += Time.deltaTime;
        }
        print("Time: " + elapsedTime);
    }
    
    private void CheckTimer()
    {
        if (elapsedTime >= waitTime)
        {
            //Debug.Log("Waiting");
            elapsedTime = 0;
            canMove = true;
            distanceOffset *= -1;
        }
    }
}
