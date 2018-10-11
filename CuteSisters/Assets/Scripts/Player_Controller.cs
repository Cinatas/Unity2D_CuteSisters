using CuteSister;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CuteSister.Player
{
    public class Player_Controller : MonoBehaviour
    {

        private static Player_Controller instance = null;
        public static Player_Controller _Instance
        {
            get
            {
                return instance;
            }
        }

        SpriteRenderer _spRender;
        Rigidbody2D _rigid2D;

        public Direction FaceDir;

        public float MoveSpeed;

        public bool isGround;

        private Animator aniCon;

        private void Awake()
        {
            instance = this;

            _spRender = this.transform.Find("Sprite").GetComponent<SpriteRenderer>();
            _rigid2D = this.GetComponent<Rigidbody2D>();
            aniCon = this.transform.Find("Sprite").GetComponent<Animator>();
        }
        

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            aniCon.SetFloat("ySpeed", _rigid2D.velocity.y);
            aniCon.SetFloat("xSpeed", _rigid2D.velocity.x);
        }

        private void FixedUpdate()
        {
            int walkFactor = (FaceDir == Direction.LEFT) ? -1 : 1;
            if (walkFactor > 0)
                _spRender.flipX = false;
            else if (walkFactor < 0)
                _spRender.flipX = true;

            _rigid2D.velocity = new Vector2(walkFactor * MoveSpeed, _rigid2D.velocity.y);
        }

        public void Jump(float JumpForce)
        {
            if (isGround)
            {
                _rigid2D.velocity = new Vector2(_rigid2D.velocity.x, JumpForce);
                aniCon.SetTrigger("Jump");
                isGround = false;
            }
        }

        public void Walk(float speed)
        {
            MoveSpeed = speed;
            aniCon.SetTrigger("Walk");
        }

        public void OnGround()
        {
            isGround = true;
            Walk(MoveSpeed);
        }
    }

}
