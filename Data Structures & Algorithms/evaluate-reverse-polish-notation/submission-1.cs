public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> calculatedVal = new ();

        for(int i=0; i< tokens.Length; i++)
        {
            var val = tokens[i];
            if(val== "+" || val=="-" || val== "*" || val =="/")
            {
                var rightOp = calculatedVal.Pop();

                if(calculatedVal.Count <1) continue;

                var leftOp = calculatedVal.Pop();
                
                if (val == "+") calculatedVal.Push(leftOp + rightOp);
                if (val == "-") calculatedVal.Push(leftOp - rightOp);
                if (val == "*") calculatedVal.Push(leftOp * rightOp);
                if (val == "/") calculatedVal.Push(leftOp / rightOp);
            }
            else{
                calculatedVal.Push(Convert.ToInt32(val));
            }
        }
        return calculatedVal.Pop();
    }
}
