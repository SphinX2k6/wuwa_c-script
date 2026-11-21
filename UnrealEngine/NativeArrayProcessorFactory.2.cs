using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000048 RID: 72
	[NullableContext(1)]
	[Nullable(0)]
	public static class NativeArrayProcessorFactory<[Nullable(2)] T>
	{
		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x0000E67C File Offset: 0x0000C87C
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

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x0000E6F4 File Offset: 0x0000C8F4
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
