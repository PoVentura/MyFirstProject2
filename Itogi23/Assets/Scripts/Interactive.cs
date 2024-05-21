using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Interactive : MonoBehaviour
{
    [SerializeField] private Camera fps;
    private Ray ray;
    private RaycastHit hit;
    [SerializeField] private float maxDistance;

    public GameObject m;
    Rigidbody rb;
    public GameObject player;
    public GameObject cube;
    float axis;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cube = GameObject.FindWithTag("cube");
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindWithTag("Player");
        Ray();
        DrawRay();

    }
    private void Ray()
    {
        ray = fps.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        if (Physics.Raycast(ray, out hit, 3) && hit.transform.gameObject.tag == "cube")
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log(player.transform.position);

                cube.GetComponent<Rigidbody>().AddForce((player.transform.position - cube.transform.position).normalized * 100f);

            }

        }
    }

    private void DrawRay()
    {
        if (Physics.Raycast(ray, out hit, maxDistance))
        {
            Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.red);
        }

        if (hit.transform == null)
        {
            Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.green);
        }
    }

}
