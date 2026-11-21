using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000E7 RID: 231
	internal sealed class ReflectionEmitCachingMemberAccessor : MemberAccessor
	{
		// Token: 0x06000C6F RID: 3183 RVA: 0x000315D9 File Offset: 0x0002F7D9
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public ReflectionEmitCachingMemberAccessor()
		{
			this._sourceAccessor = new ReflectionEmitMemberAccessor();
			this._cache = new ReflectionEmitCachingMemberAccessor.Cache<ValueTuple<string, Type, MemberInfo>>(TimeSpan.FromMilliseconds(1000L, 0L), TimeSpan.FromMilliseconds(200L, 0L));
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00031611 File Offset: 0x0002F811
		public override void Clear()
		{
			this._cache.Clear();
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0003161E File Offset: 0x0002F81E
		public override Action<TCollection, object> CreateAddMethodDelegate<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] TCollection>()
		{
			return this._cache.GetOrAdd<Action<TCollection, object>>(new ValueTuple<string, Type, MemberInfo>("CreateAddMethodDelegate", typeof(TCollection), null), ([TupleElementNames(new string[]
			{
				"id",
				"declaringType",
				"member"
			})] ValueTuple<string, Type, MemberInfo> _) => this._sourceAccessor.CreateAddMethodDelegate<TCollection>());
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0003164C File Offset: 0x0002F84C
		public override Func<object> CreateParameterlessConstructor(Type type, ConstructorInfo ctorInfo)
		{
			return this._cache.GetOrAdd<Func<object>>(new ValueTuple<string, Type, MemberInfo>("CreateParameterlessConstructor", type, ctorInfo), ([TupleElementNames(new string[]
			{
				"id",
				"declaringType",
				"member"
			})] ValueTuple<string, Type, MemberInfo> key) => this._sourceAccessor.CreateParameterlessConstructor(key.Item2, (ConstructorInfo)key.Item3));
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00031671 File Offset: 0x0002F871
		public override Func<object, TProperty> CreateFieldGetter<TProperty>(FieldInfo fieldInfo)
		{
			return this._cache.GetOrAdd<Func<object, TProperty>>(new ValueTuple<string, Type, MemberInfo>("CreateFieldGetter", typeof(TProperty), fieldInfo), ([TupleElementNames(new string[]
			{
				"id",
				"declaringType",
				"member"
			})] ValueTuple<string, Type, MemberInfo> key) => this._sourceAccessor.CreateFieldGetter<TProperty>((FieldInfo)key.Item3));
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0003169F File Offset: 0x0002F89F
		public override Action<object, TProperty> CreateFieldSetter<TProperty>(FieldInfo fieldInfo)
		{
			return this._cache.GetOrAdd<Action<object, TProperty>>(new ValueTuple<string, Type, MemberInfo>("CreateFieldSetter", typeof(TProperty), fieldInfo), ([TupleElementNames(new string[]
			{
				"id",
				"declaringType",
				"member"
			})] ValueTuple<string, Type, MemberInfo> key) => this._sourceAccessor.CreateFieldSetter<TProperty>((FieldInfo)key.Item3));
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x000316CD File Offset: 0x0002F8CD
		public override Func<IEnumerable<KeyValuePair<TKey, TValue>>, TCollection> CreateImmutableDictionaryCreateRangeDelegate<TCollection, TKey, TValue>()
		{
			return this._cache.GetOrAdd<Func<IEnumerable<KeyValuePair<TKey, TValue>>, TCollection>>(new ValueTuple<string, Type, MemberInfo>("CreateImmutableDictionaryCreateRangeDelegate", typeof(ValueTuple<TCollection, TKey, TValue>), null), ([TupleElementNames(new string[]
			{
				"id",
				"declaringType",
				"member"
			})] ValueTuple<string, Type, MemberInfo> _) => this._sourceAccessor.CreateImmutableDictionaryCreateRangeDelegate<TCollection, TKey, TValue>());
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x000316FB File Offset: 0x0002F8FB
		public override Func<IEnumerable<TElement>, TCollection> CreateImmutableEnumerableCreateRangeDelegate<TCollection, TElement>()
		{
			return this._cache.GetOrAdd<Func<IEnumerable<TElement>, TCollection>>(new ValueTuple<string, Type, MemberInfo>("CreateImmutableEnumerableCreateRangeDelegate", typeof(ValueTuple<TCollection, TElement>), null), ([TupleElementNames(new string[]
			{
				"id",
				"declaringType",
				"member"
			})] ValueTuple<string, Type, MemberInfo> _) => this._sourceAccessor.CreateImmutableEnumerableCreateRangeDelegate<TCollection, TElement>());
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00031729 File Offset: 0x0002F929
		public override Func<object[], T> CreateParameterizedConstructor<T>(ConstructorInfo constructor)
		{
			return this._cache.GetOrAdd<Func<object[], T>>(new ValueTuple<string, Type, MemberInfo>("CreateParameterizedConstructor", typeof(T), constructor), ([TupleElementNames(new string[]
			{
				"id",
				"declaringType",
				"member"
			})] ValueTuple<string, Type, MemberInfo> key) => this._sourceAccessor.CreateParameterizedConstructor<T>((ConstructorInfo)key.Item3));
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00031757 File Offset: 0x0002F957
		public override JsonTypeInfo.ParameterizedConstructorDelegate<T, TArg0, TArg1, TArg2, TArg3> CreateParameterizedConstructor<T, TArg0, TArg1, TArg2, TArg3>(ConstructorInfo constructor)
		{
			return this._cache.GetOrAdd<JsonTypeInfo.ParameterizedConstructorDelegate<T, TArg0, TArg1, TArg2, TArg3>>(new ValueTuple<string, Type, MemberInfo>("CreateParameterizedConstructor", typeof(T), constructor), ([TupleElementNames(new string[]
			{
				"id",
				"declaringType",
				"member"
			})] ValueTuple<string, Type, MemberInfo> key) => this._sourceAccessor.CreateParameterizedConstructor<T, TArg0, TArg1, TArg2, TArg3>((ConstructorInfo)key.Item3));
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00031785 File Offset: 0x0002F985
		public override Func<object, TProperty> CreatePropertyGetter<TProperty>(PropertyInfo propertyInfo)
		{
			return this._cache.GetOrAdd<Func<object, TProperty>>(new ValueTuple<string, Type, MemberInfo>("CreatePropertyGetter", typeof(TProperty), propertyInfo), ([TupleElementNames(new string[]
			{
				"id",
				"declaringType",
				"member"
			})] ValueTuple<string, Type, MemberInfo> key) => this._sourceAccessor.CreatePropertyGetter<TProperty>((PropertyInfo)key.Item3));
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x000317B3 File Offset: 0x0002F9B3
		public override Action<object, TProperty> CreatePropertySetter<TProperty>(PropertyInfo propertyInfo)
		{
			return this._cache.GetOrAdd<Action<object, TProperty>>(new ValueTuple<string, Type, MemberInfo>("CreatePropertySetter", typeof(TProperty), propertyInfo), ([TupleElementNames(new string[]
			{
				"id",
				"declaringType",
				"member"
			})] ValueTuple<string, Type, MemberInfo> key) => this._sourceAccessor.CreatePropertySetter<TProperty>((PropertyInfo)key.Item3));
		}

		// Token: 0x0400040B RID: 1035
		private readonly ReflectionEmitMemberAccessor _sourceAccessor;

		// Token: 0x0400040C RID: 1036
		[TupleElementNames(new string[]
		{
			"id",
			"declaringType",
			"member"
		})]
		private readonly ReflectionEmitCachingMemberAccessor.Cache<ValueTuple<string, Type, MemberInfo>> _cache;

		// Token: 0x020000E8 RID: 232
		private sealed class Cache<TKey>
		{
			// Token: 0x06000C85 RID: 3205 RVA: 0x000318B8 File Offset: 0x0002FAB8
			public Cache(TimeSpan slidingExpiration, TimeSpan evictionInterval)
			{
				this._slidingExpirationTicks = slidingExpiration.Ticks;
				this._evictionIntervalTicks = evictionInterval.Ticks;
				this._lastEvictedTicks = DateTime.UtcNow.Ticks;
			}

			// Token: 0x06000C86 RID: 3206 RVA: 0x00031904 File Offset: 0x0002FB04
			public TValue GetOrAdd<TValue>(TKey key, Func<TKey, TValue> valueFactory) where TValue : class
			{
				ReflectionEmitCachingMemberAccessor.Cache<TKey>.CacheEntry orAdd = this._cache.GetOrAdd<Func<TKey, TValue>>(key2, (TKey key, Func<TKey, TValue> valueFactory) => new ReflectionEmitCachingMemberAccessor.Cache<TKey>.CacheEntry(valueFactory(key)), valueFactory2);
				long ticks = DateTime.UtcNow.Ticks;
				Volatile.Write(ref orAdd.LastUsedTicks, ticks);
				if (ticks - Volatile.Read(ref this._lastEvictedTicks) >= this._evictionIntervalTicks && Interlocked.CompareExchange(ref this._evictLock, 1, 0) == 0)
				{
					if (ticks - this._lastEvictedTicks >= this._evictionIntervalTicks)
					{
						this.EvictStaleCacheEntries(ticks);
						Volatile.Write(ref this._lastEvictedTicks, ticks);
					}
					Volatile.Write(ref this._evictLock, 0);
				}
				return (TValue)((object)orAdd.Value);
			}

			// Token: 0x06000C87 RID: 3207 RVA: 0x000319B4 File Offset: 0x0002FBB4
			public void Clear()
			{
				this._cache.Clear();
				this._lastEvictedTicks = DateTime.UtcNow.Ticks;
			}

			// Token: 0x06000C88 RID: 3208 RVA: 0x000319E0 File Offset: 0x0002FBE0
			private void EvictStaleCacheEntries(long utcNowTicks)
			{
				foreach (KeyValuePair<TKey, ReflectionEmitCachingMemberAccessor.Cache<TKey>.CacheEntry> keyValuePair in this._cache)
				{
					if (utcNowTicks - Volatile.Read(ref keyValuePair.Value.LastUsedTicks) >= this._slidingExpirationTicks)
					{
						ReflectionEmitCachingMemberAccessor.Cache<TKey>.CacheEntry cacheEntry;
						this._cache.TryRemove(keyValuePair.Key, out cacheEntry);
					}
				}
			}

			// Token: 0x0400040D RID: 1037
			private int _evictLock;

			// Token: 0x0400040E RID: 1038
			private long _lastEvictedTicks;

			// Token: 0x0400040F RID: 1039
			private readonly long _evictionIntervalTicks;

			// Token: 0x04000410 RID: 1040
			private readonly long _slidingExpirationTicks;

			// Token: 0x04000411 RID: 1041
			private readonly ConcurrentDictionary<TKey, ReflectionEmitCachingMemberAccessor.Cache<TKey>.CacheEntry> _cache = new ConcurrentDictionary<TKey, ReflectionEmitCachingMemberAccessor.Cache<TKey>.CacheEntry>();

			// Token: 0x020000E9 RID: 233
			private sealed class CacheEntry
			{
				// Token: 0x06000C89 RID: 3209 RVA: 0x00031A58 File Offset: 0x0002FC58
				public CacheEntry(object value)
				{
					this.Value = value;
				}

				// Token: 0x04000412 RID: 1042
				public readonly object Value;

				// Token: 0x04000413 RID: 1043
				public long LastUsedTicks;
			}
		}
	}
}
