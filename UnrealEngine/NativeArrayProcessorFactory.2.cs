using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000063 RID: 99
	[NullableContext(1)]
	[Nullable(0)]
	public static class NativeArrayProcessorFactory<[Nullable(2)] T>
	{
		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x000139D4 File Offset: 0x00011BD4
		public static NativeArrayProcessorBase<T> Processor
		{
			get
			{
				NativeArrayProcessorBase<T> result;
				try
				{
					NativeArrayProcessorBase<T> processor = NativeArrayProcessorFactory.GetProcessor<T>();
					if (processor.IsStructProxyProcessor && ((IScriptStructProcessor)processor).GetNativeScriptStructPtr().ScriptStructPtr == IntPtr.Zero)
					{
						UnrealLogger.ErrorNoTrace("Unable to find UScriptStruct* for " + typeof(T).Name);
						result = null;
					}
					else
					{
						result = processor;
					}
				}
				catch (Exception ex)
				{
					UnrealLogger.ErrorNoTrace(ex.ToString());
					result = null;
				}
				return result;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00013A4C File Offset: 0x00011C4C
		public static NativeArrayProcessorBase<T> HashProcessor
		{
			get
			{
				NativeArrayProcessorBase<T> result;
				try
				{
					NativeArrayProcessorBase<T> processor = NativeArrayProcessorFactory<T>.Processor;
					if (!processor.HasGetTypeHash)
					{
						UnrealLogger.ErrorNoTrace("It seems that " + typeof(T).Name + " doesn't implement GetTypeHash, plz see " + processor.GetType().Name);
						result = null;
					}
					else
					{
						result = processor;
					}
				}
				catch (Exception ex)
				{
					UnrealLogger.ErrorNoTrace(ex.ToString());
					result = null;
				}
				return result;
			}
		}
	}
}
