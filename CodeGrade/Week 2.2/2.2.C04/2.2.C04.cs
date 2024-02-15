public class DNA
{
    string Seq;
    public DNA(string seq)
    {
        this.Seq = seq;
    }


    public DNA Replicate1() => new DNA(this.Seq);


    public DNA Replicate2() => this;


    public void Mutate(string newSeq) => this.Seq = newSeq;
}