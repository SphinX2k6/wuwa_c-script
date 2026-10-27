using System;
using System.Runtime.CompilerServices;

// Token: 0x02000019 RID: 25
[NullableContext(2)]
[Nullable(0)]
public class EventWithTargetBridge<T1, T2, T3, T4, T5> : IEventWitTargetBridge
{
	// Token: 0x06000053 RID: 83 RVA: 0x000049C8 File Offset: 0x00002BC8
	[NullableContext(1)]
	public EventWithTargetBridge(Action<uint, int, T1, T2, T3, T4, T5> eventAction)
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x000049D8 File Offset: 0x00002BD8
	[NullableContext(0)]
	public unsafe void Emit(uint eventId, int targetId, byte* parameterBuffer)
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
		if ((t == null && EventWithTargetBridge<T1, T2, T3, T4, T5>.IsValueType[0]) || (t2 == null && EventWithTargetBridge<T1, T2, T3, T4, T5>.IsValueType[1]) || (t3 == null && EventWithTargetBridge<T1, T2, T3, T4, T5>.IsValueType[2]) || (t4 == null && EventWithTargetBridge<T1, T2, T3, T4, T5>.IsValueType[3]) || (t5 == null && EventWithTargetBridge<T1, T2, T3, T4, T5>.IsValueType[4]))
		{
			throw new NotImplementedException();
		}
		this.<eventAction>P(eventId, targetId, t, t2, t3, t4, t5);
		if (num2 != num - 4)
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x04000043 RID: 67
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint, int, T1, T2, T3, T4, T5> <eventAction>P = eventAction;

	// Token: 0x04000044 RID: 68
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
