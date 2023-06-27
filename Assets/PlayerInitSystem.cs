using Leopotam.Ecs;
using UnityEngine;

public class PlayerInitSystem : IEcsInitSystem
{
    private EcsWorld _world = null;
    private StaticData staticData;
    private SceneData sceneData;

    public void Init()
    {
        EcsEntity entity = _world.NewEntity();

        ref var player = ref entity.Get<Player>();
        ref var inputData = ref entity.Get<PlayerInputData>();

        GameObject playerGO = Object.Instantiate(staticData.playerPrefab, sceneData.playerSpawnPoint.position, Quaternion.identity);
        player.speed = staticData.playerSpeed;
        player.rb = playerGO.GetComponent<Rigidbody2D>();
    }
}
