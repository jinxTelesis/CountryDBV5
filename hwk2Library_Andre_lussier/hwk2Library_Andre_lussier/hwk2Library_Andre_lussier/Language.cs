﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

//***********************************************
// File: Language.cs
//
// Purpose: Contains class definition of Language.
//          Language containts name, native name and two
//          iso639 language codes along with getters and 
//          setters and default constructor and a ToString method
//
// Written By: Andre Lussier
// 
// Compiler: Visual Studios 2017 
//
//*************************************************


namespace hwk2Library_Andre_lussier
{
    [DataContract]
    public class Language
    {
        #region private member variables
        private string name;
        private string nativeName;
        private string iso639_1;
        private string iso639_2;

        #endregion

        //*********************************
        // default constructor for language
        // sets defaults to english 
        // and spanish as second
        //**********************************

        public Language()
        {
            this.name = "English";
            this.nativeName = "English2";
            this.iso639_1 = "en";
            this.iso639_2 = "es";
        }

        #region properties of Language
        /// <summary>
        ///  Property for Language
        ///  
        ///  Purpose basically getters and setter shorthand for name
        ///  
        /// </summary>

        [DataMember(Name = "name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        ///  Property for Language
        ///  
        ///  Purpose: basically getters and setter shorthand for nativeName
        /// </summary>

        [DataMember(Name = "nativename")]
        public string NativeName
        {
            get
            {
                return this.nativeName;
            }

            set
            {
                this.nativeName = value;
            }
        }

        /// <summary>
        ///  Property for Language
        ///  Purpose: basically getters and setter shorthand
        ///  for .iso639_1
        /// </summary>

        [DataMember(Name="iso639_1")]
        public string Iso639_1
        {
            get
            {
                return this.iso639_1;
            }

            set
            {
                this.iso639_1 = value;
            }
        }

        /// <summary>
        ///  Property: for Language
        ///  
        ///  Purpose: getters and setter shorthand for iso639_2;
        /// </summary>

        [DataMember(Name="iso639_2")]
        public string Iso639_2
        {
            get
            {
                return this.iso639_2;
            }

            set
            {
                this.iso639_2 = value;
            }
        }

        #endregion

        #region methods of Language

        /// <summary>
        ///  Method: ToString 
        ///  
        /// Purpose: Override of the objects default
        /// sets string to human readable form for name,
        /// nativeName, iso639_1, is0639_2
        /// updated to print unknown if null encountered
        /// will not throw exceptions
        /// null conditional check added to values that might not be null
        /// for consistency 
        /// 
        /// </summary>
       

        public override string ToString()
        {

            String s = "";

            if(this.name != null) 
            {
                s += "Language name: " + this.name + "\n";
            }
            else
            {
                s += "Language name: unknown " + "\n";
            }

            if(this.NativeName != null)
            {
                s += "nativeName: " + this.nativeName + "\n";
            }
            else
            {
                s += "nativeName: unknown " + "\n";
            }

            if(this.Iso639_1 != null)
            {
                s += "iso639_1 is set to: " + this.iso639_1 + "\n";
            }
            else
            {
                s += "iso639_1 is set to: unknown " + "\n";
            }

            if(this.iso639_2 != null)
            {
                s += "iso639_2 is set to: " + this.iso639_2 + "\n";
            }
            else
            {
                s += "iso639_2 is set to: unknown " + "\n\n\n\n";
            }

            return s;
        }

        #endregion

    }
}
