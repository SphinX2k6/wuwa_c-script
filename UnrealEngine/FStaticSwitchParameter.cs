using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200119D RID: 4509
	[UnrealObjectPath("/Script/Engine.StaticSwitchParameter")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FStaticSwitchParameter : FStaticParameterBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060109C2 RID: 68034 RVA: 0x001864FE File Offset: 0x001846FE
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStaticSwitchParameter._ScriptStructPtr != 0) ? FStaticSwitchParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StaticSwitchParameter", ref FStaticSwitchParameter._ScriptStructPtr);
		}

		// Token: 0x170040D7 RID: 16599
		// (get) Token: 0x060109C3 RID: 68035 RVA: 0x00186522 File Offset: 0x00184722
		// (set) Token: 0x060109C4 RID: 68036 RVA: 0x00186532 File Offset: 0x00184732
		public unsafe bool Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStaticSwitchParameter.__PropertyOffset_Value) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStaticSwitchParameter.__PropertyOffset_Value) = (value ? 1 : 0);
			}
		}

		// Token: 0x060109C5 RID: 68037 RVA: 0x00186543 File Offset: 0x00184743
		public FStaticSwitchParameter()
		{
		}

		// Token: 0x060109C6 RID: 68038 RVA: 0x0018654B File Offset: 0x0018474B
		[NullableContext(1)]
		public FStaticSwitchParameter(bool Value, FMaterialParameterInfo ParameterInfo, bool bOverride, FGuid ExpressionGUID)
		{
			this.Value = Value;
			base.ParameterInfo = ParameterInfo;
			base.bOverride = bOverride;
			base.ExpressionGUID = ExpressionGUID;
		}

		// Token: 0x060109C7 RID: 68039 RVA: 0x00186570 File Offset: 0x00184770
		protected override IntPtr GetUStructPtr()
		{
			return FStaticSwitchParameter.StaticStruct();
		}

		// Token: 0x060109C8 RID: 68040 RVA: 0x0018657C File Offset: 0x0018477C
		[NullableContext(2)]
		public FStaticSwitchParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060109C9 RID: 68041 RVA: 0x00186586 File Offset: 0x00184786
		public FStaticSwitchParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060109CA RID: 68042 RVA: 0x00186591 File Offset: 0x00184791
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStaticSwitchParameter(Pointer, false, true);
		}

		// Token: 0x060109CB RID: 68043 RVA: 0x0018659B File Offset: 0x0018479B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStaticSwitchParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04008E29 RID: 36393
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StaticSwitchParameter";

		// Token: 0x04008E2A RID: 36394
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008E2B RID: 36395
		internal static int __PropertyOffset_Value;
	}
}
