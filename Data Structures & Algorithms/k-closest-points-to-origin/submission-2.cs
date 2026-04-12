public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        List<(int x, int y,double dist)> pointsList = new();
        for(int i=0;i<points.Length;i++){
            var point = points[i];
            var dist = Math.Sqrt(point[0]*point[0] + point[1]*point[1]);
            pointsList.Add((point[0],point[1],dist));
        }
        var res = pointsList.OrderBy(x => x.dist ).Take(k).Select(x=> new int[]{x.x , x.y }).ToArray();
 
        return res;
    }
}
