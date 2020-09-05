using System.Collections;
using System.Reflection;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Mirror.Tests.Runtime.ClientSceneTests
{
    public class ClientSceneTests_LocalPlayer : ClientSceneTestsBase
    {
        [SetUp]
        public void Setup()
        {
            PropertyInfo readyConnProperty = typeof(ClientScene).GetProperty(nameof(ClientScene.readyConnection));
            readyConnProperty.SetValue(null, new FakeNetworkConnection());
        }

        NetworkIdentity SpawnObject(bool localPlayer)
        {
            const uint netId = 1000;

            GameObject go = new GameObject();
            _createdObjects.Add(go);

            NetworkIdentity identity = go.AddComponent<NetworkIdentity>();

            SpawnMessage msg = new SpawnMessage
            {
                netId = netId,
                isLocalPlayer = localPlayer,
                isOwner = localPlayer,
            };

            ClientScene.ApplySpawnPayload(identity, msg);

            if (localPlayer)
            {
                Assert.That(ClientScene.localPlayer, Is.EqualTo(identity));
            }

            return identity;
        }

        [UnityTest]
        public IEnumerator LocalPlayerIsSetToNullAfterDestroy()
        {
            Debug.Assert(ClientScene.localPlayer == null, "LocalPlayer should be null before this test");


            NetworkIdentity player = SpawnObject(true);

            GameObject.Destroy(player);

            // wait a frame for destroy to happen
            yield return null;

            // use "is null" here to avoid unity == check
            Assert.IsTrue(ClientScene.localPlayer is null, "local player should be set to c# null");
        }

        [UnityTest]
        public IEnumerator DestroyingOtherObjectDoesntEffectLocalPlayer()
        {
            NetworkIdentity player = SpawnObject(true);
            NetworkIdentity notPlayer = SpawnObject(false);

            GameObject.Destroy(notPlayer);

            // wait a frame for destroy to happen
            yield return null;

            Assert.IsTrue(ClientScene.localPlayer != null, "local player should not be cleared");
            Assert.IsTrue(ClientScene.localPlayer == player, "local player should still be equal to player");
        }
    }
}
