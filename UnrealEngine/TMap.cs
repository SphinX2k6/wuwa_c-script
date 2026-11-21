using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000059 RID: 89
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class TMap<K, [Nullable(2)] V> : UnrealProxyObject, IDictionary<K, V>, ICollection<KeyValuePair<K, V>>, IEnumerable<KeyValuePair<K, V>>, IEnumerable, IReadOnlyDictionary<K, V>, IReadOnlyCollection<KeyValuePair<K, V>>
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0000F9EC File Offset: 0x0000DBEC
		public IntPtr NativeMapPtr
		{
			get
			{
				return base.NativePtr.Map;
			}
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0000F9F9 File Offset: 0x0000DBF9
		public TMap()
		{
			FCScriptMapHelperWrapper.AllocNativeScriptMap(base.NativePtr);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0000FA0C File Offset: 0x0000DC0C
		[NullableContext(2)]
		public TMap(IntPtr NativeScriptMapPtr, UnrealObject MemoryOwner)
		{
			SharpherealAssert.Assert(NativeScriptMapPtr != IntPtr.Zero);
			bool condition;
			if (MemoryOwner != null && !(MemoryOwner is UnrealUObject))
			{
				UnrealProxyObject unrealProxyObject = MemoryOwner as UnrealProxyObject;
				if (unrealProxyObject == null || !unrealProxyObject.IsNativePtrAllocated)
				{
					condition = false;
					goto IL_39;
				}
			}
			condition = true;
			IL_39:
			SharpherealAssert.Assert(condition);
			this._MemoryOwner = MemoryOwner;
			FCScriptMapHelperWrapper.SetNativeScriptMap(base.NativePtr, NativeScriptMapPtr, base.IsNativePtrAllocated);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0000FA71 File Offset: 0x0000DC71
		public TMap(IntPtr NativeScriptMapPtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativeScriptMapPtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0000FA7C File Offset: 0x0000DC7C
		protected override IntPtr AllocNativePtr()
		{
			NativeArrayProcessorFactory.AddRef(TMap<K, V>.KeyProcessor);
			NativeArrayProcessorFactory.AddRef(TMap<K, V>.ValueProcessor);
			IntPtr keyInnerUStructPtr = TMap<K, V>.KeyProcessor.IsStructProxyProcessor ? ((IScriptStructProcessor)TMap<K, V>.KeyProcessor).GetNativeScriptStructPtr().ScriptStructPtr : IntPtr.Zero;
			IntPtr valueInnerUStructPtr = TMap<K, V>.ValueProcessor.IsStructProxyProcessor ? ((IScriptStructProcessor)TMap<K, V>.ValueProcessor).GetNativeScriptStructPtr().ScriptStructPtr : IntPtr.Zero;
			return FCScriptMapHelperWrapper.AllocNativeMemory(TMap<K, V>.KeyInnerPropertyTypeCode, keyInnerUStructPtr, TMap<K, V>.KeyProcessor.Size, TMap<K, V>.KeyProcessor.MinAlignment, TMap<K, V>.ValueInnerPropertyTypeCode, valueInnerUStructPtr, TMap<K, V>.ValueProcessor.Size, TMap<K, V>.ValueProcessor.MinAlignment);
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0000FB26 File Offset: 0x0000DD26
		protected override void DeallocNativePtr()
		{
			this.Empty(0);
			FCScriptMapHelperWrapper.DeallocNativeMemory(this._NativePtr);
			NativeArrayProcessorFactory.DecRef(TMap<K, V>.KeyProcessor);
			NativeArrayProcessorFactory.DecRef(TMap<K, V>.ValueProcessor);
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x0000FB4E File Offset: 0x0000DD4E
		public override bool AllowMoveAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0000FB51 File Offset: 0x0000DD51
		public override void MoveAssign(IntPtr Src)
		{
			if (Src == 0)
			{
				this.Empty(0);
				return;
			}
			FCScriptMapHelperWrapper.MoveAssign(this._NativePtr, Src);
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x0000FB6A File Offset: 0x0000DD6A
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0000FB6D File Offset: 0x0000DD6D
		public override void CopyAssign(IntPtr Src)
		{
			if (Src == 0)
			{
				this.Empty(0);
				return;
			}
			FCScriptMapHelperWrapper.CopyAssign(this._NativePtr, Src);
		}

		// Token: 0x170000B1 RID: 177
		public V this[K Key]
		{
			[return: MaybeNull]
			get
			{
				return this.Get(Key);
			}
			set
			{
				this.Add(Key, value);
			}
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		public unsafe void Add(K Key, [MaybeNull] V Value)
		{
			ArgumentNullException.ThrowIfNull(Key, "Key");
			bool flag = false;
			bool flag2 = false;
			void* ptr = TMap<K, V>.KeyProcessor.GetElementPtr(ref Key, ref flag);
			if (ptr == null)
			{
				ptr = (void*)(&Key);
			}
			void* ptr2 = TMap<K, V>.ValueProcessor.GetElementPtr(ref Value, ref flag2);
			if (ptr2 == null)
			{
				ptr2 = (void*)(&Value);
			}
			FCScriptMapHelperWrapper.Add(this._NativePtr, ptr, ptr2);
			if (flag)
			{
				TMap<K, V>.KeyProcessor.DeleteElementPtr(ptr);
			}
			if (flag2)
			{
				TMap<K, V>.ValueProcessor.DeleteElementPtr(ptr2);
			}
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0000FC16 File Offset: 0x0000DE16
		public bool ContainsKey(K Key)
		{
			return this.Contains(Key);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0000FC20 File Offset: 0x0000DE20
		public unsafe bool Remove(K Key)
		{
			bool flag = false;
			void* ptr = TMap<K, V>.KeyProcessor.GetElementPtr(ref Key, ref flag);
			if (ptr == null)
			{
				ptr = (void*)(&Key);
			}
			bool result = FCScriptMapHelperWrapper.Remove(this._NativePtr, ptr);
			if (flag)
			{
				TMap<K, V>.KeyProcessor.DeleteElementPtr(ptr);
			}
			return result;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0000FC64 File Offset: 0x0000DE64
		[NullableContext(2)]
		public unsafe K GetKey(int Index)
		{
			void* keyPtr = FCScriptMapHelperWrapper.GetKeyPtr(this._NativePtr, Index);
			if (keyPtr == null)
			{
				return default(K);
			}
			return TMap<K, V>.KeyProcessor.Get(keyPtr, 0);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0000FC9C File Offset: 0x0000DE9C
		[NullableContext(2)]
		public unsafe V GetValue(int Index)
		{
			void* valuePtr = FCScriptMapHelperWrapper.GetValuePtr(this._NativePtr, Index);
			if (valuePtr == null)
			{
				return default(V);
			}
			return TMap<K, V>.ValueProcessor.Get(valuePtr, 0);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0000FCD4 File Offset: 0x0000DED4
		[NullableContext(0)]
		private unsafe void* FindValue([Nullable(1)] K Key)
		{
			ArgumentNullException.ThrowIfNull(Key, "Key");
			bool flag = false;
			void* ptr = TMap<K, V>.KeyProcessor.GetElementPtr(ref Key, ref flag);
			if (ptr == null)
			{
				ptr = (void*)(&Key);
			}
			void* result = FCScriptMapHelperWrapper.FindValue(this._NativePtr, ptr);
			if (flag)
			{
				TMap<K, V>.KeyProcessor.DeleteElementPtr(ptr);
			}
			return result;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0000FD28 File Offset: 0x0000DF28
		[return: Nullable(2)]
		public unsafe V Get(K Key)
		{
			void* ptr = this.FindValue(Key);
			if (ptr == null)
			{
				throw new KeyNotFoundException(Key.ToString());
			}
			return TMap<K, V>.ValueProcessor.Get(ptr, 0);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0000FD64 File Offset: 0x0000DF64
		public unsafe bool TryGetValue(K Key, [MaybeNullWhen(false)] out V Value)
		{
			void* ptr = this.FindValue(Key);
			if (ptr == null)
			{
				Value = default(V);
				return false;
			}
			Value = TMap<K, V>.ValueProcessor.Get(ptr, 0);
			return true;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0000FD9C File Offset: 0x0000DF9C
		[return: Nullable(2)]
		public V GetValueOrDefault(K Key)
		{
			V result;
			if (!this.TryGetValue(Key, out result))
			{
				return default(V);
			}
			return result;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0000FDBF File Offset: 0x0000DFBF
		public bool Contains(K Key)
		{
			return this.FindValue(Key) != null;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0000FDCF File Offset: 0x0000DFCF
		public int Num()
		{
			return FCScriptMapHelperWrapper.Num(this._NativePtr);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0000FDDC File Offset: 0x0000DFDC
		public int GetMaxIndex()
		{
			return FCScriptMapHelperWrapper.GetMaxIndex(this._NativePtr);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0000FDE9 File Offset: 0x0000DFE9
		public bool IsValidIndex(int Index)
		{
			return FCScriptMapHelperWrapper.IsValidIndex(this._NativePtr, Index);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0000FDF7 File Offset: 0x0000DFF7
		public void Empty(int Slack = 0)
		{
			FCScriptMapHelperWrapper.Empty(this._NativePtr, Slack);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0000FE06 File Offset: 0x0000E006
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			FCScriptMapHelperWrapper.CopyTo(DestPtr, base.NativePtr);
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0000FE14 File Offset: 0x0000E014
		[NullableContext(0)]
		public TMap<K, V>.Enumerator GetEnumerator()
		{
			return new TMap<K, V>.Enumerator(this);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0000FE1C File Offset: 0x0000E01C
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		IEnumerator<KeyValuePair<K, V>> IEnumerable<KeyValuePair<!0, !1>>.GetEnumerator()
		{
			return new TMap<K, V>.Enumerator(this);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0000FE29 File Offset: 0x0000E029
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new TMap<K, V>.Enumerator(this);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0000FE36 File Offset: 0x0000E036
		public void Add([Nullable(new byte[]
		{
			0,
			1,
			1
		})] KeyValuePair<K, V> Item)
		{
			this.Add(Item.Key, Item.Value);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0000FE4C File Offset: 0x0000E04C
		public void Clear()
		{
			this.Empty(0);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0000FE58 File Offset: 0x0000E058
		public bool Contains([Nullable(new byte[]
		{
			0,
			1,
			1
		})] KeyValuePair<K, V> Item)
		{
			V x;
			return this.TryGetValue(Item.Key, out x) && EqualityComparer<V>.Default.Equals(x, Item.Value);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0000FE8C File Offset: 0x0000E08C
		public unsafe void CopyTo([Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})] KeyValuePair<K, V>[] Array, int ArrayIndex)
		{
			ArgumentNullException.ThrowIfNull(Array, "Array");
			if (ArrayIndex < 0 || ArrayIndex > Array.Length)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
				defaultInterpolatedStringHandler.AppendLiteral("index ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(ArrayIndex);
				defaultInterpolatedStringHandler.AppendLiteral(" is out of range");
				throw new ArgumentOutOfRangeException(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			if (Array.Length - ArrayIndex < this.Num())
			{
				throw new ArgumentException("Destination array is not long enough. Check array index and length.");
			}
			int maxIndex = this.GetMaxIndex();
			for (int i = 0; i < maxIndex; i++)
			{
				if (this.IsValidIndex(i))
				{
					void* keyPtr = FCScriptMapHelperWrapper.GetKeyPtr(this._NativePtr, i);
					void* valuePtr = FCScriptMapHelperWrapper.GetValuePtr(this._NativePtr, i);
					Array[ArrayIndex++] = new KeyValuePair<K, V>((keyPtr != null) ? TMap<K, V>.KeyProcessor.Get(keyPtr, 0) : default(K), (valuePtr != null) ? TMap<K, V>.ValueProcessor.Get(valuePtr, 0) : default(V));
				}
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0000FF84 File Offset: 0x0000E184
		public bool Remove([Nullable(new byte[]
		{
			0,
			1,
			1
		})] KeyValuePair<K, V> Item)
		{
			V x;
			return this.TryGetValue(Item.Key, out x) && EqualityComparer<V>.Default.Equals(x, Item.Value) && this.Remove(Item.Key);
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0000FFC5 File Offset: 0x0000E1C5
		public int Count
		{
			get
			{
				return this.Num();
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0000FFCD File Offset: 0x0000E1CD
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0000FFD0 File Offset: 0x0000E1D0
		[Nullable(0)]
		public TMap<K, V>.KeyCollection Keys
		{
			[NullableContext(0)]
			get
			{
				return new TMap<K, V>.KeyCollection(this);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		ICollection<K> IDictionary<!0, !1>.Keys
		{
			get
			{
				return new TMap<K, V>.KeyCollection(this);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0000FFE5 File Offset: 0x0000E1E5
		[Nullable(0)]
		public TMap<K, V>.ValueCollection Values
		{
			[NullableContext(0)]
			get
			{
				return new TMap<K, V>.ValueCollection(this);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0000FFED File Offset: 0x0000E1ED
		ICollection<V> IDictionary<!0, !1>.Values
		{
			get
			{
				return new TMap<K, V>.ValueCollection(this);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0000FFFA File Offset: 0x0000E1FA
		IEnumerable<K> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x00010007 File Offset: 0x0000E207
		IEnumerable<V> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x04000142 RID: 322
		private static readonly NativeArrayProcessorBase<K> KeyProcessor = NativeArrayProcessorFactory<K>.HashProcessor;

		// Token: 0x04000143 RID: 323
		private static readonly UnrealReflectionPropertyTypeCode KeyInnerPropertyTypeCode = UnrealReflectionPropertyType.GetTypeCode(typeof(K));

		// Token: 0x04000144 RID: 324
		private static readonly NativeArrayProcessorBase<V> ValueProcessor = NativeArrayProcessorFactory<V>.Processor;

		// Token: 0x04000145 RID: 325
		private static readonly UnrealReflectionPropertyTypeCode ValueInnerPropertyTypeCode = UnrealReflectionPropertyType.GetTypeCode(typeof(V));

		// Token: 0x020008CF RID: 2255
		[Nullable(0)]
		public struct Enumerator : IEnumerator<KeyValuePair<K, V>>, IEnumerator, IDisposable
		{
			// Token: 0x0600BEB6 RID: 48822 RVA: 0x001307DD File Offset: 0x0012E9DD
			public Enumerator(TMap<K, V> Map)
			{
				this.<Map>P = Map;
				this._Index = 0;
				this._Current = default(KeyValuePair<K, V>);
				this._MaxIndex = this.<Map>P.GetMaxIndex();
			}

			// Token: 0x0600BEB7 RID: 48823 RVA: 0x0013080C File Offset: 0x0012EA0C
			public unsafe bool MoveNext()
			{
				while (this._Index < this._MaxIndex && !this.<Map>P.IsValidIndex(this._Index))
				{
					this._Index++;
				}
				int index = this._Index;
				this._Index = index + 1;
				int num = index;
				if (num < this._MaxIndex)
				{
					void* keyPtr = FCScriptMapHelperWrapper.GetKeyPtr(this.<Map>P._NativePtr, num);
					void* valuePtr = FCScriptMapHelperWrapper.GetValuePtr(this.<Map>P._NativePtr, num);
					this._Current = new KeyValuePair<K, V>((keyPtr != null) ? TMap<K, V>.KeyProcessor.Get(keyPtr, 0) : default(K), (valuePtr != null) ? TMap<K, V>.ValueProcessor.Get(valuePtr, 0) : default(V));
					return true;
				}
				return false;
			}

			// Token: 0x0600BEB8 RID: 48824 RVA: 0x001308D1 File Offset: 0x0012EAD1
			public void Reset()
			{
				this._Index = 0;
				this._Current = default(KeyValuePair<K, V>);
			}

			// Token: 0x17002339 RID: 9017
			// (get) Token: 0x0600BEB9 RID: 48825 RVA: 0x001308E6 File Offset: 0x0012EAE6
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			public KeyValuePair<K, V> Current
			{
				[return: Nullable(new byte[]
				{
					0,
					1,
					1
				})]
				get
				{
					return this._Current;
				}
			}

			// Token: 0x1700233A RID: 9018
			// (get) Token: 0x0600BEBA RID: 48826 RVA: 0x001308EE File Offset: 0x0012EAEE
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			KeyValuePair<K, V> IEnumerator<KeyValuePair<!0, !1>>.Current
			{
				[return: Nullable(new byte[]
				{
					0,
					1,
					1
				})]
				get
				{
					return this._Current;
				}
			}

			// Token: 0x1700233B RID: 9019
			// (get) Token: 0x0600BEBB RID: 48827 RVA: 0x001308F6 File Offset: 0x0012EAF6
			object IEnumerator.Current
			{
				get
				{
					return this._Current;
				}
			}

			// Token: 0x0600BEBC RID: 48828 RVA: 0x00130903 File Offset: 0x0012EB03
			public void Dispose()
			{
			}

			// Token: 0x04005784 RID: 22404
			[CompilerGenerated]
			private TMap<K, V> <Map>P;

			// Token: 0x04005785 RID: 22405
			private int _Index;

			// Token: 0x04005786 RID: 22406
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			private KeyValuePair<K, V> _Current;

			// Token: 0x04005787 RID: 22407
			private int _MaxIndex;
		}

		// Token: 0x020008D0 RID: 2256
		[Nullable(0)]
		public struct KeyCollection : ICollection<K>, IEnumerable<!0>, IEnumerable, IReadOnlyCollection<K>
		{
			// Token: 0x0600BEBD RID: 48829 RVA: 0x00130905 File Offset: 0x0012EB05
			public KeyCollection(TMap<K, V> Map)
			{
				this.<Map>P = Map;
			}

			// Token: 0x0600BEBE RID: 48830 RVA: 0x0013090E File Offset: 0x0012EB0E
			[NullableContext(0)]
			public TMap<K, V>.KeyCollection.Enumerator GetEnumerator()
			{
				return new TMap<K, V>.KeyCollection.Enumerator(this.<Map>P);
			}

			// Token: 0x0600BEBF RID: 48831 RVA: 0x0013091C File Offset: 0x0012EB1C
			public unsafe void CopyTo(K[] Array, int ArrayIndex)
			{
				ArgumentNullException.ThrowIfNull(Array, "Array");
				if (ArrayIndex < 0 || ArrayIndex > Array.Length)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
					defaultInterpolatedStringHandler.AppendLiteral("index ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(ArrayIndex);
					defaultInterpolatedStringHandler.AppendLiteral(" is out of range");
					throw new ArgumentOutOfRangeException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				if (Array.Length - ArrayIndex < this.<Map>P.Num())
				{
					throw new ArgumentException("Destination array is not long enough. Check array index and length.");
				}
				int maxIndex = this.<Map>P.GetMaxIndex();
				for (int i = 0; i < maxIndex; i++)
				{
					if (this.<Map>P.IsValidIndex(i))
					{
						void* keyPtr = FCScriptMapHelperWrapper.GetKeyPtr(this.<Map>P._NativePtr, i);
						Array[ArrayIndex++] = ((keyPtr != null) ? TMap<K, V>.KeyProcessor.Get(keyPtr, 0) : default(K));
					}
				}
			}

			// Token: 0x1700233C RID: 9020
			// (get) Token: 0x0600BEC0 RID: 48832 RVA: 0x001309F3 File Offset: 0x0012EBF3
			public int Count
			{
				get
				{
					return this.<Map>P.Num();
				}
			}

			// Token: 0x1700233D RID: 9021
			// (get) Token: 0x0600BEC1 RID: 48833 RVA: 0x00130A00 File Offset: 0x0012EC00
			bool ICollection<!0>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x0600BEC2 RID: 48834 RVA: 0x00130A03 File Offset: 0x0012EC03
			void ICollection<!0>.Add(K item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600BEC3 RID: 48835 RVA: 0x00130A0A File Offset: 0x0012EC0A
			void ICollection<!0>.Clear()
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600BEC4 RID: 48836 RVA: 0x00130A11 File Offset: 0x0012EC11
			public bool Contains(K item)
			{
				return this.<Map>P.ContainsKey(item);
			}

			// Token: 0x0600BEC5 RID: 48837 RVA: 0x00130A1F File Offset: 0x0012EC1F
			bool ICollection<!0>.Remove(K item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600BEC6 RID: 48838 RVA: 0x00130A26 File Offset: 0x0012EC26
			IEnumerator<K> IEnumerable<!0>.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0600BEC7 RID: 48839 RVA: 0x00130A33 File Offset: 0x0012EC33
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04005788 RID: 22408
			[CompilerGenerated]
			private TMap<K, V> <Map>P;

			// Token: 0x0200141A RID: 5146
			[Nullable(0)]
			public struct Enumerator : IEnumerator<!0>, IEnumerator, IDisposable
			{
				// Token: 0x0600BF43 RID: 48963 RVA: 0x00130CF2 File Offset: 0x0012EEF2
				public Enumerator(TMap<K, V> Map)
				{
					this.<Map>P = Map;
					this._Index = 0;
					this._CurrentKey = default(K);
					this._MaxIndex = this.<Map>P.GetMaxIndex();
				}

				// Token: 0x0600BF44 RID: 48964 RVA: 0x00130D1F File Offset: 0x0012EF1F
				public void Dispose()
				{
				}

				// Token: 0x0600BF45 RID: 48965 RVA: 0x00130D24 File Offset: 0x0012EF24
				public unsafe bool MoveNext()
				{
					while (this._Index < this._MaxIndex && !this.<Map>P.IsValidIndex(this._Index))
					{
						this._Index++;
					}
					int index = this._Index;
					this._Index = index + 1;
					int num = index;
					if (num < this._MaxIndex)
					{
						void* keyPtr = FCScriptMapHelperWrapper.GetKeyPtr(this.<Map>P._NativePtr, num);
						this._CurrentKey = ((keyPtr != null) ? TMap<K, V>.KeyProcessor.Get(keyPtr, 0) : default(K));
						return true;
					}
					return false;
				}

				// Token: 0x17002343 RID: 9027
				// (get) Token: 0x0600BF46 RID: 48966 RVA: 0x00130DB4 File Offset: 0x0012EFB4
				public readonly K Current
				{
					get
					{
						return this._CurrentKey;
					}
				}

				// Token: 0x17002344 RID: 9028
				// (get) Token: 0x0600BF47 RID: 48967 RVA: 0x00130DBC File Offset: 0x0012EFBC
				[Nullable(2)]
				object IEnumerator.Current
				{
					[NullableContext(2)]
					get
					{
						return this._CurrentKey;
					}
				}

				// Token: 0x0600BF48 RID: 48968 RVA: 0x00130DC9 File Offset: 0x0012EFC9
				void IEnumerator.Reset()
				{
					this._Index = 0;
					this._CurrentKey = default(K);
				}

				// Token: 0x040068C9 RID: 26825
				[CompilerGenerated]
				private TMap<K, V> <Map>P;

				// Token: 0x040068CA RID: 26826
				private int _Index;

				// Token: 0x040068CB RID: 26827
				[Nullable(2)]
				private K _CurrentKey;

				// Token: 0x040068CC RID: 26828
				private readonly int _MaxIndex;
			}
		}

		// Token: 0x020008D1 RID: 2257
		[Nullable(0)]
		public struct ValueCollection : ICollection<V>, IEnumerable<V>, IEnumerable, IReadOnlyCollection<V>
		{
			// Token: 0x0600BEC8 RID: 48840 RVA: 0x00130A40 File Offset: 0x0012EC40
			public ValueCollection(TMap<K, V> Map)
			{
				this.<Map>P = Map;
			}

			// Token: 0x0600BEC9 RID: 48841 RVA: 0x00130A49 File Offset: 0x0012EC49
			[NullableContext(0)]
			public TMap<K, V>.ValueCollection.Enumerator GetEnumerator()
			{
				return new TMap<K, V>.ValueCollection.Enumerator(this.<Map>P);
			}

			// Token: 0x0600BECA RID: 48842 RVA: 0x00130A58 File Offset: 0x0012EC58
			public unsafe void CopyTo(V[] Array, int ArrayIndex)
			{
				ArgumentNullException.ThrowIfNull(Array, "Array");
				if (ArrayIndex < 0 || ArrayIndex > Array.Length)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
					defaultInterpolatedStringHandler.AppendLiteral("index ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(ArrayIndex);
					defaultInterpolatedStringHandler.AppendLiteral(" is out of range");
					throw new ArgumentOutOfRangeException(defaultInterpolatedStringHandler.ToStringAndClear());
				}
				if (Array.Length - ArrayIndex < this.<Map>P.Num())
				{
					throw new ArgumentException("Destination array is not long enough. Check array index and length.");
				}
				int maxIndex = this.<Map>P.GetMaxIndex();
				for (int i = 0; i < maxIndex; i++)
				{
					if (this.<Map>P.IsValidIndex(i))
					{
						void* valuePtr = FCScriptMapHelperWrapper.GetValuePtr(this.<Map>P._NativePtr, i);
						Array[ArrayIndex++] = ((valuePtr != null) ? TMap<K, V>.ValueProcessor.Get(valuePtr, 0) : default(V));
					}
				}
			}

			// Token: 0x1700233E RID: 9022
			// (get) Token: 0x0600BECB RID: 48843 RVA: 0x00130B2F File Offset: 0x0012ED2F
			public int Count
			{
				get
				{
					return this.<Map>P.Num();
				}
			}

			// Token: 0x1700233F RID: 9023
			// (get) Token: 0x0600BECC RID: 48844 RVA: 0x00130B3C File Offset: 0x0012ED3C
			bool ICollection<!1>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x0600BECD RID: 48845 RVA: 0x00130B3F File Offset: 0x0012ED3F
			void ICollection<!1>.Add(V item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600BECE RID: 48846 RVA: 0x00130B46 File Offset: 0x0012ED46
			void ICollection<!1>.Clear()
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600BECF RID: 48847 RVA: 0x00130B4D File Offset: 0x0012ED4D
			public bool Contains(V item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600BED0 RID: 48848 RVA: 0x00130B54 File Offset: 0x0012ED54
			bool ICollection<!1>.Remove(V item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x0600BED1 RID: 48849 RVA: 0x00130B5B File Offset: 0x0012ED5B
			IEnumerator<V> IEnumerable<!1>.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0600BED2 RID: 48850 RVA: 0x00130B68 File Offset: 0x0012ED68
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04005789 RID: 22409
			[CompilerGenerated]
			private TMap<K, V> <Map>P;

			// Token: 0x0200141B RID: 5147
			[Nullable(0)]
			public struct Enumerator : IEnumerator<V>, IEnumerator, IDisposable
			{
				// Token: 0x0600BF49 RID: 48969 RVA: 0x00130DDE File Offset: 0x0012EFDE
				public Enumerator(TMap<K, V> Map)
				{
					this.<Map>P = Map;
					this._Index = 0;
					this._CurrentValue = default(V);
					this._MaxIndex = this.<Map>P.GetMaxIndex();
				}

				// Token: 0x0600BF4A RID: 48970 RVA: 0x00130E0B File Offset: 0x0012F00B
				public void Dispose()
				{
				}

				// Token: 0x0600BF4B RID: 48971 RVA: 0x00130E10 File Offset: 0x0012F010
				public unsafe bool MoveNext()
				{
					while (this._Index < this._MaxIndex && !this.<Map>P.IsValidIndex(this._Index))
					{
						this._Index++;
					}
					int index = this._Index;
					this._Index = index + 1;
					int num = index;
					if (num < this._MaxIndex)
					{
						void* valuePtr = FCScriptMapHelperWrapper.GetValuePtr(this.<Map>P._NativePtr, num);
						this._CurrentValue = ((valuePtr != null) ? TMap<K, V>.ValueProcessor.Get(valuePtr, 0) : default(V));
						return true;
					}
					return false;
				}

				// Token: 0x17002345 RID: 9029
				// (get) Token: 0x0600BF4C RID: 48972 RVA: 0x00130EA0 File Offset: 0x0012F0A0
				public readonly V Current
				{
					get
					{
						return this._CurrentValue;
					}
				}

				// Token: 0x17002346 RID: 9030
				// (get) Token: 0x0600BF4D RID: 48973 RVA: 0x00130EA8 File Offset: 0x0012F0A8
				[Nullable(2)]
				object IEnumerator.Current
				{
					[NullableContext(2)]
					get
					{
						return this._CurrentValue;
					}
				}

				// Token: 0x0600BF4E RID: 48974 RVA: 0x00130EB5 File Offset: 0x0012F0B5
				void IEnumerator.Reset()
				{
					this._Index = 0;
					this._CurrentValue = default(V);
				}

				// Token: 0x040068CD RID: 26829
				[CompilerGenerated]
				private TMap<K, V> <Map>P;

				// Token: 0x040068CE RID: 26830
				private int _Index;

				// Token: 0x040068CF RID: 26831
				[Nullable(2)]
				private V _CurrentValue;

				// Token: 0x040068D0 RID: 26832
				private readonly int _MaxIndex;
			}
		}
	}
}
