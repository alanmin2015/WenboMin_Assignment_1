using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    // Q1: GET: AddTen
    public class AddTenController : ApiController
    {   
        public int Get(int id)
        {
            return id+10;
        }
    }
    //Summary: Input parameter is integer id
    //Input: 21 Response: 31
    //Input: 0 Response: 10
    //Input: -9 Response: 1


    // Q2: GET: Square
    public class SquareController : ApiController
    {
        public int Get(int id)
        {
             return id*id;
        }
    }

    //Summary: Input parameter is integer id
    //Input: 2 Response: 4
    //Input: -2 Response: 4
    //Input: 10 Response: 100


    // Q3: GET: Greeting
    public class GreetingController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello World!" };
        }

     //Summary: Input parameter is null
     //Response: "Hello World!"


        // Q4: GET: Greeting/{id}
        public IEnumerable<string> Get(string id)
        {
            return new string[] { "Greetings to "+id+" people!" };
        }
    }

    //Summary: Input parameter is string id
    //Input: 3 Response: Greeting to 3 people!
    //Input: 6 Response: Greeting to 6 people!
    //Input: 0 Response: Greeting to 0 people!


    // Q5: GET: NumberMachine
    public class NumberMachineController : ApiController
    {
        public double Get(double id)
        {
            return (id*2+1)/(id-3);
        }
    }

    //Summary: Input parameter is double id
    //Input: 2 Response: -5
    //Input: 4 Response: 9
    //Input: 10 Response: 3
}
// Q6: GET: HostingCost
public class HostingCostController : ApiController
{
    public string Get(double id)
    {
   
        var day = Math.Floor(id / 14)+1;
        var sub = day * 5.5;
        string money = sub.ToString("N2");
        string Fee = day + " fortnights at $5.50/FN=$" + money + " CAD||";
        var tax = (sub * 0.13);
        string HST ="HST 13% = $"+ tax.ToString("N2")+" CAD||";
        string Total = "Total=$" + (tax + sub).ToString("N2") + " CAD";
        return Fee+"  "+HST+"  "+Total; 
        }
}

//Summary: Input parameter is double id
//Input: 0 Response: “1 fortnights at $5.50/FN = $5.50 CAD|| HST 13% = $0.72 CAD|| Total = $6.22 CAD”
//Input: 14 Response: “2 fortnights at $5.50/FN = $11.00 CAD|| HST 13% = $1.43 CAD|| Total = $12.43 CAD”
//Input: 15 Response: “2 fortnights at $5.50/FN = $11.00 CAD|| HST 13% = $1.43 CAD|| Total = $12.43 CAD”
//Input: 21 Response:  “2 fortnights at $5.50/FN = $11.00 CAD|| HST 13% = $1.43 CAD|| Total = $12.43 CAD”
//Input: 28 Response:  “3 fortnights at $5.50/FN = $16.50 CAD|| HST 13% = $2.14 CAD|| Total = $18.64 CAD”

