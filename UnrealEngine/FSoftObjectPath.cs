using System;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000083 RID: 131
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.SoftObjectPath")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSoftObjectPath : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000EEA RID: 3818 RVA: 0x00016594 File Offset: 0x00014794
		public FSoftObjectPath(string Path)
		{
			if (!string.IsNullOrEmpty(Path))
			{
				this.SetPath(Path);
			}
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x000165AC File Offset: 0x000147AC
		[NullableContext(2)]
		public FSoftObjectPath(UObject Object)
		{
			string text = (Object != null) ? Object.GetPathName() : null;
			this..ctor((text != null) ? text : FName.NAME_None, string.Empty);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x000165E4 File Offset: 0x000147E4
		public FSoftObjectPath([Nullable(2)] UObject Object, string SubPath)
		{
			string text = (Object != null) ? Object.GetPathName() : null;
			this..ctor((text != null) ? text : FName.NAME_None, SubPath);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00016618 File Offset: 0x00014818
		[NullableContext(2)]
		public unsafe void SetPath(string Path)
		{
			FCSharpStringView fcsharpStringView;
			if (string.IsNullOrEmpty(Path))
			{
				IntPtr nativePtr = base.NativePtr;
				fcsharpStringView = default(FCSharpStringView);
				FSoftObjectPath.Internal_SetPath(nativePtr, fcsharpStringView);
				return;
			}
			char* ptr;
			if (Path == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = Path.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* ptr3 = ptr;
			IntPtr nativePtr2 = base.NativePtr;
			fcsharpStringView = new FCSharpStringView(ptr3, Path.Length);
			FSoftObjectPath.Internal_SetPath(nativePtr2, fcsharpStringView);
			char* ptr2 = null;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00016670 File Offset: 0x00014870
		public void Reset()
		{
			FSoftObjectPath.Internal_Reset(base.NativePtr);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0001667D File Offset: 0x0001487D
		[NullableContext(2)]
		public UObject ResolveObject()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer(FSoftObjectPath.Internal_ResolveObject(base.NativePtr)) as UObject;
		}

		// Token: 0x06000EF0 RID: 3824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetPath(IntPtr This, in FCSharpStringView Path);

		// Token: 0x06000EF1 RID: 3825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Reset(IntPtr This);

		// Token: 0x06000EF2 RID: 3826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Internal_ResolveObject(IntPtr This);

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00016694 File Offset: 0x00014894
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder(128);
			FName assetPathName = this.AssetPathName;
			if (!assetPathName.IsNone())
			{
				stringBuilder.Append(assetPathName.ToString());
			}
			string subPathString = this.SubPathString;
			if (subPathString.Length > 0)
			{
				stringBuilder.Append(':');
				stringBuilder.Append(subPathString);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000166F8 File Offset: 0x000148F8
		public string GetAssetPathString()
		{
			FName assetPathName = this.AssetPathName;
			if (!assetPathName.IsNone())
			{
				return assetPathName.ToString();
			}
			return string.Empty;
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00016728 File Offset: 0x00014928
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoftObjectPath._ScriptStructPtr != 0) ? FSoftObjectPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.SoftObjectPath", ref FSoftObjectPath._ScriptStructPtr);
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x0001674C File Offset: 0x0001494C
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x00016760 File Offset: 0x00014960
		public unsafe FName AssetPathName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoftObjectPath.__PropertyOffset_AssetPathName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoftObjectPath.__PropertyOffset_AssetPathName) = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x00016775 File Offset: 0x00014975
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x00016789 File Offset: 0x00014989
		public unsafe string SubPathString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSoftObjectPath.__PropertyOffset_SubPathString)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSoftObjectPath.__PropertyOffset_SubPathString)), value);
			}
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0001679E File Offset: 0x0001499E
		public FSoftObjectPath()
		{
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x000167A6 File Offset: 0x000149A6
		public FSoftObjectPath(FName AssetPathName, string SubPathString)
		{
			this.AssetPathName = AssetPathName;
			this.SubPathString = SubPathString;
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x000167BC File Offset: 0x000149BC
		protected override IntPtr GetUStructPtr()
		{
			return FSoftObjectPath.StaticStruct();
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x000167C8 File Offset: 0x000149C8
		[NullableContext(2)]
		public FSoftObjectPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x000167D2 File Offset: 0x000149D2
		public FSoftObjectPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x000167DD File Offset: 0x000149DD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoftObjectPath(Pointer, false, true);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x000167E7 File Offset: 0x000149E7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoftObjectPath(Pointer, MemoryOwner);
		}

		// Token: 0x040001CE RID: 462
		public const string __ObjectPath = "/Script/CoreUObject.SoftObjectPath";

		// Token: 0x040001CF RID: 463
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040001D0 RID: 464
		internal static int __PropertyOffset_AssetPathName;

		// Token: 0x040001D1 RID: 465
		internal static int __PropertyOffset_SubPathString;
	}
}
