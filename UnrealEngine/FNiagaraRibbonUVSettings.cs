using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025DA RID: 9690
	[UnrealObjectPath("/Script/Niagara.NiagaraRibbonUVSettings")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FNiagaraRibbonUVSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024043 RID: 147523 RVA: 0x00354A4A File Offset: 0x00352C4A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraRibbonUVSettings._ScriptStructPtr != 0) ? FNiagaraRibbonUVSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraRibbonUVSettings", ref FNiagaraRibbonUVSettings._ScriptStructPtr);
		}

		// Token: 0x17008A8D RID: 35469
		// (get) Token: 0x06024044 RID: 147524 RVA: 0x00354A6E File Offset: 0x00352C6E
		// (set) Token: 0x06024045 RID: 147525 RVA: 0x00354A7E File Offset: 0x00352C7E
		public unsafe ENiagaraRibbonUVEdgeMode LeadingEdgeMode
		{
			get
			{
				return (ENiagaraRibbonUVEdgeMode)(*(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_LeadingEdgeMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_LeadingEdgeMode) = (int)value;
			}
		}

		// Token: 0x17008A8E RID: 35470
		// (get) Token: 0x06024046 RID: 147526 RVA: 0x00354A8F File Offset: 0x00352C8F
		// (set) Token: 0x06024047 RID: 147527 RVA: 0x00354A9F File Offset: 0x00352C9F
		public unsafe ENiagaraRibbonUVEdgeMode TrailingEdgeMode
		{
			get
			{
				return (ENiagaraRibbonUVEdgeMode)(*(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_TrailingEdgeMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_TrailingEdgeMode) = (int)value;
			}
		}

		// Token: 0x17008A8F RID: 35471
		// (get) Token: 0x06024048 RID: 147528 RVA: 0x00354AB0 File Offset: 0x00352CB0
		// (set) Token: 0x06024049 RID: 147529 RVA: 0x00354AC0 File Offset: 0x00352CC0
		public unsafe ENiagaraRibbonUVDistributionMode DistributionMode
		{
			get
			{
				return (ENiagaraRibbonUVDistributionMode)(*(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_DistributionMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_DistributionMode) = (int)value;
			}
		}

		// Token: 0x17008A90 RID: 35472
		// (get) Token: 0x0602404A RID: 147530 RVA: 0x00354AD1 File Offset: 0x00352CD1
		// (set) Token: 0x0602404B RID: 147531 RVA: 0x00354AE1 File Offset: 0x00352CE1
		public unsafe float TilingLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_TilingLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_TilingLength) = value;
			}
		}

		// Token: 0x17008A91 RID: 35473
		// (get) Token: 0x0602404C RID: 147532 RVA: 0x00354AF2 File Offset: 0x00352CF2
		// (set) Token: 0x0602404D RID: 147533 RVA: 0x00354B06 File Offset: 0x00352D06
		public unsafe FVector2D Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x17008A92 RID: 35474
		// (get) Token: 0x0602404E RID: 147534 RVA: 0x00354B1B File Offset: 0x00352D1B
		// (set) Token: 0x0602404F RID: 147535 RVA: 0x00354B2F File Offset: 0x00352D2F
		public unsafe FVector2D Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17008A93 RID: 35475
		// (get) Token: 0x06024050 RID: 147536 RVA: 0x00354B44 File Offset: 0x00352D44
		// (set) Token: 0x06024051 RID: 147537 RVA: 0x00354B54 File Offset: 0x00352D54
		public unsafe bool bEnablePerParticleUOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_bEnablePerParticleUOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_bEnablePerParticleUOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008A94 RID: 35476
		// (get) Token: 0x06024052 RID: 147538 RVA: 0x00354B65 File Offset: 0x00352D65
		// (set) Token: 0x06024053 RID: 147539 RVA: 0x00354B75 File Offset: 0x00352D75
		public unsafe bool bEnablePerParticleVRangeOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_bEnablePerParticleVRangeOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraRibbonUVSettings.__PropertyOffset_bEnablePerParticleVRangeOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024054 RID: 147540 RVA: 0x00354B86 File Offset: 0x00352D86
		public FNiagaraRibbonUVSettings()
		{
		}

		// Token: 0x06024055 RID: 147541 RVA: 0x00354B90 File Offset: 0x00352D90
		public FNiagaraRibbonUVSettings(ENiagaraRibbonUVEdgeMode LeadingEdgeMode, ENiagaraRibbonUVEdgeMode TrailingEdgeMode, ENiagaraRibbonUVDistributionMode DistributionMode, float TilingLength, FVector2D Offset, FVector2D Scale, bool bEnablePerParticleUOverride, bool bEnablePerParticleVRangeOverride)
		{
			this.LeadingEdgeMode = LeadingEdgeMode;
			this.TrailingEdgeMode = TrailingEdgeMode;
			this.DistributionMode = DistributionMode;
			this.TilingLength = TilingLength;
			this.Offset = Offset;
			this.Scale = Scale;
			this.bEnablePerParticleUOverride = bEnablePerParticleUOverride;
			this.bEnablePerParticleVRangeOverride = bEnablePerParticleVRangeOverride;
		}

		// Token: 0x06024056 RID: 147542 RVA: 0x00354BE0 File Offset: 0x00352DE0
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraRibbonUVSettings.StaticStruct();
		}

		// Token: 0x06024057 RID: 147543 RVA: 0x00354BEC File Offset: 0x00352DEC
		[NullableContext(2)]
		public FNiagaraRibbonUVSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024058 RID: 147544 RVA: 0x00354BF6 File Offset: 0x00352DF6
		public FNiagaraRibbonUVSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024059 RID: 147545 RVA: 0x00354C01 File Offset: 0x00352E01
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraRibbonUVSettings(Pointer, false, true);
		}

		// Token: 0x0602405A RID: 147546 RVA: 0x00354C0B File Offset: 0x00352E0B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraRibbonUVSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04013511 RID: 79121
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraRibbonUVSettings";

		// Token: 0x04013512 RID: 79122
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013513 RID: 79123
		internal static int __PropertyOffset_LeadingEdgeMode;

		// Token: 0x04013514 RID: 79124
		internal static int __PropertyOffset_TrailingEdgeMode;

		// Token: 0x04013515 RID: 79125
		internal static int __PropertyOffset_DistributionMode;

		// Token: 0x04013516 RID: 79126
		internal static int __PropertyOffset_TilingLength;

		// Token: 0x04013517 RID: 79127
		internal static int __PropertyOffset_Offset;

		// Token: 0x04013518 RID: 79128
		internal static int __PropertyOffset_Scale;

		// Token: 0x04013519 RID: 79129
		internal static int __PropertyOffset_bEnablePerParticleUOverride;

		// Token: 0x0401351A RID: 79130
		internal static int __PropertyOffset_bEnablePerParticleVRangeOverride;
	}
}
