using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010F8 RID: 4344
	[UnrealObjectPath("/Script/Engine.SkeletalMeshComponentClothTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSkeletalMeshComponentClothTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FC0C RID: 64524 RVA: 0x00174082 File Offset: 0x00172282
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshComponentClothTickFunction._ScriptStructPtr != 0) ? FSkeletalMeshComponentClothTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshComponentClothTickFunction", ref FSkeletalMeshComponentClothTickFunction._ScriptStructPtr);
		}

		// Token: 0x0600FC0D RID: 64525 RVA: 0x001740A6 File Offset: 0x001722A6
		public FSkeletalMeshComponentClothTickFunction()
		{
		}

		// Token: 0x0600FC0E RID: 64526 RVA: 0x001740AE File Offset: 0x001722AE
		public FSkeletalMeshComponentClothTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x0600FC0F RID: 64527 RVA: 0x001740EB File Offset: 0x001722EB
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshComponentClothTickFunction.StaticStruct();
		}

		// Token: 0x0600FC10 RID: 64528 RVA: 0x001740F7 File Offset: 0x001722F7
		[NullableContext(2)]
		public FSkeletalMeshComponentClothTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FC11 RID: 64529 RVA: 0x00174101 File Offset: 0x00172301
		public FSkeletalMeshComponentClothTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FC12 RID: 64530 RVA: 0x0017410C File Offset: 0x0017230C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshComponentClothTickFunction(Pointer, false, true);
		}

		// Token: 0x0600FC13 RID: 64531 RVA: 0x00174116 File Offset: 0x00172316
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshComponentClothTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x040087C8 RID: 34760
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkeletalMeshComponentClothTickFunction";

		// Token: 0x040087C9 RID: 34761
		private static IntPtr _ScriptStructPtr;
	}
}
