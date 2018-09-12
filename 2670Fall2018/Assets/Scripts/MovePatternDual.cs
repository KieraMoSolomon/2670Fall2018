using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu]
public class MovePatternDual : MovePattern
{

	private bool doubleJump;
	
	public override void Invoke(CharacterController controller, Transform transform)
	{
		if (controller.isGrounded)
		{
			Move(transform);
			doubleJump = true;
		}
		else
		{
			if (doubleJump)
			{
				Move(transform);
				doubleJump = false;
			}
		}

		Move(controller);
	}

	void SetJump()
	{
		doubleJump = true;
	}
}
