using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA.Utillities
{
    public class Base
    {
        public static IWebDriver Driver;// making it static to be able to use it anywhere without having initialize it
    }
}
