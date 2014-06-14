using UnityEngine;
using System.Collections;

public class MoveMonster : MonoBehaviour {
	// Use this for initialization
    public Transform Sprite;
    public float Speed = 10;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * Speed * Time.deltaTime);
	}
}
