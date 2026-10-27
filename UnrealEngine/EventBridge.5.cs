using System;
using System.Runtime.CompilerServices;

// Token: 0x0200000F RID: 15
[NullableContext(2)]
[Nullable(0)]
public class EventBridge<T1, T2, T3, T4> : IEventBridge
{
	// Token: 0x06000038 RID: 56 RVA: 0x00003F66 File Offset: 0x00002166
	[NullableContext(1)]
	public EventBridge(Action<uint, T1, T2, T3, T4> eventAction)
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003F78 File Offset: 0x00002178
	[NullableContext(0)]
	public unsafe void Emit(uint eventId, byte* parameterBuffer)
	{
		int num = 0;
		int num2 = GameScriptPropertyConverterUtils.ReadParameterBuffer<int>(parameterBuffer, ref num);
		T1 t = default(T1);
		T2 t2 = default(T2);
		T3 t3 = default(T3);
		T4 t4 = default(T4);
		if (!GameScriptPropertyConverterUtils.ReadParameter<T1>(parameterBuffer, ref num, ref t) || !GameScriptPropertyConverterUtils.ReadParameter<T2>(parameterBuffer, ref num, ref t2) || !GameScriptPropertyConverterUtils.ReadParameter<T3>(parameterBuffer, ref num, ref t3) || !GameScriptPropertyConverterUtils.ReadParameter<T4>(parameterBuffer, ref num, ref t4))
		{
			throw new NotImplementedException();
		}
		if ((t == null && EventBridge<T1, T2, T3, T4>.IsValueType[0]) || (t2 == null && EventBridge<T1, T2, T3, T4>.IsValueType[1]) || (t3 == null && EventBridge<T1, T2, T3, T4>.IsValueType[2]) || (t4 == null && EventBridge<T1, T2, T3, T4>.IsValueType[3]))
		{
			throw new NotImplementedException();
		}
		this.<eventAction>P(eventId, t, t2, t3, t4);
		if (num2 != num - 4)
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x04000032 RID: 50
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint, T1, T2, T3, T4> <eventAction>P = eventAction;

	// Token: 0x04000033 RID: 51
	[Nullable(1)]
	private static readonly bool[] IsValueType = new bool[]
	{
		typeof(T1).IsValueType,
		typeof(T2).IsValueType,
		typeof(T3).IsValueType,
		typeof(T4).IsValueType
	};
}
