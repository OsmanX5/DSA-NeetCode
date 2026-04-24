/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        List<Interval> visited = new ();
        foreach(var interval in intervals){

            foreach(var x in visited){
                if(IsInRange(interval.start,x) || IsInRange(interval.end,x))
                    return false;
            }

            visited.Add(interval);
        }
        return true;


        bool IsInRange(int x ,Interval interval){
            return x< interval.end && x>= interval.start;
        }
    }
}
