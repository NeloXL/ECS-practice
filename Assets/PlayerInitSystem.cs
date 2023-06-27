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
        ref var input = ref entity.Get<PlayerInputData>();
        ref var jump = ref entity.Get<PlayerJumpData>();
        ref var ground = ref entity.Get<GroundCheckData>();

        GameObject playerGO = Object.Instantiate(staticData.playerPrefab, sceneData.playerSpawnPoint.position, Quaternion.identity);
        player.speed = staticData.playerSpeed;
        player.jumpForce = staticData.playerJumpForce;
        ground.checkGroundRadius = staticData.checkGroundRadius;
        ground.groundLayer = staticData.groundLayer;
        ground.originTransform = playerGO.transform.GetChild(0);
        player.rb = playerGO.GetComponent<Rigidbody2D>();
    }
}
