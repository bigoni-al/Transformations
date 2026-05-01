using UnityEngine;

public class Dilator : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;

    private void Update()
    {
        float scaleSpeed = _growthSpeed * Time.deltaTime;

        transform.localScale = new Vector3(transform.localScale.x + scaleSpeed, 
            transform.localScale.y + scaleSpeed, transform.localScale.z + scaleSpeed);
    }
}