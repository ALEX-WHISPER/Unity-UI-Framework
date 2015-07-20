﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 *	
 *  
 *
 *	by Xuanyi
 *
 */

namespace MoleMole
{
	public static class TransformExtension 
    {

	    public static Transform GetFirstChild(this Transform trans)
        {
            return trans.GetChild(0);
        }

        public static Transform GetLastChild(this Transform trans)
        {
            return trans.GetChild(trans.childCount - 1);
        }

        public static void DestroyChildren(this Transform trans)
        {
            foreach (Transform child in trans)
            {
                GameObject.Destroy(child.gameObject);
            }
        }

        public static Transform AddChild(this Transform trans, Transform prefab, string name = null)
        {
            Transform childTrans = GameObject.Instantiate(prefab) as Transform;
            childTrans.SetParent(trans, false);
            if (name != null)
	        {
                childTrans.gameObject.name = name;
	        }
            return childTrans;
        }
	}
}
