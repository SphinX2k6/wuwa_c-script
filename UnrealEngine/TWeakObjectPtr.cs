using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200007B RID: 123
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.WeakObject, PropertiesSize = 8)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct TWeakObjectPtr<[Nullable(0)] T> : IEqualityOperators<TWeakObjectPtr<T>, TWeakObjectPtr<T>, bool>, IEquatable<TWeakObjectPtr<T>> where T : UnrealUObject
	{
		// Token: 0x06000BC9 RID: 3017 RVA: 0x000133BD File Offset: 0x000115BD
		public TWeakObjectPtr(in FWeakObjectPtr WeakObjectPtr)
		{
			this._WeakObjectPtr = WeakObjectPtr;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000133CB File Offset: 0x000115CB
		public TWeakObjectPtr(T TargetObject)
		{
			this._WeakObjectPtr = new FWeakObjectPtr(TargetObject);
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x000133DE File Offset: 0x000115DE
		public TWeakObjectPtr(UClassStackOnlyPtr ClassPtr)
		{
			this._WeakObjectPtr = new FWeakObjectPtr(ClassPtr);
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x000133EC File Offset: 0x000115EC
		public TWeakObjectPtr(int ObjectIndex, int ObjectSerialNumber)
		{
			this._WeakObjectPtr = new FWeakObjectPtr(ObjectIndex, ObjectSerialNumber);
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x000133FB File Offset: 0x000115FB
		public void Reset()
		{
			this._WeakObjectPtr.Reset();
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x00013408 File Offset: 0x00011608
		public readonly bool IsValid(bool bEvenIfPendingKill = false, bool bThreadsafeTest = false)
		{
			return this._WeakObjectPtr.IsValid(bEvenIfPendingKill, bThreadsafeTest);
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00013417 File Offset: 0x00011617
		public readonly T Get()
		{
			return BuiltinUtils.GetOrCreateUObjectByIndexAndSerialNumber<T>(this._WeakObjectPtr.ObjectIndex, this._WeakObjectPtr.ObjectSerialNumber);
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00013434 File Offset: 0x00011634
		[NullableContext(1)]
		public readonly string GetName()
		{
			return this._WeakObjectPtr.GetName();
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00013441 File Offset: 0x00011641
		public readonly FName GetFName()
		{
			return this._WeakObjectPtr.GetFName();
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0001344E File Offset: 0x0001164E
		public static implicit operator T([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<T> weak)
		{
			return weak.Get();
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00013457 File Offset: 0x00011657
		public readonly bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<T> other)
		{
			return this._WeakObjectPtr.Equals(other._WeakObjectPtr);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0001346C File Offset: 0x0001166C
		public override readonly bool Equals(object obj)
		{
			if (obj is TWeakObjectPtr<T>)
			{
				TWeakObjectPtr<T> other = (TWeakObjectPtr<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00013491 File Offset: 0x00011691
		public override readonly int GetHashCode()
		{
			return this._WeakObjectPtr.GetHashCode();
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000134A4 File Offset: 0x000116A4
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

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000134B7 File Offset: 0x000116B7
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

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000134CA File Offset: 0x000116CA
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TWeakObjectPtr<T>(in FWeakObjectPtr weakObjectPtr)
		{
			return new TWeakObjectPtr<T>(ref weakObjectPtr);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x000134D2 File Offset: 0x000116D2
		public static implicit operator FWeakObjectPtr([Nullable(new byte[]
		{
			0,
			1
		})] in TWeakObjectPtr<T> weakObjectPtr)
		{
			return weakObjectPtr._WeakObjectPtr;
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000134DA File Offset: 0x000116DA
		[NullableContext(1)]
		public override readonly string ToString()
		{
			return this._WeakObjectPtr.ToString();
		}

		// Token: 0x040001B5 RID: 437
		internal FWeakObjectPtr _WeakObjectPtr;
	}
}
