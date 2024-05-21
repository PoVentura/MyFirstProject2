using UnityEngine;

public class CubeInteraction : MonoBehaviour
{
    public Transform player;
    public Transform cube;
    public float distanceThreshold = 5f;
    private bool isInteracting = false;
    private Vector3 initialPlayerPosition;

    private void Start()
    {
        initialPlayerPosition = player.position;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            float distance = Vector3.Distance(player.position, cube.position);

            if (distance <= distanceThreshold)
            {
                isInteracting = true;
                player.SetParent(cube);
            }
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            isInteracting = false;
            player.SetParent(null);
            player.position = initialPlayerPosition;
        }

        if (isInteracting)
        {
            player.position = cube.position;
        }
    }
}
