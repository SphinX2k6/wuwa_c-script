using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000153 RID: 339
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.TopLevelAssetPath")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FTopLevelAssetPath : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001323 RID: 4899 RVA: 0x0001E3B2 File Offset: 0x0001C5B2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTopLevelAssetPath._ScriptStructPtr != 0) ? FTopLevelAssetPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.TopLevelAssetPath", ref FTopLevelAssetPath._ScriptStructPtr);
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x0001E3D6 File Offset: 0x0001C5D6
		// (set) Token: 0x06001325 RID: 4901 RVA: 0x0001E3EA File Offset: 0x0001C5EA
		public unsafe FName PackageName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTopLevelAssetPath.__PropertyOffset_PackageName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTopLevelAssetPath.__PropertyOffset_PackageName) = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x0001E3FF File Offset: 0x0001C5FF
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x0001E413 File Offset: 0x0001C613
		public unsafe FName AssetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTopLevelAssetPath.__PropertyOffset_AssetName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTopLevelAssetPath.__PropertyOffset_AssetName) = value;
			}
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0001E428 File Offset: 0x0001C628
		public FTopLevelAssetPath()
		{
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0001E430 File Offset: 0x0001C630
		protected override IntPtr GetUStructPtr()
		{
			return FTopLevelAssetPath.StaticStruct();
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0001E43C File Offset: 0x0001C63C
		[NullableContext(2)]
		public FTopLevelAssetPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0001E446 File Offset: 0x0001C646
		public FTopLevelAssetPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0001E451 File Offset: 0x0001C651
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTopLevelAssetPath(Pointer, false, true);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0001E45B File Offset: 0x0001C65B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTopLevelAssetPath(Pointer, MemoryOwner);
		}

		// Token: 0x04000610 RID: 1552
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.TopLevelAssetPath";

		// Token: 0x04000611 RID: 1553
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000612 RID: 1554
		internal static int __PropertyOffset_PackageName;

		// Token: 0x04000613 RID: 1555
		internal static int __PropertyOffset_AssetName;
	}
}
