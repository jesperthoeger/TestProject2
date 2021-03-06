﻿using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace TestProject2
{
    public class TestProject2Info : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "TestProject2";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("d10eba05-8f3d-43c5-87ad-9d70c597faf0");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
