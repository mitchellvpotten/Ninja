using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

    public Transform origin;
    public Transform destination;
    public float speed = 5f;

    private Transform _myTransform;
    private bool _Switching;

    // Use this for initialization
    void Start()
    {
        _myTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // if transform position == origin move to destination
        if (_myTransform.position == origin.position)
        {
            _Switching = true;
        }

        //if transform position == destination move to origin 
        if (_myTransform.position == destination.position)
        {
            _Switching = false;
        }

        // if switching == true move towards destination
        if (_Switching == true)
        {
            _myTransform.position = Vector3.MoveTowards(_myTransform.position, destination.position, speed * Time.deltaTime);
        }

        // if switching == false move towards origin
        if (_Switching == false)
        {
            _myTransform.position = Vector3.MoveTowards(_myTransform.position, origin.position, speed * Time.deltaTime);
        }

    }
}
