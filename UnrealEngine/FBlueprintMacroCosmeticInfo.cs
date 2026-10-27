using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008C9 RID: 2249
	[UnrealObjectPath("/Script/Engine.BlueprintMacroCosmeticInfo")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FBlueprintMacroCosmeticInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007AD1 RID: 31441 RVA: 0x000AFAC6 File Offset: 0x000ADCC6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlueprintMacroCosmeticInfo._ScriptStructPtr != 0) ? FBlueprintMacroCosmeticInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlueprintMacroCosmeticInfo", ref FBlueprintMacroCosmeticInfo._ScriptStructPtr);
		}

		// Token: 0x06007AD2 RID: 31442 RVA: 0x000AFAEA File Offset: 0x000ADCEA
		public FBlueprintMacroCosmeticInfo()
		{
		}

		// Token: 0x06007AD3 RID: 31443 RVA: 0x000AFAF2 File Offset: 0x000ADCF2
		protected override IntPtr GetUStructPtr()
		{
			return FBlueprintMacroCosmeticInfo.StaticStruct();
		}

		// Token: 0x06007AD4 RID: 31444 RVA: 0x000AFAFE File Offset: 0x000ADCFE
		[NullableContext(2)]
		public FBlueprintMacroCosmeticInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x000AFB08 File Offset: 0x000ADD08
		public FBlueprintMacroCosmeticInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x000AFB13 File Offset: 0x000ADD13
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlueprintMacroCosmeticInfo(Pointer, false, true);
		}

		// Token: 0x06007AD7 RID: 31447 RVA: 0x000AFB1D File Offset: 0x000ADD1D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlueprintMacroCosmeticInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003B10 RID: 15120
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BlueprintMacroCosmeticInfo";

		// Token: 0x04003B11 RID: 15121
		private static IntPtr _ScriptStructPtr;
	}
}
