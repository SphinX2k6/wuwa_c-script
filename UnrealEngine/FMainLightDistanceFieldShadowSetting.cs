using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001BFB RID: 7163
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.MainLightDistanceFieldShadowSetting")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FMainLightDistanceFieldShadowSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BA0D RID: 113165 RVA: 0x0028A7E8 File Offset: 0x002889E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMainLightDistanceFieldShadowSetting._ScriptStructPtr != 0) ? FMainLightDistanceFieldShadowSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.MainLightDistanceFieldShadowSetting", ref FMainLightDistanceFieldShadowSetting._ScriptStructPtr);
		}

		// Token: 0x17006F5E RID: 28510
		// (get) Token: 0x0601BA0E RID: 113166 RVA: 0x0028A80C File Offset: 0x00288A0C
		// (set) Token: 0x0601BA0F RID: 113167 RVA: 0x0028A825 File Offset: 0x00288A25
		public unsafe bool bOverride_bEnableDistanceFieldShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_bOverride_bEnableDistanceFieldShadow) & FMainLightDistanceFieldShadowSetting.__PropertyMask_bOverride_bEnableDistanceFieldShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_bOverride_bEnableDistanceFieldShadow) = ((*(base.NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_bOverride_bEnableDistanceFieldShadow) & ~FMainLightDistanceFieldShadowSetting.__PropertyMask_bOverride_bEnableDistanceFieldShadow) | (value ? FMainLightDistanceFieldShadowSetting.__PropertyMask_bOverride_bEnableDistanceFieldShadow : 0));
			}
		}

		// Token: 0x17006F5F RID: 28511
		// (get) Token: 0x0601BA10 RID: 113168 RVA: 0x0028A855 File Offset: 0x00288A55
		// (set) Token: 0x0601BA11 RID: 113169 RVA: 0x0028A86E File Offset: 0x00288A6E
		public unsafe bool bOverride_DistanceFieldShadowDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_bOverride_DistanceFieldShadowDistance) & FMainLightDistanceFieldShadowSetting.__PropertyMask_bOverride_DistanceFieldShadowDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_bOverride_DistanceFieldShadowDistance) = ((*(base.NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_bOverride_DistanceFieldShadowDistance) & ~FMainLightDistanceFieldShadowSetting.__PropertyMask_bOverride_DistanceFieldShadowDistance) | (value ? FMainLightDistanceFieldShadowSetting.__PropertyMask_bOverride_DistanceFieldShadowDistance : 0));
			}
		}

		// Token: 0x17006F60 RID: 28512
		// (get) Token: 0x0601BA12 RID: 113170 RVA: 0x0028A89E File Offset: 0x00288A9E
		// (set) Token: 0x0601BA13 RID: 113171 RVA: 0x0028A8B7 File Offset: 0x00288AB7
		public unsafe bool bOverride_TraceDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_bOverride_TraceDistance) & FMainLightDistanceFieldShadowSetting.__PropertyMask_bOverride_TraceDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_bOverride_TraceDistance) = ((*(base.NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_bOverride_TraceDistance) & ~FMainLightDistanceFieldShadowSetting.__PropertyMask_bOverride_TraceDistance) | (value ? FMainLightDistanceFieldShadowSetting.__PropertyMask_bOverride_TraceDistance : 0));
			}
		}

		// Token: 0x17006F61 RID: 28513
		// (get) Token: 0x0601BA14 RID: 113172 RVA: 0x0028A8E7 File Offset: 0x00288AE7
		// (set) Token: 0x0601BA15 RID: 113173 RVA: 0x0028A8F7 File Offset: 0x00288AF7
		public unsafe bool bEnableDistanceFieldShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_bEnableDistanceFieldShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_bEnableDistanceFieldShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006F62 RID: 28514
		// (get) Token: 0x0601BA16 RID: 113174 RVA: 0x0028A908 File Offset: 0x00288B08
		// (set) Token: 0x0601BA17 RID: 113175 RVA: 0x0028A918 File Offset: 0x00288B18
		public unsafe float DistanceFieldShadowDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_DistanceFieldShadowDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_DistanceFieldShadowDistance) = value;
			}
		}

		// Token: 0x17006F63 RID: 28515
		// (get) Token: 0x0601BA18 RID: 113176 RVA: 0x0028A929 File Offset: 0x00288B29
		// (set) Token: 0x0601BA19 RID: 113177 RVA: 0x0028A939 File Offset: 0x00288B39
		public unsafe float TraceDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_TraceDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMainLightDistanceFieldShadowSetting.__PropertyOffset_TraceDistance) = value;
			}
		}

		// Token: 0x0601BA1A RID: 113178 RVA: 0x0028A94A File Offset: 0x00288B4A
		public FMainLightDistanceFieldShadowSetting()
		{
		}

		// Token: 0x0601BA1B RID: 113179 RVA: 0x0028A952 File Offset: 0x00288B52
		public FMainLightDistanceFieldShadowSetting(bool bOverride_bEnableDistanceFieldShadow, bool bOverride_DistanceFieldShadowDistance, bool bOverride_TraceDistance, bool bEnableDistanceFieldShadow, float DistanceFieldShadowDistance, float TraceDistance)
		{
			this.bOverride_bEnableDistanceFieldShadow = bOverride_bEnableDistanceFieldShadow;
			this.bOverride_DistanceFieldShadowDistance = bOverride_DistanceFieldShadowDistance;
			this.bOverride_TraceDistance = bOverride_TraceDistance;
			this.bEnableDistanceFieldShadow = bEnableDistanceFieldShadow;
			this.DistanceFieldShadowDistance = DistanceFieldShadowDistance;
			this.TraceDistance = TraceDistance;
		}

		// Token: 0x0601BA1C RID: 113180 RVA: 0x0028A987 File Offset: 0x00288B87
		protected override IntPtr GetUStructPtr()
		{
			return FMainLightDistanceFieldShadowSetting.StaticStruct();
		}

		// Token: 0x0601BA1D RID: 113181 RVA: 0x0028A993 File Offset: 0x00288B93
		[NullableContext(2)]
		public FMainLightDistanceFieldShadowSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BA1E RID: 113182 RVA: 0x0028A99D File Offset: 0x00288B9D
		public FMainLightDistanceFieldShadowSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BA1F RID: 113183 RVA: 0x0028A9A8 File Offset: 0x00288BA8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMainLightDistanceFieldShadowSetting(Pointer, false, true);
		}

		// Token: 0x0601BA20 RID: 113184 RVA: 0x0028A9B2 File Offset: 0x00288BB2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMainLightDistanceFieldShadowSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400EDB0 RID: 60848
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.MainLightDistanceFieldShadowSetting";

		// Token: 0x0400EDB1 RID: 60849
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EDB2 RID: 60850
		internal static int __PropertyOffset_bOverride_bEnableDistanceFieldShadow;

		// Token: 0x0400EDB3 RID: 60851
		internal static byte __PropertyMask_bOverride_bEnableDistanceFieldShadow;

		// Token: 0x0400EDB4 RID: 60852
		internal static int __PropertyOffset_bOverride_DistanceFieldShadowDistance;

		// Token: 0x0400EDB5 RID: 60853
		internal static byte __PropertyMask_bOverride_DistanceFieldShadowDistance;

		// Token: 0x0400EDB6 RID: 60854
		internal static int __PropertyOffset_bOverride_TraceDistance;

		// Token: 0x0400EDB7 RID: 60855
		internal static byte __PropertyMask_bOverride_TraceDistance;

		// Token: 0x0400EDB8 RID: 60856
		internal static int __PropertyOffset_bEnableDistanceFieldShadow;

		// Token: 0x0400EDB9 RID: 60857
		internal static int __PropertyOffset_DistanceFieldShadowDistance;

		// Token: 0x0400EDBA RID: 60858
		internal static int __PropertyOffset_TraceDistance;
	}
}
