using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D58 RID: 3416
	[UnrealObjectPath("/Script/Engine.LightmassPrimitiveSettings")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FLightmassPrimitiveSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B84D RID: 47181 RVA: 0x0010648B File Offset: 0x0010468B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLightmassPrimitiveSettings._ScriptStructPtr != 0) ? FLightmassPrimitiveSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LightmassPrimitiveSettings", ref FLightmassPrimitiveSettings._ScriptStructPtr);
		}

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x0600B84E RID: 47182 RVA: 0x001064AF File Offset: 0x001046AF
		// (set) Token: 0x0600B84F RID: 47183 RVA: 0x001064C8 File Offset: 0x001046C8
		public unsafe bool bUseTwoSidedLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_bUseTwoSidedLighting) & FLightmassPrimitiveSettings.__PropertyMask_bUseTwoSidedLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_bUseTwoSidedLighting) = ((*(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_bUseTwoSidedLighting) & ~FLightmassPrimitiveSettings.__PropertyMask_bUseTwoSidedLighting) | (value ? FLightmassPrimitiveSettings.__PropertyMask_bUseTwoSidedLighting : 0));
			}
		}

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x0600B850 RID: 47184 RVA: 0x001064F8 File Offset: 0x001046F8
		// (set) Token: 0x0600B851 RID: 47185 RVA: 0x00106511 File Offset: 0x00104711
		public unsafe bool bShadowIndirectOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_bShadowIndirectOnly) & FLightmassPrimitiveSettings.__PropertyMask_bShadowIndirectOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_bShadowIndirectOnly) = ((*(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_bShadowIndirectOnly) & ~FLightmassPrimitiveSettings.__PropertyMask_bShadowIndirectOnly) | (value ? FLightmassPrimitiveSettings.__PropertyMask_bShadowIndirectOnly : 0));
			}
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x0600B852 RID: 47186 RVA: 0x00106541 File Offset: 0x00104741
		// (set) Token: 0x0600B853 RID: 47187 RVA: 0x0010655A File Offset: 0x0010475A
		public unsafe bool bUseEmissiveForStaticLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_bUseEmissiveForStaticLighting) & FLightmassPrimitiveSettings.__PropertyMask_bUseEmissiveForStaticLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_bUseEmissiveForStaticLighting) = ((*(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_bUseEmissiveForStaticLighting) & ~FLightmassPrimitiveSettings.__PropertyMask_bUseEmissiveForStaticLighting) | (value ? FLightmassPrimitiveSettings.__PropertyMask_bUseEmissiveForStaticLighting : 0));
			}
		}

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x0600B854 RID: 47188 RVA: 0x0010658A File Offset: 0x0010478A
		// (set) Token: 0x0600B855 RID: 47189 RVA: 0x001065A3 File Offset: 0x001047A3
		public unsafe bool bUseVertexNormalForHemisphereGather
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_bUseVertexNormalForHemisphereGather) & FLightmassPrimitiveSettings.__PropertyMask_bUseVertexNormalForHemisphereGather) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_bUseVertexNormalForHemisphereGather) = ((*(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_bUseVertexNormalForHemisphereGather) & ~FLightmassPrimitiveSettings.__PropertyMask_bUseVertexNormalForHemisphereGather) | (value ? FLightmassPrimitiveSettings.__PropertyMask_bUseVertexNormalForHemisphereGather : 0));
			}
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x0600B856 RID: 47190 RVA: 0x001065D3 File Offset: 0x001047D3
		// (set) Token: 0x0600B857 RID: 47191 RVA: 0x001065E3 File Offset: 0x001047E3
		public unsafe float EmissiveLightFalloffExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_EmissiveLightFalloffExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_EmissiveLightFalloffExponent) = value;
			}
		}

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x0600B858 RID: 47192 RVA: 0x001065F4 File Offset: 0x001047F4
		// (set) Token: 0x0600B859 RID: 47193 RVA: 0x00106604 File Offset: 0x00104804
		public unsafe float EmissiveLightExplicitInfluenceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_EmissiveLightExplicitInfluenceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_EmissiveLightExplicitInfluenceRadius) = value;
			}
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x0600B85A RID: 47194 RVA: 0x00106615 File Offset: 0x00104815
		// (set) Token: 0x0600B85B RID: 47195 RVA: 0x00106625 File Offset: 0x00104825
		public unsafe float EmissiveBoost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_EmissiveBoost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_EmissiveBoost) = value;
			}
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x0600B85C RID: 47196 RVA: 0x00106636 File Offset: 0x00104836
		// (set) Token: 0x0600B85D RID: 47197 RVA: 0x00106646 File Offset: 0x00104846
		public unsafe float DiffuseBoost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_DiffuseBoost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_DiffuseBoost) = value;
			}
		}

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x0600B85E RID: 47198 RVA: 0x00106657 File Offset: 0x00104857
		// (set) Token: 0x0600B85F RID: 47199 RVA: 0x00106667 File Offset: 0x00104867
		public unsafe float FullyOccludedSamplesFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_FullyOccludedSamplesFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassPrimitiveSettings.__PropertyOffset_FullyOccludedSamplesFraction) = value;
			}
		}

		// Token: 0x0600B860 RID: 47200 RVA: 0x00106678 File Offset: 0x00104878
		public FLightmassPrimitiveSettings()
		{
		}

		// Token: 0x0600B861 RID: 47201 RVA: 0x00106680 File Offset: 0x00104880
		public FLightmassPrimitiveSettings(bool bUseTwoSidedLighting, bool bShadowIndirectOnly, bool bUseEmissiveForStaticLighting, bool bUseVertexNormalForHemisphereGather, float EmissiveLightFalloffExponent, float EmissiveLightExplicitInfluenceRadius, float EmissiveBoost, float DiffuseBoost, float FullyOccludedSamplesFraction)
		{
			this.bUseTwoSidedLighting = bUseTwoSidedLighting;
			this.bShadowIndirectOnly = bShadowIndirectOnly;
			this.bUseEmissiveForStaticLighting = bUseEmissiveForStaticLighting;
			this.bUseVertexNormalForHemisphereGather = bUseVertexNormalForHemisphereGather;
			this.EmissiveLightFalloffExponent = EmissiveLightFalloffExponent;
			this.EmissiveLightExplicitInfluenceRadius = EmissiveLightExplicitInfluenceRadius;
			this.EmissiveBoost = EmissiveBoost;
			this.DiffuseBoost = DiffuseBoost;
			this.FullyOccludedSamplesFraction = FullyOccludedSamplesFraction;
		}

		// Token: 0x0600B862 RID: 47202 RVA: 0x001066D8 File Offset: 0x001048D8
		protected override IntPtr GetUStructPtr()
		{
			return FLightmassPrimitiveSettings.StaticStruct();
		}

		// Token: 0x0600B863 RID: 47203 RVA: 0x001066E4 File Offset: 0x001048E4
		[NullableContext(2)]
		public FLightmassPrimitiveSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B864 RID: 47204 RVA: 0x001066EE File Offset: 0x001048EE
		public FLightmassPrimitiveSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B865 RID: 47205 RVA: 0x001066F9 File Offset: 0x001048F9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLightmassPrimitiveSettings(Pointer, false, true);
		}

		// Token: 0x0600B866 RID: 47206 RVA: 0x00106703 File Offset: 0x00104903
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLightmassPrimitiveSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04006093 RID: 24723
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LightmassPrimitiveSettings";

		// Token: 0x04006094 RID: 24724
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006095 RID: 24725
		internal static int __PropertyOffset_bUseTwoSidedLighting;

		// Token: 0x04006096 RID: 24726
		internal static byte __PropertyMask_bUseTwoSidedLighting;

		// Token: 0x04006097 RID: 24727
		internal static int __PropertyOffset_bShadowIndirectOnly;

		// Token: 0x04006098 RID: 24728
		internal static byte __PropertyMask_bShadowIndirectOnly;

		// Token: 0x04006099 RID: 24729
		internal static int __PropertyOffset_bUseEmissiveForStaticLighting;

		// Token: 0x0400609A RID: 24730
		internal static byte __PropertyMask_bUseEmissiveForStaticLighting;

		// Token: 0x0400609B RID: 24731
		internal static int __PropertyOffset_bUseVertexNormalForHemisphereGather;

		// Token: 0x0400609C RID: 24732
		internal static byte __PropertyMask_bUseVertexNormalForHemisphereGather;

		// Token: 0x0400609D RID: 24733
		internal static int __PropertyOffset_EmissiveLightFalloffExponent;

		// Token: 0x0400609E RID: 24734
		internal static int __PropertyOffset_EmissiveLightExplicitInfluenceRadius;

		// Token: 0x0400609F RID: 24735
		internal static int __PropertyOffset_EmissiveBoost;

		// Token: 0x040060A0 RID: 24736
		internal static int __PropertyOffset_DiffuseBoost;

		// Token: 0x040060A1 RID: 24737
		internal static int __PropertyOffset_FullyOccludedSamplesFraction;
	}
}
