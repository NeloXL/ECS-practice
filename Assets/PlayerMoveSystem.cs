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

            player.rb.velocity = new Vector2(player.speed * input.moveInput, player.rb.velocity.y);
        }
    }
}
