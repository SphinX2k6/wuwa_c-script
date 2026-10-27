using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008BE RID: 2238
	[UnrealObjectPath("/Script/Engine.BlueprintDebugData")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 496)]
	public class FBlueprintDebugData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007A48 RID: 31304 RVA: 0x000AEE1E File Offset: 0x000AD01E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlueprintDebugData._ScriptStructPtr != 0) ? FBlueprintDebugData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlueprintDebugData", ref FBlueprintDebugData._ScriptStructPtr);
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x000AEE42 File Offset: 0x000AD042
		public FBlueprintDebugData()
		{
		}

		// Token: 0x06007A4A RID: 31306 RVA: 0x000AEE4A File Offset: 0x000AD04A
		protected override IntPtr GetUStructPtr()
		{
			return FBlueprintDebugData.StaticStruct();
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x000AEE56 File Offset: 0x000AD056
		[NullableContext(2)]
		public FBlueprintDebugData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x000AEE60 File Offset: 0x000AD060
		public FBlueprintDebugData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x000AEE6B File Offset: 0x000AD06B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlueprintDebugData(Pointer, false, true);
		}

		// Token: 0x06007A4E RID: 31310 RVA: 0x000AEE75 File Offset: 0x000AD075
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlueprintDebugData(Pointer, MemoryOwner);
		}

		// Token: 0x04003ACA RID: 15050
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BlueprintDebugData";

		// Token: 0x04003ACB RID: 15051
		private static IntPtr _ScriptStructPtr;
	}
}
