using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D _birdRb;
    [SerializeField] private float birdJumpSpeed;
    public bool isDead = false;
    private void Awake()
    {
        _birdRb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        BirdJump();
    }

    private void BirdJump()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _birdRb.velocity = Vector2.up * birdJumpSpeed;
        }
    }
}
