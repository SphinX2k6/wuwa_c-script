using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnrealEngine.Bulitin.Utils;

namespace UnrealEngine.Utils
{
	// Token: 0x0200089C RID: 2204
	[NullableContext(1)]
	[Nullable(0)]
	public class UnrealLogger
	{
		// Token: 0x0600BE04 RID: 48644
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void Print(int logVerbosity, void* message);

		// Token: 0x0600BE05 RID: 48645 RVA: 0x0012F511 File Offset: 0x0012D711
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

		// Token: 0x0600BE06 RID: 48646 RVA: 0x0012F51C File Offset: 0x0012D71C
		public static void Info(string message)
		{
			UnrealLogger.Print(EUeLogVerbosity.Display, message, false);
		}

		// Token: 0x0600BE07 RID: 48647 RVA: 0x0012F526 File Offset: 0x0012D726
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

		// Token: 0x0600BE08 RID: 48648 RVA: 0x0012F531 File Offset: 0x0012D731
		public static void Warn(string message)
		{
			UnrealLogger.Print(EUeLogVerbosity.Warning, message, false);
		}

		// Token: 0x0600BE09 RID: 48649 RVA: 0x0012F53B File Offset: 0x0012D73B
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

		// Token: 0x0600BE0A RID: 48650 RVA: 0x0012F546 File Offset: 0x0012D746
		public static void Error(string message)
		{
			UnrealLogger.Print(EUeLogVerbosity.Error, message, true);
		}

		// Token: 0x0600BE0B RID: 48651 RVA: 0x0012F550 File Offset: 0x0012D750
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

		// Token: 0x0600BE0C RID: 48652 RVA: 0x0012F55B File Offset: 0x0012D75B
		public static void ErrorNoTrace(string message)
		{
			UnrealLogger.Print(EUeLogVerbosity.Error, message, false);
		}

		// Token: 0x0600BE0D RID: 48653 RVA: 0x0012F568 File Offset: 0x0012D768
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

		// Token: 0x0600BE0E RID: 48654 RVA: 0x0012F674 File Offset: 0x0012D874
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

		// Token: 0x0600BE0F RID: 48655 RVA: 0x0012F8B0 File Offset: 0x0012DAB0
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

		// Token: 0x0600BE10 RID: 48656 RVA: 0x0012F91B File Offset: 0x0012DB1B
		public unsafe static void Print(EUeLogVerbosity logVerbosity, UnsafeStringBuilder sb)
		{
			if (sb.Length > 0)
			{
				UnrealLogger.Print((int)logVerbosity, (void*)sb.GetBuffer());
			}
		}

		// Token: 0x040056B3 RID: 22195
		private static readonly ThreadLocal<UnsafeStringBuilder> LocalSb = new ThreadLocal<UnsafeStringBuilder>(() => new UnsafeStringBuilder(1024));

		// Token: 0x040056B4 RID: 22196
		private const int MAX_CONTAINER_DEPTH = 4;

		// Token: 0x040056B5 RID: 22197
		[Nullable(new byte[]
		{
			2,
			1
		})]
		[ThreadStatic]
		private static HashSet<object> _visitedContainers;

		// Token: 0x040056B6 RID: 22198
		[ThreadStatic]
		private static int _containerDepth;
	}
}
