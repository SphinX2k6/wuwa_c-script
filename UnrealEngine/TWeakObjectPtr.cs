using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000096 RID: 150
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.WeakObject, PropertiesSize = 8)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct TWeakObjectPtr<[Nullable(0)] T> : IEqualityOperators<TWeakObjectPtr<T>, TWeakObjectPtr<T>, bool>, IEquatable<TWeakObjectPtr<T>> where T : UnrealUObject
	{
		// Token: 0x06001036 RID: 4150 RVA: 0x00018699 File Offset: 0x00016899
		public TWeakObjectPtr(in FWeakObjectPtr WeakObjectPtr)
		{
			this._WeakObjectPtr = WeakObjectPtr;
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x000186A7 File Offset: 0x000168A7
		public TWeakObjectPtr(T TargetObject)
		{
			this._WeakObjectPtr = new FWeakObjectPtr(TargetObject);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x000186BA File Offset: 0x000168BA
		public TWeakObjectPtr(UClassStackOnlyPtr ClassPtr)
		{
			this._WeakObjectPtr = new FWeakObjectPtr(ClassPtr);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x000186C8 File Offset: 0x000168C8
		public TWeakObjectPtr(int ObjectIndex, int ObjectSerialNumber)
		{
			this._WeakObjectPtr = new FWeakObjectPtr(ObjectIndex, ObjectSerialNumber);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x000186D7 File Offset: 0x000168D7
		public void Reset()
		{
			this._WeakObjectPtr.Reset();
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x000186E4 File Offset: 0x000168E4
		public readonly bool IsValid(bool bEvenIfPendingKill = false, bool bThreadsafeTest = false)
		{
			return this._WeakObjectPtr.IsValid(bEvenIfPendingKill, bThreadsafeTest);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x000186F3 File Offset: 0x000168F3
		public readonly T Get()
		{
			return BuiltinUtils.GetOrCreateUObjectByIndexAndSerialNumber<T>(this._WeakObjectPtr.ObjectIndex, this._WeakObjectPtr.ObjectSerialNumber);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00018710 File Offset: 0x00016910
		[NullableContext(1)]
		public readonly string GetName()
		{
			return this._WeakObjectPtr.GetName();
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0001871D File Offset: 0x0001691D
		public readonly FName GetFName()
		{
			return this._WeakObjectPtr.GetFName();
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0001872A File Offset: 0x0001692A
		public static implicit operator T([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<T> weak)
		{
			return weak.Get();
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00018733 File Offset: 0x00016933
		public readonly bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<T> other)
		{
			return this._WeakObjectPtr.Equals(other._WeakObjectPtr);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00018748 File Offset: 0x00016948
		public override readonly bool Equals(object obj)
		{
			if (obj is TWeakObjectPtr<T>)
			{
				TWeakObjectPtr<T> other = (TWeakObjectPtr<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0001876D File Offset: 0x0001696D
		public override readonly int GetHashCode()
		{
			return this._WeakObjectPtr.GetHashCode();
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00018780 File Offset: 0x00016980
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<T> right)
		{
			return left._WeakObjectPtr == right._WeakObjectPtr;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00018793 File Offset: 0x00016993
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<T> right)
		{
			return left._WeakObjectPtr != right._WeakObjectPtr;
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x000187A6 File Offset: 0x000169A6
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TWeakObjectPtr<T>(in FWeakObjectPtr weakObjectPtr)
		{
			return new TWeakObjectPtr<T>(ref weakObjectPtr);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x000187AE File Offset: 0x000169AE
		public static implicit operator FWeakObjectPtr([Nullable(new byte[]
		{
			0,
			1
		})] in TWeakObjectPtr<T> weakObjectPtr)
		{
			return weakObjectPtr._WeakObjectPtr;
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x000187B6 File Offset: 0x000169B6
		[NullableContext(1)]
		public override readonly string ToString()
		{
			return this._WeakObjectPtr.ToString();
		}

		// Token: 0x040001FC RID: 508
		internal FWeakObjectPtr _WeakObjectPtr;
	}
}
