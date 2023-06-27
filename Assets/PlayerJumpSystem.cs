using Leopotam.Ecs;
using UnityEngine;

public class PlayerJumpSystem : IEcsRunSystem
{
    private EcsFilter<Player, PlayerJumpData> filter;

    public void Run()
    {
        foreach (var i in filter)
        {
            ref var player = ref filter.Get1(i);
            ref var jump = ref filter.Get2(i);

            if (Input.GetKeyDown(KeyCode.Space) && jump.isStaying)
            {
                jump.isStaying = false;
                player.rb.AddForce(Vector2.up * player.jumpForce);
            }
        }
    }
}
