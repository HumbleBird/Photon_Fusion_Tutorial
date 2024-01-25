using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct NetworkInputData : INetworkInput
{
    public const byte MOUSEBUTTON1 = 0x01;
    public const byte MOUSEBUTTON2 = 0x02;

    public byte buttons;
    public Vector3 direction;
}
