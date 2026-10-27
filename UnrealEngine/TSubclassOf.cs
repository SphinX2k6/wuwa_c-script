using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000095 RID: 149
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.Subclass)]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.Subclass, PropertiesSize = 8)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public readonly struct TSubclassOf<[Nullable(0)] T> : IEquatable<TSubclassOf<T>>, IEqualityOperators<TSubclassOf<T>, TSubclassOf<T>, bool> where T : IUnrealUObject
	{
		// Token: 0x06001021 RID: 4129 RVA: 0x0001851F File Offset: 0x0001671F
		public TSubclassOf(IntPtr From)
		{
			this._NativePtr = From;
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00018528 File Offset: 0x00016728
		public TSubclassOf(UClassStackOnlyPtr From)
		{
			this._NativePtr = From.NativePtr;
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00018537 File Offset: 0x00016737
		public TSubclassOf(UClass From)
		{
			this._NativePtr = ((From != null) ? From._NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0001854F File Offset: 0x0001674F
		[NullableContext(0)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public TSubclassOf<TResult> As<TResult>() where TResult : IUnrealUObject
		{
			return new TSubclassOf<TResult>(this._NativePtr);
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0001855C File Offset: 0x0001675C
		public UClassStackOnlyPtr Get()
		{
			return UClass.IsChildOf(this._NativePtr, IUnrealUObject.StaticClass()) ? this._NativePtr : IntPtr.Zero;
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00018590 File Offset: 0x00016790
		public bool IsValid()
		{
			return this.Get().IsValid();
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x000185AB File Offset: 0x000167AB
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<T> Other)
		{
			return this == Other;
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x000185BC File Offset: 0x000167BC
		public override bool Equals(object Obj)
		{
			if (Obj is TSubclassOf<T>)
			{
				TSubclassOf<T> b = (TSubclassOf<T>)Obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x000185E6 File Offset: 0x000167E6
		public override int GetHashCode()
		{
			return this._NativePtr.GetHashCode();
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x000185F3 File Offset: 0x000167F3
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<T> A, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<T> B)
		{
			return A._NativePtr == B._NativePtr;
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x00018603 File Offset: 0x00016803
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<T> A, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<T> B)
		{
			return !(A == B);
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0001860F File Offset: 0x0001680F
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TSubclassOf<T>(IntPtr ClassPtr)
		{
			return new TSubclassOf<T>(ClassPtr);
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00018617 File Offset: 0x00016817
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TSubclassOf<T>(UClassStackOnlyPtr ClassPtr)
		{
			return new TSubclassOf<T>(ClassPtr);
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0001861F File Offset: 0x0001681F
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TSubclassOf<T>(UClass ClassPtr)
		{
			return new TSubclassOf<T>(ClassPtr);
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x00018627 File Offset: 0x00016827
		public static implicit operator UClassStackOnlyPtr([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<T> Class)
		{
			return Class.Get();
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00018630 File Offset: 0x00016830
		public bool IsChildOf(UClassStackOnlyPtr B)
		{
			return UClass.IsChildOf(this, B);
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00018643 File Offset: 0x00016843
		public bool IsA(UClassStackOnlyPtr B)
		{
			return UClass.IsA(this, B);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00018656 File Offset: 0x00016856
		public FName GetFName()
		{
			return UClass.GetFName(this);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00018668 File Offset: 0x00016868
		[NullableContext(1)]
		public string GetName()
		{
			return UClass.GetName(this);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0001867A File Offset: 0x0001687A
		[NullableContext(1)]
		public string GetPathName()
		{
			return UClass.GetPathName(this);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0001868C File Offset: 0x0001688C
		public UClass ToUClass()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UClass>(this._NativePtr);
		}

		// Token: 0x040001FB RID: 507
		public readonly IntPtr _NativePtr;
	}
}
