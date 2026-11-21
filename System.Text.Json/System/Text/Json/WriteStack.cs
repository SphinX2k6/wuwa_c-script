using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading;
using System.Threading.Tasks;

namespace System.Text.Json
{
	// Token: 0x02000051 RID: 81
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	[StructLayout(LayoutKind.Auto)]
	internal struct WriteStack
	{
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00016B77 File Offset: 0x00014D77
		public readonly int CurrentDepth
		{
			get
			{
				return this._count;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00016B7F File Offset: 0x00014D7F
		public readonly bool IsContinuation
		{
			get
			{
				return this._continuationCount != 0;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00016B8A File Offset: 0x00014D8A
		public readonly bool CurrentContainsMetadata
		{
			get
			{
				return this.NewReferenceId != null || this.PolymorphicTypeDiscriminator != null;
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00016BA0 File Offset: 0x00014DA0
		private void EnsurePushCapacity()
		{
			if (this._stack == null)
			{
				this._stack = new WriteStackFrame[4];
				return;
			}
			if (this._count - (int)this._indexOffset == this._stack.Length)
			{
				Array.Resize<WriteStackFrame>(ref this._stack, 2 * this._stack.Length);
			}
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00016BF0 File Offset: 0x00014DF0
		internal void Initialize(JsonTypeInfo jsonTypeInfo, object rootValueBoxed = null, bool supportContinuation = false, bool supportAsync = false)
		{
			this.Current.JsonTypeInfo = jsonTypeInfo;
			this.Current.JsonPropertyInfo = jsonTypeInfo.PropertyInfoForTypeInfo;
			this.Current.NumberHandling = this.Current.JsonPropertyInfo.EffectiveNumberHandling;
			this.SupportContinuation = supportContinuation;
			this.SupportAsync = supportAsync;
			JsonSerializerOptions options = jsonTypeInfo.Options;
			if (options.ReferenceHandlingStrategy != ReferenceHandlingStrategy.None)
			{
				this.ReferenceResolver = options.ReferenceHandler.CreateResolver(true);
				if (options.ReferenceHandlingStrategy == ReferenceHandlingStrategy.IgnoreCycles && rootValueBoxed != null && jsonTypeInfo.Type.IsValueType)
				{
					this.ReferenceResolver.PushReferenceForCycleDetection(rootValueBoxed);
				}
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00016C8A File Offset: 0x00014E8A
		public readonly JsonTypeInfo PeekNestedJsonTypeInfo()
		{
			if (this._count != 0)
			{
				return this.Current.JsonPropertyInfo.JsonTypeInfo;
			}
			return this.Current.JsonTypeInfo;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00016CB0 File Offset: 0x00014EB0
		public void Push()
		{
			if (this._continuationCount != 0)
			{
				int count = this._count;
				this._count = count + 1;
				if (count > 0 || this._indexOffset == 0)
				{
					this.Current = this._stack[this._count - (int)this._indexOffset];
				}
				if (this._continuationCount == this._count)
				{
					this._continuationCount = 0;
				}
				return;
			}
			if (this._count == 0 && this.Current.PolymorphicSerializationState == PolymorphicSerializationState.None)
			{
				this._count = 1;
				this._indexOffset = 1;
				return;
			}
			JsonTypeInfo nestedJsonTypeInfo = this.Current.GetNestedJsonTypeInfo();
			JsonNumberHandling? numberHandling = this.Current.NumberHandling;
			this.EnsurePushCapacity();
			this._stack[this._count - (int)this._indexOffset] = this.Current;
			this.Current = default(WriteStackFrame);
			this._count++;
			this.Current.JsonTypeInfo = nestedJsonTypeInfo;
			this.Current.JsonPropertyInfo = nestedJsonTypeInfo.PropertyInfoForTypeInfo;
			JsonNumberHandling? jsonNumberHandling = numberHandling;
			this.Current.NumberHandling = ((jsonNumberHandling != null) ? jsonNumberHandling : this.Current.JsonPropertyInfo.EffectiveNumberHandling);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00016DD8 File Offset: 0x00014FD8
		public void Pop(bool success)
		{
			int num;
			if (!success)
			{
				if (this._continuationCount == 0)
				{
					if (this._count == 1 && this._indexOffset > 0)
					{
						this._continuationCount = 1;
						this._count = 0;
						return;
					}
					this.EnsurePushCapacity();
					num = this._count;
					this._count = num - 1;
					this._continuationCount = num;
				}
				else
				{
					num = this._count - 1;
					this._count = num;
					if (num == 0 && this._indexOffset > 0)
					{
						return;
					}
				}
				int num2 = this._count - (int)this._indexOffset;
				this._stack[num2 + 1] = this.Current;
				this.Current = this._stack[num2];
				return;
			}
			num = this._count - 1;
			this._count = num;
			if (num > 0 || this._indexOffset == 0)
			{
				this.Current = this._stack[this._count - (int)this._indexOffset];
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00016EC0 File Offset: 0x000150C0
		public void AddCompletedAsyncDisposable(IAsyncDisposable asyncDisposable)
		{
			List<IAsyncDisposable> list;
			if ((list = this.CompletedAsyncDisposables) == null)
			{
				list = (this.CompletedAsyncDisposables = new List<IAsyncDisposable>());
			}
			list.Add(asyncDisposable);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00016EEC File Offset: 0x000150EC
		public readonly ValueTask DisposeCompletedAsyncDisposables()
		{
			WriteStack.<DisposeCompletedAsyncDisposables>d__31 <DisposeCompletedAsyncDisposables>d__;
			<DisposeCompletedAsyncDisposables>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<DisposeCompletedAsyncDisposables>d__.<>4__this = this;
			<DisposeCompletedAsyncDisposables>d__.<>1__state = -1;
			<DisposeCompletedAsyncDisposables>d__.<>t__builder.Start<WriteStack.<DisposeCompletedAsyncDisposables>d__31>(ref <DisposeCompletedAsyncDisposables>d__);
			return <DisposeCompletedAsyncDisposables>d__.<>t__builder.Task;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00016F34 File Offset: 0x00015134
		public readonly void DisposePendingDisposablesOnException()
		{
			Exception ex = null;
			WriteStack.<DisposePendingDisposablesOnException>g__DisposeFrame|32_0(this.Current.CollectionEnumerator, ref ex);
			int num = Math.Max(this._count, this._continuationCount);
			for (int i = 0; i < num - 1; i++)
			{
				WriteStack.<DisposePendingDisposablesOnException>g__DisposeFrame|32_0(this._stack[i].CollectionEnumerator, ref ex);
			}
			if (ex != null)
			{
				ExceptionDispatchInfo.Capture(ex).Throw();
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00016F9C File Offset: 0x0001519C
		public readonly ValueTask DisposePendingDisposablesOnExceptionAsync()
		{
			WriteStack.<DisposePendingDisposablesOnExceptionAsync>d__33 <DisposePendingDisposablesOnExceptionAsync>d__;
			<DisposePendingDisposablesOnExceptionAsync>d__.<>t__builder = AsyncValueTaskMethodBuilder.Create();
			<DisposePendingDisposablesOnExceptionAsync>d__.<>4__this = this;
			<DisposePendingDisposablesOnExceptionAsync>d__.<>1__state = -1;
			<DisposePendingDisposablesOnExceptionAsync>d__.<>t__builder.Start<WriteStack.<DisposePendingDisposablesOnExceptionAsync>d__33>(ref <DisposePendingDisposablesOnExceptionAsync>d__);
			return <DisposePendingDisposablesOnExceptionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00016FE4 File Offset: 0x000151E4
		public string PropertyPath()
		{
			StringBuilder stringBuilder = new StringBuilder("$");
			int continuationCount = this._continuationCount;
			ValueTuple<int, bool> valueTuple;
			if (continuationCount != 0)
			{
				if (continuationCount != 1)
				{
					valueTuple = new ValueTuple<int, bool>(continuationCount, false);
				}
				else
				{
					valueTuple = new ValueTuple<int, bool>(0, true);
				}
			}
			else
			{
				valueTuple = new ValueTuple<int, bool>(this._count - 1, true);
			}
			ValueTuple<int, bool> valueTuple2 = valueTuple;
			int item = valueTuple2.Item1;
			bool item2 = valueTuple2.Item2;
			for (int i = 1; i <= item; i++)
			{
				WriteStack.<PropertyPath>g__AppendStackFrame|34_0(stringBuilder, ref this._stack[i - (int)this._indexOffset]);
			}
			if (item2)
			{
				WriteStack.<PropertyPath>g__AppendStackFrame|34_0(stringBuilder, ref this.Current);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x00017080 File Offset: 0x00015280
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string DebuggerDisplay
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 3);
				defaultInterpolatedStringHandler.AppendLiteral("Path = ");
				defaultInterpolatedStringHandler.AppendFormatted(this.PropertyPath());
				defaultInterpolatedStringHandler.AppendLiteral(" Current = ConverterStrategy.");
				JsonPropertyInfo jsonPropertyInfo = this.Current.JsonPropertyInfo;
				defaultInterpolatedStringHandler.AppendFormatted<ConverterStrategy?>((jsonPropertyInfo != null) ? new ConverterStrategy?(jsonPropertyInfo.EffectiveConverter.ConverterStrategy) : null);
				defaultInterpolatedStringHandler.AppendLiteral(", ");
				JsonTypeInfo jsonTypeInfo = this.Current.JsonTypeInfo;
				defaultInterpolatedStringHandler.AppendFormatted((jsonTypeInfo != null) ? jsonTypeInfo.Type.Name : null);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00017124 File Offset: 0x00015324
		[CompilerGenerated]
		internal static void <DisposePendingDisposablesOnException>g__DisposeFrame|32_0(IEnumerator collectionEnumerator, ref Exception exception)
		{
			try
			{
				IDisposable disposable = collectionEnumerator as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			catch (Exception ex)
			{
				exception = ex;
			}
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0001715C File Offset: 0x0001535C
		[CompilerGenerated]
		internal static ValueTask<Exception> <DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|33_0(IEnumerator collectionEnumerator, IAsyncDisposable asyncDisposable, Exception exception)
		{
			WriteStack.<<DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|33_0>d <<DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|33_0>d;
			<<DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|33_0>d.<>t__builder = AsyncValueTaskMethodBuilder<Exception>.Create();
			<<DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|33_0>d.collectionEnumerator = collectionEnumerator;
			<<DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|33_0>d.asyncDisposable = asyncDisposable;
			<<DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|33_0>d.exception = exception;
			<<DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|33_0>d.<>1__state = -1;
			<<DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|33_0>d.<>t__builder.Start<WriteStack.<<DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|33_0>d>(ref <<DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|33_0>d);
			return <<DisposePendingDisposablesOnExceptionAsync>g__DisposeFrame|33_0>d.<>t__builder.Task;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000171B0 File Offset: 0x000153B0
		[CompilerGenerated]
		internal static void <PropertyPath>g__AppendStackFrame|34_0(StringBuilder sb, ref WriteStackFrame frame)
		{
			JsonPropertyInfo jsonPropertyInfo = frame.JsonPropertyInfo;
			string propertyName = ((jsonPropertyInfo != null) ? jsonPropertyInfo.MemberName : null) ?? frame.JsonPropertyNameAsString;
			WriteStack.<PropertyPath>g__AppendPropertyName|34_1(sb, propertyName);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x000171E4 File Offset: 0x000153E4
		[CompilerGenerated]
		internal static void <PropertyPath>g__AppendPropertyName|34_1(StringBuilder sb, string propertyName)
		{
			if (propertyName != null)
			{
				if (propertyName.AsSpan().ContainsSpecialCharacters())
				{
					sb.Append("['");
					sb.Append(propertyName);
					sb.Append("']");
					return;
				}
				sb.Append('.');
				sb.Append(propertyName);
			}
		}

		// Token: 0x04000165 RID: 357
		public WriteStackFrame Current;

		// Token: 0x04000166 RID: 358
		private WriteStackFrame[] _stack;

		// Token: 0x04000167 RID: 359
		private int _count;

		// Token: 0x04000168 RID: 360
		private int _continuationCount;

		// Token: 0x04000169 RID: 361
		private byte _indexOffset;

		// Token: 0x0400016A RID: 362
		public CancellationToken CancellationToken;

		// Token: 0x0400016B RID: 363
		public bool SuppressFlush;

		// Token: 0x0400016C RID: 364
		public Task PendingTask;

		// Token: 0x0400016D RID: 365
		public List<IAsyncDisposable> CompletedAsyncDisposables;

		// Token: 0x0400016E RID: 366
		public int FlushThreshold;

		// Token: 0x0400016F RID: 367
		public PipeWriter PipeWriter;

		// Token: 0x04000170 RID: 368
		public ReferenceResolver ReferenceResolver;

		// Token: 0x04000171 RID: 369
		public bool SupportContinuation;

		// Token: 0x04000172 RID: 370
		public bool SupportAsync;

		// Token: 0x04000173 RID: 371
		public string NewReferenceId;

		// Token: 0x04000174 RID: 372
		public object PolymorphicTypeDiscriminator;

		// Token: 0x04000175 RID: 373
		public PolymorphicTypeResolver PolymorphicTypeResolver;
	}
}
