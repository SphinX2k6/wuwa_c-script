using System;
using System.Runtime.CompilerServices;

// Token: 0x0200000D RID: 13
public class EventBridge<[Nullable(2)] T1, [Nullable(2)] T2> : IEventBridge
{
	// Token: 0x06000032 RID: 50 RVA: 0x00003D93 File Offset: 0x00001F93
	[NullableContext(1)]
	public EventBridge(Action<uint, T1, T2> eventAction)
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00003DA4 File Offset: 0x00001FA4
	public unsafe void Emit(uint eventId, byte* parameterBuffer)
	{
		int num = 0;
		int num2 = GameScriptPropertyConverterUtils.ReadParameterBuffer<int>(parameterBuffer, ref num);
		T1 t = default(T1);
		T2 t2 = default(T2);
		if (!GameScriptPropertyConverterUtils.ReadParameter<T1>(parameterBuffer, ref num, ref t) || !GameScriptPropertyConverterUtils.ReadParameter<T2>(parameterBuffer, ref num, ref t2))
		{
			throw new NotImplementedException();
		}
		if ((t == null && EventBridge<T1, T2>.IsValueType[0]) || (t2 == null && EventBridge<T1, T2>.IsValueType[1]))
		{
			throw new NotImplementedException();
		}
		this.<eventAction>P(eventId, t, t2);
		if (num2 != num - 4)
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x0400002E RID: 46
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint, T1, T2> <eventAction>P = eventAction;

	// Token: 0x0400002F RID: 47
	[Nullable(1)]
	private static readonly bool[] IsValueType = new bool[]
	{
		typeof(T1).IsValueType,
		typeof(T2).IsValueType
	};
}
