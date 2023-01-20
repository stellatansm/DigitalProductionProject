using UnityEngine;

public class PlayerWalkState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("I am walking");
    }

    public override void UpdateState(PlayerStateManager player)
    {
       if (Input.GetKey(KeyCode.Z)) //Holding Breath
       {
           player.SwitchState(player.breathState);
       }
       if (Input.GetKeyDown(KeyCode.X)) //Crouching
       {
            player.SwitchState(player.crouchState);
       }
       if (Input.GetKeyDown(KeyCode.C)) //covering eyes
       {
           player.SwitchState(player.eyesState);
       }

        if (Input.GetAxisRaw("Horizontal") == 0) //idle
        {
            player.SwitchState(player.idleState);
        }
    }

    public override void OnCollisionEnter(PlayerStateManager player)
    {

    }

}
