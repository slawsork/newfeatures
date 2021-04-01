#nullable enable
namespace newfeatures1.NullReferenceChecks
{
    public class NullableSuperDispatcher
    {
        private string _name;
        private string? _target; // <- c#8 feature
        
        public NullableSuperDispatcher(string name)
        {
            //_name = name;
            var length = _target.Length;
            //var length = _target!.Length;
        }
    }
}