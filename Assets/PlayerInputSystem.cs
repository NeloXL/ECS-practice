﻿using Leopotam.Ecs;
using UnityEngine;

public class PlayerInputSystem : IEcsRunSystem
{
    private EcsFilter<PlayerInputData> filter;

    public void Run()
    {
        foreach (var i in filter)
        {
            ref var input = ref filter.Get1(i);

            input.moveInput = Input.GetAxis("Horizontal");
        }
    }
}