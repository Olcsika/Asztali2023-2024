StreamReader olvas = new StreamReader("nevek.txt");
string[] vag =olvas.ReadToEnd().Split(',');
Array.Sort(vag);

olvas.Close();
/*
foreach (string i in vag)
{
    Console.WriteLine(i);
}
*/
Console.WriteLine(vag[0]);