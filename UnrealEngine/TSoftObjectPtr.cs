using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000093 RID: 147
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.SoftObject, PropertiesSize = 48)]
	public class TSoftObjectPtr<[Nullable(0)] T> : FSoftObjectPtr, IEqualityOperators<TSoftObjectPtr<T>, TSoftObjectPtr<T>, bool>, IEquatable<TSoftObjectPtr<T>>, IUnrealStructProxyForward<TSoftObjectPtr<T>, FSoftObjectPtr>, IUnrealStructProxy<TSoftObjectPtr<T>> where T : UnrealUObject
	{
		// Token: 0x0600100A RID: 4106 RVA: 0x0001842B File Offset: 0x0001662B
		public TSoftObjectPtr()
		{
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00018433 File Offset: 0x00016633
		public TSoftObjectPtr(IntPtr OtherNativePtr, bool bWithMoveAssign = false, bool bWithCopyAssignIfCannotMove = true) : base(OtherNativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0001843E File Offset: 0x0001663E
		[NullableContext(2)]
		public TSoftObjectPtr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00018448 File Offset: 0x00016648
		[NullableContext(2)]
		public TSoftObjectPtr(UnrealUObject Object) : base(Object)
		{
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00018451 File Offset: 0x00016651
		public TSoftObjectPtr(string ObjectPath) : base(ObjectPath)
		{
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0001845A File Offset: 0x0001665A
		public TSoftObjectPtr(FSoftObjectPath ObjectPath) : base(ObjectPath)
		{
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00018463 File Offset: 0x00016663
		public TSoftObjectPtr(FSoftObjectPtr SoftObjectPtr) : base(SoftObjectPtr.NativePtr, false, true)
		{
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00018473 File Offset: 0x00016673
		[NullableContext(2)]
		public new T Get()
		{
			return base.Get() as T;
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00018485 File Offset: 0x00016685
		public TSoftObjectPtr<S> As<[Nullable(0)] S>() where S : UObject
		{
			return new TSoftObjectPtr<S>(this);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0001848D File Offset: 0x0001668D
		public TSoftObjectPtr<S> Cast<[Nullable(0)] S>() where S : T
		{
			return new TSoftObjectPtr<S>(this);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00018495 File Offset: 0x00016695
		public static bool operator ==([Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<T> Left, [Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<T> Right)
		{
			return Left == Right;
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0001849E File Offset: 0x0001669E
		public static bool operator !=([Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<T> Left, [Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<T> Right)
		{
			return Left != Right;
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x000184A7 File Offset: 0x000166A7
		public bool Equals([Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<T> Other)
		{
			return this == Other;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x000184B0 File Offset: 0x000166B0
		[NullableContext(2)]
		public override bool Equals(object Obj)
		{
			TSoftObjectPtr<T> tsoftObjectPtr = Obj as TSoftObjectPtr<T>;
			return tsoftObjectPtr != null && this.Equals(tsoftObjectPtr);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x000184D0 File Offset: 0x000166D0
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x000184D8 File Offset: 0x000166D8
		public new static TSoftObjectPtr<T> Create(IntPtr Src)
		{
			return new TSoftObjectPtr<T>(Src, false, true);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000184E2 File Offset: 0x000166E2
		public new static TSoftObjectPtr<T> Create(IntPtr Src, [Nullable(2)] UnrealObject MemoryOwner)
		{
			return new TSoftObjectPtr<T>(Src, MemoryOwner);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000184EB File Offset: 0x000166EB
		int IUnrealStructProxy<TSoftObjectPtr<!0>>.get_Size()
		{
			return FSoftObjectPtr.Size;
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x000184F2 File Offset: 0x000166F2
		int IUnrealStructProxy<TSoftObjectPtr<!0>>.get_MinAlignment()
		{
			return FSoftObjectPtr.MinAlignment;
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x000184F9 File Offset: 0x000166F9
		void IUnrealStructProxy<TSoftObjectPtr<!0>>.NativeConstruct(IntPtr Pointer, int ArrDim = 1)
		{
			FSoftObjectPtr.NativeConstruct(Pointer, ArrDim);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x00018502 File Offset: 0x00016702
		void IUnrealStructProxy<TSoftObjectPtr<!0>>.NativeDestruct(IntPtr Pointer, int ArrDim = 1)
		{
			FSoftObjectPtr.NativeDestruct(Pointer, ArrDim);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0001850B File Offset: 0x0001670B
		void IUnrealStructProxy<TSoftObjectPtr<!0>>.NativeCopy(IntPtr Dest, IntPtr Src, int ArrDim = 1)
		{
			FSoftObjectPtr.NativeCopy(Dest, Src, ArrDim);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00018515 File Offset: 0x00016715
		int IUnrealStructProxy<TSoftObjectPtr<!0>>.NativeFindIndex(IntPtr Pointer, int ArrDim, IntPtr Value)
		{
			return FSoftObjectPtr.NativeFindIndex(Pointer, ArrDim, Value);
		}
	}
}
