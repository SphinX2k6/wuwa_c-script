using System;
using System.Runtime.CompilerServices;

// Token: 0x0200001B RID: 27
[NullableContext(2)]
[Nullable(0)]
public class EventWithTargetBridge<T1, T2, T3, T4, T5, T6, T7> : IEventWitTargetBridge
{
	// Token: 0x06000059 RID: 89 RVA: 0x00004D08 File Offset: 0x00002F08
	[NullableContext(1)]
	public EventWithTargetBridge(Action<uint, int, T1, T2, T3, T4, T5, T6, T7> eventAction)
	{
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00004D18 File Offset: 0x00002F18
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
		T6 t6 = default(T6);
		T7 t7 = default(T7);
		if (!GameScriptPropertyConverterUtils.ReadParameter<T1>(parameterBuffer, ref num, ref t) || !GameScriptPropertyConverterUtils.ReadParameter<T2>(parameterBuffer, ref num, ref t2) || !GameScriptPropertyConverterUtils.ReadParameter<T3>(parameterBuffer, ref num, ref t3) || !GameScriptPropertyConverterUtils.ReadParameter<T4>(parameterBuffer, ref num, ref t4) || !GameScriptPropertyConverterUtils.ReadParameter<T5>(parameterBuffer, ref num, ref t5) || !GameScriptPropertyConverterUtils.ReadParameter<T6>(parameterBuffer, ref num, ref t6) || !GameScriptPropertyConverterUtils.ReadParameter<T7>(parameterBuffer, ref num, ref t7))
		{
			throw new NotImplementedException();
		}
		if ((t == null && EventWithTargetBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[0]) || (t2 == null && EventWithTargetBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[1]) || (t3 == null && EventWithTargetBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[2]) || (t4 == null && EventWithTargetBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[3]) || (t5 == null && EventWithTargetBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[4]) || (t6 == null && EventWithTargetBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[5]) || (t7 == null && EventWithTargetBridge<T1, T2, T3, T4, T5, T6, T7>.IsValueType[6]))
		{
			throw new NotImplementedException();
		}
		this.<eventAction>P(eventId, targetId, t, t2, t3, t4, t5, t6, t7);
		if (num2 != num - 4)
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x04000047 RID: 71
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint, int, T1, T2, T3, T4, T5, T6, T7> <eventAction>P = eventAction;

	// Token: 0x04000048 RID: 72
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
