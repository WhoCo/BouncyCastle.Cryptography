
#if __MonOS__BUILDSTRAP
extern alias Microsoft_Net_Transition;

global using Stream = Microsoft_Net_Transition::Microsoft.Net.Transition.System.IO.Stream;
global using SeekOrigin = Microsoft_Net_Transition::Microsoft.Net.Transition.System.IO.SeekOrigin;
global using MemoryStream = Microsoft_Net_Transition::Microsoft.Net.Transition.System.IO.MemoryStream;
global using BufferedStream = Microsoft_Net_Transition::Microsoft.Net.Transition.System.IO.BufferedStream;
// global using BinaryReader = Microsoft_Net_Transition::Microsoft.Net.Transition.System.IO.BinaryReader;
// global using BinaryWriter = Microsoft_Net_Transition::Microsoft.Net.Transition.System.IO.BinaryWriter;
#endif

#if __MonOS__
global using Microsoft.Net.Transition.System;
global using Microsoft.Net.Transition.System.IO;

global using List<T1> = System.Collections.ArrayList<T1>
global using IList<T1> = System.Collections.List<T1>
global using ICollection<T1> = System.Collections.Collection<T1>
global using IEnumerable<T1> = System.Collections.Enumerable<T1>
global using IEnumerator<T1> = System.Collections.Enumerator<T1>
#endif
