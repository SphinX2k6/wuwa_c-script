using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000078 RID: 120
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.SoftObject, PropertiesSize = 48)]
	public class TSoftObjectPtr<[Nullable(0)] T> : FSoftObjectPtr, IEqualityOperators<TSoftObjectPtr<T>, TSoftObjectPtr<T>, bool>, IEquatable<TSoftObjectPtr<T>>, IUnrealStructProxyForward<TSoftObjectPtr<T>, FSoftObjectPtr>, IUnrealStructProxy<TSoftObjectPtr<T>> where T : UnrealUObject
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x0001314F File Offset: 0x0001134F
		public TSoftObjectPtr()
		{
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00013157 File Offset: 0x00011357
		public TSoftObjectPtr(IntPtr OtherNativePtr, bool bWithMoveAssign = false, bool bWithCopyAssignIfCannotMove = true) : base(OtherNativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x00013162 File Offset: 0x00011362
		[NullableContext(2)]
		public TSoftObjectPtr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0001316C File Offset: 0x0001136C
		[NullableContext(2)]
		public TSoftObjectPtr(UnrealUObject Object) : base(Object)
		{
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00013175 File Offset: 0x00011375
		public TSoftObjectPtr(string ObjectPath) : base(ObjectPath)
		{
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0001317E File Offset: 0x0001137E
		public TSoftObjectPtr(FSoftObjectPath ObjectPath) : base(ObjectPath)
		{
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00013187 File Offset: 0x00011387
		public TSoftObjectPtr(FSoftObjectPtr SoftObjectPtr) : base(SoftObjectPtr.NativePtr, false, true)
		{
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00013197 File Offset: 0x00011397
		[NullableContext(2)]
		public new T Get()
		{
			return base.Get() as T;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000131A9 File Offset: 0x000113A9
		public TSoftObjectPtr<S> As<[Nullable(0)] S>() where S : UObject
		{
			return new TSoftObjectPtr<S>(this);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000131B1 File Offset: 0x000113B1
		public TSoftObjectPtr<S> Cast<[Nullable(0)] S>() where S : T
		{
			return new TSoftObjectPtr<S>(this);
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x000131B9 File Offset: 0x000113B9
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

		// Token: 0x06000BA8 RID: 2984 RVA: 0x000131C2 File Offset: 0x000113C2
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

		// Token: 0x06000BA9 RID: 2985 RVA: 0x000131CB File Offset: 0x000113CB
		public bool Equals([Nullable(new byte[]
		{
			2,
			1
		})] TSoftObjectPtr<T> Other)
		{
			return this == Other;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x000131D4 File Offset: 0x000113D4
		[NullableContext(2)]
		public override bool Equals(object Obj)
		{
			TSoftObjectPtr<T> tsoftObjectPtr = Obj as TSoftObjectPtr<T>;
			return tsoftObjectPtr != null && this.Equals(tsoftObjectPtr);
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x000131F4 File Offset: 0x000113F4
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000131FC File Offset: 0x000113FC
		public new static TSoftObjectPtr<T> Create(IntPtr Src)
		{
			return new TSoftObjectPtr<T>(Src, false, true);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00013206 File Offset: 0x00011406
		public new static TSoftObjectPtr<T> Create(IntPtr Src, [Nullable(2)] UnrealObject MemoryOwner)
		{
			return new TSoftObjectPtr<T>(Src, MemoryOwner);
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0001320F File Offset: 0x0001140F
		int IUnrealStructProxy<TSoftObjectPtr<!0>>.get_Size()
		{
			return FSoftObjectPtr.Size;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00013216 File Offset: 0x00011416
		int IUnrealStructProxy<TSoftObjectPtr<!0>>.get_MinAlignment()
		{
			return FSoftObjectPtr.MinAlignment;
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x0001321D File Offset: 0x0001141D
		void IUnrealStructProxy<TSoftObjectPtr<!0>>.NativeConstruct(IntPtr Pointer, int ArrDim = 1)
		{
			FSoftObjectPtr.NativeConstruct(Pointer, ArrDim);
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00013226 File Offset: 0x00011426
		void IUnrealStructProxy<TSoftObjectPtr<!0>>.NativeDestruct(IntPtr Pointer, int ArrDim = 1)
		{
			FSoftObjectPtr.NativeDestruct(Pointer, ArrDim);
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0001322F File Offset: 0x0001142F
		void IUnrealStructProxy<TSoftObjectPtr<!0>>.NativeCopy(IntPtr Dest, IntPtr Src, int ArrDim = 1)
		{
			FSoftObjectPtr.NativeCopy(Dest, Src, ArrDim);
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x00013239 File Offset: 0x00011439
		int IUnrealStructProxy<TSoftObjectPtr<!0>>.NativeFindIndex(IntPtr Pointer, int ArrDim, IntPtr Value)
		{
			return FSoftObjectPtr.NativeFindIndex(Pointer, ArrDim, Value);
		}
	}
}
