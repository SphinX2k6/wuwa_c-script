using System;
using System.Runtime.CompilerServices;

// Token: 0x0200000E RID: 14
public class EventBridge<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3> : IEventBridge
{
	// Token: 0x06000035 RID: 53 RVA: 0x00003E5B File Offset: 0x0000205B
	[NullableContext(1)]
	public EventBridge(Action<uint, T1, T2, T3> eventAction)
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003E6C File Offset: 0x0000206C
	public unsafe void Emit(uint eventId, byte* parameterBuffer)
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
		if ((t == null && EventBridge<T1, T2, T3>.IsValueType[0]) || (t2 == null && EventBridge<T1, T2, T3>.IsValueType[1]) || (t3 == null && EventBridge<T1, T2, T3>.IsValueType[2]))
		{
			throw new NotImplementedException();
		}
		this.<eventAction>P(eventId, t, t2, t3);
		if (num2 != num - 4)
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x04000030 RID: 48
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint, T1, T2, T3> <eventAction>P = eventAction;

	// Token: 0x04000031 RID: 49
	[Nullable(1)]
	private static readonly bool[] IsValueType = new bool[]
	{
		typeof(T1).IsValueType,
		typeof(T2).IsValueType,
		typeof(T3).IsValueType
	};
}
