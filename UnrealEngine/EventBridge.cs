using System;
using System.Runtime.CompilerServices;

// Token: 0x0200000B RID: 11
public class EventBridge : IEventBridge
{
	// Token: 0x0600002D RID: 45 RVA: 0x00003CE6 File Offset: 0x00001EE6
	[NullableContext(1)]
	public EventBridge(Action<uint> eventAction)
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00003CF5 File Offset: 0x00001EF5
	public unsafe void Emit(uint eventId, byte* parameterBuffer)
	{
		this.<eventAction>P(eventId);
	}

	// Token: 0x0400002B RID: 43
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint> <eventAction>P = eventAction;
}
