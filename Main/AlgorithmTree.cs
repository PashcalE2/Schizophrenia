namespace Schizophrenia {
    public abstract class AlgorithmNode {


        public AlgorithmNode() {
        }

        public abstract void Run(Context ctx);

        public abstract bool IsNext(Context ctx);
    }

    public class AlgorithmTree {
        public AlgorithmTree() {
        }
    }
}
