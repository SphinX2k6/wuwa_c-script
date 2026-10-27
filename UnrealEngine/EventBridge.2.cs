using System;
using System.Runtime.CompilerServices;

// Token: 0x0200000C RID: 12
public class EventBridge<[Nullable(2)] T1> : IEventBridge
{
	// Token: 0x0600002F RID: 47 RVA: 0x00003D03 File Offset: 0x00001F03
	[NullableContext(1)]
	public EventBridge(Action<uint, T1> eventAction)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00003D14 File Offset: 0x00001F14
	public unsafe void Emit(uint eventId, byte* parameterBuffer)
	{
		int num = 0;
		int num2 = GameScriptPropertyConverterUtils.ReadParameterBuffer<int>(parameterBuffer, ref num);
		T1 t = default(T1);
		if (!GameScriptPropertyConverterUtils.ReadParameter<T1>(parameterBuffer, ref num, ref t))
		{
			throw new NotImplementedException();
		}
		if (t == null && EventBridge<T1>.IsValueType[0])
		{
			throw new NotImplementedException();
		}
		this.<eventAction>P(eventId, t);
		if (num2 != num - 4)
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x0400002C RID: 44
	[Nullable(1)]
	[CompilerGenerated]
	private Action<uint, T1> <eventAction>P = eventAction;

	// Token: 0x0400002D RID: 45
	[Nullable(1)]
	private static readonly bool[] IsValueType = new bool[]
	{
		typeof(T1).IsValueType
	};
}
