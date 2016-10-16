﻿using System;
namespace TomRijnbeek.Audio {
    /// <summary>
    /// The listener that should be used if there is only one listener necessary.
    /// It registers itself as main listener with OpenAL and is not meant to be replaced.
    /// </summary>
    public class SingleListener : Listener {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:TomRijnbeek.Audio.SingleListener"/> class.
        /// </summary>
        public SingleListener() {
            if (ALListener.Get() != null) {
                throw new InvalidOperationException("Only one single listener can be created and registered.");
            }
            ALListener.Set(this);
        }
    }
}