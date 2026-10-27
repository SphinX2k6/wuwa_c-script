using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200166B RID: 5739
	[UnrealObjectPath("/Script/KuroAnim.KuroQuadrupedIK_DebugSettings")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroQuadrupedIK_DebugSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014CB4 RID: 85172 RVA: 0x001E9478 File Offset: 0x001E7678
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroQuadrupedIK_DebugSettings._ScriptStructPtr != 0) ? FKuroQuadrupedIK_DebugSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroQuadrupedIK_DebugSettings", ref FKuroQuadrupedIK_DebugSettings._ScriptStructPtr);
		}

		// Token: 0x17005245 RID: 21061
		// (get) Token: 0x06014CB5 RID: 85173 RVA: 0x001E949C File Offset: 0x001E769C
		// (set) Token: 0x06014CB6 RID: 85174 RVA: 0x001E94AC File Offset: 0x001E76AC
		public unsafe bool EnableDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_EnableDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_EnableDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005246 RID: 21062
		// (get) Token: 0x06014CB7 RID: 85175 RVA: 0x001E94BD File Offset: 0x001E76BD
		// (set) Token: 0x06014CB8 RID: 85176 RVA: 0x001E94CD File Offset: 0x001E76CD
		public unsafe bool DisplayTrace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_DisplayTrace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_DisplayTrace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005247 RID: 21063
		// (get) Token: 0x06014CB9 RID: 85177 RVA: 0x001E94DE File Offset: 0x001E76DE
		// (set) Token: 0x06014CBA RID: 85178 RVA: 0x001E94EE File Offset: 0x001E76EE
		public unsafe float DebugDrawLifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_DebugDrawLifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_DebugDrawLifeTime) = value;
			}
		}

		// Token: 0x17005248 RID: 21064
		// (get) Token: 0x06014CBB RID: 85179 RVA: 0x001E94FF File Offset: 0x001E76FF
		// (set) Token: 0x06014CBC RID: 85180 RVA: 0x001E950F File Offset: 0x001E770F
		public unsafe bool DebugDrawOnTop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_DebugDrawOnTop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_DebugDrawOnTop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005249 RID: 21065
		// (get) Token: 0x06014CBD RID: 85181 RVA: 0x001E9520 File Offset: 0x001E7720
		// (set) Token: 0x06014CBE RID: 85182 RVA: 0x001E9530 File Offset: 0x001E7730
		public unsafe float DebugDrawScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_DebugDrawScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_DebugDrawScale) = value;
			}
		}

		// Token: 0x1700524A RID: 21066
		// (get) Token: 0x06014CBF RID: 85183 RVA: 0x001E9541 File Offset: 0x001E7741
		// (set) Token: 0x06014CC0 RID: 85184 RVA: 0x001E9551 File Offset: 0x001E7751
		public unsafe float CharacterDebugSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_CharacterDebugSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_CharacterDebugSpeed) = value;
			}
		}

		// Token: 0x1700524B RID: 21067
		// (get) Token: 0x06014CC1 RID: 85185 RVA: 0x001E9562 File Offset: 0x001E7762
		// (set) Token: 0x06014CC2 RID: 85186 RVA: 0x001E9572 File Offset: 0x001E7772
		public unsafe bool SpineWorkOutsidePIE
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_SpineWorkOutsidePIE) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_SpineWorkOutsidePIE) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700524C RID: 21068
		// (get) Token: 0x06014CC3 RID: 85187 RVA: 0x001E9583 File Offset: 0x001E7783
		// (set) Token: 0x06014CC4 RID: 85188 RVA: 0x001E9593 File Offset: 0x001E7793
		public unsafe bool DisplaySpineSolver
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_DisplaySpineSolver) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_DisplaySpineSolver) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700524D RID: 21069
		// (get) Token: 0x06014CC5 RID: 85189 RVA: 0x001E95A4 File Offset: 0x001E77A4
		// (set) Token: 0x06014CC6 RID: 85190 RVA: 0x001E95B4 File Offset: 0x001E77B4
		public unsafe bool FeetWorkOutsidePIE
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_FeetWorkOutsidePIE) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_FeetWorkOutsidePIE) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700524E RID: 21070
		// (get) Token: 0x06014CC7 RID: 85191 RVA: 0x001E95C5 File Offset: 0x001E77C5
		// (set) Token: 0x06014CC8 RID: 85192 RVA: 0x001E95D5 File Offset: 0x001E77D5
		public unsafe bool DisplayFeetTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_DisplayFeetTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_DebugSettings.__PropertyOffset_DisplayFeetTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014CC9 RID: 85193 RVA: 0x001E95E6 File Offset: 0x001E77E6
		public FKuroQuadrupedIK_DebugSettings()
		{
		}

		// Token: 0x06014CCA RID: 85194 RVA: 0x001E95F0 File Offset: 0x001E77F0
		public FKuroQuadrupedIK_DebugSettings(bool EnableDebug, bool DisplayTrace, float DebugDrawLifeTime, bool DebugDrawOnTop, float DebugDrawScale, float CharacterDebugSpeed, bool SpineWorkOutsidePIE, bool DisplaySpineSolver, bool FeetWorkOutsidePIE, bool DisplayFeetTarget)
		{
			this.EnableDebug = EnableDebug;
			this.DisplayTrace = DisplayTrace;
			this.DebugDrawLifeTime = DebugDrawLifeTime;
			this.DebugDrawOnTop = DebugDrawOnTop;
			this.DebugDrawScale = DebugDrawScale;
			this.CharacterDebugSpeed = CharacterDebugSpeed;
			this.SpineWorkOutsidePIE = SpineWorkOutsidePIE;
			this.DisplaySpineSolver = DisplaySpineSolver;
			this.FeetWorkOutsidePIE = FeetWorkOutsidePIE;
			this.DisplayFeetTarget = DisplayFeetTarget;
		}

		// Token: 0x06014CCB RID: 85195 RVA: 0x001E9650 File Offset: 0x001E7850
		protected override IntPtr GetUStructPtr()
		{
			return FKuroQuadrupedIK_DebugSettings.StaticStruct();
		}

		// Token: 0x06014CCC RID: 85196 RVA: 0x001E965C File Offset: 0x001E785C
		[NullableContext(2)]
		public FKuroQuadrupedIK_DebugSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014CCD RID: 85197 RVA: 0x001E9666 File Offset: 0x001E7866
		public FKuroQuadrupedIK_DebugSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014CCE RID: 85198 RVA: 0x001E9671 File Offset: 0x001E7871
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroQuadrupedIK_DebugSettings(Pointer, false, true);
		}

		// Token: 0x06014CCF RID: 85199 RVA: 0x001E967B File Offset: 0x001E787B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroQuadrupedIK_DebugSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B562 RID: 46434
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.KuroQuadrupedIK_DebugSettings";

		// Token: 0x0400B563 RID: 46435
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B564 RID: 46436
		internal static int __PropertyOffset_EnableDebug;

		// Token: 0x0400B565 RID: 46437
		internal static int __PropertyOffset_DisplayTrace;

		// Token: 0x0400B566 RID: 46438
		internal static int __PropertyOffset_DebugDrawLifeTime;

		// Token: 0x0400B567 RID: 46439
		internal static int __PropertyOffset_DebugDrawOnTop;

		// Token: 0x0400B568 RID: 46440
		internal static int __PropertyOffset_DebugDrawScale;

		// Token: 0x0400B569 RID: 46441
		internal static int __PropertyOffset_CharacterDebugSpeed;

		// Token: 0x0400B56A RID: 46442
		internal static int __PropertyOffset_SpineWorkOutsidePIE;

		// Token: 0x0400B56B RID: 46443
		internal static int __PropertyOffset_DisplaySpineSolver;

		// Token: 0x0400B56C RID: 46444
		internal static int __PropertyOffset_FeetWorkOutsidePIE;

		// Token: 0x0400B56D RID: 46445
		internal static int __PropertyOffset_DisplayFeetTarget;
	}
}
