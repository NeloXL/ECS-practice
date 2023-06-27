using Leopotam.Ecs;
using UnityEngine;

public class GroundCheckSystem : IEcsRunSystem
{
    private EcsFilter<GroundCheckData, PlayerJumpData> filter;

    public void Run()
    {
        foreach(var i in filter)
        {
            ref var ground = ref filter.Get1(i);
            ref var jump = ref filter.Get2(i);

            if(Physics2D.Raycast(ground.originTransform.position, Vector2.down, ground.checkGroundRadius, ground.groundLayer))
            {
                jump.isStaying = true;
            }
            else
            {
                jump.isStaying = false;
            }
        }
    }
}