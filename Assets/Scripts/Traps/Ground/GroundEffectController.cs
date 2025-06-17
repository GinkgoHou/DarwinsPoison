using System;
using System.Collections;
using System.Collections.Generic;
using Game.Level;
using MizukiTool.UIEffect;
using UnityEngine;

namespace Game.Traps
{
    public class GroundEffectController : TrapEffectController
    {
        public Transform child;

        public void StartRotationEffect(Vector2 pos)
        {
            Vector3 v = pos - (Vector2)transform.position;
            child.position = transform.position + (Vector3)v;
            transform.position = pos;
            StartRotationEffect();
        }

        public void StartTransformEffect(Vector2 pos)
        {
            Vector3 v = pos - (Vector2)transform.position;
            child.position = transform.position + (Vector3)v;
            transform.position = pos;
            StartRotationEffect();
        }
    }
}