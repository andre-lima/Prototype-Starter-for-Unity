using UnityEngine;
using System.Collections;
using DG.Tweening;

public class ShakeButton : MonoBehaviour {

    RectTransform rect;
    Vector3 spin;

    // Use this for initialization
    void Awake () {
        DOTween.Init();
        rect = gameObject.GetComponent<RectTransform>();
        spin = new Vector3(20f, 20f, 00f);
    }

    void Start()
    {
        StartCoroutine(Shake());

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator Shake()
    {
        rect.DOShakeRotation(3f, spin, 3, 0f);
        rect.DOShakeAnchorPos(3f, 40f, 5, 80, false);
        yield return new WaitForSeconds(3.2f);
        StartCoroutine(Shake());
    }
}
