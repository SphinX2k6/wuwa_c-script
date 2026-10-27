using System;
using System.Runtime.CompilerServices;

// Token: 0x02000014 RID: 20
public class EventWithTargetBridge : IEventWitTargetBridge
{
	// Token: 0x06000045 RID: 69 RVA: 0x000045D6 File Offset: 0x000027D6
	[NullableContext(1)]
	public EventWithTargetBridge(Action<uint, int> eventAction)
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x000045E8 File Offset: 0x000027E8
	public unsafe void Emit(uint eventId, int targetId, byte* parameterBuffer)
	{
		int num = 0;
		int num2 = GameScriptPropertyConverterUtils.ReadParameterBuffer<int>(parameterBuffer, ref num);
		this.<eventAction>P(eventId, targetId);
		if (num2 != num - 4)
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x0400003A RID: 58
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint, int> <eventAction>P = eventAction;
}
