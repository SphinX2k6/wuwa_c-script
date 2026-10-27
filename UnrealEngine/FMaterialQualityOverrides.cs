using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200228C RID: 8844
	[UnrealObjectPath("/Script/MaterialShaderQualitySettings.MaterialQualityOverrides")]
	[UnrealStructLayout(9, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 9)]
	public class FMaterialQualityOverrides : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060219CF RID: 137679 RVA: 0x0031BA9A File Offset: 0x00319C9A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialQualityOverrides._ScriptStructPtr != 0) ? FMaterialQualityOverrides._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MaterialShaderQualitySettings.MaterialQualityOverrides", ref FMaterialQualityOverrides._ScriptStructPtr);
		}

		// Token: 0x17008297 RID: 33431
		// (get) Token: 0x060219D0 RID: 137680 RVA: 0x0031BABE File Offset: 0x00319CBE
		// (set) Token: 0x060219D1 RID: 137681 RVA: 0x0031BACE File Offset: 0x00319CCE
		public unsafe bool bDiscardQualityDuringCook
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bDiscardQualityDuringCook) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bDiscardQualityDuringCook) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008298 RID: 33432
		// (get) Token: 0x060219D2 RID: 137682 RVA: 0x0031BADF File Offset: 0x00319CDF
		// (set) Token: 0x060219D3 RID: 137683 RVA: 0x0031BAEF File Offset: 0x00319CEF
		public unsafe bool bEnableOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bEnableOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bEnableOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008299 RID: 33433
		// (get) Token: 0x060219D4 RID: 137684 RVA: 0x0031BB00 File Offset: 0x00319D00
		// (set) Token: 0x060219D5 RID: 137685 RVA: 0x0031BB10 File Offset: 0x00319D10
		public unsafe bool bForceFullyRough
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bForceFullyRough) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bForceFullyRough) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700829A RID: 33434
		// (get) Token: 0x060219D6 RID: 137686 RVA: 0x0031BB21 File Offset: 0x00319D21
		// (set) Token: 0x060219D7 RID: 137687 RVA: 0x0031BB31 File Offset: 0x00319D31
		public unsafe bool bForceNonMetal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bForceNonMetal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bForceNonMetal) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700829B RID: 33435
		// (get) Token: 0x060219D8 RID: 137688 RVA: 0x0031BB42 File Offset: 0x00319D42
		// (set) Token: 0x060219D9 RID: 137689 RVA: 0x0031BB52 File Offset: 0x00319D52
		public unsafe bool bForceDisableLMDirectionality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bForceDisableLMDirectionality) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bForceDisableLMDirectionality) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700829C RID: 33436
		// (get) Token: 0x060219DA RID: 137690 RVA: 0x0031BB63 File Offset: 0x00319D63
		// (set) Token: 0x060219DB RID: 137691 RVA: 0x0031BB73 File Offset: 0x00319D73
		public unsafe bool bForceLQReflections
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bForceLQReflections) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bForceLQReflections) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700829D RID: 33437
		// (get) Token: 0x060219DC RID: 137692 RVA: 0x0031BB84 File Offset: 0x00319D84
		// (set) Token: 0x060219DD RID: 137693 RVA: 0x0031BB94 File Offset: 0x00319D94
		public unsafe bool bForceDisablePreintegratedGF
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bForceDisablePreintegratedGF) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bForceDisablePreintegratedGF) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700829E RID: 33438
		// (get) Token: 0x060219DE RID: 137694 RVA: 0x0031BBA5 File Offset: 0x00319DA5
		// (set) Token: 0x060219DF RID: 137695 RVA: 0x0031BBB5 File Offset: 0x00319DB5
		public unsafe bool bDisableMaterialNormalCalculation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bDisableMaterialNormalCalculation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_bDisableMaterialNormalCalculation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700829F RID: 33439
		// (get) Token: 0x060219E0 RID: 137696 RVA: 0x0031BBC6 File Offset: 0x00319DC6
		// (set) Token: 0x060219E1 RID: 137697 RVA: 0x0031BBD6 File Offset: 0x00319DD6
		public unsafe EMobileShadowQuality MobileShadowQuality
		{
			get
			{
				return (EMobileShadowQuality)(*(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_MobileShadowQuality));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialQualityOverrides.__PropertyOffset_MobileShadowQuality) = (byte)value;
			}
		}

		// Token: 0x060219E2 RID: 137698 RVA: 0x0031BBE7 File Offset: 0x00319DE7
		public FMaterialQualityOverrides()
		{
		}

		// Token: 0x060219E3 RID: 137699 RVA: 0x0031BBF0 File Offset: 0x00319DF0
		public FMaterialQualityOverrides(bool bDiscardQualityDuringCook, bool bEnableOverride, bool bForceFullyRough, bool bForceNonMetal, bool bForceDisableLMDirectionality, bool bForceLQReflections, bool bForceDisablePreintegratedGF, bool bDisableMaterialNormalCalculation, EMobileShadowQuality MobileShadowQuality)
		{
			this.bDiscardQualityDuringCook = bDiscardQualityDuringCook;
			this.bEnableOverride = bEnableOverride;
			this.bForceFullyRough = bForceFullyRough;
			this.bForceNonMetal = bForceNonMetal;
			this.bForceDisableLMDirectionality = bForceDisableLMDirectionality;
			this.bForceLQReflections = bForceLQReflections;
			this.bForceDisablePreintegratedGF = bForceDisablePreintegratedGF;
			this.bDisableMaterialNormalCalculation = bDisableMaterialNormalCalculation;
			this.MobileShadowQuality = MobileShadowQuality;
		}

		// Token: 0x060219E4 RID: 137700 RVA: 0x0031BC48 File Offset: 0x00319E48
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialQualityOverrides.StaticStruct();
		}

		// Token: 0x060219E5 RID: 137701 RVA: 0x0031BC54 File Offset: 0x00319E54
		[NullableContext(2)]
		public FMaterialQualityOverrides(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060219E6 RID: 137702 RVA: 0x0031BC5E File Offset: 0x00319E5E
		public FMaterialQualityOverrides(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060219E7 RID: 137703 RVA: 0x0031BC69 File Offset: 0x00319E69
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialQualityOverrides(Pointer, false, true);
		}

		// Token: 0x060219E8 RID: 137704 RVA: 0x0031BC73 File Offset: 0x00319E73
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialQualityOverrides(Pointer, MemoryOwner);
		}

		// Token: 0x04011F33 RID: 73523
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MaterialShaderQualitySettings.MaterialQualityOverrides";

		// Token: 0x04011F34 RID: 73524
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011F35 RID: 73525
		internal static int __PropertyOffset_bDiscardQualityDuringCook;

		// Token: 0x04011F36 RID: 73526
		internal static int __PropertyOffset_bEnableOverride;

		// Token: 0x04011F37 RID: 73527
		internal static int __PropertyOffset_bForceFullyRough;

		// Token: 0x04011F38 RID: 73528
		internal static int __PropertyOffset_bForceNonMetal;

		// Token: 0x04011F39 RID: 73529
		internal static int __PropertyOffset_bForceDisableLMDirectionality;

		// Token: 0x04011F3A RID: 73530
		internal static int __PropertyOffset_bForceLQReflections;

		// Token: 0x04011F3B RID: 73531
		internal static int __PropertyOffset_bForceDisablePreintegratedGF;

		// Token: 0x04011F3C RID: 73532
		internal static int __PropertyOffset_bDisableMaterialNormalCalculation;

		// Token: 0x04011F3D RID: 73533
		internal static int __PropertyOffset_MobileShadowQuality;
	}
}
