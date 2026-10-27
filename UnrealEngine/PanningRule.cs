using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200029A RID: 666
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.PanningRule")]
	public enum PanningRule : byte
	{
		// Token: 0x04000E19 RID: 3609
		PanningRule_Speakers,
		// Token: 0x04000E1A RID: 3610
		PanningRule_Headphones,
		// Token: 0x04000E1B RID: 3611
		PanningRule_MAX
	}
}
