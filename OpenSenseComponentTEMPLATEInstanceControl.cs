using System;
using System.Composition;
using Microsoft.Psi;
using OpenSense.Component.Contract;

namespace OpenSense.Component.TEMPLATE_GROUP
{
    [Serializable]
    public class TEMPLATEInstance : ConventionalComponentConfiguration
    {
        private bool mute = false;

        public bool Mute
        {
            get => mute;
            set => SetProperty(ref mute, value);
        }

		// TODO: Add more properties if needed
      
        public override IComponentMetadata GetMetadata() => new TEMPLATEMetadata();

        protected override object Instantiate(Pipeline pipeline, IServiceProvider serviceProvider) => new TEMPLATE(pipeline)
        {
            Mute = Mute,
			// TODO: Add more here too
        };
    }
}