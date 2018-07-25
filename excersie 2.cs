using System;

class Program
{
    static void Main(string[] args) {
    {
        using (Datatable x = new Datatable())
        {   
            x.colums.add("forename", typeof(string));
            x.colums.add("surname", typeof(string));
            x.colums.add("age", typeof(integer));
            x.colums.add("favourite food", typeof(string));
            
            x.Rows.Add("...", DateTime.Now);
            
            Console.WriteLine(x.Rows[0].Field<string>(0));
        }
    }
}
