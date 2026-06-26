using System;

public class Dapartment
{
    public int Id { get; set; }
    public string F_Name { get; private set; }
    public string L_Name { get; private set; }


    public void SetName(string fname, string lname)
    {
        F_Name = fname;
        L_Name = lname;
    }


}



