using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FCA RID: 4042
	[UnrealObjectPath("/Script/Engine.ParticleSystemWorldManagerTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FParticleSystemWorldManagerTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DA11 RID: 55825 RVA: 0x00141DE3 File Offset: 0x0013FFE3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParticleSystemWorldManagerTickFunction._ScriptStructPtr != 0) ? FParticleSystemWorldManagerTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ParticleSystemWorldManagerTickFunction", ref FParticleSystemWorldManagerTickFunction._ScriptStructPtr);
		}

		// Token: 0x0600DA12 RID: 55826 RVA: 0x00141E07 File Offset: 0x00140007
		public FParticleSystemWorldManagerTickFunction()
		{
		}

		// Token: 0x0600DA13 RID: 55827 RVA: 0x00141E0F File Offset: 0x0014000F
		public FParticleSystemWorldManagerTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x0600DA14 RID: 55828 RVA: 0x00141E4C File Offset: 0x0014004C
		protected override IntPtr GetUStructPtr()
		{
			return FParticleSystemWorldManagerTickFunction.StaticStruct();
		}

		// Token: 0x0600DA15 RID: 55829 RVA: 0x00141E58 File Offset: 0x00140058
		[NullableContext(2)]
		public FParticleSystemWorldManagerTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DA16 RID: 55830 RVA: 0x00141E62 File Offset: 0x00140062
		public FParticleSystemWorldManagerTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DA17 RID: 55831 RVA: 0x00141E6D File Offset: 0x0014006D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParticleSystemWorldManagerTickFunction(Pointer, false, true);
		}

		// Token: 0x0600DA18 RID: 55832 RVA: 0x00141E77 File Offset: 0x00140077
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParticleSystemWorldManagerTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x0400763D RID: 30269
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleSystemWorldManagerTickFunction";

		// Token: 0x0400763E RID: 30270
		private static IntPtr _ScriptStructPtr;
	}
}
