using UnityEngine;

public class MovementSphere : MonoBehaviour
{
    private float _speed = 1f;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }
}
