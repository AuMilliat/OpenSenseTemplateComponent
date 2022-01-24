using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using CLI;
using Microsoft.Psi;
using Microsoft.Psi.Components;

namespace OpenSense.Component.TEMPLATE_GROUP
{
    public class TEMPLATE : Subpipeline, INotifyPropertyChanged
    {

		/* Begin props */
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

		// mute property to skip message on demand
        private bool mute = false;

        public bool Mute
        {
            get => mute;
            set => SetProperty(ref mute, value);
        }
		// TODO: Add more properties if needed
		
        /* End props */


		/* Begin in/out puts*/
		
		// Connector for the reciever
        private Connector<INPUT_TYPE> InConnector;

        // Receiver that encapsulates the input
        public Receiver<INPUT_TYPE> In => InConnector.In;

        // Emitter that encapsulates the output 
        public Emitter<OUTPUT_TYPE> Out{ get; private set; }
		
		// TODO: Add more if needed and renaming properly the reciever & emitter
		
		/* End in/out puts */
		
		
		// Constructor
        public TEMPLATE(Pipeline pipeline) : base(pipeline)
        {
			// Connecting input and output
            InConnector = CreateInputConnectorFrom<INPUT_TYPE>(pipeline, nameof(In));
			Out = pipeline.CreateEmitter<OUTPUT_TYPE>(this, nameof(this.Out));
			//TODO: Add more connection if needed
			

			// Registering method that will be called for every input
            InConnector.Out.Do(Process);
        }

		// Main class method that is called for each message in.
        private void Process(INPUT_TYPE input, Envelope envelope)
        {
            if (Mute)
            {
                return;
            }
            lock (this)
            {
				//TODO: stuff here
            }
        }
    }
}
