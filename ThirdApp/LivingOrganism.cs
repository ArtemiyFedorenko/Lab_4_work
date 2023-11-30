class LivingOrganism
{
    protected int energy;
    protected int age;
    protected int size;

    public int Energy
    {
        get { return energy; }
        set { energy = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public int Size
    {
        get { return size; }
        set { size = value; }
    }

    public LivingOrganism(int energy, int age, int size)
    {
        Energy = energy;
        Age = age;
        Size = size;
    }
}