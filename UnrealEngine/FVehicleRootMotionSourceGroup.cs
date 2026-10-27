using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F3B RID: 7995
	[UnrealObjectPath("/Script/KuroVehicle.VehicleRootMotionSourceGroup")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FVehicleRootMotionSourceGroup : FRootMotionSourceGroup, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E6F7 RID: 124663 RVA: 0x002D3F8C File Offset: 0x002D218C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVehicleRootMotionSourceGroup._ScriptStructPtr != 0) ? FVehicleRootMotionSourceGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVehicle.VehicleRootMotionSourceGroup", ref FVehicleRootMotionSourceGroup._ScriptStructPtr);
		}

		// Token: 0x0601E6F8 RID: 124664 RVA: 0x002D3FB0 File Offset: 0x002D21B0
		public FVehicleRootMotionSourceGroup()
		{
		}

		// Token: 0x0601E6F9 RID: 124665 RVA: 0x002D3FB8 File Offset: 0x002D21B8
		[NullableContext(1)]
		public FVehicleRootMotionSourceGroup(bool bHasAdditiveSources, bool bHasOverrideSources, bool bHasOverrideSourcesWithIgnoreZAccumulate, bool bIsAdditiveVelocityApplied, FRootMotionSourceSettings LastAccumulatedSettings, FVector_NetQuantize10 LastPreAdditiveVelocity)
		{
			base.bHasAdditiveSources = bHasAdditiveSources;
			base.bHasOverrideSources = bHasOverrideSources;
			base.bHasOverrideSourcesWithIgnoreZAccumulate = bHasOverrideSourcesWithIgnoreZAccumulate;
			base.bIsAdditiveVelocityApplied = bIsAdditiveVelocityApplied;
			base.LastAccumulatedSettings = LastAccumulatedSettings;
			base.LastPreAdditiveVelocity = LastPreAdditiveVelocity;
		}

		// Token: 0x0601E6FA RID: 124666 RVA: 0x002D3FED File Offset: 0x002D21ED
		protected override IntPtr GetUStructPtr()
		{
			return FVehicleRootMotionSourceGroup.StaticStruct();
		}

		// Token: 0x0601E6FB RID: 124667 RVA: 0x002D3FF9 File Offset: 0x002D21F9
		[NullableContext(2)]
		public FVehicleRootMotionSourceGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E6FC RID: 124668 RVA: 0x002D4003 File Offset: 0x002D2203
		public FVehicleRootMotionSourceGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E6FD RID: 124669 RVA: 0x002D400E File Offset: 0x002D220E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVehicleRootMotionSourceGroup(Pointer, false, true);
		}

		// Token: 0x0601E6FE RID: 124670 RVA: 0x002D4018 File Offset: 0x002D2218
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVehicleRootMotionSourceGroup(Pointer, MemoryOwner);
		}

		// Token: 0x040106B1 RID: 67249
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroVehicle.VehicleRootMotionSourceGroup";

		// Token: 0x040106B2 RID: 67250
		private static IntPtr _ScriptStructPtr;
	}
}
