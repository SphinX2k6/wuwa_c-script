using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001524 RID: 5412
	[UnrealObjectPath("/Script/ImposterManager.KuroImposterVer2Component")]
	[UnrealStructLayout(2112, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2112)]
	public class UKuroImposterVer2Component : UStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013B20 RID: 80672 RVA: 0x001CEDAE File Offset: 0x001CCFAE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroImposterVer2Component._ClassPtr;
		}

		// Token: 0x06013B21 RID: 80673 RVA: 0x001CEDBC File Offset: 0x001CCFBC
		public UKuroImposterVer2Component() : this(BuiltinUtils.AllocNativeUObject(UKuroImposterVer2Component.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013B22 RID: 80674 RVA: 0x001CEDE4 File Offset: 0x001CCFE4
		[NullableContext(1)]
		public UKuroImposterVer2Component(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroImposterVer2Component.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004D1D RID: 19741
		// (get) Token: 0x06013B23 RID: 80675 RVA: 0x001CEE17 File Offset: 0x001CD017
		// (set) Token: 0x06013B24 RID: 80676 RVA: 0x001CEE2B File Offset: 0x001CD02B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UStaticMeshComponent> SourceComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroImposterVer2Component.__PropertyOffset_SourceComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UKuroImposterVer2Component.__PropertyOffset_SourceComponent) = value;
			}
		}

		// Token: 0x17004D1E RID: 19742
		// (get) Token: 0x06013B25 RID: 80677 RVA: 0x001CEE40 File Offset: 0x001CD040
		// (set) Token: 0x06013B26 RID: 80678 RVA: 0x001CEE50 File Offset: 0x001CD050
		public unsafe float StartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroImposterVer2Component.__PropertyOffset_StartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroImposterVer2Component.__PropertyOffset_StartDistance) = value;
			}
		}

		// Token: 0x17004D1F RID: 19743
		// (get) Token: 0x06013B27 RID: 80679 RVA: 0x001CEE61 File Offset: 0x001CD061
		// (set) Token: 0x06013B28 RID: 80680 RVA: 0x001CEE71 File Offset: 0x001CD071
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroImposterVer2Component.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroImposterVer2Component.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x17004D20 RID: 19744
		// (get) Token: 0x06013B29 RID: 80681 RVA: 0x001CEE82 File Offset: 0x001CD082
		// (set) Token: 0x06013B2A RID: 80682 RVA: 0x001CEE92 File Offset: 0x001CD092
		public unsafe bool bSeasonalEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroImposterVer2Component.__PropertyOffset_bSeasonalEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroImposterVer2Component.__PropertyOffset_bSeasonalEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004D21 RID: 19745
		// (get) Token: 0x06013B2B RID: 80683 RVA: 0x001CEEA3 File Offset: 0x001CD0A3
		// (set) Token: 0x06013B2C RID: 80684 RVA: 0x001CEEB7 File Offset: 0x001CD0B7
		public unsafe FLinearColor InstanceTintColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroImposterVer2Component.__PropertyOffset_InstanceTintColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroImposterVer2Component.__PropertyOffset_InstanceTintColor) = value;
			}
		}

		// Token: 0x17004D22 RID: 19746
		// (get) Token: 0x06013B2D RID: 80685 RVA: 0x001CEECC File Offset: 0x001CD0CC
		// (set) Token: 0x06013B2E RID: 80686 RVA: 0x001CEEDC File Offset: 0x001CD0DC
		public unsafe bool bExternalSourceVisibilityControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroImposterVer2Component.__PropertyOffset_bExternalSourceVisibilityControl) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroImposterVer2Component.__PropertyOffset_bExternalSourceVisibilityControl) = (value ? 1 : 0);
			}
		}

		// Token: 0x06013B2F RID: 80687 RVA: 0x001CEEED File Offset: 0x001CD0ED
		static UKuroImposterVer2Component()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ImposterManager.KuroImposterVer2Component");
		}

		// Token: 0x06013B30 RID: 80688 RVA: 0x001CEEFB File Offset: 0x001CD0FB
		protected UKuroImposterVer2Component(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AA2A RID: 43562
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ImposterManager.KuroImposterVer2Component";

		// Token: 0x0400AA2B RID: 43563
		private static IntPtr _ClassPtr;

		// Token: 0x0400AA2C RID: 43564
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AA2D RID: 43565
		internal static int __PropertyOffset_SourceComponent;

		// Token: 0x0400AA2E RID: 43566
		internal static int __PropertyOffset_StartDistance;

		// Token: 0x0400AA2F RID: 43567
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x0400AA30 RID: 43568
		internal static int __PropertyOffset_bSeasonalEnabled;

		// Token: 0x0400AA31 RID: 43569
		internal static int __PropertyOffset_InstanceTintColor;

		// Token: 0x0400AA32 RID: 43570
		internal static int __PropertyOffset_bExternalSourceVisibilityControl;
	}
}
