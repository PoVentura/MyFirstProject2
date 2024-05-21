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
        // ѕровер€ем, нажата ли кнопка F
        if (Input.GetKeyDown(KeyCode.F))
        {
            // ѕровер€ем, находитс€ ли игрок в определенном рассто€нии от куба
            float distanceToCube = Vector3.Distance(player.position, cube.position);
            if (distanceToCube <= attractionDistance)
            {
                // ѕереключаем прит€жение
                isAttracted = !isAttracted;

                // ≈сли игрок уже прит€гиваетс€, отключаем гравитацию и фиксируем его в позиции куба
                if (isAttracted)
                {
                    playerRigidbody.useGravity = false;
                    playerRigidbody.velocity = Vector3.zero;
                    playerRigidbody.angularVelocity = Vector3.zero;
                    player.parent = cube;
                }
                // ≈сли игрок перестал прит€гиватьс€, возвращаем гравитацию и снимаем фиксацию
                else
                {
                    playerRigidbody.useGravity = true;
                    player.parent = null;
                }
            }
        }

        // ѕровер€ем, находитс€ ли игрок на земле
        isGrounded = Physics.Raycast(player.position, Vector3.down, 0.2f, groundLayer);

        // ≈сли игрок не прит€гиваетс€ и находитс€ на земле, ставим его на землю
        if (!isAttracted && isGrounded)
        {
            player.position = new Vector3(player.position.x, 0f, player.position.z);
        }
    }
}
