﻿using UnityEngine;
using System.Collections;

public class TriangleComponent : ShapeComponent
{
    // Use this for initialization
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void WhatAmI()
    {
        Debug.Log("I AM A TRIANGLE!");
    }
}
