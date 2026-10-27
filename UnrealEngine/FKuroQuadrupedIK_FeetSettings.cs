using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200166C RID: 5740
	[UnrealObjectPath("/Script/KuroAnim.KuroQuadrupedIK_FeetSettings")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FKuroQuadrupedIK_FeetSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014CD0 RID: 85200 RVA: 0x001E9684 File Offset: 0x001E7884
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroQuadrupedIK_FeetSettings._ScriptStructPtr != 0) ? FKuroQuadrupedIK_FeetSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.KuroQuadrupedIK_FeetSettings", ref FKuroQuadrupedIK_FeetSettings._ScriptStructPtr);
		}

		// Token: 0x1700524F RID: 21071
		// (get) Token: 0x06014CD1 RID: 85201 RVA: 0x001E96A8 File Offset: 0x001E78A8
		// (set) Token: 0x06014CD2 RID: 85202 RVA: 0x001E96B8 File Offset: 0x001E78B8
		public unsafe float MaxFeetLiftDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_MaxFeetLiftDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_MaxFeetLiftDistance) = value;
			}
		}

		// Token: 0x17005250 RID: 21072
		// (get) Token: 0x06014CD3 RID: 85203 RVA: 0x001E96C9 File Offset: 0x001E78C9
		// (set) Token: 0x06014CD4 RID: 85204 RVA: 0x001E96D9 File Offset: 0x001E78D9
		public unsafe float MaxFeetDipDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_MaxFeetDipDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_MaxFeetDipDistance) = value;
			}
		}

		// Token: 0x17005251 RID: 21073
		// (get) Token: 0x06014CD5 RID: 85205 RVA: 0x001E96EA File Offset: 0x001E78EA
		// (set) Token: 0x06014CD6 RID: 85206 RVA: 0x001E96FA File Offset: 0x001E78FA
		public unsafe float MaxFeetRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_MaxFeetRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_MaxFeetRotation) = value;
			}
		}

		// Token: 0x17005252 RID: 21074
		// (get) Token: 0x06014CD7 RID: 85207 RVA: 0x001E970B File Offset: 0x001E790B
		// (set) Token: 0x06014CD8 RID: 85208 RVA: 0x001E971B File Offset: 0x001E791B
		public unsafe float MaxFeetSwingRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_MaxFeetSwingRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_MaxFeetSwingRotation) = value;
			}
		}

		// Token: 0x17005253 RID: 21075
		// (get) Token: 0x06014CD9 RID: 85209 RVA: 0x001E972C File Offset: 0x001E792C
		// (set) Token: 0x06014CDA RID: 85210 RVA: 0x001E973C File Offset: 0x001E793C
		public unsafe float MaxFeetReachRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_MaxFeetReachRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_MaxFeetReachRatio) = value;
			}
		}

		// Token: 0x17005254 RID: 21076
		// (get) Token: 0x06014CDB RID: 85211 RVA: 0x001E974D File Offset: 0x001E794D
		// (set) Token: 0x06014CDC RID: 85212 RVA: 0x001E975D File Offset: 0x001E795D
		public unsafe float FeetLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetLerpSpeed) = value;
			}
		}

		// Token: 0x17005255 RID: 21077
		// (get) Token: 0x06014CDD RID: 85213 RVA: 0x001E976E File Offset: 0x001E796E
		// (set) Token: 0x06014CDE RID: 85214 RVA: 0x001E977E File Offset: 0x001E797E
		public unsafe float FeetLocationLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetLocationLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetLocationLerpSpeed) = value;
			}
		}

		// Token: 0x17005256 RID: 21078
		// (get) Token: 0x06014CDF RID: 85215 RVA: 0x001E978F File Offset: 0x001E798F
		// (set) Token: 0x06014CE0 RID: 85216 RVA: 0x001E979F File Offset: 0x001E799F
		public unsafe float FeetRotationLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetRotationLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetRotationLerpSpeed) = value;
			}
		}

		// Token: 0x17005257 RID: 21079
		// (get) Token: 0x06014CE1 RID: 85217 RVA: 0x001E97B0 File Offset: 0x001E79B0
		// (set) Token: 0x06014CE2 RID: 85218 RVA: 0x001E97C0 File Offset: 0x001E79C0
		public unsafe bool FeetEnableSticky
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetEnableSticky) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetEnableSticky) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005258 RID: 21080
		// (get) Token: 0x06014CE3 RID: 85219 RVA: 0x001E97D1 File Offset: 0x001E79D1
		// (set) Token: 0x06014CE4 RID: 85220 RVA: 0x001E97E1 File Offset: 0x001E79E1
		public unsafe float FeetStickyFloorHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetStickyFloorHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetStickyFloorHeight) = value;
			}
		}

		// Token: 0x17005259 RID: 21081
		// (get) Token: 0x06014CE5 RID: 85221 RVA: 0x001E97F2 File Offset: 0x001E79F2
		// (set) Token: 0x06014CE6 RID: 85222 RVA: 0x001E9802 File Offset: 0x001E7A02
		public unsafe float FeetStickyRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetStickyRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetStickyRange) = value;
			}
		}

		// Token: 0x1700525A RID: 21082
		// (get) Token: 0x06014CE7 RID: 85223 RVA: 0x001E9813 File Offset: 0x001E7A13
		// (set) Token: 0x06014CE8 RID: 85224 RVA: 0x001E9823 File Offset: 0x001E7A23
		public unsafe float FeetStickyOffToOnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetStickyOffToOnSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetStickyOffToOnSpeed) = value;
			}
		}

		// Token: 0x1700525B RID: 21083
		// (get) Token: 0x06014CE9 RID: 85225 RVA: 0x001E9834 File Offset: 0x001E7A34
		// (set) Token: 0x06014CEA RID: 85226 RVA: 0x001E9844 File Offset: 0x001E7A44
		public unsafe float FeetStickyOnToOffSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetStickyOnToOffSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroQuadrupedIK_FeetSettings.__PropertyOffset_FeetStickyOnToOffSpeed) = value;
			}
		}

		// Token: 0x06014CEB RID: 85227 RVA: 0x001E9855 File Offset: 0x001E7A55
		public FKuroQuadrupedIK_FeetSettings()
		{
		}

		// Token: 0x06014CEC RID: 85228 RVA: 0x001E9860 File Offset: 0x001E7A60
		public FKuroQuadrupedIK_FeetSettings(float MaxFeetLiftDistance, float MaxFeetDipDistance, float MaxFeetRotation, float MaxFeetSwingRotation, float MaxFeetReachRatio, float FeetLerpSpeed, float FeetLocationLerpSpeed, float FeetRotationLerpSpeed, bool FeetEnableSticky, float FeetStickyFloorHeight, float FeetStickyRange, float FeetStickyOffToOnSpeed, float FeetStickyOnToOffSpeed)
		{
			this.MaxFeetLiftDistance = MaxFeetLiftDistance;
			this.MaxFeetDipDistance = MaxFeetDipDistance;
			this.MaxFeetRotation = MaxFeetRotation;
			this.MaxFeetSwingRotation = MaxFeetSwingRotation;
			this.MaxFeetReachRatio = MaxFeetReachRatio;
			this.FeetLerpSpeed = FeetLerpSpeed;
			this.FeetLocationLerpSpeed = FeetLocationLerpSpeed;
			this.FeetRotationLerpSpeed = FeetRotationLerpSpeed;
			this.FeetEnableSticky = FeetEnableSticky;
			this.FeetStickyFloorHeight = FeetStickyFloorHeight;
			this.FeetStickyRange = FeetStickyRange;
			this.FeetStickyOffToOnSpeed = FeetStickyOffToOnSpeed;
			this.FeetStickyOnToOffSpeed = FeetStickyOnToOffSpeed;
		}

		// Token: 0x06014CED RID: 85229 RVA: 0x001E98D8 File Offset: 0x001E7AD8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroQuadrupedIK_FeetSettings.StaticStruct();
		}

		// Token: 0x06014CEE RID: 85230 RVA: 0x001E98E4 File Offset: 0x001E7AE4
		[NullableContext(2)]
		public FKuroQuadrupedIK_FeetSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014CEF RID: 85231 RVA: 0x001E98EE File Offset: 0x001E7AEE
		public FKuroQuadrupedIK_FeetSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014CF0 RID: 85232 RVA: 0x001E98F9 File Offset: 0x001E7AF9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroQuadrupedIK_FeetSettings(Pointer, false, true);
		}

		// Token: 0x06014CF1 RID: 85233 RVA: 0x001E9903 File Offset: 0x001E7B03
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroQuadrupedIK_FeetSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B56E RID: 46446
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.KuroQuadrupedIK_FeetSettings";

		// Token: 0x0400B56F RID: 46447
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B570 RID: 46448
		internal static int __PropertyOffset_MaxFeetLiftDistance;

		// Token: 0x0400B571 RID: 46449
		internal static int __PropertyOffset_MaxFeetDipDistance;

		// Token: 0x0400B572 RID: 46450
		internal static int __PropertyOffset_MaxFeetRotation;

		// Token: 0x0400B573 RID: 46451
		internal static int __PropertyOffset_MaxFeetSwingRotation;

		// Token: 0x0400B574 RID: 46452
		internal static int __PropertyOffset_MaxFeetReachRatio;

		// Token: 0x0400B575 RID: 46453
		internal static int __PropertyOffset_FeetLerpSpeed;

		// Token: 0x0400B576 RID: 46454
		internal static int __PropertyOffset_FeetLocationLerpSpeed;

		// Token: 0x0400B577 RID: 46455
		internal static int __PropertyOffset_FeetRotationLerpSpeed;

		// Token: 0x0400B578 RID: 46456
		internal static int __PropertyOffset_FeetEnableSticky;

		// Token: 0x0400B579 RID: 46457
		internal static int __PropertyOffset_FeetStickyFloorHeight;

		// Token: 0x0400B57A RID: 46458
		internal static int __PropertyOffset_FeetStickyRange;

		// Token: 0x0400B57B RID: 46459
		internal static int __PropertyOffset_FeetStickyOffToOnSpeed;

		// Token: 0x0400B57C RID: 46460
		internal static int __PropertyOffset_FeetStickyOnToOffSpeed;
	}
}
