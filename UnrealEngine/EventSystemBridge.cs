using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200001D RID: 29
[NullableContext(1)]
[Nullable(0)]
public class EventSystemBridge
{
	// Token: 0x0600005F RID: 95 RVA: 0x00004F34 File Offset: 0x00003134
	[NullableContext(0)]
	public unsafe static void EmitFromJavaScript(uint eventId, int targetId, byte parameterCount, byte* parameterBuffer)
	{
		try
		{
			IEventWitTargetBridge eventWitTargetBridge;
			if (targetId == 0)
			{
				IEventBridge eventBridge;
				if (EventSystemBridge.EventDictionary.TryGetValue(eventId, out eventBridge))
				{
					eventBridge.Emit(eventId, parameterBuffer);
				}
				else
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(115, 3);
					defaultInterpolatedStringHandler.AppendLiteral("EventSystemBridge EmitFromJavaScript eventId:");
					defaultInterpolatedStringHandler.AppendFormatted<uint>(eventId);
					defaultInterpolatedStringHandler.AppendLiteral(", targetId:");
					defaultInterpolatedStringHandler.AppendFormatted<int>(targetId);
					defaultInterpolatedStringHandler.AppendLiteral(", parameterCount:");
					defaultInterpolatedStringHandler.AppendFormatted<byte>(parameterCount);
					defaultInterpolatedStringHandler.AppendLiteral(" EventDictionary没有找到注册事件，请检查是否因为泛型参数不一致导致的");
					UnrealLogger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			else if (EventSystemBridge.EventWithTargetDictionary.TryGetValue(eventId, out eventWitTargetBridge))
			{
				eventWitTargetBridge.Emit(eventId, targetId, parameterBuffer);
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(125, 3);
				defaultInterpolatedStringHandler.AppendLiteral("EventSystemBridge EmitFromJavaScript eventId:");
				defaultInterpolatedStringHandler.AppendFormatted<uint>(eventId);
				defaultInterpolatedStringHandler.AppendLiteral(", targetId:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(targetId);
				defaultInterpolatedStringHandler.AppendLiteral(", parameterCount:");
				defaultInterpolatedStringHandler.AppendFormatted<byte>(parameterCount);
				defaultInterpolatedStringHandler.AppendLiteral(" EventWithTargetDictionary没有找到注册事件，请检查是否因为泛型参数不一致导致的");
				UnrealLogger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}
		catch (Exception value)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(79, 4);
			defaultInterpolatedStringHandler.AppendLiteral("EventSystemBridge EmitFromJavaScript eventId:");
			defaultInterpolatedStringHandler.AppendFormatted<uint>(eventId);
			defaultInterpolatedStringHandler.AppendLiteral(", targetId:");
			defaultInterpolatedStringHandler.AppendFormatted<int>(targetId);
			defaultInterpolatedStringHandler.AppendLiteral(", parameterCount:");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(parameterCount);
			defaultInterpolatedStringHandler.AppendLiteral(" 执行异常:");
			defaultInterpolatedStringHandler.AppendFormatted<Exception>(value);
			UnrealLogger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
		}
	}

	// Token: 0x06000060 RID: 96 RVA: 0x000050B4 File Offset: 0x000032B4
	public static void RegisterEvent(uint eventName, Action<uint> eventAction)
	{
		if (!EventSystemBridge.EventDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventDictionary.Add(eventName, new EventBridge(eventAction));
		}
	}

	// Token: 0x06000061 RID: 97 RVA: 0x000050D4 File Offset: 0x000032D4
	public static void RegisterEvent<[Nullable(2)] T1>(uint eventName, Action<uint, T1> eventAction)
	{
		if (!EventSystemBridge.EventDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventDictionary.Add(eventName, new EventBridge<T1>(eventAction));
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000050F4 File Offset: 0x000032F4
	[NullableContext(2)]
	public static void RegisterEvent<T1, T2>(uint eventName, [Nullable(1)] Action<uint, T1, T2> eventAction)
	{
		if (!EventSystemBridge.EventDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventDictionary.Add(eventName, new EventBridge<T1, T2>(eventAction));
		}
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00005114 File Offset: 0x00003314
	[NullableContext(2)]
	public static void RegisterEvent<T1, T2, T3>(uint eventName, [Nullable(1)] Action<uint, T1, T2, T3> eventAction)
	{
		if (!EventSystemBridge.EventDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventDictionary.Add(eventName, new EventBridge<T1, T2, T3>(eventAction));
		}
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00005134 File Offset: 0x00003334
	[NullableContext(2)]
	public static void RegisterEvent<T1, T2, T3, T4>(uint eventName, [Nullable(1)] Action<uint, T1, T2, T3, T4> eventAction)
	{
		if (!EventSystemBridge.EventDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventDictionary.Add(eventName, new EventBridge<T1, T2, T3, T4>(eventAction));
		}
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00005154 File Offset: 0x00003354
	[NullableContext(2)]
	public static void RegisterEvent<T1, T2, T3, T4, T5>(uint eventName, [Nullable(1)] Action<uint, T1, T2, T3, T4, T5> eventAction)
	{
		if (!EventSystemBridge.EventDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventDictionary.Add(eventName, new EventBridge<T1, T2, T3, T4, T5>(eventAction));
		}
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00005174 File Offset: 0x00003374
	[NullableContext(2)]
	public static void RegisterEvent<T1, T2, T3, T4, T5, T6>(uint eventName, [Nullable(1)] Action<uint, T1, T2, T3, T4, T5, T6> eventAction)
	{
		if (!EventSystemBridge.EventDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventDictionary.Add(eventName, new EventBridge<T1, T2, T3, T4, T5, T6>(eventAction));
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00005194 File Offset: 0x00003394
	[NullableContext(2)]
	public static void RegisterEvent<T1, T2, T3, T4, T5, T6, T7>(uint eventName, [Nullable(1)] Action<uint, T1, T2, T3, T4, T5, T6, T7> eventAction)
	{
		if (!EventSystemBridge.EventDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventDictionary.Add(eventName, new EventBridge<T1, T2, T3, T4, T5, T6, T7>(eventAction));
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x000051B4 File Offset: 0x000033B4
	public static void RegisterEventWithTarget(uint eventName, Action<uint, int> eventAction)
	{
		if (!EventSystemBridge.EventWithTargetDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventWithTargetDictionary.Add(eventName, new EventWithTargetBridge(eventAction));
		}
	}

	// Token: 0x06000069 RID: 105 RVA: 0x000051D4 File Offset: 0x000033D4
	public static void RegisterEventWithTarget<[Nullable(2)] T1>(uint eventName, Action<uint, int, T1> eventAction)
	{
		if (!EventSystemBridge.EventWithTargetDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventWithTargetDictionary.Add(eventName, new EventWithTargetBridge<T1>(eventAction));
		}
	}

	// Token: 0x0600006A RID: 106 RVA: 0x000051F4 File Offset: 0x000033F4
	[NullableContext(2)]
	public static void RegisterEventWithTarget<T1, T2>(uint eventName, [Nullable(1)] Action<uint, int, T1, T2> eventAction)
	{
		if (!EventSystemBridge.EventWithTargetDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventWithTargetDictionary.Add(eventName, new EventWithTargetBridge<T1, T2>(eventAction));
		}
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00005214 File Offset: 0x00003414
	[NullableContext(2)]
	public static void RegisterEventWithTarget<T1, T2, T3>(uint eventName, [Nullable(1)] Action<uint, int, T1, T2, T3> eventAction)
	{
		if (!EventSystemBridge.EventWithTargetDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventWithTargetDictionary.Add(eventName, new EventWithTargetBridge<T1, T2, T3>(eventAction));
		}
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00005234 File Offset: 0x00003434
	[NullableContext(2)]
	public static void RegisterEventWithTarget<T1, T2, T3, T4>(uint eventName, [Nullable(1)] Action<uint, int, T1, T2, T3, T4> eventAction)
	{
		if (!EventSystemBridge.EventWithTargetDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventWithTargetDictionary.Add(eventName, new EventWithTargetBridge<T1, T2, T3, T4>(eventAction));
		}
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00005254 File Offset: 0x00003454
	[NullableContext(2)]
	public static void RegisterEventWithTarget<T1, T2, T3, T4, T5>(uint eventName, [Nullable(1)] Action<uint, int, T1, T2, T3, T4, T5> eventAction)
	{
		if (!EventSystemBridge.EventWithTargetDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventWithTargetDictionary.Add(eventName, new EventWithTargetBridge<T1, T2, T3, T4, T5>(eventAction));
		}
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00005274 File Offset: 0x00003474
	[NullableContext(2)]
	public static void RegisterEventWithTarget<T1, T2, T3, T4, T5, T6>(uint eventName, [Nullable(1)] Action<uint, int, T1, T2, T3, T4, T5, T6> eventAction)
	{
		if (!EventSystemBridge.EventWithTargetDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventWithTargetDictionary.Add(eventName, new EventWithTargetBridge<T1, T2, T3, T4, T5, T6>(eventAction));
		}
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00005294 File Offset: 0x00003494
	[NullableContext(2)]
	public static void RegisterEventWithTarget<T1, T2, T3, T4, T5, T6, T7>(uint eventName, [Nullable(1)] Action<uint, int, T1, T2, T3, T4, T5, T6, T7> eventAction)
	{
		if (!EventSystemBridge.EventWithTargetDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventWithTargetDictionary.Add(eventName, new EventWithTargetBridge<T1, T2, T3, T4, T5, T6, T7>(eventAction));
		}
	}

	// Token: 0x06000070 RID: 112 RVA: 0x000052B4 File Offset: 0x000034B4
	public static void UnregisterEvent(uint eventName)
	{
		if (EventSystemBridge.EventDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventDictionary.Remove(eventName);
		}
	}

	// Token: 0x06000071 RID: 113 RVA: 0x000052CF File Offset: 0x000034CF
	public static void UnregisterEventWithTarget(uint eventName)
	{
		if (EventSystemBridge.EventWithTargetDictionary.ContainsKey(eventName))
		{
			EventSystemBridge.EventWithTargetDictionary.Remove(eventName);
		}
	}

	// Token: 0x06000072 RID: 114 RVA: 0x000052EA File Offset: 0x000034EA
	public static void EmitToJavaScript(uint eventName, int targetId)
	{
		UJsBridgetBlueprintFunctionLibrary.CSharpCallJavascript(eventName, targetId, 0, 0UL);
	}

	// Token: 0x06000073 RID: 115 RVA: 0x000052F8 File Offset: 0x000034F8
	public unsafe static void EmitToJavaScript<[Nullable(2)] T1>(uint eventName, int targetId, T1 p0)
	{
		EventParameter<T1> eventParameter = new EventParameter<T1>(p0);
		int parameterBufferSize = eventParameter.GetParameterBufferSize();
		byte* ptr = stackalloc byte[(UIntPtr)(parameterBufferSize + 4)];
		int num = 0;
		GameScriptPropertyConverterUtils.WriteParameterBuffer<int>(parameterBufferSize, ptr, ref num);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T1>(eventParameter.Define, p0, ptr, ref num);
		UJsBridgetBlueprintFunctionLibrary.CSharpCallJavascript(eventName, targetId, 1, ptr);
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00005340 File Offset: 0x00003540
	public unsafe static void EmitToJavaScript<[Nullable(2)] T1, [Nullable(2)] T2>(uint eventName, int targetId, T1 p0, T2 p1)
	{
		EventParameter<T1> eventParameter = new EventParameter<T1>(p0);
		EventParameter<T2> eventParameter2 = new EventParameter<T2>(p1);
		int num = eventParameter.GetParameterBufferSize() + eventParameter2.GetParameterBufferSize();
		byte* ptr = stackalloc byte[(UIntPtr)(num + 4)];
		int num2 = 0;
		GameScriptPropertyConverterUtils.WriteParameterBuffer<int>(num, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T1>(eventParameter.Define, p0, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T2>(eventParameter2.Define, p1, ptr, ref num2);
		UJsBridgetBlueprintFunctionLibrary.CSharpCallJavascript(eventName, targetId, 2, ptr);
	}

	// Token: 0x06000075 RID: 117 RVA: 0x000053A8 File Offset: 0x000035A8
	public unsafe static void EmitToJavaScript<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(uint eventName, int targetId, T1 p0, T2 p1, T3 p2)
	{
		EventParameter<T1> eventParameter = new EventParameter<T1>(p0);
		EventParameter<T2> eventParameter2 = new EventParameter<T2>(p1);
		EventParameter<T3> eventParameter3 = new EventParameter<T3>(p2);
		int num = eventParameter.GetParameterBufferSize() + eventParameter2.GetParameterBufferSize() + eventParameter3.GetParameterBufferSize();
		byte* ptr = stackalloc byte[(UIntPtr)(num + 4)];
		int num2 = 0;
		GameScriptPropertyConverterUtils.WriteParameterBuffer<int>(num, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T1>(eventParameter.Define, p0, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T2>(eventParameter2.Define, p1, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T3>(eventParameter3.Define, p2, ptr, ref num2);
		UJsBridgetBlueprintFunctionLibrary.CSharpCallJavascript(eventName, targetId, 3, ptr);
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00005434 File Offset: 0x00003634
	public unsafe static void EmitToJavaScript<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(uint eventName, int targetId, T1 p0, T2 p1, T3 p2, T4 p3)
	{
		EventParameter<T1> eventParameter = new EventParameter<T1>(p0);
		EventParameter<T2> eventParameter2 = new EventParameter<T2>(p1);
		EventParameter<T3> eventParameter3 = new EventParameter<T3>(p2);
		EventParameter<T4> eventParameter4 = new EventParameter<T4>(p3);
		int num = eventParameter.GetParameterBufferSize() + eventParameter2.GetParameterBufferSize() + eventParameter3.GetParameterBufferSize() + eventParameter4.GetParameterBufferSize();
		byte* ptr = stackalloc byte[(UIntPtr)(num + 4)];
		int num2 = 0;
		GameScriptPropertyConverterUtils.WriteParameterBuffer<int>(num, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T1>(eventParameter.Define, p0, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T2>(eventParameter2.Define, p1, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T3>(eventParameter3.Define, p2, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T4>(eventParameter4.Define, p3, ptr, ref num2);
		UJsBridgetBlueprintFunctionLibrary.CSharpCallJavascript(eventName, targetId, 4, ptr);
	}

	// Token: 0x06000077 RID: 119 RVA: 0x000054E4 File Offset: 0x000036E4
	public unsafe static void EmitToJavaScript<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(uint eventName, int targetId, T1 p0, T2 p1, T3 p2, T4 p3, T5 p4)
	{
		EventParameter<T1> eventParameter = new EventParameter<T1>(p0);
		EventParameter<T2> eventParameter2 = new EventParameter<T2>(p1);
		EventParameter<T3> eventParameter3 = new EventParameter<T3>(p2);
		EventParameter<T4> eventParameter4 = new EventParameter<T4>(p3);
		EventParameter<T5> eventParameter5 = new EventParameter<T5>(p4);
		int num = eventParameter.GetParameterBufferSize() + eventParameter2.GetParameterBufferSize() + eventParameter3.GetParameterBufferSize() + eventParameter4.GetParameterBufferSize() + eventParameter5.GetParameterBufferSize();
		byte* ptr = stackalloc byte[(UIntPtr)(num + 4)];
		int num2 = 0;
		GameScriptPropertyConverterUtils.WriteParameterBuffer<int>(num, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T1>(eventParameter.Define, p0, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T2>(eventParameter2.Define, p1, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T3>(eventParameter3.Define, p2, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T4>(eventParameter4.Define, p3, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T5>(eventParameter5.Define, p4, ptr, ref num2);
		UJsBridgetBlueprintFunctionLibrary.CSharpCallJavascript(eventName, targetId, 5, ptr);
	}

	// Token: 0x06000078 RID: 120 RVA: 0x000055B8 File Offset: 0x000037B8
	public unsafe static void EmitToJavaScript<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6>(uint eventName, int targetId, T1 p0, T2 p1, T3 p2, T4 p3, T5 p4, T6 p5)
	{
		EventParameter<T1> eventParameter = new EventParameter<T1>(p0);
		EventParameter<T2> eventParameter2 = new EventParameter<T2>(p1);
		EventParameter<T3> eventParameter3 = new EventParameter<T3>(p2);
		EventParameter<T4> eventParameter4 = new EventParameter<T4>(p3);
		EventParameter<T5> eventParameter5 = new EventParameter<T5>(p4);
		EventParameter<T6> eventParameter6 = new EventParameter<T6>(p5);
		int num = eventParameter.GetParameterBufferSize() + eventParameter2.GetParameterBufferSize() + eventParameter3.GetParameterBufferSize() + eventParameter4.GetParameterBufferSize() + eventParameter5.GetParameterBufferSize() + eventParameter6.GetParameterBufferSize();
		byte* ptr = stackalloc byte[(UIntPtr)(num + 4)];
		int num2 = 0;
		GameScriptPropertyConverterUtils.WriteParameterBuffer<int>(num, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T1>(eventParameter.Define, p0, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T2>(eventParameter2.Define, p1, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T3>(eventParameter3.Define, p2, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T4>(eventParameter4.Define, p3, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T5>(eventParameter5.Define, p4, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T6>(eventParameter6.Define, p5, ptr, ref num2);
		UJsBridgetBlueprintFunctionLibrary.CSharpCallJavascript(eventName, targetId, 6, ptr);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x000056AC File Offset: 0x000038AC
	public unsafe static void EmitToJavaScript<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7>(uint eventName, int targetId, T1 p0, T2 p1, T3 p2, T4 p3, T5 p4, T6 p5, T7 p6)
	{
		EventParameter<T1> eventParameter = new EventParameter<T1>(p0);
		EventParameter<T2> eventParameter2 = new EventParameter<T2>(p1);
		EventParameter<T3> eventParameter3 = new EventParameter<T3>(p2);
		EventParameter<T4> eventParameter4 = new EventParameter<T4>(p3);
		EventParameter<T5> eventParameter5 = new EventParameter<T5>(p4);
		EventParameter<T6> eventParameter6 = new EventParameter<T6>(p5);
		EventParameter<T7> eventParameter7 = new EventParameter<T7>(p6);
		int num = eventParameter.GetParameterBufferSize() + eventParameter2.GetParameterBufferSize() + eventParameter3.GetParameterBufferSize() + eventParameter4.GetParameterBufferSize() + eventParameter5.GetParameterBufferSize() + eventParameter6.GetParameterBufferSize() + eventParameter7.GetParameterBufferSize();
		byte* ptr = stackalloc byte[(UIntPtr)(num + 4)];
		int num2 = 0;
		GameScriptPropertyConverterUtils.WriteParameterBuffer<int>(num, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T1>(eventParameter.Define, p0, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T2>(eventParameter2.Define, p1, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T3>(eventParameter3.Define, p2, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T4>(eventParameter4.Define, p3, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T5>(eventParameter5.Define, p4, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T6>(eventParameter6.Define, p5, ptr, ref num2);
		GameScriptPropertyConverterUtils.WriteParameterBuffer<T7>(eventParameter7.Define, p6, ptr, ref num2);
		UJsBridgetBlueprintFunctionLibrary.CSharpCallJavascript(eventName, targetId, 7, ptr);
	}

	// Token: 0x0400004A RID: 74
	private static readonly Dictionary<uint, IEventBridge> EventDictionary = new Dictionary<uint, IEventBridge>();

	// Token: 0x0400004B RID: 75
	private static readonly Dictionary<uint, IEventWitTargetBridge> EventWithTargetDictionary = new Dictionary<uint, IEventWitTargetBridge>();
}
