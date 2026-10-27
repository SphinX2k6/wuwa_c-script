using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000074 RID: 116
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class TMap<K, [Nullable(2)] V> : UnrealProxyObject, IDictionary<K, V>, ICollection<KeyValuePair<K, V>>, IEnumerable<KeyValuePair<K, V>>, IEnumerable, IReadOnlyDictionary<K, V>, IReadOnlyCollection<KeyValuePair<K, V>>
	{
		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x00014CEC File Offset: 0x00012EEC
		public IntPtr NativeMapPtr
		{
			get
			{
				return base.NativePtr.Map;
			}
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00014CF9 File Offset: 0x00012EF9
		public TMap()
		{
			FCScriptMapHelperWrapper.AllocNativeScriptMap(base.NativePtr);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00014D0C File Offset: 0x00012F0C
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

		// Token: 0x06000E24 RID: 3620 RVA: 0x00014D71 File Offset: 0x00012F71
		public TMap(IntPtr NativeScriptMapPtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativeScriptMapPtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00014D7C File Offset: 0x00012F7C
		protected override IntPtr AllocNativePtr()
		{
			NativeArrayProcessorFactory.AddRef(TMap<K, V>.KeyProcessor);
			NativeArrayProcessorFactory.AddRef(TMap<K, V>.ValueProcessor);
			IntPtr keyInnerUStructPtr = TMap<K, V>.KeyProcessor.IsStructProxyProcessor ? ((IScriptStructProcessor)TMap<K, V>.KeyProcessor).GetNativeScriptStructPtr().ScriptStructPtr : IntPtr.Zero;
			IntPtr valueInnerUStructPtr = TMap<K, V>.ValueProcessor.IsStructProxyProcessor ? ((IScriptStructProcessor)TMap<K, V>.ValueProcessor).GetNativeScriptStructPtr().ScriptStructPtr : IntPtr.Zero;
			return FCScriptMapHelperWrapper.AllocNativeMemory(TMap<K, V>.KeyInnerPropertyTypeCode, keyInnerUStructPtr, TMap<K, V>.KeyProcessor.Size, TMap<K, V>.KeyProcessor.MinAlignment, TMap<K, V>.ValueInnerPropertyTypeCode, valueInnerUStructPtr, TMap<K, V>.ValueProcessor.Size, TMap<K, V>.ValueProcessor.MinAlignment);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00014E26 File Offset: 0x00013026
		protected override void DeallocNativePtr()
		{
			this.Empty(0);
			FCScriptMapHelperWrapper.DeallocNativeMemory(this._NativePtr);
			NativeArrayProcessorFactory.DecRef(TMap<K, V>.KeyProcessor);
			NativeArrayProcessorFactory.DecRef(TMap<K, V>.ValueProcessor);
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x00014E4E File Offset: 0x0001304E
		public override bool AllowMoveAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00014E51 File Offset: 0x00013051
		public override void MoveAssign(IntPtr Src)
		{
			if (Src == 0)
			{
				this.Empty(0);
				return;
			}
			FCScriptMapHelperWrapper.MoveAssign(this._NativePtr, Src);
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x00014E6A File Offset: 0x0001306A
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00014E6D File Offset: 0x0001306D
		public override void CopyAssign(IntPtr Src)
		{
			if (Src == 0)
			{
				this.Empty(0);
				return;
			}
			FCScriptMapHelperWrapper.CopyAssign(this._NativePtr, Src);
		}

		// Token: 0x170004A9 RID: 1193
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

		// Token: 0x06000E2D RID: 3629 RVA: 0x00014E9C File Offset: 0x0001309C
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

		// Token: 0x06000E2E RID: 3630 RVA: 0x00014F16 File Offset: 0x00013116
		public bool ContainsKey(K Key)
		{
			return this.Contains(Key);
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00014F20 File Offset: 0x00013120
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

		// Token: 0x06000E30 RID: 3632 RVA: 0x00014F64 File Offset: 0x00013164
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

		// Token: 0x06000E31 RID: 3633 RVA: 0x00014F9C File Offset: 0x0001319C
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

		// Token: 0x06000E32 RID: 3634 RVA: 0x00014FD4 File Offset: 0x000131D4
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

		// Token: 0x06000E33 RID: 3635 RVA: 0x00015028 File Offset: 0x00013228
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

		// Token: 0x06000E34 RID: 3636 RVA: 0x00015064 File Offset: 0x00013264
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

		// Token: 0x06000E35 RID: 3637 RVA: 0x0001509C File Offset: 0x0001329C
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

		// Token: 0x06000E36 RID: 3638 RVA: 0x000150BF File Offset: 0x000132BF
		public bool Contains(K Key)
		{
			return this.FindValue(Key) != null;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x000150CF File Offset: 0x000132CF
		public int Num()
		{
			return FCScriptMapHelperWrapper.Num(this._NativePtr);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x000150DC File Offset: 0x000132DC
		public int GetMaxIndex()
		{
			return FCScriptMapHelperWrapper.GetMaxIndex(this._NativePtr);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x000150E9 File Offset: 0x000132E9
		public bool IsValidIndex(int Index)
		{
			return FCScriptMapHelperWrapper.IsValidIndex(this._NativePtr, Index);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x000150F7 File Offset: 0x000132F7
		public void Empty(int Slack = 0)
		{
			FCScriptMapHelperWrapper.Empty(this._NativePtr, Slack);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00015106 File Offset: 0x00013306
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			FCScriptMapHelperWrapper.CopyTo(DestPtr, base.NativePtr);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00015114 File Offset: 0x00013314
		[return: Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
		{
			return new TMap<K, V>.Enumerator(this);
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00015121 File Offset: 0x00013321
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new TMap<K, V>.Enumerator(this);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x0001512E File Offset: 0x0001332E
		public void Add([Nullable(new byte[]
		{
			0,
			1,
			1
		})] KeyValuePair<K, V> Item)
		{
			this.Add(Item.Key, Item.Value);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00015144 File Offset: 0x00013344
		public void Clear()
		{
			this.Empty(0);
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00015150 File Offset: 0x00013350
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

		// Token: 0x06000E41 RID: 3649 RVA: 0x00015184 File Offset: 0x00013384
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

		// Token: 0x06000E42 RID: 3650 RVA: 0x0001527C File Offset: 0x0001347C
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

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000E43 RID: 3651 RVA: 0x000152BD File Offset: 0x000134BD
		public int Count
		{
			get
			{
				return this.Num();
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x000152C5 File Offset: 0x000134C5
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000E45 RID: 3653 RVA: 0x000152C8 File Offset: 0x000134C8
		[Nullable(0)]
		public TMap<K, V>.KeyCollection Keys
		{
			[NullableContext(0)]
			get
			{
				return new TMap<K, V>.KeyCollection(this);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x000152D0 File Offset: 0x000134D0
		ICollection<K> IDictionary<!0, !1>.Keys
		{
			get
			{
				return new TMap<K, V>.KeyCollection(this);
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x000152DD File Offset: 0x000134DD
		[Nullable(0)]
		public TMap<K, V>.ValueCollection Values
		{
			[NullableContext(0)]
			get
			{
				return new TMap<K, V>.ValueCollection(this);
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x000152E5 File Offset: 0x000134E5
		ICollection<V> IDictionary<!0, !1>.Values
		{
			get
			{
				return new TMap<K, V>.ValueCollection(this);
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x000152F2 File Offset: 0x000134F2
		IEnumerable<K> IReadOnlyDictionary<!0, !1>.Keys
		{
			get
			{
				return this.Keys;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x000152FF File Offset: 0x000134FF
		IEnumerable<V> IReadOnlyDictionary<!0, !1>.Values
		{
			get
			{
				return this.Values;
			}
		}

		// Token: 0x04000189 RID: 393
		private static readonly NativeArrayProcessorBase<K> KeyProcessor = NativeArrayProcessorFactory<K>.HashProcessor;

		// Token: 0x0400018A RID: 394
		private static readonly UnrealReflectionPropertyTypeCode KeyInnerPropertyTypeCode = UnrealReflectionPropertyType.GetTypeCode(typeof(K));

		// Token: 0x0400018B RID: 395
		private static readonly NativeArrayProcessorBase<V> ValueProcessor = NativeArrayProcessorFactory<V>.Processor;

		// Token: 0x0400018C RID: 396
		private static readonly UnrealReflectionPropertyTypeCode ValueInnerPropertyTypeCode = UnrealReflectionPropertyType.GetTypeCode(typeof(V));

		// Token: 0x02002B21 RID: 11041
		[Nullable(0)]
		public struct Enumerator : IEnumerator<KeyValuePair<K, V>>, IEnumerator, IDisposable
		{
			// Token: 0x060284FB RID: 165115 RVA: 0x003D5481 File Offset: 0x003D3681
			public Enumerator(TMap<K, V> Map)
			{
				this.<Map>P = Map;
				this._Index = 0;
				this._Current = default(KeyValuePair<K, V>);
				this._MaxIndex = this.<Map>P.GetMaxIndex();
			}

			// Token: 0x060284FC RID: 165116 RVA: 0x003D54B0 File Offset: 0x003D36B0
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

			// Token: 0x060284FD RID: 165117 RVA: 0x003D5575 File Offset: 0x003D3775
			public void Reset()
			{
				this._Index = 0;
				this._Current = default(KeyValuePair<K, V>);
			}

			// Token: 0x170099AE RID: 39342
			// (get) Token: 0x060284FE RID: 165118 RVA: 0x003D558A File Offset: 0x003D378A
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

			// Token: 0x170099AF RID: 39343
			// (get) Token: 0x060284FF RID: 165119 RVA: 0x003D5592 File Offset: 0x003D3792
			object IEnumerator.Current
			{
				get
				{
					return this._Current;
				}
			}

			// Token: 0x06028500 RID: 165120 RVA: 0x003D559F File Offset: 0x003D379F
			public void Dispose()
			{
			}

			// Token: 0x0401636E RID: 90990
			[CompilerGenerated]
			private TMap<K, V> <Map>P;

			// Token: 0x0401636F RID: 90991
			private int _Index;

			// Token: 0x04016370 RID: 90992
			[Nullable(new byte[]
			{
				0,
				1,
				1
			})]
			private KeyValuePair<K, V> _Current;

			// Token: 0x04016371 RID: 90993
			private int _MaxIndex;
		}

		// Token: 0x02002B22 RID: 11042
		[Nullable(0)]
		public struct KeyCollection : ICollection<K>, IEnumerable<K>, IEnumerable, IReadOnlyCollection<K>
		{
			// Token: 0x06028501 RID: 165121 RVA: 0x003D55A1 File Offset: 0x003D37A1
			public KeyCollection(TMap<K, V> Map)
			{
				this.<Map>P = Map;
			}

			// Token: 0x06028502 RID: 165122 RVA: 0x003D55AA File Offset: 0x003D37AA
			[NullableContext(0)]
			public TMap<K, V>.KeyCollection.Enumerator GetEnumerator()
			{
				return new TMap<K, V>.KeyCollection.Enumerator(this.<Map>P);
			}

			// Token: 0x06028503 RID: 165123 RVA: 0x003D55B8 File Offset: 0x003D37B8
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

			// Token: 0x170099B0 RID: 39344
			// (get) Token: 0x06028504 RID: 165124 RVA: 0x003D568F File Offset: 0x003D388F
			public int Count
			{
				get
				{
					return this.<Map>P.Num();
				}
			}

			// Token: 0x170099B1 RID: 39345
			// (get) Token: 0x06028505 RID: 165125 RVA: 0x003D569C File Offset: 0x003D389C
			bool ICollection<!0>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06028506 RID: 165126 RVA: 0x003D569F File Offset: 0x003D389F
			void ICollection<!0>.Add(K item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06028507 RID: 165127 RVA: 0x003D56A6 File Offset: 0x003D38A6
			void ICollection<!0>.Clear()
			{
				throw new NotSupportedException();
			}

			// Token: 0x06028508 RID: 165128 RVA: 0x003D56AD File Offset: 0x003D38AD
			public bool Contains(K item)
			{
				return this.<Map>P.ContainsKey(item);
			}

			// Token: 0x06028509 RID: 165129 RVA: 0x003D56BB File Offset: 0x003D38BB
			bool ICollection<!0>.Remove(K item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x0602850A RID: 165130 RVA: 0x003D56C2 File Offset: 0x003D38C2
			IEnumerator<K> IEnumerable<!0>.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0602850B RID: 165131 RVA: 0x003D56CF File Offset: 0x003D38CF
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04016372 RID: 90994
			[CompilerGenerated]
			private TMap<K, V> <Map>P;

			// Token: 0x02003C11 RID: 15377
			[Nullable(0)]
			public struct Enumerator : IEnumerator<!0>, IEnumerator, IDisposable
			{
				// Token: 0x060285E2 RID: 165346 RVA: 0x003D5986 File Offset: 0x003D3B86
				public Enumerator(TMap<K, V> Map)
				{
					this.<Map>P = Map;
					this._Index = 0;
					this._CurrentKey = default(K);
					this._MaxIndex = this.<Map>P.GetMaxIndex();
				}

				// Token: 0x060285E3 RID: 165347 RVA: 0x003D59B3 File Offset: 0x003D3BB3
				public void Dispose()
				{
				}

				// Token: 0x060285E4 RID: 165348 RVA: 0x003D59B8 File Offset: 0x003D3BB8
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

				// Token: 0x170099B6 RID: 39350
				// (get) Token: 0x060285E5 RID: 165349 RVA: 0x003D5A48 File Offset: 0x003D3C48
				public readonly K Current
				{
					get
					{
						return this._CurrentKey;
					}
				}

				// Token: 0x170099B7 RID: 39351
				// (get) Token: 0x060285E6 RID: 165350 RVA: 0x003D5A50 File Offset: 0x003D3C50
				[Nullable(2)]
				object IEnumerator.Current
				{
					[NullableContext(2)]
					get
					{
						return this._CurrentKey;
					}
				}

				// Token: 0x060285E7 RID: 165351 RVA: 0x003D5A5D File Offset: 0x003D3C5D
				void IEnumerator.Reset()
				{
					this._Index = 0;
					this._CurrentKey = default(K);
				}

				// Token: 0x04017E48 RID: 97864
				[CompilerGenerated]
				private TMap<K, V> <Map>P;

				// Token: 0x04017E49 RID: 97865
				private int _Index;

				// Token: 0x04017E4A RID: 97866
				[Nullable(2)]
				private K _CurrentKey;

				// Token: 0x04017E4B RID: 97867
				private readonly int _MaxIndex;
			}
		}

		// Token: 0x02002B23 RID: 11043
		[Nullable(0)]
		public struct ValueCollection : ICollection<V>, IEnumerable<V>, IEnumerable, IReadOnlyCollection<V>
		{
			// Token: 0x0602850C RID: 165132 RVA: 0x003D56DC File Offset: 0x003D38DC
			public ValueCollection(TMap<K, V> Map)
			{
				this.<Map>P = Map;
			}

			// Token: 0x0602850D RID: 165133 RVA: 0x003D56E5 File Offset: 0x003D38E5
			[NullableContext(0)]
			public TMap<K, V>.ValueCollection.Enumerator GetEnumerator()
			{
				return new TMap<K, V>.ValueCollection.Enumerator(this.<Map>P);
			}

			// Token: 0x0602850E RID: 165134 RVA: 0x003D56F4 File Offset: 0x003D38F4
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

			// Token: 0x170099B2 RID: 39346
			// (get) Token: 0x0602850F RID: 165135 RVA: 0x003D57CB File Offset: 0x003D39CB
			public int Count
			{
				get
				{
					return this.<Map>P.Num();
				}
			}

			// Token: 0x170099B3 RID: 39347
			// (get) Token: 0x06028510 RID: 165136 RVA: 0x003D57D8 File Offset: 0x003D39D8
			bool ICollection<!1>.IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06028511 RID: 165137 RVA: 0x003D57DB File Offset: 0x003D39DB
			void ICollection<!1>.Add(V item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06028512 RID: 165138 RVA: 0x003D57E2 File Offset: 0x003D39E2
			void ICollection<!1>.Clear()
			{
				throw new NotSupportedException();
			}

			// Token: 0x06028513 RID: 165139 RVA: 0x003D57E9 File Offset: 0x003D39E9
			public bool Contains(V item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06028514 RID: 165140 RVA: 0x003D57F0 File Offset: 0x003D39F0
			bool ICollection<!1>.Remove(V item)
			{
				throw new NotSupportedException();
			}

			// Token: 0x06028515 RID: 165141 RVA: 0x003D57F7 File Offset: 0x003D39F7
			IEnumerator<V> IEnumerable<!1>.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x06028516 RID: 165142 RVA: 0x003D5804 File Offset: 0x003D3A04
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04016373 RID: 90995
			[CompilerGenerated]
			private TMap<K, V> <Map>P;

			// Token: 0x02003C12 RID: 15378
			[Nullable(0)]
			public struct Enumerator : IEnumerator<V>, IEnumerator, IDisposable
			{
				// Token: 0x060285E8 RID: 165352 RVA: 0x003D5A72 File Offset: 0x003D3C72
				public Enumerator(TMap<K, V> Map)
				{
					this.<Map>P = Map;
					this._Index = 0;
					this._CurrentValue = default(V);
					this._MaxIndex = this.<Map>P.GetMaxIndex();
				}

				// Token: 0x060285E9 RID: 165353 RVA: 0x003D5A9F File Offset: 0x003D3C9F
				public void Dispose()
				{
				}

				// Token: 0x060285EA RID: 165354 RVA: 0x003D5AA4 File Offset: 0x003D3CA4
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

				// Token: 0x170099B8 RID: 39352
				// (get) Token: 0x060285EB RID: 165355 RVA: 0x003D5B34 File Offset: 0x003D3D34
				public readonly V Current
				{
					get
					{
						return this._CurrentValue;
					}
				}

				// Token: 0x170099B9 RID: 39353
				// (get) Token: 0x060285EC RID: 165356 RVA: 0x003D5B3C File Offset: 0x003D3D3C
				[Nullable(2)]
				object IEnumerator.Current
				{
					[NullableContext(2)]
					get
					{
						return this._CurrentValue;
					}
				}

				// Token: 0x060285ED RID: 165357 RVA: 0x003D5B49 File Offset: 0x003D3D49
				void IEnumerator.Reset()
				{
					this._Index = 0;
					this._CurrentValue = default(V);
				}

				// Token: 0x04017E4C RID: 97868
				[CompilerGenerated]
				private TMap<K, V> <Map>P;

				// Token: 0x04017E4D RID: 97869
				private int _Index;

				// Token: 0x04017E4E RID: 97870
				[Nullable(2)]
				private V _CurrentValue;

				// Token: 0x04017E4F RID: 97871
				private readonly int _MaxIndex;
			}
		}
	}
}
