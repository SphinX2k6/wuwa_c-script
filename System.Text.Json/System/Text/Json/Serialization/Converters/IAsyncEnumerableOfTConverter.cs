using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000107 RID: 263
	internal sealed class IAsyncEnumerableOfTConverter<TAsyncEnumerable, TElement> : JsonCollectionConverter<TAsyncEnumerable, TElement> where TAsyncEnumerable : IAsyncEnumerable<TElement>
	{
		// Token: 0x06000D25 RID: 3365 RVA: 0x000332DD File Offset: 0x000314DD
		internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out TAsyncEnumerable value)
		{
			if (!typeToConvert.IsAssignableFrom(typeof(IAsyncEnumerable<TElement>)))
			{
				ThrowHelper.ThrowNotSupportedException_CannotPopulateCollection(this.Type, ref reader, ref state);
			}
			return base.OnTryRead(ref reader, typeToConvert, options, ref state, out value);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0003330C File Offset: 0x0003150C
		protected override void Add(in TElement value, ref ReadStack state)
		{
			((IAsyncEnumerableOfTConverter<TAsyncEnumerable, TElement>.BufferedAsyncEnumerable)state.Current.ReturnValue)._buffer.Add(value);
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0003332E File Offset: 0x0003152E
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			state.Current.ReturnValue = new IAsyncEnumerableOfTConverter<TAsyncEnumerable, TElement>.BufferedAsyncEnumerable();
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00033340 File Offset: 0x00031540
		internal override bool OnTryWrite(Utf8JsonWriter writer, TAsyncEnumerable value, JsonSerializerOptions options, ref WriteStack state)
		{
			if (!state.SupportAsync)
			{
				ThrowHelper.ThrowNotSupportedException_TypeRequiresAsyncSerialization(this.Type);
			}
			return base.OnTryWrite(writer, value, options, ref state);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00033364 File Offset: 0x00031564
		protected override bool OnWriteResume(Utf8JsonWriter writer, TAsyncEnumerable value, JsonSerializerOptions options, ref WriteStack state)
		{
			IAsyncEnumerator<TElement> asyncEnumerator;
			ValueTask<bool> valueTask;
			if (state.Current.AsyncDisposable == null)
			{
				asyncEnumerator = value.GetAsyncEnumerator(state.CancellationToken);
				state.Current.AsyncDisposable = asyncEnumerator;
				valueTask = asyncEnumerator.MoveNextAsync();
				if (!valueTask.IsCompleted)
				{
					state.SuppressFlush = true;
					goto IL_106;
				}
			}
			else
			{
				asyncEnumerator = (IAsyncEnumerator<TElement>)state.Current.AsyncDisposable;
				if (state.Current.AsyncEnumeratorIsPendingCompletion)
				{
					valueTask = new ValueTask<bool>((Task<bool>)state.PendingTask);
					state.Current.AsyncEnumeratorIsPendingCompletion = false;
					state.PendingTask = null;
				}
				else
				{
					valueTask = new ValueTask<bool>(true);
				}
			}
			JsonConverter<TElement> elementConverter = JsonCollectionConverter<TAsyncEnumerable, TElement>.GetElementConverter(ref state);
			while (valueTask.Result)
			{
				if (JsonConverter.ShouldFlush(ref state, writer))
				{
					return false;
				}
				TElement telement = asyncEnumerator.Current;
				if (!elementConverter.TryWrite(writer, telement, options, ref state))
				{
					return false;
				}
				state.Current.EndCollectionElement();
				valueTask = asyncEnumerator.MoveNextAsync();
				if (!valueTask.IsCompleted)
				{
					goto IL_106;
				}
			}
			state.Current.AsyncDisposable = null;
			state.AddCompletedAsyncDisposable(asyncEnumerator);
			return true;
			IL_106:
			state.PendingTask = valueTask.AsTask();
			state.Current.AsyncEnumeratorIsPendingCompletion = true;
			return false;
		}

		// Token: 0x02000108 RID: 264
		private sealed class BufferedAsyncEnumerable : IAsyncEnumerable<TElement>
		{
			// Token: 0x06000D2C RID: 3372 RVA: 0x0003349B File Offset: 0x0003169B
			[AsyncIteratorStateMachine(typeof(IAsyncEnumerableOfTConverter<, >.BufferedAsyncEnumerable.<GetAsyncEnumerator>d__1))]
			public IAsyncEnumerator<TElement> GetAsyncEnumerator(CancellationToken _)
			{
				IAsyncEnumerableOfTConverter<TAsyncEnumerable, TElement>.BufferedAsyncEnumerable.<GetAsyncEnumerator>d__1 <GetAsyncEnumerator>d__ = new IAsyncEnumerableOfTConverter<TAsyncEnumerable, TElement>.BufferedAsyncEnumerable.<GetAsyncEnumerator>d__1(-3);
				<GetAsyncEnumerator>d__.<>4__this = this;
				return <GetAsyncEnumerator>d__;
			}

			// Token: 0x04000426 RID: 1062
			public readonly List<TElement> _buffer = new List<TElement>();
		}
	}
}
