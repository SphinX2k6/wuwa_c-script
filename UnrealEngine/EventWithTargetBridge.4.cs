using System;
using System.Runtime.CompilerServices;

// Token: 0x02000017 RID: 23
public class EventWithTargetBridge<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3> : IEventWitTargetBridge
{
	// Token: 0x0600004D RID: 77 RVA: 0x00004770 File Offset: 0x00002970
	[NullableContext(1)]
	public EventWithTargetBridge(Action<uint, int, T1, T2, T3> eventAction)
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00004780 File Offset: 0x00002980
	public unsafe void Emit(uint eventId, int targetId, byte* parameterBuffer)
	{
		int num = 0;
		int num2 = GameScriptPropertyConverterUtils.ReadParameterBuffer<int>(parameterBuffer, ref num);
		T1 t = default(T1);
		T2 t2 = default(T2);
		T3 t3 = default(T3);
		if (!GameScriptPropertyConverterUtils.ReadParameter<T1>(parameterBuffer, ref num, ref t) || !GameScriptPropertyConverterUtils.ReadParameter<T2>(parameterBuffer, ref num, ref t2) || !GameScriptPropertyConverterUtils.ReadParameter<T3>(parameterBuffer, ref num, ref t3))
		{
			throw new NotImplementedException();
		}
		if ((t == null && EventWithTargetBridge<T1, T2, T3>.IsValueType[0]) || (t2 == null && EventWithTargetBridge<T1, T2, T3>.IsValueType[1]) || (t3 == null && EventWithTargetBridge<T1, T2, T3>.IsValueType[2]))
		{
			throw new NotImplementedException();
		}
		this.<eventAction>P(eventId, targetId, t, t2, t3);
		if (num2 != num - 4)
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x0400003F RID: 63
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint, int, T1, T2, T3> <eventAction>P = eventAction;

	// Token: 0x04000040 RID: 64
	[Nullable(1)]
	private static readonly bool[] IsValueType = new bool[]
	{
		typeof(T1).IsValueType,
		typeof(T2).IsValueType,
		typeof(T3).IsValueType
	};
}
