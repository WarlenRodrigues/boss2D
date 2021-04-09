using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    GameManager gm;

    public Rigidbody2D rb;
    public Rigidbody2D slingShot;
    public GameObject nextBullet;

    public float releaseTime = 0.15f;
    public float maxDragDistance = 2.0f;


    private bool isPressed = false;

    private void Start()
    {
        gm = GameManager.GetInstance();
    }

    private void Update()
    {
        if (isPressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 slingShotPos = slingShot.position;
            if (Vector3.Distance(mousePos, slingShotPos) > maxDragDistance)
                rb.position = slingShotPos + (mousePos - slingShotPos).normalized * maxDragDistance;
            else
                rb.position = mousePos;
        }
    }

    private void OnMouseDown()
    {
        isPressed = true;
        rb.isKinematic = true;
    }

    private void OnMouseUp()
    {
        isPressed = false;
        rb.isKinematic = false;

        StartCoroutine(Release());
    }

    IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseTime);

        GetComponent<SpringJoint2D>().enabled = false;
        this.enabled = false;

        yield return new WaitForSeconds(3.0f);

        if (nextBullet != null)
        {
            nextBullet.SetActive(true);
        }
        else
        {
            Target.TargetsOverTheTable = 0;
            gm.ChangeState(GameManager.GameState.ENDGAMELOST);
            // gm.Reset();
        }
    }
}
