public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        
        var combinedPosAndSpeed = new (int pos, int speed)[position.Length];
        for(int i=0; i< position.Length; i++)
        {
            combinedPosAndSpeed[i] = (position[i], speed[i]);
        }


        Array.Sort(combinedPosAndSpeed, (a, b) => b.pos.CompareTo(a.pos));
        Stack<double> fleets = new();

        
        for(int i=0; i< position.Length; i++)
        {
            double timeToTarget = (double)(target-combinedPosAndSpeed[i].pos)/combinedPosAndSpeed[i].speed;

            if(fleets.Count ==0 || timeToTarget > fleets.Peek())
            {
                fleets.Push(timeToTarget);
            }
        }

        return fleets.Count;
    }
}
