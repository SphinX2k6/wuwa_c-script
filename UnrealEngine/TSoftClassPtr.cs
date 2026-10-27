using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000092 RID: 146
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.SoftClass, PropertiesSize = 48)]
	public class TSoftClassPtr<[Nullable(0)] T> : FSoftObjectPtr, IEqualityOperators<TSoftClassPtr<T>, TSoftClassPtr<T>, bool>, IEquatable<TSoftClassPtr<T>>, IUnrealStructProxyForward<TSoftClassPtr<T>, FSoftObjectPtr>, IUnrealStructProxy<TSoftClassPtr<T>> where T : UnrealUObject, IUnrealUObject
	{
		// Token: 0x06000FF3 RID: 4083 RVA: 0x0001833C File Offset: 0x0001653C
		public TSoftClassPtr()
		{
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00018344 File Offset: 0x00016544
		public TSoftClassPtr(IntPtr OtherNativePtr, bool bWithMoveAssign = false, bool bWithCopyAssignIfCannotMove = true) : base(OtherNativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0001834F File Offset: 0x0001654F
		[NullableContext(2)]
		public TSoftClassPtr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00018359 File Offset: 0x00016559
		public TSoftClassPtr(UClassStackOnlyPtr Class) : base(Class)
		{
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00018362 File Offset: 0x00016562
		public TSoftClassPtr(string ClassPath) : base(ClassPath)
		{
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0001836B File Offset: 0x0001656B
		public TSoftClassPtr(FSoftClassPath ClassPath) : base(ClassPath)
		{
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00018374 File Offset: 0x00016574
		public TSoftClassPtr(FSoftObjectPtr SoftObjectPtr) : base(SoftObjectPtr.NativePtr, false, true)
		{
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00018384 File Offset: 0x00016584
		public new UClassStackOnlyPtr Get()
		{
			return base.GetNativePtr();
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00018391 File Offset: 0x00016591
		public TSoftClassPtr<S> As<[Nullable(0)] S>() where S : UObject
		{
			return new TSoftClassPtr<S>(this);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00018399 File Offset: 0x00016599
		public TSoftClassPtr<S> Cast<[Nullable(0)] S>() where S : T
		{
			return new TSoftClassPtr<S>(this);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x000183A1 File Offset: 0x000165A1
		public static bool operator ==([Nullable(new byte[]
		{
			2,
			1
		})] TSoftClassPtr<T> Left, [Nullable(new byte[]
		{
			2,
			1
		})] TSoftClassPtr<T> Right)
		{
			return Left == Right;
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x000183AA File Offset: 0x000165AA
		public static bool operator !=([Nullable(new byte[]
		{
			2,
			1
		})] TSoftClassPtr<T> Left, [Nullable(new byte[]
		{
			2,
			1
		})] TSoftClassPtr<T> Right)
		{
			return Left != Right;
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x000183B3 File Offset: 0x000165B3
		public bool Equals([Nullable(new byte[]
		{
			2,
			1
		})] TSoftClassPtr<T> Other)
		{
			return this == Other;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x000183BC File Offset: 0x000165BC
		[NullableContext(2)]
		public override bool Equals(object Obj)
		{
			TSoftClassPtr<T> tsoftClassPtr = Obj as TSoftClassPtr<T>;
			return tsoftClassPtr != null && this.Equals(tsoftClassPtr);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x000183DC File Offset: 0x000165DC
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x000183E4 File Offset: 0x000165E4
		public new static TSoftClassPtr<T> Create(IntPtr Src)
		{
			return new TSoftClassPtr<T>(Src, false, true);
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x000183EE File Offset: 0x000165EE
		public new static TSoftClassPtr<T> Create(IntPtr Src, [Nullable(2)] UnrealObject MemoryOwner)
		{
			return new TSoftClassPtr<T>(Src, MemoryOwner);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x000183F7 File Offset: 0x000165F7
		int IUnrealStructProxy<TSoftClassPtr<!0>>.get_Size()
		{
			return FSoftObjectPtr.Size;
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x000183FE File Offset: 0x000165FE
		int IUnrealStructProxy<TSoftClassPtr<!0>>.get_MinAlignment()
		{
			return FSoftObjectPtr.MinAlignment;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00018405 File Offset: 0x00016605
		void IUnrealStructProxy<TSoftClassPtr<!0>>.NativeConstruct(IntPtr Pointer, int ArrDim = 1)
		{
			FSoftObjectPtr.NativeConstruct(Pointer, ArrDim);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0001840E File Offset: 0x0001660E
		void IUnrealStructProxy<TSoftClassPtr<!0>>.NativeDestruct(IntPtr Pointer, int ArrDim = 1)
		{
			FSoftObjectPtr.NativeDestruct(Pointer, ArrDim);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00018417 File Offset: 0x00016617
		void IUnrealStructProxy<TSoftClassPtr<!0>>.NativeCopy(IntPtr Dest, IntPtr Src, int ArrDim = 1)
		{
			FSoftObjectPtr.NativeCopy(Dest, Src, ArrDim);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00018421 File Offset: 0x00016621
		int IUnrealStructProxy<TSoftClassPtr<!0>>.NativeFindIndex(IntPtr Pointer, int ArrDim, IntPtr Value)
		{
			return FSoftObjectPtr.NativeFindIndex(Pointer, ArrDim, Value);
		}
	}
}
