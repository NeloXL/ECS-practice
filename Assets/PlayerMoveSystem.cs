using Leopotam.Ecs;
using UnityEngine;

public class PlayerMoveSystem : IEcsRunSystem
{
    EcsFilter<Player, PlayerInputData> filter;

    public void Run()
    {
        foreach (var i in filter)
        {
            ref var player = ref filter.Get1(i);
            ref var input = ref filter.Get2(i);

            Vector2 dir = (Vector2.up * input.moveInput.y + Vector2.right * input.moveInput.x).normalized;
            player.rb.velocity = player.speed * dir;
        }
    }
}