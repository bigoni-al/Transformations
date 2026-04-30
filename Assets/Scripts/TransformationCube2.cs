using UnityEngine;

public class TransformationCube2 : MonoBehaviour
{
    private float _rotationSpeed = 10f;
    private float _directionSpeed = 1f;
    private float _scaleSpeed = 0.5f;

    private void Update()
    {
        Rotate();
        Move();
        Swell();
    }

    private void Rotate() 
    {
        transform.Rotate(_rotationSpeed * Time.deltaTime * Vector3.up);
    }

    private void Move()
    {
        transform.Translate(_directionSpeed * Time.deltaTime * Vector3.forward);
    }

    private void Swell()
    {
        var scale = transform.localScale;
        var nextScale = new Vector3(transform.localScale.x + _scaleSpeed, 
            transform.localScale.y + _scaleSpeed, transform.localScale.z + _scaleSpeed);

        transform.localScale = Vector3.Lerp(scale, nextScale, _scaleSpeed * Time.deltaTime);
    }
}