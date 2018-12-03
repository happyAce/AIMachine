using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace xlj
{
    public static class Singleton<T>where T:class
    {
        private static T _instance;
        static Singleton()
        {
            return;
        }
        public static void Create()
        {
            _instance = (T)Activator.CreateInstance(typeof(T), true);
            return;
        }
        public static T Instance
        {
            get
            {
                if(_instance == null)
                {
                    Create();
                }
                return _instance;
            }
        }
        public static void Destory()
        {
            _instance = null;
            return;
        }

    }
}
