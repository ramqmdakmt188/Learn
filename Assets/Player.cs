using UnityEngine;

public class Player : MonoBehaviour
{
    public float xInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
    }
}
