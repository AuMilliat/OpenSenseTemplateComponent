using System;
using System.Composition;
using Microsoft.Psi;
using OpenSense.Component.Contract;

namespace OpenSense.Component.TEMPLATE_GROUP
{

    [Export(typeof(IComponentMetadata))]
    public class TEMPLATEMetadata : ConventionalComponentMetadata
    {

        public override string Description => "Template Component for OpenSense";

        protected override Type ComponentType => typeof(TEMPLATE);

        public override ComponentConfiguration CreateConfiguration() => new TEMPLATEConfiguration();
    }
}
