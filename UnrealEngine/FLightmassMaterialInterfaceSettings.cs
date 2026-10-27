using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D54 RID: 3412
	[UnrealObjectPath("/Script/Engine.LightmassMaterialInterfaceSettings")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FLightmassMaterialInterfaceSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B81F RID: 47135 RVA: 0x0010603A File Offset: 0x0010423A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLightmassMaterialInterfaceSettings._ScriptStructPtr != 0) ? FLightmassMaterialInterfaceSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LightmassMaterialInterfaceSettings", ref FLightmassMaterialInterfaceSettings._ScriptStructPtr);
		}

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x0600B820 RID: 47136 RVA: 0x0010605E File Offset: 0x0010425E
		// (set) Token: 0x0600B821 RID: 47137 RVA: 0x0010606E File Offset: 0x0010426E
		public unsafe float EmissiveBoost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_EmissiveBoost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_EmissiveBoost) = value;
			}
		}

		// Token: 0x17002A20 RID: 10784
		// (get) Token: 0x0600B822 RID: 47138 RVA: 0x0010607F File Offset: 0x0010427F
		// (set) Token: 0x0600B823 RID: 47139 RVA: 0x0010608F File Offset: 0x0010428F
		public unsafe float DiffuseBoost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_DiffuseBoost);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_DiffuseBoost) = value;
			}
		}

		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x0600B824 RID: 47140 RVA: 0x001060A0 File Offset: 0x001042A0
		// (set) Token: 0x0600B825 RID: 47141 RVA: 0x001060B0 File Offset: 0x001042B0
		public unsafe float ExportResolutionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_ExportResolutionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_ExportResolutionScale) = value;
			}
		}

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x0600B826 RID: 47142 RVA: 0x001060C1 File Offset: 0x001042C1
		// (set) Token: 0x0600B827 RID: 47143 RVA: 0x001060DA File Offset: 0x001042DA
		public unsafe bool bCastShadowAsMasked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bCastShadowAsMasked) & FLightmassMaterialInterfaceSettings.__PropertyMask_bCastShadowAsMasked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bCastShadowAsMasked) = ((*(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bCastShadowAsMasked) & ~FLightmassMaterialInterfaceSettings.__PropertyMask_bCastShadowAsMasked) | (value ? FLightmassMaterialInterfaceSettings.__PropertyMask_bCastShadowAsMasked : 0));
			}
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x0600B828 RID: 47144 RVA: 0x0010610A File Offset: 0x0010430A
		// (set) Token: 0x0600B829 RID: 47145 RVA: 0x00106123 File Offset: 0x00104323
		public unsafe bool bOverrideCastShadowAsMasked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bOverrideCastShadowAsMasked) & FLightmassMaterialInterfaceSettings.__PropertyMask_bOverrideCastShadowAsMasked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bOverrideCastShadowAsMasked) = ((*(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bOverrideCastShadowAsMasked) & ~FLightmassMaterialInterfaceSettings.__PropertyMask_bOverrideCastShadowAsMasked) | (value ? FLightmassMaterialInterfaceSettings.__PropertyMask_bOverrideCastShadowAsMasked : 0));
			}
		}

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x0600B82A RID: 47146 RVA: 0x00106153 File Offset: 0x00104353
		// (set) Token: 0x0600B82B RID: 47147 RVA: 0x0010616C File Offset: 0x0010436C
		public unsafe bool bOverrideEmissiveBoost
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bOverrideEmissiveBoost) & FLightmassMaterialInterfaceSettings.__PropertyMask_bOverrideEmissiveBoost) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bOverrideEmissiveBoost) = ((*(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bOverrideEmissiveBoost) & ~FLightmassMaterialInterfaceSettings.__PropertyMask_bOverrideEmissiveBoost) | (value ? FLightmassMaterialInterfaceSettings.__PropertyMask_bOverrideEmissiveBoost : 0));
			}
		}

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x0600B82C RID: 47148 RVA: 0x0010619C File Offset: 0x0010439C
		// (set) Token: 0x0600B82D RID: 47149 RVA: 0x001061B5 File Offset: 0x001043B5
		public unsafe bool bOverrideDiffuseBoost
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bOverrideDiffuseBoost) & FLightmassMaterialInterfaceSettings.__PropertyMask_bOverrideDiffuseBoost) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bOverrideDiffuseBoost) = ((*(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bOverrideDiffuseBoost) & ~FLightmassMaterialInterfaceSettings.__PropertyMask_bOverrideDiffuseBoost) | (value ? FLightmassMaterialInterfaceSettings.__PropertyMask_bOverrideDiffuseBoost : 0));
			}
		}

		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x0600B82E RID: 47150 RVA: 0x001061E5 File Offset: 0x001043E5
		// (set) Token: 0x0600B82F RID: 47151 RVA: 0x001061FE File Offset: 0x001043FE
		public unsafe bool bOverrideExportResolutionScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bOverrideExportResolutionScale) & FLightmassMaterialInterfaceSettings.__PropertyMask_bOverrideExportResolutionScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bOverrideExportResolutionScale) = ((*(base.NativePtr + (IntPtr)FLightmassMaterialInterfaceSettings.__PropertyOffset_bOverrideExportResolutionScale) & ~FLightmassMaterialInterfaceSettings.__PropertyMask_bOverrideExportResolutionScale) | (value ? FLightmassMaterialInterfaceSettings.__PropertyMask_bOverrideExportResolutionScale : 0));
			}
		}

		// Token: 0x0600B830 RID: 47152 RVA: 0x0010622E File Offset: 0x0010442E
		public FLightmassMaterialInterfaceSettings()
		{
		}

		// Token: 0x0600B831 RID: 47153 RVA: 0x00106238 File Offset: 0x00104438
		public FLightmassMaterialInterfaceSettings(float EmissiveBoost, float DiffuseBoost, float ExportResolutionScale, bool bCastShadowAsMasked, bool bOverrideCastShadowAsMasked, bool bOverrideEmissiveBoost, bool bOverrideDiffuseBoost, bool bOverrideExportResolutionScale)
		{
			this.EmissiveBoost = EmissiveBoost;
			this.DiffuseBoost = DiffuseBoost;
			this.ExportResolutionScale = ExportResolutionScale;
			this.bCastShadowAsMasked = bCastShadowAsMasked;
			this.bOverrideCastShadowAsMasked = bOverrideCastShadowAsMasked;
			this.bOverrideEmissiveBoost = bOverrideEmissiveBoost;
			this.bOverrideDiffuseBoost = bOverrideDiffuseBoost;
			this.bOverrideExportResolutionScale = bOverrideExportResolutionScale;
		}

		// Token: 0x0600B832 RID: 47154 RVA: 0x00106288 File Offset: 0x00104488
		protected override IntPtr GetUStructPtr()
		{
			return FLightmassMaterialInterfaceSettings.StaticStruct();
		}

		// Token: 0x0600B833 RID: 47155 RVA: 0x00106294 File Offset: 0x00104494
		[NullableContext(2)]
		public FLightmassMaterialInterfaceSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B834 RID: 47156 RVA: 0x0010629E File Offset: 0x0010449E
		public FLightmassMaterialInterfaceSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B835 RID: 47157 RVA: 0x001062A9 File Offset: 0x001044A9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLightmassMaterialInterfaceSettings(Pointer, false, true);
		}

		// Token: 0x0600B836 RID: 47158 RVA: 0x001062B3 File Offset: 0x001044B3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLightmassMaterialInterfaceSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400607A RID: 24698
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LightmassMaterialInterfaceSettings";

		// Token: 0x0400607B RID: 24699
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400607C RID: 24700
		internal static int __PropertyOffset_EmissiveBoost;

		// Token: 0x0400607D RID: 24701
		internal static int __PropertyOffset_DiffuseBoost;

		// Token: 0x0400607E RID: 24702
		internal static int __PropertyOffset_ExportResolutionScale;

		// Token: 0x0400607F RID: 24703
		internal static int __PropertyOffset_bCastShadowAsMasked;

		// Token: 0x04006080 RID: 24704
		internal static byte __PropertyMask_bCastShadowAsMasked;

		// Token: 0x04006081 RID: 24705
		internal static int __PropertyOffset_bOverrideCastShadowAsMasked;

		// Token: 0x04006082 RID: 24706
		internal static byte __PropertyMask_bOverrideCastShadowAsMasked;

		// Token: 0x04006083 RID: 24707
		internal static int __PropertyOffset_bOverrideEmissiveBoost;

		// Token: 0x04006084 RID: 24708
		internal static byte __PropertyMask_bOverrideEmissiveBoost;

		// Token: 0x04006085 RID: 24709
		internal static int __PropertyOffset_bOverrideDiffuseBoost;

		// Token: 0x04006086 RID: 24710
		internal static byte __PropertyMask_bOverrideDiffuseBoost;

		// Token: 0x04006087 RID: 24711
		internal static int __PropertyOffset_bOverrideExportResolutionScale;

		// Token: 0x04006088 RID: 24712
		internal static byte __PropertyMask_bOverrideExportResolutionScale;
	}
}
