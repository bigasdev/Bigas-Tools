using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tag : MonoBehaviour
{
    public Tags tagRef;
    public string tagName;
}
public enum Tags{
    PLACE,
    CHAR,
    OBJECT
}
