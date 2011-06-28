﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestSupportLibrary
{

    public class PublicType
    {
        public static object InternalInstance
        {
            get{ 
                return new InternalType();
            }
        }

        public bool PrivateMethod(object param)
        {
            return param != null;
        }
    }


    internal class InternalType
    {
        public bool InternalMethod(object param)
        {
            return param != null;
        }
    }
   
}
