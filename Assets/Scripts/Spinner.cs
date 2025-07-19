using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 0f;
    [SerializeField] float zAngle = 0f;

    [SerializeField] float spinSpeed = 1f;

    void Update()
    {
        transform.Rotate(new Vector3(xAngle, yAngle, zAngle) * spinSpeed * Time.deltaTime);
    }
}

