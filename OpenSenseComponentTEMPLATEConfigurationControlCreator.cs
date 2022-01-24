using System.Composition;
using System.Windows;
using OpenSense.Component.TEMPLATE_GROUP;
using OpenSense.Component.Contract;
using OpenSense.Wpf.Component.Contract;


namespace OpenSense.Component.TEMPLATE_GROUP
{
    [Export(typeof(IConfigurationControlCreator))]
    public class TEMPLATEConfigurationControlCreator : IConfigurationControlCreator
    {

        public bool CanCreate(ComponentConfiguration configuration) => configuration is TEMPLATEConfiguration;

        public UIElement Create(ComponentConfiguration configuration) => new TEMPLATEConfigurationControl() { DataContext = configuration };
    }
}
