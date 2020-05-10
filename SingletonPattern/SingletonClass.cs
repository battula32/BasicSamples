using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    public class SingletonClass
    {
        private static SingletonClass singleton;

        private string testString;
        private SingletonClass()
        {
        }

        public static SingletonClass Singleton
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new SingletonClass();
                }

                return singleton;
            }
        }

        public string TestString
        {
            get
            {
                return this.testString;
            }

            set
            {
                this.testString = value;
            }
        }
    }

    public sealed class SingletonClass1
    {
        private readonly static SingletonClass1 singletonObject = new SingletonClass1();
        private string testString;
        private SingletonClass1()
        {
        }

        public static SingletonClass1 SingletonObject
        {
            get
            {
                return singletonObject;
            }
        }

        public string TestString
        {
            get
            {
                return this.testString;
            }

            set
            {
                this.testString = value;
            }
        }
    }

    public class SingletonThreadSync
    {
        private static SingletonThreadSync singletonThreadSync;
        private static object syncObj = new object();
        private SingletonThreadSync()
        {
        }

        public static SingletonThreadSync SingletonThread
        {
            get
            {
                if (singletonThreadSync == null)
                {
                    lock (syncObj)
                    {
                        if (singletonThreadSync == null)
                        {
                            singletonThreadSync = new SingletonThreadSync();
                        }
                    }
                }

                return singletonThreadSync;
            }
        }
    }
}
