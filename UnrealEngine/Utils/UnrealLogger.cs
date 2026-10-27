using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnrealEngine.Bulitin.Utils;

namespace UnrealEngine.Utils
{
	// Token: 0x02002AED RID: 10989
	[NullableContext(1)]
	[Nullable(0)]
	public class UnrealLogger
	{
		// Token: 0x0602844F RID: 164943
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void Print(int logVerbosity, void* message);

		// Token: 0x06028450 RID: 164944 RVA: 0x003D4201 File Offset: 0x003D2401
		public static void Info(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})] ReadOnlySpan<ValueTuple<string, object>> args)
		{
			UnrealLogger.Print(EUeLogVerbosity.Display, message, false, args);
		}

		// Token: 0x06028451 RID: 164945 RVA: 0x003D420C File Offset: 0x003D240C
		public static void Info(string message)
		{
			UnrealLogger.Print(EUeLogVerbosity.Display, message, false);
		}

		// Token: 0x06028452 RID: 164946 RVA: 0x003D4216 File Offset: 0x003D2416
		public static void Warn(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})] ReadOnlySpan<ValueTuple<string, object>> args)
		{
			UnrealLogger.Print(EUeLogVerbosity.Warning, message, false, args);
		}

		// Token: 0x06028453 RID: 164947 RVA: 0x003D4221 File Offset: 0x003D2421
		public static void Warn(string message)
		{
			UnrealLogger.Print(EUeLogVerbosity.Warning, message, false);
		}

		// Token: 0x06028454 RID: 164948 RVA: 0x003D422B File Offset: 0x003D242B
		public static void Error(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})] ReadOnlySpan<ValueTuple<string, object>> args)
		{
			UnrealLogger.Print(EUeLogVerbosity.Error, message, true, args);
		}

		// Token: 0x06028455 RID: 164949 RVA: 0x003D4236 File Offset: 0x003D2436
		public static void Error(string message)
		{
			UnrealLogger.Print(EUeLogVerbosity.Error, message, true);
		}

		// Token: 0x06028456 RID: 164950 RVA: 0x003D4240 File Offset: 0x003D2440
		public static void ErrorNoTrace(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})] ReadOnlySpan<ValueTuple<string, object>> args)
		{
			UnrealLogger.Print(EUeLogVerbosity.Error, message, false, args);
		}

		// Token: 0x06028457 RID: 164951 RVA: 0x003D424B File Offset: 0x003D244B
		public static void ErrorNoTrace(string message)
		{
			UnrealLogger.Print(EUeLogVerbosity.Error, message, false);
		}

		// Token: 0x06028458 RID: 164952 RVA: 0x003D4258 File Offset: 0x003D2458
		private unsafe static void Print(EUeLogVerbosity logVerbosity, string message, bool trace, [ParamCollection] [ScopedRef] [Nullable(new byte[]
		{
			0,
			0,
			1,
			1
		})] ReadOnlySpan<ValueTuple<string, object>> args)
		{
			if (args.Length > 0 || trace)
			{
				UnsafeStringBuilder value = UnrealLogger.LocalSb.Value;
				value.Clear();
				value.Append(message);
				if (args.Length > 0)
				{
					value.Append(' ');
					ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = args;
					for (int i = 0; i < readOnlySpan.Length; i++)
					{
						ValueTuple<string, object> valueTuple = *readOnlySpan[i];
						UnsafeStringBuilder unsafeStringBuilder = value;
						UnsafeStringBuilder unsafeStringBuilder2 = unsafeStringBuilder;
						UnsafeStringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new UnsafeStringBuilder.AppendInterpolatedStringHandler(3, 1, unsafeStringBuilder);
						appendInterpolatedStringHandler.AppendLiteral("[");
						appendInterpolatedStringHandler.AppendFormatted(valueTuple.Item1);
						appendInterpolatedStringHandler.AppendLiteral(": ");
						unsafeStringBuilder2.Append(ref appendInterpolatedStringHandler);
						UnrealLogger.AppendValueToBuilder(value, valueTuple.Item2);
						value.Append(']');
					}
				}
				if (trace)
				{
					StackTrace value2 = new StackTrace(1);
					value.Append<StackTrace>(value2);
				}
				UnrealLogger.Print((int)logVerbosity, (void*)value.GetBuffer());
				return;
			}
			if (message != null && message.Length != 0)
			{
				char* ptr;
				if (message == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = message.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* message2 = ptr;
				UnrealLogger.Print((int)logVerbosity, (void*)message2);
				char* ptr2 = null;
			}
		}

		// Token: 0x06028459 RID: 164953 RVA: 0x003D4364 File Offset: 0x003D2564
		private static void AppendValueToBuilder(UnsafeStringBuilder builder, [Nullable(2)] object value)
		{
			if (value == null)
			{
				builder.Append("null");
				return;
			}
			string text = value as string;
			if (text != null)
			{
				builder.Append(text);
				return;
			}
			if (value is ValueType)
			{
				builder.Append(value.ToString());
				return;
			}
			bool flag = value is IDictionary || value is IEnumerable;
			if (!flag)
			{
				Type type = value.GetType();
				builder.Append(type.FullName ?? type.Name);
				return;
			}
			if (UnrealLogger._containerDepth >= 4)
			{
				builder.Append("...");
				return;
			}
			if (UnrealLogger._visitedContainers == null)
			{
				UnrealLogger._visitedContainers = new HashSet<object>(ReferenceEqualityComparer.Instance);
			}
			if (!UnrealLogger._visitedContainers.Add(value))
			{
				builder.Append("<cycle>");
				return;
			}
			UnrealLogger._containerDepth++;
			try
			{
				IDictionary dictionary = value as IDictionary;
				if (dictionary != null)
				{
					builder.Append('{');
					bool flag2 = true;
					foreach (object obj in dictionary)
					{
						DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
						if (!flag2)
						{
							builder.Append(", ");
						}
						flag2 = false;
						UnrealLogger.AppendValueToBuilder(builder, dictionaryEntry.Key);
						builder.Append(": ");
						UnrealLogger.AppendValueToBuilder(builder, dictionaryEntry.Value);
					}
					builder.Append('}');
				}
				else
				{
					IEnumerable enumerable = (IEnumerable)value;
					builder.Append('[');
					bool flag3 = true;
					foreach (object value2 in enumerable)
					{
						if (!flag3)
						{
							builder.Append(", ");
						}
						flag3 = false;
						UnrealLogger.AppendValueToBuilder(builder, value2);
					}
					builder.Append(']');
				}
			}
			finally
			{
				UnrealLogger._visitedContainers.Remove(value);
				UnrealLogger._containerDepth--;
			}
		}

		// Token: 0x0602845A RID: 164954 RVA: 0x003D45A0 File Offset: 0x003D27A0
		private unsafe static void Print(EUeLogVerbosity logVerbosity, string message, bool trace)
		{
			if (trace)
			{
				UnsafeStringBuilder value = UnrealLogger.LocalSb.Value;
				value.Clear();
				value.Append(message);
				StackTrace value2 = new StackTrace(1);
				value.Append<StackTrace>(value2);
				UnrealLogger.Print((int)logVerbosity, (void*)value.GetBuffer());
				return;
			}
			if (message != null && message.Length != 0)
			{
				char* ptr;
				if (message == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = message.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* message2 = ptr;
				UnrealLogger.Print((int)logVerbosity, (void*)message2);
				char* ptr2 = null;
			}
		}

		// Token: 0x0602845B RID: 164955 RVA: 0x003D460B File Offset: 0x003D280B
		public unsafe static void Print(EUeLogVerbosity logVerbosity, UnsafeStringBuilder sb)
		{
			if (sb.Length > 0)
			{
				UnrealLogger.Print((int)logVerbosity, (void*)sb.GetBuffer());
			}
		}

		// Token: 0x0401629C RID: 90780
		private static readonly ThreadLocal<UnsafeStringBuilder> LocalSb = new ThreadLocal<UnsafeStringBuilder>(() => new UnsafeStringBuilder(1024));

		// Token: 0x0401629D RID: 90781
		private const int MAX_CONTAINER_DEPTH = 4;

		// Token: 0x0401629E RID: 90782
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[ThreadStatic]
		private static HashSet<object> _visitedContainers;

		// Token: 0x0401629F RID: 90783
		[ThreadStatic]
		private static int _containerDepth;
	}
}
