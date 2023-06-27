using Leopotam.Ecs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ECSMain : MonoBehaviour
{
    public StaticData configuration;
    public SceneData sceneData;
    
    private EcsWorld world = null;
    private EcsSystems systems = null;

    private void Start()
    {
        world = new EcsWorld();
        systems = new EcsSystems(world);

        systems.Add(new PlayerInitSystem())
            .Add(new PlayerInputSystem())
            .Add(new PlayerMoveSystem())
            .Inject(configuration)
            .Inject(sceneData);
        systems.Init();
    }


    private void Update()
    {
        systems.Run();
    }

    private void OnDestroy()
    {
        systems.Destroy();
        systems = null;
        world.Destroy();
        world = null;
    }
}
