using System;

namespace mta
{
    class Program
    {
        public class lN
        {
            public string name = "Line N";
            public string[] stops = new string[] { "Times Square", "34th", "28th", "23rd", "Union Square", "8th" };
        }

        public class lL
        {
            public string name = "Line L";
            public string[] stops = new string[] { "8th", "6th", "Union Square", "3rd", "1st" };
        }

        public class l6
        {
            public string name = "Line 6";
            public string[] stops = new string[] { "Grand Central", "33rd", "28th", "23rd", "Union Square", "Astor Place" };
        }

        static void Main(string[] args)
        {
            static string singleLineTrip(string lineName, string stationIn, string stationOut)
            {
                // lines
                lN lineN = new lN();
                lL lineL = new lL();
                l6 line6 = new l6();

                // variables
                string line;
                int stationInIndex;
                int stationOutIndex;
                string[] tripDirection;


                if (lineName == lineN.name)
                {
                    // getting the index of the stations
                    stationInIndex = Array.IndexOf(lineN.stops, stationIn);
                    stationOutIndex = Array.IndexOf(lineN.stops, stationOut);

                    // checking the trip direction
                    if (stationInIndex < stationOutIndex)
                    {
                        tripDirection = lineN.stops;
                    }
                    else
                    {
                        // user is going in the opposite direction
                        Array.Reverse(lineN.stops);
                        tripDirection = lineN.stops;

                        stationInIndex = Array.IndexOf(tripDirection, stationIn);
                        stationOutIndex = Array.IndexOf(tripDirection, stationOut);
                    }

                    // display trip
                    line = lineN.name;

                    Console.WriteLine($"You must travel through the following stops on the { line }:");
                    for (int i = stationInIndex; i <= stationOutIndex; i++)
                    {
                        Console.WriteLine($"{tripDirection[i]}");
                    }
                    Console.WriteLine();

                    return (stationOut);
                }
                else if (lineName == lineL.name)
                {
                    // getting the index of the stations
                    stationInIndex = Array.IndexOf(lineL.stops, stationIn);
                    stationOutIndex = Array.IndexOf(lineL.stops, stationOut);

                    // checking the trip direction
                    if (stationInIndex < stationOutIndex)
                    {
                        tripDirection = lineL.stops;
                    }
                    else
                    {
                        // user is going in the opposite direction
                        Array.Reverse(lineL.stops);
                        tripDirection = lineL.stops;

                        stationInIndex = Array.IndexOf(tripDirection, stationIn);
                        stationOutIndex = Array.IndexOf(tripDirection, stationOut);
                    }

                    // display trip
                    line = lineL.name;
                    
                    Console.WriteLine($"You must travel through the following stops on the { line }:");
                    for (int i = stationInIndex; i <= stationOutIndex; i++)
                    {
                        Console.WriteLine($"{tripDirection[i]}");
                    }
                    Console.WriteLine();

                    return stationOut;
                }
                else if (lineName == line6.name)
                {
                    // getting the index of the stations
                    stationInIndex = Array.IndexOf(line6.stops, stationIn);
                    stationOutIndex = Array.IndexOf(line6.stops, stationOut);

                    // checking the trip direction
                    if (stationInIndex < stationOutIndex)
                    {
                        tripDirection = line6.stops;
                    }
                    else
                    {
                        // user is going in the opposite direction
                        Array.Reverse(line6.stops);

                        tripDirection = line6.stops;

                        stationInIndex = Array.IndexOf(tripDirection, stationIn);
                        stationOutIndex = Array.IndexOf(tripDirection, stationOut);
                    }

                    // display trip
                    line = line6.name;
                    Console.WriteLine($"You must travel through the following stops on the { line }:");
                    for (int i = stationInIndex; i <= stationOutIndex; i++)
                    {
                        Console.WriteLine($"{tripDirection[i]}");
                    }
                    Console.WriteLine();

                    return stationOut;
                }
                else
                {
                    return ("Line not available");
                }
            }

            static void trip (string lineIn, string stationIn, string lineOut, string stationOut)
            {
                // first line trip
                string stationChange = "Union Square";
                singleLineTrip(lineIn, stationIn, stationChange);

                Console.WriteLine($"Change to {lineOut}");
                Console.WriteLine();

                // second line trip
                singleLineTrip(lineOut, stationChange, stationOut);
            }

            //singleLineTrip("Line 6", "33rd", "Union Square");
            //singleLineTrip("Line 6", "Union Square", "33rd");

            trip("Line N", "34th", "Line 6", "Grand Central");

        }
    }
}
