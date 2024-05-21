using UnityEngine;

public class CubeAttraction : MonoBehaviour
{
    public Transform player;
    public Transform cube;
    public float attractionDistance = 5f;
    public float attractionForce = 10f;
    public LayerMask groundLayer;

    private bool isAttracted = false;
    private bool isGrounded = false;
    private Rigidbody playerRigidbody;

    private void Start()
    {
        playerRigidbody = player.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // ���������, ������ �� ������ F
        if (Input.GetKeyDown(KeyCode.F))
        {
            // ���������, ��������� �� ����� � ������������ ���������� �� ����
            float distanceToCube = Vector3.Distance(player.position, cube.position);
            if (distanceToCube <= attractionDistance)
            {
                // ����������� ����������
                isAttracted = !isAttracted;

                // ���� ����� ��� �������������, ��������� ���������� � ��������� ��� � ������� ����
                if (isAttracted)
                {
                    playerRigidbody.useGravity = false;
                    playerRigidbody.velocity = Vector3.zero;
                    playerRigidbody.angularVelocity = Vector3.zero;
                    player.parent = cube;
                }
                // ���� ����� �������� �������������, ���������� ���������� � ������� ��������
                else
                {
                    playerRigidbody.useGravity = true;
                    player.parent = null;
                }
            }
        }

        // ���������, ��������� �� ����� �� �����
        isGrounded = Physics.Raycast(player.position, Vector3.down, 0.2f, groundLayer);

        // ���� ����� �� ������������� � ��������� �� �����, ������ ��� �� �����
        if (!isAttracted && isGrounded)
        {
            player.position = new Vector3(player.position.x, 0f, player.position.z);
        }
    }
}
