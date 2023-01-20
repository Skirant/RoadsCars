using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _oldMousePositionX;
    private float _eulerY;

    [SerializeField] public Transform _wheelFLTransform;
    [SerializeField] public Transform _wheelFRTransform;
    [SerializeField] public Transform _wheelRLTransform;
    [SerializeField] public Transform _wheelRRTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _oldMousePositionX = Input.mousePosition.x;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * _speed;
            newPosition.x = Mathf.Clamp(newPosition.x, -3f, 3f);
            transform.position = newPosition;

            float deltaX = Input.mousePosition.x - _oldMousePositionX;
            _oldMousePositionX = Input.mousePosition.x;

            _eulerY += deltaX;
            _eulerY = Mathf.Clamp(_eulerY, -70, 70);
            transform.eulerAngles = new Vector3(0, _eulerY, 0);

            WheelTranformRotate();
        }
    }

    void WheelTranformRotate()
    {
        _wheelFLTransform.Rotate(0.0f, 0.0f, 60 * Time.deltaTime * _speed);
        _wheelFRTransform.Rotate(0.0f, 0.0f, 60 * Time.deltaTime * _speed);
        _wheelRLTransform.Rotate(0.0f, 0.0f, 60 * Time.deltaTime * _speed);
        _wheelRRTransform.Rotate(0.0f, 0.0f, 60 * Time.deltaTime * _speed);
    }
}
