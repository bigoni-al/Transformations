using UnityEngine;

public class GrowthCapsule : MonoBehaviour
{
    [SerializeField] private float _increaseSpeed;

    private void Update()
    {
        float scaleSpeed = _increaseSpeed * Time.deltaTime;

        transform.localScale = new Vector3(transform.localScale.x + scaleSpeed, 
            transform.localScale.y + scaleSpeed, transform.localScale.z + scaleSpeed);
    }
}