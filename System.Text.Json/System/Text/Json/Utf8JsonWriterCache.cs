using System;
using System.Buffers;

namespace System.Text.Json
{
	// Token: 0x02000040 RID: 64
	internal static class Utf8JsonWriterCache
	{
		// Token: 0x060004A4 RID: 1188 RVA: 0x00014BAF File Offset: 0x00012DAF
		public static Utf8JsonWriter RentWriterAndBuffer(JsonSerializerOptions options, out PooledByteBufferWriter bufferWriter)
		{
			return Utf8JsonWriterCache.RentWriterAndBuffer(options.GetWriterOptions(), options.DefaultBufferSize, out bufferWriter);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00014BC4 File Offset: 0x00012DC4
		public static Utf8JsonWriter RentWriterAndBuffer(JsonWriterOptions options, int defaultBufferSize, out PooledByteBufferWriter bufferWriter)
		{
			Utf8JsonWriterCache.ThreadLocalState threadLocalState;
			if ((threadLocalState = Utf8JsonWriterCache.t_threadLocalState) == null)
			{
				threadLocalState = (Utf8JsonWriterCache.t_threadLocalState = new Utf8JsonWriterCache.ThreadLocalState());
			}
			Utf8JsonWriterCache.ThreadLocalState threadLocalState2 = threadLocalState;
			Utf8JsonWriterCache.ThreadLocalState threadLocalState3 = threadLocalState2;
			int rentedWriters = threadLocalState3.RentedWriters;
			threadLocalState3.RentedWriters = rentedWriters + 1;
			Utf8JsonWriter utf8JsonWriter;
			if (rentedWriters == 0)
			{
				bufferWriter = threadLocalState2.BufferWriter;
				utf8JsonWriter = threadLocalState2.Writer;
				bufferWriter.InitializeEmptyInstance(defaultBufferSize);
				utf8JsonWriter.Reset(bufferWriter, options);
			}
			else
			{
				bufferWriter = new PooledByteBufferWriter(defaultBufferSize);
				utf8JsonWriter = new Utf8JsonWriter(bufferWriter, options);
			}
			return utf8JsonWriter;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00014C30 File Offset: 0x00012E30
		public static Utf8JsonWriter RentWriter(JsonSerializerOptions options, IBufferWriter<byte> bufferWriter)
		{
			Utf8JsonWriterCache.ThreadLocalState threadLocalState;
			if ((threadLocalState = Utf8JsonWriterCache.t_threadLocalState) == null)
			{
				threadLocalState = (Utf8JsonWriterCache.t_threadLocalState = new Utf8JsonWriterCache.ThreadLocalState());
			}
			Utf8JsonWriterCache.ThreadLocalState threadLocalState2 = threadLocalState;
			Utf8JsonWriterCache.ThreadLocalState threadLocalState3 = threadLocalState2;
			int rentedWriters = threadLocalState3.RentedWriters;
			threadLocalState3.RentedWriters = rentedWriters + 1;
			Utf8JsonWriter utf8JsonWriter;
			if (rentedWriters == 0)
			{
				utf8JsonWriter = threadLocalState2.Writer;
				utf8JsonWriter.Reset(bufferWriter, options.GetWriterOptions());
			}
			else
			{
				utf8JsonWriter = new Utf8JsonWriter(bufferWriter, options.GetWriterOptions());
			}
			return utf8JsonWriter;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00014C8C File Offset: 0x00012E8C
		public static void ReturnWriterAndBuffer(Utf8JsonWriter writer, PooledByteBufferWriter bufferWriter)
		{
			Utf8JsonWriterCache.ThreadLocalState threadLocalState = Utf8JsonWriterCache.t_threadLocalState;
			writer.ResetAllStateForCacheReuse();
			bufferWriter.ClearAndReturnBuffers();
			int rentedWriters = threadLocalState.RentedWriters - 1;
			threadLocalState.RentedWriters = rentedWriters;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00014CBC File Offset: 0x00012EBC
		public static void ReturnWriter(Utf8JsonWriter writer)
		{
			Utf8JsonWriterCache.ThreadLocalState threadLocalState = Utf8JsonWriterCache.t_threadLocalState;
			writer.ResetAllStateForCacheReuse();
			int rentedWriters = threadLocalState.RentedWriters - 1;
			threadLocalState.RentedWriters = rentedWriters;
		}

		// Token: 0x040000F1 RID: 241
		[ThreadStatic]
		private static Utf8JsonWriterCache.ThreadLocalState t_threadLocalState;

		// Token: 0x02000041 RID: 65
		private sealed class ThreadLocalState
		{
			// Token: 0x060004A9 RID: 1193 RVA: 0x00014CE3 File Offset: 0x00012EE3
			public ThreadLocalState()
			{
				this.BufferWriter = PooledByteBufferWriter.CreateEmptyInstanceForCaching();
				this.Writer = Utf8JsonWriter.CreateEmptyInstanceForCaching();
			}

			// Token: 0x040000F2 RID: 242
			public readonly PooledByteBufferWriter BufferWriter;

			// Token: 0x040000F3 RID: 243
			public readonly Utf8JsonWriter Writer;

			// Token: 0x040000F4 RID: 244
			public int RentedWriters;
		}
	}
}
