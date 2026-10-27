using System;
using System.Runtime.CompilerServices;

// Token: 0x02000018 RID: 24
[NullableContext(2)]
[Nullable(0)]
public class EventWithTargetBridge<T1, T2, T3, T4> : IEventWitTargetBridge
{
	// Token: 0x06000050 RID: 80 RVA: 0x0000487E File Offset: 0x00002A7E
	[NullableContext(1)]
	public EventWithTargetBridge(Action<uint, int, T1, T2, T3, T4> eventAction)
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00004890 File Offset: 0x00002A90
	[NullableContext(0)]
	public unsafe void Emit(uint eventId, int targetId, byte* parameterBuffer)
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
		if ((t == null && EventWithTargetBridge<T1, T2, T3, T4>.IsValueType[0]) || (t2 == null && EventWithTargetBridge<T1, T2, T3, T4>.IsValueType[1]) || (t3 == null && EventWithTargetBridge<T1, T2, T3, T4>.IsValueType[2]) || (t4 == null && EventWithTargetBridge<T1, T2, T3, T4>.IsValueType[3]))
		{
			throw new NotImplementedException();
		}
		this.<eventAction>P(eventId, targetId, t, t2, t3, t4);
		if (num2 != num - 4)
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x04000041 RID: 65
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint, int, T1, T2, T3, T4> <eventAction>P = eventAction;

	// Token: 0x04000042 RID: 66
	[Nullable(1)]
	private static readonly bool[] IsValueType = new bool[]
	{
		typeof(T1).IsValueType,
		typeof(T2).IsValueType,
		typeof(T3).IsValueType,
		typeof(T4).IsValueType
	};
}
