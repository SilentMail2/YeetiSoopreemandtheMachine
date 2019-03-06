using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{

    //world cords
    private Vector3 worldCord3d;

    //Zone
    private ZoneTypes zone;
    public enum ZoneTypes
    {
        A,
        B,
        C,
        None
    }

    public Vector3 WorldCord3D
    {
        get { return worldCord3d; }
    }
    public ZoneTypes Zone
    {
        get { return zone; }
    }

    public Location(Vector3 worldCords3D)
    {
        this.worldCord3d = worldCords3D;

        zone = ZoneTypes.None;
    }
    public Location (ZoneTypes zone)
    {
        worldCord3d = Vector3.zero;
        this.zone = zone;
    }
    public bool Compare(Location location)
    {
        if (worldCord3d!=Vector3.zero && location.worldCord3d == worldCord3d)
        {
            return true;
        }
        else if (zone != ZoneTypes.None && location.zone == zone)
        {
            return true;
        }
        else { return false; }
    }


}
