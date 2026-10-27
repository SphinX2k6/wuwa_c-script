using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A9C RID: 6812
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.GlobalLightSetting")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGlobalLightSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019346 RID: 103238 RVA: 0x002548C8 File Offset: 0x00252AC8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGlobalLightSetting._ScriptStructPtr != 0) ? FGlobalLightSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.GlobalLightSetting", ref FGlobalLightSetting._ScriptStructPtr);
		}

		// Token: 0x1700646B RID: 25707
		// (get) Token: 0x06019347 RID: 103239 RVA: 0x002548EC File Offset: 0x00252AEC
		// (set) Token: 0x06019348 RID: 103240 RVA: 0x00254905 File Offset: 0x00252B05
		public unsafe bool bOverride_GlobalLightIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bOverride_GlobalLightIntensity) & FGlobalLightSetting.__PropertyMask_bOverride_GlobalLightIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bOverride_GlobalLightIntensity) = ((*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bOverride_GlobalLightIntensity) & ~FGlobalLightSetting.__PropertyMask_bOverride_GlobalLightIntensity) | (value ? FGlobalLightSetting.__PropertyMask_bOverride_GlobalLightIntensity : 0));
			}
		}

		// Token: 0x1700646C RID: 25708
		// (get) Token: 0x06019349 RID: 103241 RVA: 0x00254935 File Offset: 0x00252B35
		// (set) Token: 0x0601934A RID: 103242 RVA: 0x0025494E File Offset: 0x00252B4E
		public unsafe bool bEnableGlobalLightControl
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bEnableGlobalLightControl) & FGlobalLightSetting.__PropertyMask_bEnableGlobalLightControl) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bEnableGlobalLightControl) = ((*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bEnableGlobalLightControl) & ~FGlobalLightSetting.__PropertyMask_bEnableGlobalLightControl) | (value ? FGlobalLightSetting.__PropertyMask_bEnableGlobalLightControl : 0));
			}
		}

		// Token: 0x1700646D RID: 25709
		// (get) Token: 0x0601934B RID: 103243 RVA: 0x0025497E File Offset: 0x00252B7E
		// (set) Token: 0x0601934C RID: 103244 RVA: 0x0025498E File Offset: 0x00252B8E
		public unsafe float GlobalLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_GlobalLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_GlobalLightIntensity) = value;
			}
		}

		// Token: 0x1700646E RID: 25710
		// (get) Token: 0x0601934D RID: 103245 RVA: 0x0025499F File Offset: 0x00252B9F
		// (set) Token: 0x0601934E RID: 103246 RVA: 0x002549B8 File Offset: 0x00252BB8
		public unsafe bool bEnableGlobalEmssiveDay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bEnableGlobalEmssiveDay) & FGlobalLightSetting.__PropertyMask_bEnableGlobalEmssiveDay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bEnableGlobalEmssiveDay) = ((*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bEnableGlobalEmssiveDay) & ~FGlobalLightSetting.__PropertyMask_bEnableGlobalEmssiveDay) | (value ? FGlobalLightSetting.__PropertyMask_bEnableGlobalEmssiveDay : 0));
			}
		}

		// Token: 0x1700646F RID: 25711
		// (get) Token: 0x0601934F RID: 103247 RVA: 0x002549E8 File Offset: 0x00252BE8
		// (set) Token: 0x06019350 RID: 103248 RVA: 0x00254A01 File Offset: 0x00252C01
		public unsafe bool bEnableGlobalEmssiveNight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bEnableGlobalEmssiveNight) & FGlobalLightSetting.__PropertyMask_bEnableGlobalEmssiveNight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bEnableGlobalEmssiveNight) = ((*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bEnableGlobalEmssiveNight) & ~FGlobalLightSetting.__PropertyMask_bEnableGlobalEmssiveNight) | (value ? FGlobalLightSetting.__PropertyMask_bEnableGlobalEmssiveNight : 0));
			}
		}

		// Token: 0x17006470 RID: 25712
		// (get) Token: 0x06019351 RID: 103249 RVA: 0x00254A31 File Offset: 0x00252C31
		// (set) Token: 0x06019352 RID: 103250 RVA: 0x00254A4A File Offset: 0x00252C4A
		public unsafe bool UseLineaLerpEmissiveSwitch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_UseLineaLerpEmissiveSwitch) & FGlobalLightSetting.__PropertyMask_UseLineaLerpEmissiveSwitch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_UseLineaLerpEmissiveSwitch) = ((*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_UseLineaLerpEmissiveSwitch) & ~FGlobalLightSetting.__PropertyMask_UseLineaLerpEmissiveSwitch) | (value ? FGlobalLightSetting.__PropertyMask_UseLineaLerpEmissiveSwitch : 0));
			}
		}

		// Token: 0x17006471 RID: 25713
		// (get) Token: 0x06019353 RID: 103251 RVA: 0x00254A7A File Offset: 0x00252C7A
		// (set) Token: 0x06019354 RID: 103252 RVA: 0x00254A93 File Offset: 0x00252C93
		public unsafe bool bOverride_GlobalEmssiveIntensitySwitch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bOverride_GlobalEmssiveIntensitySwitch) & FGlobalLightSetting.__PropertyMask_bOverride_GlobalEmssiveIntensitySwitch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bOverride_GlobalEmssiveIntensitySwitch) = ((*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_bOverride_GlobalEmssiveIntensitySwitch) & ~FGlobalLightSetting.__PropertyMask_bOverride_GlobalEmssiveIntensitySwitch) | (value ? FGlobalLightSetting.__PropertyMask_bOverride_GlobalEmssiveIntensitySwitch : 0));
			}
		}

		// Token: 0x17006472 RID: 25714
		// (get) Token: 0x06019355 RID: 103253 RVA: 0x00254AC3 File Offset: 0x00252CC3
		// (set) Token: 0x06019356 RID: 103254 RVA: 0x00254AD3 File Offset: 0x00252CD3
		public unsafe float GlobalEmssiveIntensitySwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_GlobalEmssiveIntensitySwitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGlobalLightSetting.__PropertyOffset_GlobalEmssiveIntensitySwitch) = value;
			}
		}

		// Token: 0x06019357 RID: 103255 RVA: 0x00254AE4 File Offset: 0x00252CE4
		public FGlobalLightSetting()
		{
		}

		// Token: 0x06019358 RID: 103256 RVA: 0x00254AEC File Offset: 0x00252CEC
		public FGlobalLightSetting(bool bOverride_GlobalLightIntensity, bool bEnableGlobalLightControl, float GlobalLightIntensity, bool bEnableGlobalEmssiveDay, bool bEnableGlobalEmssiveNight, bool UseLineaLerpEmissiveSwitch, bool bOverride_GlobalEmssiveIntensitySwitch, float GlobalEmssiveIntensitySwitch)
		{
			this.bOverride_GlobalLightIntensity = bOverride_GlobalLightIntensity;
			this.bEnableGlobalLightControl = bEnableGlobalLightControl;
			this.GlobalLightIntensity = GlobalLightIntensity;
			this.bEnableGlobalEmssiveDay = bEnableGlobalEmssiveDay;
			this.bEnableGlobalEmssiveNight = bEnableGlobalEmssiveNight;
			this.UseLineaLerpEmissiveSwitch = UseLineaLerpEmissiveSwitch;
			this.bOverride_GlobalEmssiveIntensitySwitch = bOverride_GlobalEmssiveIntensitySwitch;
			this.GlobalEmssiveIntensitySwitch = GlobalEmssiveIntensitySwitch;
		}

		// Token: 0x06019359 RID: 103257 RVA: 0x00254B3C File Offset: 0x00252D3C
		protected override IntPtr GetUStructPtr()
		{
			return FGlobalLightSetting.StaticStruct();
		}

		// Token: 0x0601935A RID: 103258 RVA: 0x00254B48 File Offset: 0x00252D48
		[NullableContext(2)]
		public FGlobalLightSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601935B RID: 103259 RVA: 0x00254B52 File Offset: 0x00252D52
		public FGlobalLightSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601935C RID: 103260 RVA: 0x00254B5D File Offset: 0x00252D5D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGlobalLightSetting(Pointer, false, true);
		}

		// Token: 0x0601935D RID: 103261 RVA: 0x00254B67 File Offset: 0x00252D67
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGlobalLightSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400DBFD RID: 56317
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.GlobalLightSetting";

		// Token: 0x0400DBFE RID: 56318
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DBFF RID: 56319
		internal static int __PropertyOffset_bOverride_GlobalLightIntensity;

		// Token: 0x0400DC00 RID: 56320
		internal static byte __PropertyMask_bOverride_GlobalLightIntensity;

		// Token: 0x0400DC01 RID: 56321
		internal static int __PropertyOffset_bEnableGlobalLightControl;

		// Token: 0x0400DC02 RID: 56322
		internal static byte __PropertyMask_bEnableGlobalLightControl;

		// Token: 0x0400DC03 RID: 56323
		internal static int __PropertyOffset_GlobalLightIntensity;

		// Token: 0x0400DC04 RID: 56324
		internal static int __PropertyOffset_bEnableGlobalEmssiveDay;

		// Token: 0x0400DC05 RID: 56325
		internal static byte __PropertyMask_bEnableGlobalEmssiveDay;

		// Token: 0x0400DC06 RID: 56326
		internal static int __PropertyOffset_bEnableGlobalEmssiveNight;

		// Token: 0x0400DC07 RID: 56327
		internal static byte __PropertyMask_bEnableGlobalEmssiveNight;

		// Token: 0x0400DC08 RID: 56328
		internal static int __PropertyOffset_UseLineaLerpEmissiveSwitch;

		// Token: 0x0400DC09 RID: 56329
		internal static byte __PropertyMask_UseLineaLerpEmissiveSwitch;

		// Token: 0x0400DC0A RID: 56330
		internal static int __PropertyOffset_bOverride_GlobalEmssiveIntensitySwitch;

		// Token: 0x0400DC0B RID: 56331
		internal static byte __PropertyMask_bOverride_GlobalEmssiveIntensitySwitch;

		// Token: 0x0400DC0C RID: 56332
		internal static int __PropertyOffset_GlobalEmssiveIntensitySwitch;
	}
}
