using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200260A RID: 9738
	[UnrealObjectPath("/Script/Niagara.NiagaraWorldManagerTickFunction")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FNiagaraWorldManagerTickFunction : FTickFunction, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060243AC RID: 148396 RVA: 0x0035A344 File Offset: 0x00358544
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraWorldManagerTickFunction._ScriptStructPtr != 0) ? FNiagaraWorldManagerTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraWorldManagerTickFunction", ref FNiagaraWorldManagerTickFunction._ScriptStructPtr);
		}

		// Token: 0x060243AD RID: 148397 RVA: 0x0035A368 File Offset: 0x00358568
		public FNiagaraWorldManagerTickFunction()
		{
		}

		// Token: 0x060243AE RID: 148398 RVA: 0x0035A370 File Offset: 0x00358570
		public FNiagaraWorldManagerTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			base.TickGroup = TickGroup;
			base.EndTickGroup = EndTickGroup;
			base.bTickEvenWhenPaused = bTickEvenWhenPaused;
			base.bCanEverTick = bCanEverTick;
			base.bStartWithTickEnabled = bStartWithTickEnabled;
			base.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			base.TickInterval = TickInterval;
		}

		// Token: 0x060243AF RID: 148399 RVA: 0x0035A3AD File Offset: 0x003585AD
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraWorldManagerTickFunction.StaticStruct();
		}

		// Token: 0x060243B0 RID: 148400 RVA: 0x0035A3B9 File Offset: 0x003585B9
		[NullableContext(2)]
		public FNiagaraWorldManagerTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060243B1 RID: 148401 RVA: 0x0035A3C3 File Offset: 0x003585C3
		public FNiagaraWorldManagerTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060243B2 RID: 148402 RVA: 0x0035A3CE File Offset: 0x003585CE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraWorldManagerTickFunction(Pointer, false, true);
		}

		// Token: 0x060243B3 RID: 148403 RVA: 0x0035A3D8 File Offset: 0x003585D8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraWorldManagerTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x0401370B RID: 79627
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraWorldManagerTickFunction";

		// Token: 0x0401370C RID: 79628
		private static IntPtr _ScriptStructPtr;
	}
}
