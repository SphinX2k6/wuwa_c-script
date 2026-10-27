using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200006F RID: 111
	[NullableContext(1)]
	[Nullable(0)]
	public static class NativeSetProcessorFactory
	{
		// Token: 0x06000DBF RID: 3519 RVA: 0x00013C80 File Offset: 0x00011E80
		public static INativeSetProcessor<T> GetProcessor<[Nullable(2)] T>()
		{
			switch (Type.GetTypeCode(typeof(T)))
			{
			case TypeCode.Empty:
			case TypeCode.DBNull:
			case TypeCode.DateTime:
			case TypeCode.String:
				throw new ArgumentOutOfRangeException();
			case TypeCode.Object:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_ObjectProcessor;
			case TypeCode.Boolean:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_BoolProcessor;
			case TypeCode.Char:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_CharProcessor;
			case TypeCode.SByte:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_SByteProcessor;
			case TypeCode.Byte:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_ByteProcessor;
			case TypeCode.Int16:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_Int16Processor;
			case TypeCode.UInt16:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_UInt16Processor;
			case TypeCode.Int32:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_Int32Processor;
			case TypeCode.UInt32:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_UInt32Processor;
			case TypeCode.Int64:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_Int64Processor;
			case TypeCode.UInt64:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_UInt64Processor;
			case TypeCode.Single:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_FloatProcessor;
			case TypeCode.Double:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_DoubleProcessor;
			case TypeCode.Decimal:
				return (INativeSetProcessor<T>)NativeSetProcessorFactory.s_DecimalProcessor;
			}
			throw new ArgumentOutOfRangeException();
		}

		// Token: 0x04000178 RID: 376
		private static readonly UnmanagedSetProcessor<bool> s_BoolProcessor = new UnmanagedSetProcessor<bool>();

		// Token: 0x04000179 RID: 377
		private static readonly UnmanagedSetProcessor<char> s_CharProcessor = new UnmanagedSetProcessor<char>();

		// Token: 0x0400017A RID: 378
		private static readonly UnmanagedSetProcessor<byte> s_ByteProcessor = new UnmanagedSetProcessor<byte>();

		// Token: 0x0400017B RID: 379
		private static readonly UnmanagedSetProcessor<sbyte> s_SByteProcessor = new UnmanagedSetProcessor<sbyte>();

		// Token: 0x0400017C RID: 380
		private static readonly UnmanagedSetProcessor<short> s_Int16Processor = new UnmanagedSetProcessor<short>();

		// Token: 0x0400017D RID: 381
		private static readonly UnmanagedSetProcessor<ushort> s_UInt16Processor = new UnmanagedSetProcessor<ushort>();

		// Token: 0x0400017E RID: 382
		private static readonly UnmanagedSetProcessor<int> s_Int32Processor = new UnmanagedSetProcessor<int>();

		// Token: 0x0400017F RID: 383
		private static readonly UnmanagedSetProcessor<uint> s_UInt32Processor = new UnmanagedSetProcessor<uint>();

		// Token: 0x04000180 RID: 384
		private static readonly UnmanagedSetProcessor<long> s_Int64Processor = new UnmanagedSetProcessor<long>();

		// Token: 0x04000181 RID: 385
		private static readonly UnmanagedSetProcessor<ulong> s_UInt64Processor = new UnmanagedSetProcessor<ulong>();

		// Token: 0x04000182 RID: 386
		private static readonly UnmanagedSetProcessor<float> s_FloatProcessor = new UnmanagedSetProcessor<float>();

		// Token: 0x04000183 RID: 387
		private static readonly UnmanagedSetProcessor<double> s_DoubleProcessor = new UnmanagedSetProcessor<double>();

		// Token: 0x04000184 RID: 388
		private static readonly UnmanagedSetProcessor<decimal> s_DecimalProcessor = new UnmanagedSetProcessor<decimal>();

		// Token: 0x04000185 RID: 389
		private static UnrealObjectSetProcessor<UnrealUObject> s_ObjectProcessor = new UnrealObjectSetProcessor<UnrealUObject>();
	}
}
