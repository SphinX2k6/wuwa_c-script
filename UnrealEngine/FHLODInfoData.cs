using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C2F RID: 3119
	[UnrealObjectPath("/Script/Engine.HLODInfoData")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FHLODInfoData : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009E2B RID: 40491 RVA: 0x000E0D5A File Offset: 0x000DEF5A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHLODInfoData._ScriptStructPtr != 0) ? FHLODInfoData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HLODInfoData", ref FHLODInfoData._ScriptStructPtr);
		}

		// Token: 0x06009E2C RID: 40492 RVA: 0x000E0D7E File Offset: 0x000DEF7E
		public FHLODInfoData()
		{
		}

		// Token: 0x06009E2D RID: 40493 RVA: 0x000E0D86 File Offset: 0x000DEF86
		public FHLODInfoData(FName GridName, FName ActorLable, int LODLevel, FGuid CellGuid, bool bIsCustom, bool bIsAlreadyCustom, FName ChangeReason, int SubActorNum, FBox HLODBounds, FName SubActorHLODLayer, bool bNew, FName Area, FName AssetsPath, FName ActorPackageName)
		{
		}

		// Token: 0x06009E2E RID: 40494 RVA: 0x000E0D8E File Offset: 0x000DEF8E
		protected override IntPtr GetUStructPtr()
		{
			return FHLODInfoData.StaticStruct();
		}

		// Token: 0x06009E2F RID: 40495 RVA: 0x000E0D9A File Offset: 0x000DEF9A
		[NullableContext(2)]
		public FHLODInfoData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009E30 RID: 40496 RVA: 0x000E0DA4 File Offset: 0x000DEFA4
		public FHLODInfoData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009E31 RID: 40497 RVA: 0x000E0DAF File Offset: 0x000DEFAF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHLODInfoData(Pointer, false, true);
		}

		// Token: 0x06009E32 RID: 40498 RVA: 0x000E0DB9 File Offset: 0x000DEFB9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHLODInfoData(Pointer, MemoryOwner);
		}

		// Token: 0x04005735 RID: 22325
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HLODInfoData";

		// Token: 0x04005736 RID: 22326
		private static IntPtr _ScriptStructPtr;
	}
}
