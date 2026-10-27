using System;
using System.Runtime.CompilerServices;

// Token: 0x02000015 RID: 21
public class EventWithTargetBridge<[Nullable(2)] T1> : IEventWitTargetBridge
{
	// Token: 0x06000047 RID: 71 RVA: 0x00004617 File Offset: 0x00002817
	[NullableContext(1)]
	public EventWithTargetBridge(Action<uint, int, T1> eventAction)
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00004628 File Offset: 0x00002828
	public unsafe void Emit(uint eventId, int targetId, byte* parameterBuffer)
	{
		int num = 0;
		int num2 = GameScriptPropertyConverterUtils.ReadParameterBuffer<int>(parameterBuffer, ref num);
		T1 t = default(T1);
		if (!GameScriptPropertyConverterUtils.ReadParameter<T1>(parameterBuffer, ref num, ref t))
		{
			throw new NotImplementedException();
		}
		if (t == null && EventWithTargetBridge<T1>.IsValueType[0])
		{
			throw new NotImplementedException();
		}
		this.<eventAction>P(eventId, targetId, t);
		if (num2 != num - 4)
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x0400003B RID: 59
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint, int, T1> <eventAction>P = eventAction;

	// Token: 0x0400003C RID: 60
	[Nullable(1)]
	private static readonly bool[] IsValueType = new bool[]
	{
		typeof(T1).IsValueType
	};
}
