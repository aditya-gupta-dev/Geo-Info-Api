using System;
using System.IO;
public class Database 
{
    public static string FilePath = "db/world_population.csv";
    public static List<Country> LoadData() 
    {
        List<Country> countries = new List<Country>();
        using(StreamReader reader = new StreamReader(FilePath))
        {
            string? exp = reader.ReadLine();
            while(true) 
            {
                string line = reader.ReadLine()!;

                if(line == null) 
                {
                    break;
                }

                string[] elements = line.Split(',');

                Country country = new Country()
                {
                    Rank = elements[0],
                    CCA3 = elements[1],
                    Name = elements[2],
                    Capital = elements[3],
                    Population = new Population()
                    {
                        PopulationIn2022 = elements[4],
                        PopulationIn2020 = elements[5],
                        PopulationIn2015 = elements[6],
                        PopulationIn2010 = elements[7],
                        PopulationIn2000 = elements[8],
                        PopulationIn1990 = elements[9],
                        PopulationIn1980 = elements[10],
                        PopulationIn1970 = elements[11]
                    },
                    Area = elements[12],
                    Density = elements[13],
                    GrowthRate = elements[14],
                    WorldPopulationPercentage = elements[15]
                };
               countries.Add(country);         
            }
        }
        return countries;
    }
}