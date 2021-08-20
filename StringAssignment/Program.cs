using System;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clone
            //makes a clone of the given string i.e s1.
            string s1 = "hello";
            string s2 = (string)s1.Clone();
            Console.WriteLine(s2);

            //Compare
            //compares the string
            //s1==s2 returns 0
            //s1>s2 returns 1
            //s1<s2 returns -1
            string s3 = "hii";
            string s4 = "hola";
            string s5 = "hii";
            Console.WriteLine(string.Compare(s3,s4));//s4 is greater than s3 so will return -1
            Console.WriteLine(string.Compare(s3,s5));//s3==s5 so will return 0.

            //CompareOrdinal
            //This method is used to compare two specified string objects or substrings using numeric values
            string s6 = "hello";
            string s7 = "asp";
            Console.WriteLine(string.CompareOrdinal(s6,s7));

            //CompareTo
            //if strings are equal returns 0 else returns 1
            Console.WriteLine(s1.CompareTo(s6));//returns 0 as both strings are same.

            //Concat
            //used to concat 2 strings
            string st1 = "Incub";
            string st2 = "Xperts";
            string str;
            str = string.Concat(st1, st2);
            Console.WriteLine("The concatenated string is:{0}",str);

            //Contains
            //if a substring is present in the mentioned string then returns true else false
            string st3 = "IncubXperts";
            string st4 = "Xperts";
            Console.WriteLine(st3.Contains(st4));//will return true

            //Copy
            //make copy of a string
            string st5 = string.Copy(st3);
            Console.WriteLine(st5);//will return incubxperts

            //CopyTo
            //copies the given required substring into another string.
            string st8 = "Hello guys, How Are You?";
            char[] ch = new char[15];
            st8.CopyTo(12, ch, 0, 12);
            Console.WriteLine(ch);//will return How Are You?

            //EndsWith
            //checks wheather the ending substring matches with the given string or not.
            string st9 = "Increment++";
            string st10 = "Increment++";
            bool a, b;

            a = st9.EndsWith("++");
            b = st10.EndsWith("--");

            Console.WriteLine(a.ToString());//true
            Console.WriteLine(b.ToString());//false

            //Equals
            //checks wheather 2 strings are equal or not
            string st11 = "helloworld";
            string s12 = "helloworld";
            Console.WriteLine(st11.Equals(s12));//true

            //Format
            DateTime d1 = new DateTime(2021, 8, 19);
            string st13 = string.Format("{0:D}", d1);
            Console.WriteLine(st13);

            //GetEnumerator
            //converts string object into character enumerator
            string l = "loops";
            CharEnumerator ce = l.GetEnumerator();
            while (ce.MoveNext())
            {
                Console.WriteLine(ce.Current);//l o o p s in iteration
            }

            //GetHashCode
            //used to get the hash code of the specified string
            int p, q, r;

            string a1 = "hey..";
            string a2 = "guyzz..";
            string a3 = "good night..";

            p = a1.GetHashCode();
            q = a2.GetHashCode();
            r = a3.GetHashCode();

            Console.WriteLine("Display Hashcode..");
            Console.WriteLine("string 1: {0} and hashcode:{1}",a1,p);//displays string and hashcode.
            Console.WriteLine("string 2: {0} and hashcode:{1}", a2, q);
            Console.WriteLine("string 3: {0} and hashcode:{1}", a3, r);

            //GetType
            //returns the type 
            string st14 = "hello";
            Console.WriteLine(st14.GetType());//system.string

            //GetTypeCode
            //returns typecode i.e string
            string st15 = "hello";
            Console.WriteLine(st14.GetTypeCode());

            //IndexOf
            //returns the index of the chararcter
            string st16 = "tanmay";
            int index1 = st16.IndexOf('m');
            Console.WriteLine("the index of m is :{0}",index1);//3

            //Insert
            //inserts a string at the given position
            string st17 = "karnagar";
            Console.WriteLine("the current string is: {0}",st17);//karnagar

            Console.WriteLine("the new string is : {0}",st17.Insert(3,"ven"));//karvenagar

            //Intern
            //used to retrieve refrence to the specified string
            string s18 = "hello interns";
            string s19 = string.Intern(s18);
            Console.WriteLine(s19);//hello interns

            //IsInterned

            string s20 = string.IsInterned(s18);
            Console.WriteLine(s20);//hello interns

            //IsNormalized
            //used to check whether the given string is in a particular unicode normalization or not
            string s21 = "hello there";
            bool value;

            value = s21.IsNormalized();
            Console.WriteLine("string is:{0}",s21);
            Console.WriteLine("is the string in the normalized form:{0}",value);//true

            //IsNullOrEmpty
            //tells wheather the string is empty or not
            string s22 = "tanmay";
            string s23 = "";
            string s24 = null;

            bool b1 = string.IsNullOrEmpty(s22);
            bool b2 = string.IsNullOrEmpty(s23);
            bool b3 = string.IsNullOrEmpty(s24);

            Console.WriteLine(b1);//false
            Console.WriteLine(b2);//true
            Console.WriteLine(b3);//true

            //IsNullOrWhiteSpace
            //used to check wheather the string is null or white space characters.
            string s25 = " ";
            string s26 = "\t";
            string s27 = "tanmay";

            bool b4 = string.IsNullOrWhiteSpace(s25);
            bool b5 = string.IsNullOrWhiteSpace(s26);
            bool b6 = string.IsNullOrWhiteSpace(s27);

            Console.WriteLine(b4);//true
            Console.WriteLine(b5);//true
            Console.WriteLine(b6);//false

            //Join
            //used to concatnate the members of collection or array
            object[] array = { "hi", "interns", 8000 };
            string s28 = string.Join(",", array);

            Console.WriteLine("value of string is {0}",s28);

            //LastIndexOf
            //returns the index of the last matched character
            string s29 = "tanmay";
            int last = s29.LastIndexOf('a');
            Console.WriteLine("the last index is:{0}",last);//4


            //LastIndexOfAny
            //used to find the index position of the last occurence of one or more characters specified in string
            string s30 = "tanmaym";
            char[] chh = { 'a', 'm' };
            int idx = s30.LastIndexOfAny(chh);
            Console.WriteLine(idx);//6 index of m

            //Normalize
            //use to get the new strig whose textual value is same as this string 
            string s31 = "pune";
            string s32 = s31.Normalize();
            Console.WriteLine(s32);//pune

            //PadLeft
            //used to right align the characcters in the string by paddig them with spaces.
            string s33 = "maharashtra";
            Console.WriteLine("padding:{0}",s33.PadLeft(20));//                  maharashtra

            //PadRight
            // used to left align the characters in the string
            Console.WriteLine("padding:{0}",s33.PadRight(20));//maharashtra

            //Remove
            //remove all the characters from the specified string
            Console.WriteLine("removed string :{0}",s33.Remove(4));//maha

            //Replace
            //used to replace all the specefied unicode characters
            Console.WriteLine("replaced string :{0}",s33.Replace('a','X'));//mxhxrxshtrx

            //split
            //returns an array odf string generated by splitting of original string seperated by the delimiters
            string s34 = "hello incubxeprts";
            string[] s35 = s34.Split(' ');
            foreach(string s36 in s35)
            {
                Console.WriteLine(s36);//hello
                                       //incubxperts
            }

            //StartsWith
            //used to check whether the beginning of the string intance matches with the specefied string
            string s37 = "India";
            bool b7 = s37.StartsWith("I");
            bool b8 = s37.StartsWith("i");
            Console.WriteLine(b7);//TRUE
            Console.WriteLine(b8);//FALSE

            //SubString
            //used to retrieve the string from the current instance
            string s38 = "India is my country";
            Console.WriteLine("the substring is:{0}",s38.Substring(6));

            //ToCharArray
            //used to copy the characters from a specefied string
            char[] cp = s38.ToCharArray();
            Console.WriteLine("character array is:");

            for(int i = 0; i < cp.Length; i++)
            {
                Console.Write(" " + cp[i]);// I n d i a i s m y c o u n t r y
            }
            Console.WriteLine();


            //ToLower
            //converts every character to the lower case
            string s39 = "IncubXperts";
            string lwr = s39.ToLower();
            Console.WriteLine(lwr);//incubxperts

            //ToLowerInvariant
            //converts every character to the lower case using casing rules
            string lwrinvrt = s39.ToLowerInvariant();
            Console.WriteLine(lwrinvrt);//incubxperts

            //ToString
            //used to get instance of string
            int s40 = 1234;
            string S41 = s40.ToString();
            Console.WriteLine(S41);//1234

            //ToUpper
            //converts every character to the upper case
            string upper = s39.ToUpper();
            Console.WriteLine(upper);//INCUBXPERTS

            //Trim
            //used to remove all the spaces from the current string

            string s42 = "   heya..  ";
            Console.WriteLine("After trimimg: {0}",s42.Trim());//heya..

            //TrimEnd
            //used to remove the spaces at the end of the string
            Console.WriteLine("After applying trimend:{0}",s42.TrimEnd());//    heya..

            //TrimStart
            //used to remove the spaces or characters at the start of the defined string
            string s43 = "***abc***";
            char[] ct = { '*' };
            Console.WriteLine(s43.TrimStart(ct));//abc***

            //







            















































        }
    }
}
