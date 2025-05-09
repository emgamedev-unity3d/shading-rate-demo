using UnityEngine;
using Unity.Netcode;

public class HeyCameraLookAtMe : NetworkBehaviour
{
    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();

        if (IsOwner)
        {
            var carFollow = FindAnyObjectByType<CarFollow>();
            carFollow.target = transform;

            var speedOmeter = FindAnyObjectByType<Speedometer>();
            speedOmeter.Car_RB = GetComponent<Rigidbody>();

            var miniMapCar = FindAnyObjectByType<MinimapCar>();
            miniMapCar.CarTransform = transform;
        }
    }
}
