using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000085 RID: 133
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.SoftObject, PropertiesSize = 48)]
	public class FSoftObjectPtr : UnrealProxyObject, IEqualityOperators<FSoftObjectPtr, FSoftObjectPtr, bool>, IEquatable<FSoftObjectPtr>, IUnrealStructProxy<FSoftObjectPtr>
	{
		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x0001691C File Offset: 0x00014B1C
		[Nullable(0)]
		private unsafe FSoftObjectPtr.FSoftObjectPtrView* View
		{
			[NullableContext(0)]
			get
			{
				return this._NativePtr;
			}
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00016924 File Offset: 0x00014B24
		public FSoftObjectPtr()
		{
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0001692C File Offset: 0x00014B2C
		public FSoftObjectPtr(IntPtr OtherNativePtr, bool bWithMoveAssign = false, bool bWithCopyAssignIfCannotMove = true) : base(OtherNativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00016937 File Offset: 0x00014B37
		[NullableContext(2)]
		public FSoftObjectPtr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00016941 File Offset: 0x00014B41
		public FSoftObjectPtr(UClassStackOnlyPtr Class)
		{
			this.Set(Class);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00016950 File Offset: 0x00014B50
		[NullableContext(2)]
		public FSoftObjectPtr(UnrealUObject Object)
		{
			this.Set(Object);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0001695F File Offset: 0x00014B5F
		public FSoftObjectPtr(string ObjectPath)
		{
			this.Set(new FSoftObjectPath(ObjectPath));
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00016973 File Offset: 0x00014B73
		public FSoftObjectPtr(FSoftObjectPath ObjectPath)
		{
			this.Set(ObjectPath);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00016982 File Offset: 0x00014B82
		public new bool IsValid()
		{
			return base.IsValid() && this.Get() != null;
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00016997 File Offset: 0x00014B97
		[NullableContext(2)]
		public UnrealUObject Get()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(this.GetNativePtr());
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x000169A4 File Offset: 0x00014BA4
		public IntPtr GetNativePtr()
		{
			return FSoftObjectPtr.Get(this._NativePtr);
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x000169B1 File Offset: 0x00014BB1
		public unsafe FSoftObjectPath ToSoftObjectPath()
		{
			return this.View->SoftObjectPath;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x000169C4 File Offset: 0x00014BC4
		public string ToAssetPathName()
		{
			FName assetPathName = this.GetAssetPathName();
			if (!(assetPathName == FName.NAME_None))
			{
				return assetPathName.ToString();
			}
			return string.Empty;
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x000169F8 File Offset: 0x00014BF8
		public unsafe FName GetAssetPathName()
		{
			return this.View->SoftObjectPath.AssetPathName;
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00016A0A File Offset: 0x00014C0A
		public string GetAssetFullPath()
		{
			return this.ToString();
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00016A14 File Offset: 0x00014C14
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

		// Token: 0x06000F18 RID: 3864 RVA: 0x00016A78 File Offset: 0x00014C78
		[NullableContext(2)]
		public static bool operator !=(FSoftObjectPtr Left, FSoftObjectPtr Right)
		{
			return !(Left == Right);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00016A84 File Offset: 0x00014C84
		[NullableContext(2)]
		public bool Equals(FSoftObjectPtr Other)
		{
			return this == Other;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00016A90 File Offset: 0x00014C90
		[NullableContext(2)]
		public override bool Equals(object Obj)
		{
			FSoftObjectPtr fsoftObjectPtr = Obj as FSoftObjectPtr;
			return fsoftObjectPtr != null && this.Equals(fsoftObjectPtr);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00016AB0 File Offset: 0x00014CB0
		public unsafe override string ToString()
		{
			if (this._NativePtr == IntPtr.Zero)
			{
				return string.Empty;
			}
			return this.View->SoftObjectPath.ToString();
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00016ADB File Offset: 0x00014CDB
		public unsafe override int GetHashCode()
		{
			return this.View->SoftObjectPath.GetHashCode();
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00016AF3 File Offset: 0x00014CF3
		[NullableContext(2)]
		public void Set(UnrealUObject UObject)
		{
			FSoftObjectPtr.SetFromUObject(base.NativePtr, (UObject != null) ? UObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00016B10 File Offset: 0x00014D10
		public void Set(UClassStackOnlyPtr UClass)
		{
			FSoftObjectPtr.SetFromUObject(base.NativePtr, UClass.NativePtr);
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00016B24 File Offset: 0x00014D24
		public void Set(FSoftObjectPath ObjectPath)
		{
			FSoftObjectPtr.SetFromSoftObjectPath(base.NativePtr, ObjectPath.NativePtr);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x00016B37 File Offset: 0x00014D37
		public void Reset()
		{
			FSoftObjectPtr.Reset(base.NativePtr);
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00016B44 File Offset: 0x00014D44
		public void ResetWeakPtr()
		{
			FSoftObjectPtr.ResetWeakPtr(base.NativePtr);
		}

		// Token: 0x06000F22 RID: 3874
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern IntPtr Get(IntPtr Self);

		// Token: 0x06000F23 RID: 3875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetFromUObject(IntPtr Self, IntPtr UObject);

		// Token: 0x06000F24 RID: 3876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetFromSoftObjectPath(IntPtr Self, IntPtr ObjectPath);

		// Token: 0x06000F25 RID: 3877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Reset(IntPtr Self);

		// Token: 0x06000F26 RID: 3878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ResetWeakPtr(IntPtr Self);

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x00016B51 File Offset: 0x00014D51
		public static int Size
		{
			get
			{
				return 48;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00016B55 File Offset: 0x00014D55
		public static int MinAlignment
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00016B58 File Offset: 0x00014D58
		public static FSoftObjectPtr Create(IntPtr Src)
		{
			return new FSoftObjectPtr(Src, false, true);
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00016B62 File Offset: 0x00014D62
		public static FSoftObjectPtr Create(IntPtr Src, [Nullable(2)] UnrealObject MemoryOwner)
		{
			return new FSoftObjectPtr(Src, MemoryOwner);
		}

		// Token: 0x06000F2B RID: 3883
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeConstruct(IntPtr Pointer, int ArrDim = 1);

		// Token: 0x06000F2C RID: 3884
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeDestruct(IntPtr Pointer, int ArrDim = 1);

		// Token: 0x06000F2D RID: 3885
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NativeCopy(IntPtr Dest, IntPtr Src, int ArrDim = 1);

		// Token: 0x06000F2E RID: 3886
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int NativeFindIndex(IntPtr Pointer, int ArrDim, IntPtr Value);

		// Token: 0x06000F2F RID: 3887 RVA: 0x00016B6B File Offset: 0x00014D6B
		protected unsafe override IntPtr AllocNativePtr()
		{
			void* ptr = BuiltinUtils.Malloc((UIntPtr)((IntPtr)FSoftObjectPtr.Size), (uint)FSoftObjectPtr.MinAlignment);
			FSoftObjectPtr.NativeConstruct(ptr, 1);
			return ptr;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00016B84 File Offset: 0x00014D84
		protected override void DeallocNativePtr()
		{
			FSoftObjectPtr.NativeDestruct(this._NativePtr, 1);
			BuiltinUtils.Free(this._NativePtr);
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x00016B9D File Offset: 0x00014D9D
		public override bool AllowMoveAssign
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x00016BA0 File Offset: 0x00014DA0
		public override bool AllowCopyAssign
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00016BA3 File Offset: 0x00014DA3
		public override void CopyAssign(IntPtr FromNativePtr)
		{
			FSoftObjectPtr.NativeCopy(this._NativePtr, FromNativePtr, 1);
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00016BB2 File Offset: 0x00014DB2
		public override void CopyTo(IntPtr DestPtr, UScriptStructStackOnlyPtr NativeUStructPtr = default(UScriptStructStackOnlyPtr))
		{
			FSoftObjectPtr.NativeCopy(DestPtr, this._NativePtr, 1);
		}

		// Token: 0x040001D4 RID: 468
		public const int __Size = 48;

		// Token: 0x040001D5 RID: 469
		public const int __Pack = 8;

		// Token: 0x02002B26 RID: 11046
		[NullableContext(0)]
		[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 48)]
		internal struct FSoftObjectPtrView
		{
			// Token: 0x0401637C RID: 91004
			[FieldOffset(0)]
			internal readonly FWeakObjectPtr WeakObjectPtr;

			// Token: 0x0401637D RID: 91005
			[FieldOffset(8)]
			internal readonly int TagAtLastTest;

			// Token: 0x0401637E RID: 91006
			[FieldOffset(16)]
			internal readonly FSoftObjectPathStruct SoftObjectPath;
		}
	}
}
