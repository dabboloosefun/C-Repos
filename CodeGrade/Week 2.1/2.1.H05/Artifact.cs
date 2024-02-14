public class Artifact
{
    public double Rarity;
    public double Condition;
    public Artifact(double rarity, double condition)
    {
        this.Rarity = rarity;
        this.Condition = condition;
    }

    public double GetValue()
    { 
        return this.Rarity * this.Condition;
    }


    public string Appraise()
    {
        return $"Value: {GetValue()}";
    }


    public bool isEqualTo(Artifact comparedArtifact)
    {
        if (comparedArtifact == null) return false;
        if (comparedArtifact.Rarity == this.Rarity && comparedArtifact.Condition == this.Condition)
        {
            return true;
        }
        return false;
    }
}