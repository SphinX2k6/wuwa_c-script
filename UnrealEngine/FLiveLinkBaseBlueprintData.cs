using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020021F2 RID: 8690
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkBaseBlueprintData")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FLiveLinkBaseBlueprintData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602121C RID: 135708 RVA: 0x0030DB1A File Offset: 0x0030BD1A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkBaseBlueprintData._ScriptStructPtr != 0) ? FLiveLinkBaseBlueprintData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkBaseBlueprintData", ref FLiveLinkBaseBlueprintData._ScriptStructPtr);
		}

		// Token: 0x0602121D RID: 135709 RVA: 0x0030DB3E File Offset: 0x0030BD3E
		public FLiveLinkBaseBlueprintData()
		{
		}

		// Token: 0x0602121E RID: 135710 RVA: 0x0030DB46 File Offset: 0x0030BD46
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkBaseBlueprintData.StaticStruct();
		}

		// Token: 0x0602121F RID: 135711 RVA: 0x0030DB52 File Offset: 0x0030BD52
		[NullableContext(2)]
		public FLiveLinkBaseBlueprintData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021220 RID: 135712 RVA: 0x0030DB5C File Offset: 0x0030BD5C
		public FLiveLinkBaseBlueprintData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021221 RID: 135713 RVA: 0x0030DB67 File Offset: 0x0030BD67
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkBaseBlueprintData(Pointer, false, true);
		}

		// Token: 0x06021222 RID: 135714 RVA: 0x0030DB71 File Offset: 0x0030BD71
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkBaseBlueprintData(Pointer, MemoryOwner);
		}

		// Token: 0x04011AE2 RID: 72418
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkBaseBlueprintData";

		// Token: 0x04011AE3 RID: 72419
		private static IntPtr _ScriptStructPtr;
	}
}
