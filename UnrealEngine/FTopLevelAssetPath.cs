using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200076D RID: 1901
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.TopLevelAssetPath")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FTopLevelAssetPath : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060063CB RID: 25547 RVA: 0x0008F4BE File Offset: 0x0008D6BE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTopLevelAssetPath._ScriptStructPtr != 0) ? FTopLevelAssetPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.TopLevelAssetPath", ref FTopLevelAssetPath._ScriptStructPtr);
		}

		// Token: 0x170017AC RID: 6060
		// (get) Token: 0x060063CC RID: 25548 RVA: 0x0008F4E2 File Offset: 0x0008D6E2
		// (set) Token: 0x060063CD RID: 25549 RVA: 0x0008F4F6 File Offset: 0x0008D6F6
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

		// Token: 0x170017AD RID: 6061
		// (get) Token: 0x060063CE RID: 25550 RVA: 0x0008F50B File Offset: 0x0008D70B
		// (set) Token: 0x060063CF RID: 25551 RVA: 0x0008F51F File Offset: 0x0008D71F
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

		// Token: 0x060063D0 RID: 25552 RVA: 0x0008F534 File Offset: 0x0008D734
		public FTopLevelAssetPath()
		{
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x0008F53C File Offset: 0x0008D73C
		public FTopLevelAssetPath(FName PackageName, FName AssetName)
		{
			this.PackageName = PackageName;
			this.AssetName = AssetName;
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x0008F552 File Offset: 0x0008D752
		protected override IntPtr GetUStructPtr()
		{
			return FTopLevelAssetPath.StaticStruct();
		}

		// Token: 0x060063D3 RID: 25555 RVA: 0x0008F55E File Offset: 0x0008D75E
		[NullableContext(2)]
		public FTopLevelAssetPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060063D4 RID: 25556 RVA: 0x0008F568 File Offset: 0x0008D768
		public FTopLevelAssetPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060063D5 RID: 25557 RVA: 0x0008F573 File Offset: 0x0008D773
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTopLevelAssetPath(Pointer, false, true);
		}

		// Token: 0x060063D6 RID: 25558 RVA: 0x0008F57D File Offset: 0x0008D77D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTopLevelAssetPath(Pointer, MemoryOwner);
		}

		// Token: 0x04002FDA RID: 12250
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.TopLevelAssetPath";

		// Token: 0x04002FDB RID: 12251
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002FDC RID: 12252
		internal static int __PropertyOffset_PackageName;

		// Token: 0x04002FDD RID: 12253
		internal static int __PropertyOffset_AssetName;
	}
}
