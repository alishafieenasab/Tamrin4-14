Console.WriteLine("Enter Number of Excercise : ");
Console.WriteLine("First Excercise : 1");
Console.WriteLine("Second Excercise : 2");
Console.WriteLine("Third Excercise : 3");
int x = Convert.ToInt32(Console.ReadLine());

switch (x)
{
    case 1:
        Console.WriteLine("Please Enter an Integer : ");
        int n = Convert.ToInt32(Console.ReadLine());
        StringNInt("ali", n);
        break;
    case 2:
        delDel("adelsethdel");
        break;
    case 3:
        Console.WriteLine(stringE("hello"));
        break;
    default: 
        Console.WriteLine("Invalid Integer");
        break;
}


//---------------------Methods-------------------

void StringNInt(string aString, int aInt)
{
    for (int i = 0; i < aString.Length; i += aInt)
    {
        Console.Write(aString[i]);
    }
}


//----------------------Part2------------------------



void delDel(string aString)
{
    for (int i = 0; i < aString.Length; i++)
    {
        if(aString[i] == 'd' && aString[i + 1] == 'e' && aString[i + 2] == 'l')
        {
            i += 2;
            continue;
        }
        Console.Write(aString[i]);
    }
}


//-----------------------Part3-------------------------



bool stringE(string aString)
{
    bool flag = false;
    int j = 0;
    for(int i = 0; i < aString.Length; i++)
    {
        if(aString[i] == 'e')
            j++;
        if(j >= 1 && j <= 3)
            flag = true;
    }
    return flag;
}