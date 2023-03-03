namespace Specification.Rules.Abstractions
{
    public interface IRule<in TModel>
    {
        //está satisfeito
        bool IsSatisfiedBy(TModel model);
    }
}
