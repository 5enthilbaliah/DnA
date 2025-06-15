// ReSharper disable InconsistentNaming
namespace Ds05.Trees;

public class IslandCoordinate
{
    public int Column { get; set; }
    public int Row { get; set; }
    

    public string Key => $"{Row}-{Column}";

    // Directions
    public IslandCoordinate? N { get; set; }
    public IslandCoordinate? E { get; set; }
    public IslandCoordinate? S { get; set; }
    public IslandCoordinate? W { get; set; }

    public IslandCoordinate? NE { get; set; }
    public IslandCoordinate? SE { get; set; }
    public IslandCoordinate? SW { get; set; }
    public IslandCoordinate? NW { get; set; }

    public int Visit(HashSet<string> visited)
    {
        if (visited.Contains(Key)) return 0;

        var visit = 1;
        visited.Add(Key);
        
        visit += N?.Visit(visited) ?? 0;
        visit += NE?.Visit(visited) ?? 0;
        visit += E?.Visit(visited) ?? 0;
        visit += SE?.Visit(visited) ?? 0;
        visit += S?.Visit(visited) ?? 0;
        visit += SW?.Visit(visited) ?? 0;
        visit += W?.Visit(visited) ?? 0;
        visit += NW?.Visit(visited) ?? 0;
        
        return visit;
    }
}

public class FindLargestIsland(int[,] map)
{
    public int Execute()
    {
        var coordinateDictionary = new Dictionary<string, IslandCoordinate>();
        Func<int, int, IslandCoordinate> safeIslandCoordinate = (row, column) =>
        {
            var key = $"{row},{column}";
            if (coordinateDictionary.TryGetValue(key, out IslandCoordinate? value)) return value;
            value = new IslandCoordinate
            {
                Row = row,
                Column = column,
            };
            coordinateDictionary[key] = value;
            return value;
        };

        var noOfRows = map.GetLength(0);
        var noOfColumns = map.GetLength(1);

        for (var row = 0; row < noOfRows; row++)
        {
            for (var column = 0; column < noOfColumns; column++)
            {
                if (map[row, column] != 1) continue;

                var coordinate = safeIslandCoordinate(row, column);

                // check for island to North
                if (row > 0 && map[row - 1, column] == 1)
                {
                    coordinate.N = safeIslandCoordinate(row - 1, column);
                }
                
                // check for island to NorthEast
                if (row > 0 && column < noOfColumns - 1 && map[row - 1, column + 1] == 1)
                {
                    coordinate.NE = safeIslandCoordinate(row - 1, column + 1);
                }

                // check for island to East
                if (column < noOfColumns - 1 && map[row, column + 1] == 1)
                {
                    coordinate.E = safeIslandCoordinate(row, column + 1);
                }
                
                // check for island to SouthEast
                if (row < noOfRows - 1 && column < noOfColumns - 1 && map[row + 1, column + 1] == 1)
                {
                    coordinate.SE = safeIslandCoordinate(row + 1, column + 1);
                }

                // check for island to South
                if (row < noOfRows - 1 && map[row + 1, column] == 1)
                {
                    coordinate.S = safeIslandCoordinate(row + 1, column);
                }
                
                // check for island to SouthWest
                if (row < noOfRows - 1 && column > 0 && map[row + 1, column - 1] == 1)
                {
                    coordinate.SW = safeIslandCoordinate(row + 1, column - 1);
                }

                // check for island to West
                if (column > 0 && map[row, column - 1] == 1)
                {
                    coordinate.W = safeIslandCoordinate(row, column - 1);
                }
                
                // check for island to NorthWest
                if (row > 0 && column > 0 && map[row - 1, column - 1] == 1)
                {
                    coordinate.NW = safeIslandCoordinate(row - 1, column - 1);
                }
            }
        }
        
        var visited = new HashSet<string>();
        var maxVisits = 0;
        foreach (var key in coordinateDictionary.Keys)
        {
            if (!visited.Contains(key))
            {
                var visitCount = coordinateDictionary[key].Visit(visited);
                
                if (visitCount > maxVisits)
                    maxVisits = visitCount;
            }
        }

        return maxVisits;
    }
}