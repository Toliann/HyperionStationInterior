
using UnityEngine;

namespace HyperionStation
{

    public static class Common
    {

        static public bool CollideWithPlayer(Collider collider_obj)
        {
            if (collider_obj.tag == "Player") { return true; }
            GameObject gobj = collider_obj.gameObject;
            while (gobj != null)
            {
                if (gobj.tag == "Player") { return true; }
                if (gobj.transform.parent == null) { return false; }
                gobj = gobj.transform.parent.gameObject;
            };
            return false;


        }
        static public bool CollideWithEnemy(Collider collider_obj)
        {
            if (collider_obj.tag == "Enemy") { return true; }
            GameObject gobj = collider_obj.gameObject;
            while (gobj != null)
            {
                if (gobj.tag == "Enemy") { return true; }
                if (gobj.transform.parent == null) { return false; }
                gobj = gobj.transform.parent.gameObject;
            };
            return false;


        }
    }

}
