using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200006A RID: 106
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.SoftObject, PropertiesSize = 48)]
	public class FSoftObjectPtr : UnrealProxyObject, IEqualityOperators<FSoftObjectPtr, FSoftObjectPtr, bool>, IEquatable<FSoftObjectPtr>, IUnrealStructProxy<FSoftObjectPtr>
	{
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00011650 File Offset: 0x0000F850
		[Nullable(0)]
		private unsafe FSoftObjectPtr.FSoftObjectPtrView* View
		{
			[NullableContext(0)]
			get
			{
				return this._NativePtr;
			}
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00011658 File Offset: 0x0000F858
		public FSoftObjectPtr()
		{
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00011660 File Offset: 0x0000F860
		public FSoftObjectPtr(IntPtr OtherNativePtr, bool bWithMoveAssign = false, bool bWithCopyAssignIfCannotMove = true) : base(OtherNativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0001166B File Offset: 0x0000F86B
		[NullableContext(2)]
		public FSoftObjectPtr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00011675 File Offset: 0x0000F875
		public FSoftObjectPtr(UClassStackOnlyPtr Class)
		{
			this.Set(Class);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00011684 File Offset: 0x0000F884
		[NullableContext(2)]
		public FSoftObjectPtr(UnrealUObject Object)
		{
			this.Set(Object);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00011693 File Offset: 0x0000F893
		public FSoftObjectPtr(string ObjectPath)
		{
			this.Set(new FSoftObjectPath(ObjectPath));
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x000116A7 File Offset: 0x0000F8A7
		public FSoftObjectPtr(FSoftObjectPath ObjectPath)
		{
			this.Set(ObjectPath);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x000116B6 File Offset: 0x0000F8B6
		public new bool IsValid()
		{
			return base.IsValid() && this.Get() != null;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000116CB File Offset: 0x0000F8CB
		[NullableContext(2)]
		public UnrealUObject Get()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(this.GetNativePtr());
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x000116D8 File Offset: 0x0000F8D8
		public IntPtr GetNativePtr()
		{
			return FSoftObjectPtr.Get(this._NativePtr);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000116E5 File Offset: 0x0000F8E5
		public unsafe FSoftObjectPath ToSoftObjectPath()
		{
			return this.View->SoftObjectPath;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x000116F8 File Offset: 0x0000F8F8
		public string ToAssetPathName()
		{
			FName assetPathName = this.GetAssetPathName();
			if (!(assetPathName == FName.NAME_None))
			{
				return assetPathName.ToString();
			}
			return string.Empty;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0001172C File Offset: 0x0000F92C
		public unsafe FName GetAssetPathName()
		{
			return this.View->SoftObjectPath.AssetPathName;
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0001173E File Offset: 0x0000F93E
		public string GetAssetFullPath()
		{
			return this.ToString();
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00011748 File Offset: 0x0000F948
		[NullableContext(2)]
		public unsafe static bool operator ==(FSoftObjectPtr Left, FSoftObjectPtr Right)
		{
			if (Left == Right)
			{
				return true;
			}
			if (Left == null || Right == null)
			{
				return false;
			}
			if (Left._NativePtr == Right._NativePtr)
			{
				return true;
			}
			if (Left._NativePtr == IntPtr.Zero || Right._NativePtr == IntPtr.Zero)
			{
				return false;
			}
			ref FSoftObjectPtr.FSoftObjectPtrView view = ref *Left.View;
			FSoftObjectPtr.FSoftObjectPtrView* view2 = Right.View;
			return view.SoftObjectPath == view2->SoftObjectPath;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000117AC File Offset: 0x0000F9AC
		[NullableContext(2)]
		public static bool operator !=(FSoftObjectPtr Left, FSoftObjectPtr Right)
		{
			return !(Left == Right);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x000117B8 File Offset: 0x0000F9B8
		[NullableContext(2)]
		public bool Equals(FSoftObjectPtr Other)
		{
			return this == Other;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x000117C4 File Offset: 0x0000F9C4
		[NullableContext(2)]
		public override bool Equals(object Obj)
		{
			FSoftObjectPtr fsoftObjectPtr = Obj as FSoftObjectPtr;
			return fsoftObjectPtr != null && this.Equals(fsoftObjectPtr);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x000117E4 File Offset: 0x0000F9E4
		public unsafe override string ToString()
		{
			if (this._NativePtr == IntPtr.Zero)
			{
				return string.Empty;
			}
			return this.View->SoftObjectPath.ToString();
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0001180F File Offset: 0x0000FA0F
		public unsafe override int GetHashCode()
		{
			return this.View->SoftObjectPath.GetHashCode();
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00011827 File Offset: 0x0000FA27
		[NullableContext(2)]
		public void Set(UnrealUObject UObject)
		{
			FSoftObjectPtr.SetFromUObject(base.NativePtr, (UObject != null) ? UObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00011844 File Offset: 0x0000FA44
		public void Set(UClassStackOnlyPtr UClass)
		{
			FSoftObjectPtr.SetFromUObject(base.NativePtr, UClass.NativePtr);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00011858 File Offset: 0x0000FA58
		public void Set(FSoftObjectPath ObjectPath)
		{
			FSoftObjectPtr.SetFromSoftObjectPath(base.NativePtr, ObjectPath.NativePtr);
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0001186B File Offset: 0x0000FA6B
		public void Reset()
		{
			FSoftObjectPtr.Reset(base.NativePtr);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00011878 File Offset: 0x0000FA78
		public void ResetWeakPtr()
		{
			FSoftObjectPtr.ResetWeakPtr(base.NativePtr);
		}

		// Token: 0x06000AB5 RID: 2741
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr Get(IntPtr Self);

		// Token: 0x06000AB6 RID: 2742
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetFromUObject(IntPtr Self, IntPtr UObject);

		// Token: 0x06000AB7 RID: 2743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetFromSoftObjectPath(IntPtr Self, IntPtr ObjectPath);

		// Token: 0x06000AB8 RID: 2744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Reset(IntPtr Self);

		// Token: 0x06000AB9 RID: 2745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ResetWeakPtr(IntPtr Self);

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00011885 File Offset: 0x0000FA85
		public static int Size
		{
			get
			{
				return 48;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x00011889 File Offset: 0x0000FA89
		public static int MinAlignment
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0001188C File Offset: 0x0000FA8C
		public static FSoftObjectPtr Create(IntPtr Src)
		{
			return new FSoftObjectPtr(Src, false, true);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00011896 File Offset: 0x0000FA96
		public static FSoftObjectPtr Create(IntPtr Src, [Nullable(2)] UnrealObject MemoryOwner)
		{
			return new FSoftObjectPtr(Src, MemoryOwner);
		}

		// Token: 0x06000ABE RID: 2750
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeConstruct(IntPtr Pointer, int ArrDim = 1);

		// Token: 0x06000ABF RID: 2751
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeDestruct(IntPtr Pointer, int ArrDim = 1);

		// Token: 0x06000AC0 RID: 2752
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeCopy(IntPtr Dest, IntPtr Src, int ArrDim = 1);

		// Token: 0x06000AC1 RID: 2753
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int NativeFindIndex(IntPtr Pointer, int ArrDim, IntPtr Value);

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0001189F File Offset: 0x0000FA9F
		protected unsafe override IntPtr AllocNativePtr()
		{
			void* ptr = BuiltinUtils.Malloc((UIntPtr)((IntPtr)FSoftObjectPtr.Size), (uint)FSoftObjectPtr.MinAlignment);
			FSoftObjectPtr.NativeConstruct(ptr, 1);
			return ptr;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x000118B8 File Offset: 0x0000FAB8
		protected override void DeallocNativePtr()
		{
			FSoftObjectPtr.NativeDestruct(this._NativePtr, 1);
			BuiltinUtils.Free(this._NativePtr);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x000118D1 File Offset: 0x0000FAD1
		public override bool AllowMoveAssign
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x000118D4 File Offset: 0x0000FAD4
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x000118D7 File Offset: 0x0000FAD7
		public override void CopyAssign(IntPtr FromNativePtr)
		{
			FSoftObjectPtr.NativeCopy(this._NativePtr, FromNativePtr, 1);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x000118E6 File Offset: 0x0000FAE6
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			FSoftObjectPtr.NativeCopy(DestPtr, this._NativePtr, 1);
		}

		// Token: 0x0400018D RID: 397
		public const int __Size = 48;

		// Token: 0x0400018E RID: 398
		public const int __Pack = 8;

		// Token: 0x020008D4 RID: 2260
		[NullableContext(0)]
		[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 48)]
		internal struct FSoftObjectPtrView
		{
			// Token: 0x04005792 RID: 22418
			[FieldOffset(0)]
			internal readonly FWeakObjectPtr WeakObjectPtr;

			// Token: 0x04005793 RID: 22419
			[FieldOffset(8)]
			internal readonly int TagAtLastTest;

			// Token: 0x04005794 RID: 22420
			[FieldOffset(16)]
			internal readonly FSoftObjectPathStruct SoftObjectPath;
		}
	}
}
