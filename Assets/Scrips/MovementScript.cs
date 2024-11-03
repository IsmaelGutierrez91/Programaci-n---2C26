using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float xSpeed;
    public float ySpeed;
    public int xDirection;
    public int yDirection;
    private Transform _componetTransform;
    private SpriteRenderer _spriteRender;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        _componetTransform = GetComponent<Transform>();
        _spriteRender = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        _componetTransform.position = new Vector2(_componetTransform.position.x + xSpeed * Time.deltaTime * xDirection, _componetTransform.position.y + ySpeed * Time.deltaTime * yDirection);
        if (_componetTransform.position.x <= -7.45)
        {
            xDirection = 1;
            _spriteRender.flipX = false;
        }
        else if (_componetTransform.position.x >= 7.45)
        {
            xDirection = -1;
            _spriteRender.flipX = true;
        }
        if (_componetTransform.position.y <= -4.15)
        {
            yDirection = 1;
            _spriteRender.flipY = false;
        }
        else if(_componetTransform.position.y >= 4.15)
        {
            yDirection = -1;
            _spriteRender.flipY = true;
        }
    }
}