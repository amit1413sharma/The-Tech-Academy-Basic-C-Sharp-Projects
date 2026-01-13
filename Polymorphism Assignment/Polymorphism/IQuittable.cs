using System; // Provides basic system functionality

namespace PolymorphismAssignment
{
    // Interface that defines quitting behavior
    interface IQuittable
    {
        // Void method that classes implementing this interface must define
        void Quit();
    }
}
