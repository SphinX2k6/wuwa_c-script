using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000143 RID: 323
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/CoreUObject.PrimaryAssetType")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FPrimaryAssetType : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060012C6 RID: 4806 RVA: 0x0001DB05 File Offset: 0x0001BD05
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPrimaryAssetType._ScriptStructPtr != 0) ? FPrimaryAssetType._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.PrimaryAssetType", ref FPrimaryAssetType._ScriptStructPtr);
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x0001DB29 File Offset: 0x0001BD29
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x0001DB3D File Offset: 0x0001BD3D
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPrimaryAssetType.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPrimaryAssetType.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x0001DB52 File Offset: 0x0001BD52
		public FPrimaryAssetType()
		{
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x0001DB5A File Offset: 0x0001BD5A
		protected override IntPtr GetUStructPtr()
		{
			return FPrimaryAssetType.StaticStruct();
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0001DB66 File Offset: 0x0001BD66
		[NullableContext(2)]
		public FPrimaryAssetType(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0001DB70 File Offset: 0x0001BD70
		public FPrimaryAssetType(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x0001DB7B File Offset: 0x0001BD7B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPrimaryAssetType(Pointer, false, true);
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x0001DB85 File Offset: 0x0001BD85
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPrimaryAssetType(Pointer, MemoryOwner);
		}

		// Token: 0x040005DB RID: 1499
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.PrimaryAssetType";

		// Token: 0x040005DC RID: 1500
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040005DD RID: 1501
		internal static int __PropertyOffset_Name;
	}
}
