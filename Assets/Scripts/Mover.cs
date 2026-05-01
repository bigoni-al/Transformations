using UnityEngine;

public class Mover : MonoBehaviour
{
    private float _speed = 1f;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }
}
