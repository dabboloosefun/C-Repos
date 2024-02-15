public class DNA
{
    DNA Ancestor;
    string Seq;
    public DNA(DNA ancestor, string seq)
    {
        this.Ancestor = ancestor;
        this.Seq = seq;
    }

    public DNA Replicate()
    {
        return new DNA(this, MutateTransition(this.Seq));
    }

}