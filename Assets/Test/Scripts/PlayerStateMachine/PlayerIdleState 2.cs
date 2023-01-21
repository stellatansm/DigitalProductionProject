using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    SpriteRenderer spriteRender;

    public Rigidbody2D playerRB;

    public override void EnterState(PlayerStateManager player)
    {

        Debug.Log("Ayo I'm standing still");

    }

    public override void UpdateState(PlayerStateManager player)
    {

        if (Input.GetKey(KeyCode.V)) //Holding Breath
        {
             player.SwitchState(player.breathState);
        }
        if (Input.GetKey(KeyCode.X)) //Crouching
        {
            player.SwitchState(player.crouchState);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)) //covering eyes
        {
             player.SwitchState(player.eyesState);
        }

        if (Input.GetAxisRaw("Horizontal") != 0) //idle
        {
            player.SwitchState(player.walkState);
        }
    }

    public override void OnCollisionEnter(PlayerStateManager player)
    {

    }
}
