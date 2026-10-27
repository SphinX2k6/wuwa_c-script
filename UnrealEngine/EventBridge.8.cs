using System;
using System.Runtime.CompilerServices;

// Token: 0x02000012 RID: 18
[NullableContext(2)]
[Nullable(0)]
public class EventBridge<T1, T2, T3, T4, T5, T6, T7> : IEventBridge
{
	// Token: 0x06000041 RID: 65 RVA: 0x000043E4 File Offset: 0x000025E4
	[NullableContext(1)]
	public EventBridge(Action<uint, T1, T2, T3, T4, T5, T6, T7> eventAction)
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000043F4 File Offset: 0x000025F4
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
		T6 t6 = default(T6);
		T7 t7 = default(T7);
		if (!GameScriptPropertyConverterUtils.ReadParameter<T1>(parameterBuffer, ref num, ref t) || !GameScriptPropertyConverterUtils.ReadParameter<T2>(parameterBuffer, ref num, ref t2) || !GameScriptPropertyConverterUtils.ReadParameter<T3>(parameterBuffer, ref num, ref t3) || !GameScriptPropertyConverterUtils.ReadParameter<T4>(parameterBuffer, ref num, ref t4) || !GameScriptPropertyConverterUtils.ReadParameter<T5>(parameterBuffer, ref num, ref t5) || !GameScriptPropertyConverterUtils.ReadParameter<T6>(parameterBuffer, ref num, ref t6) || !GameScriptPropertyConverterUtils.ReadParameter<T7>(parameterBuffer, ref num, ref t7))
		{
			throw new NotImplementedException();
		}
		if ((t == null && EventBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[0]) || (t2 == null && EventBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[1]) || (t3 == null && EventBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[2]) || (t4 == null && EventBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[3]) || (t5 == null && EventBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[4]) || (t6 == null && EventBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[5]) || (t7 == null && EventBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[6]))
		{
			throw new NotImplementedException();
		}
		this.<eventAction>P(eventId, t, t2, t3, t4, t5, t6, t7);
		if (num2 != num - 4)
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x04000038 RID: 56
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint, T1, T2, T3, T4, T5, T6, T7> <eventAction>P = eventAction;

	// Token: 0x04000039 RID: 57
	[Nullable(1)]
	private static readonly bool[] IsValueType = new bool[]
	{
		typeof(T1).IsValueType,
		typeof(T2).IsValueType,
		typeof(T3).IsValueType,
		typeof(T4).IsValueType,
		typeof(T5).IsValueType,
		typeof(T6).IsValueType,
		typeof(T7).IsValueType
	};
}
