using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PowerUPsTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void PowerUPsTestsSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator SpeedTest()
    {
        GameObject playa = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/player"));
        GameObject speed = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Speed_Pickup"));


        playa.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        speed.transform.position = new Vector3(1.0f, 1.0f, 1.0f);

        Vector3 speedPos = speed.transform.position;

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return new WaitForSeconds(1.0f);

        Assert.AreNotEqual(speed.transform.position.x, speedPos.x);
    }


    [UnityTest]
    public IEnumerator BulletTest()
    {
        GameObject playa = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/player"));
        GameObject shot = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Shot_Pickup"));


        playa.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        shot.transform.position = new Vector3(1.0f, 1.0f, 1.0f);

        Vector3 shotPos = shot.transform.position;

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return new WaitForSeconds(1.0f);

        Assert.AreNotEqual(shot.transform.position.x, shotPos.x);
    }

    [UnityTest]
    public IEnumerator DashTest()
    {
        GameObject playa = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/player"));
        GameObject dash = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Dash"));


        playa.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        dash.transform.position = new Vector3(1.0f, 1.0f, 1.0f);

        Vector3 dashPos = dash.transform.position;


        yield return new WaitForSeconds(1.0f);

        Assert.AreNotEqual(dash.transform.position.x, dashPos.x);
    }

    [UnityTest]
    public IEnumerator DoubleJumpTest()
    {
        GameObject playa = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/player"));
        GameObject djump = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/DoubleJump_Pickup"));


        playa.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        djump.transform.position = new Vector3(1.0f, 1.0f, 1.0f);


        yield return new WaitForSeconds(1.0f);

        Assert.AreNotEqual(playa.transform.position.y, 1.0f);
    }

    [UnityTest]
    public IEnumerator InvincibilityTest()
    {
        GameObject playa = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/player"));
        GameObject invinc = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Invincibility_Pickup"));


        playa.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        invinc.transform.position = new Vector3(1.0f, 1.0f, 1.0f);

        yield return new WaitForSeconds(1.0f);
      

        Assert.False(playa.GetComponent<BoxCollider2D>().isActiveAndEnabled);
    }


    [UnityTest]
    public IEnumerator InvisibilityTest()
    {
        GameObject playa = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/player"));
        GameObject invis = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Invisibility_Pickup"));
        Color standardColour = playa.GetComponent<SpriteRenderer>().material.color;

        playa.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        invis.transform.position = new Vector3(1.0f, 1.0f, 1.0f);

        yield return new WaitForSeconds(1.0f);

        Color newColour = playa.GetComponent<SpriteRenderer>().material.color;

        Assert.AreNotEqual(standardColour, newColour);
    }

    [UnityTest]
    public IEnumerator JumpingTest()
    {
        GameObject playa = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/player"));
        GameObject jump = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Jumping_Pickup"));

        playa.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        jump.transform.position = new Vector3(1.0f, 1.0f, 1.0f);


        Vector3 jumpPos = jump.transform.position;

        yield return new WaitForSeconds(1.0f);


        Assert.AreNotEqual(jumpPos, jump.transform.position);
    }


    [UnityTest]
    public IEnumerator SlipperyTest()
    {
        GameObject playa = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/player"));
        GameObject slippery = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Slippery_Pickup"));

        playa.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        slippery.transform.position = new Vector3(1.0f, 1.0f, 1.0f);

        yield return new WaitForSeconds(1.0f);


        Assert.NotNull(slippery);
    }

    [UnityTest]
    public IEnumerator SlowdownTest()
    {
        GameObject playa = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/player"));
        GameObject slowdown = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Slowdown_Pickup"));

        playa.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        slowdown.transform.position = new Vector3(1.0f, 1.0f, 1.0f);


        Vector3 slowdownPos = slowdown.transform.position;

        yield return new WaitForSeconds(1.0f);


        Assert.AreNotEqual(slowdownPos, slowdown.transform.position);
    }


}
