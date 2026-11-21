using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000077 RID: 119
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.SoftClass, PropertiesSize = 48)]
	public class TSoftClassPtr<[Nullable(0)] T> : FSoftObjectPtr, IEqualityOperators<TSoftClassPtr<T>, TSoftClassPtr<T>, bool>, IEquatable<TSoftClassPtr<T>>, IUnrealStructProxyForward<TSoftClassPtr<T>, FSoftObjectPtr>, IUnrealStructProxy<TSoftClassPtr<T>> where T : UnrealUObject, IUnrealUObject
	{
		// Token: 0x06000B86 RID: 2950 RVA: 0x00013060 File Offset: 0x00011260
		public TSoftClassPtr()
		{
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00013068 File Offset: 0x00011268
		public TSoftClassPtr(IntPtr OtherNativePtr, bool bWithMoveAssign = false, bool bWithCopyAssignIfCannotMove = true) : base(OtherNativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00013073 File Offset: 0x00011273
		[NullableContext(2)]
		public TSoftClassPtr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0001307D File Offset: 0x0001127D
		public TSoftClassPtr(UClassStackOnlyPtr Class) : base(Class)
		{
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00013086 File Offset: 0x00011286
		public TSoftClassPtr(string ClassPath) : base(ClassPath)
		{
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0001308F File Offset: 0x0001128F
		public TSoftClassPtr(FSoftClassPath ClassPath) : base(ClassPath)
		{
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00013098 File Offset: 0x00011298
		public TSoftClassPtr(FSoftObjectPtr SoftObjectPtr) : base(SoftObjectPtr.NativePtr, false, true)
		{
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000130A8 File Offset: 0x000112A8
		public new UClassStackOnlyPtr Get()
		{
			return base.GetNativePtr();
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x000130B5 File Offset: 0x000112B5
		public TSoftClassPtr<S> As<[Nullable(0)] S>() where S : UObject
		{
			return new TSoftClassPtr<S>(this);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000130BD File Offset: 0x000112BD
		public TSoftClassPtr<S> Cast<[Nullable(0)] S>() where S : T
		{
			return new TSoftClassPtr<S>(this);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000130C5 File Offset: 0x000112C5
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

		// Token: 0x06000B91 RID: 2961 RVA: 0x000130CE File Offset: 0x000112CE
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

		// Token: 0x06000B92 RID: 2962 RVA: 0x000130D7 File Offset: 0x000112D7
		public bool Equals([Nullable(new byte[]
		{
			2,
			1
		})] TSoftClassPtr<T> Other)
		{
			return this == Other;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000130E0 File Offset: 0x000112E0
		[NullableContext(2)]
		public override bool Equals(object Obj)
		{
			TSoftClassPtr<T> tsoftClassPtr = Obj as TSoftClassPtr<T>;
			return tsoftClassPtr != null && this.Equals(tsoftClassPtr);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00013100 File Offset: 0x00011300
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00013108 File Offset: 0x00011308
		public new static TSoftClassPtr<T> Create(IntPtr Src)
		{
			return new TSoftClassPtr<T>(Src, false, true);
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00013112 File Offset: 0x00011312
		public new static TSoftClassPtr<T> Create(IntPtr Src, [Nullable(2)] UnrealObject MemoryOwner)
		{
			return new TSoftClassPtr<T>(Src, MemoryOwner);
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0001311B File Offset: 0x0001131B
		int IUnrealStructProxy<TSoftClassPtr<!0>>.get_Size()
		{
			return FSoftObjectPtr.Size;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00013122 File Offset: 0x00011322
		int IUnrealStructProxy<TSoftClassPtr<!0>>.get_MinAlignment()
		{
			return FSoftObjectPtr.MinAlignment;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00013129 File Offset: 0x00011329
		void IUnrealStructProxy<TSoftClassPtr<!0>>.NativeConstruct(IntPtr Pointer, int ArrDim = 1)
		{
			FSoftObjectPtr.NativeConstruct(Pointer, ArrDim);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00013132 File Offset: 0x00011332
		void IUnrealStructProxy<TSoftClassPtr<!0>>.NativeDestruct(IntPtr Pointer, int ArrDim = 1)
		{
			FSoftObjectPtr.NativeDestruct(Pointer, ArrDim);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0001313B File Offset: 0x0001133B
		void IUnrealStructProxy<TSoftClassPtr<!0>>.NativeCopy(IntPtr Dest, IntPtr Src, int ArrDim = 1)
		{
			FSoftObjectPtr.NativeCopy(Dest, Src, ArrDim);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00013145 File Offset: 0x00011345
		int IUnrealStructProxy<TSoftClassPtr<!0>>.NativeFindIndex(IntPtr Pointer, int ArrDim, IntPtr Value)
		{
			return FSoftObjectPtr.NativeFindIndex(Pointer, ArrDim, Value);
		}
	}
}
