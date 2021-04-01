using System;

namespace newfeatures1.NullReferenceChecks
{
    public class SomeManager
    {
        private readonly NullableSuperDispatcher _dispatcher;

        public SomeManager(NullableSuperDispatcher dispatcher)
        {
            _dispatcher = dispatcher ?? throw new ArgumentNullException(nameof(dispatcher));
        }
        
        // public SomeManager(NullableSuperDispatcher dispatcher!)
        // {
        //     _dispatcher = dispatcher;
        // }
    }
}