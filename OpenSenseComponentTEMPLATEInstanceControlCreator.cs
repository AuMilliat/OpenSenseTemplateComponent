using System.Composition;
using System.Windows;
using OpenSense.Component.TEMPLATE_GROUP;
using OpenSense.Component.Contract;
using OpenSense.Wpf.Component.Contract;


namespace OpenSense.Component.TEMPLATE_GROUP
{
    [Export(typeof(IInstanceControlCreator))]
    public class TEMPLATEInstanceControlCreator : IInstanceControlCreator
    {

        public bool CanCreate(object instance) => instance is TEMPLATE;

        public UIElement Create(object instance) => new TEMPLATEInstanceControl() { DataContext = instance };
    }
}
