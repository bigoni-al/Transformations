using UnityEngine;

public class RotationCube1 : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        transform.Rotate(_rotationSpeed * Time.deltaTime * Vector3.up);
    }
}
