using System;
using System.Runtime.CompilerServices;

// Token: 0x02000016 RID: 22
public class EventWithTargetBridge<[Nullable(2)] T1, [Nullable(2)] T2> : IEventWitTargetBridge
{
	// Token: 0x0600004A RID: 74 RVA: 0x000046A8 File Offset: 0x000028A8
	[NullableContext(1)]
	public EventWithTargetBridge(Action<uint, int, T1, T2> eventAction)
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x000046B8 File Offset: 0x000028B8
	public unsafe void Emit(uint eventId, int targetId, byte* parameterBuffer)
	{
		int num = 0;
		int num2 = GameScriptPropertyConverterUtils.ReadParameterBuffer<int>(parameterBuffer, ref num);
		T1 t = default(T1);
		T2 t2 = default(T2);
		if (!GameScriptPropertyConverterUtils.ReadParameter<T1>(parameterBuffer, ref num, ref t) || !GameScriptPropertyConverterUtils.ReadParameter<T2>(parameterBuffer, ref num, ref t2))
		{
			throw new NotImplementedException();
		}
		if ((t == null && EventWithTargetBridge<T1, T2>.IsValueType[0]) || (t2 == null && EventWithTargetBridge<T1, T2>.IsValueType[1]))
		{
			throw new NotImplementedException();
		}
		this.<eventAction>P(eventId, targetId, t, t2);
		if (num2 != num - 4)
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x0400003D RID: 61
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint, int, T1, T2> <eventAction>P = eventAction;

	// Token: 0x0400003E RID: 62
	[Nullable(1)]
	private static readonly bool[] IsValueType = new bool[]
	{
		typeof(T1).IsValueType,
		typeof(T2).IsValueType
	};
}
