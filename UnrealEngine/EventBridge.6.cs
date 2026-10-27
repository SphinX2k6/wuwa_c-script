using System;
using System.Runtime.CompilerServices;

// Token: 0x02000010 RID: 16
[NullableContext(2)]
[Nullable(0)]
public class EventBridge<T1, T2, T3, T4, T5> : IEventBridge
{
	// Token: 0x0600003B RID: 59 RVA: 0x000040AC File Offset: 0x000022AC
	[NullableContext(1)]
	public EventBridge(Action<uint, T1, T2, T3, T4, T5> eventAction)
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000040BC File Offset: 0x000022BC
	[NullableContext(0)]
	public unsafe void Emit(uint eventId, byte* parameterBuffer)
	{
		int num = 0;
		int num2 = GameScriptPropertyConverterUtils.ReadParameterBuffer<int>(parameterBuffer, ref num);
		T1 t = default(T1);
		T2 t2 = default(T2);
		T3 t3 = default(T3);
		T4 t4 = default(T4);
		T5 t5 = default(T5);
		if (!GameScriptPropertyConverterUtils.ReadParameter<T1>(parameterBuffer, ref num, ref t) || !GameScriptPropertyConverterUtils.ReadParameter<T2>(parameterBuffer, ref num, ref t2) || !GameScriptPropertyConverterUtils.ReadParameter<T3>(parameterBuffer, ref num, ref t3) || !GameScriptPropertyConverterUtils.ReadParameter<T4>(parameterBuffer, ref num, ref t4) || !GameScriptPropertyConverterUtils.ReadParameter<T5>(parameterBuffer, ref num, ref t5))
		{
			throw new NotImplementedException();
		}
		if ((t == null && EventBridge<T1, T2, T3, T4, T5>.IsValueType[0]) || (t2 == null && EventBridge<T1, T2, T3, T4, T5>.IsValueType[1]) || (t3 == null && EventBridge<T1, T2, T3, T4, T5>.IsValueType[2]) || (t4 == null && EventBridge<T1, T2, T3, T4, T5>.IsValueType[3]) || (t5 == null && EventBridge<T1, T2, T3, T4, T5>.IsValueType[4]))
		{
			throw new NotImplementedException();
		}
		this.<eventAction>P(eventId, t, t2, t3, t4, t5);
		if (num2 != num - 4)
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x04000034 RID: 52
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint, T1, T2, T3, T4, T5> <eventAction>P = eventAction;

	// Token: 0x04000035 RID: 53
	[Nullable(1)]
	private static readonly bool[] IsValueType = new bool[]
	{
		typeof(T1).IsValueType,
		typeof(T2).IsValueType,
		typeof(T3).IsValueType,
		typeof(T4).IsValueType,
		typeof(T5).IsValueType
	};
}
