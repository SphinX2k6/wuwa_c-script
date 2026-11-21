using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003BF RID: 959
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelBase")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UEffectModelBase : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005DBB RID: 23995 RVA: 0x000848BF File Offset: 0x00082ABF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelBase._ClassPtr;
		}

		// Token: 0x06005DBC RID: 23996 RVA: 0x000848CC File Offset: 0x00082ACC
		public UEffectModelBase() : this(BuiltinUtils.AllocNativeUObject(UEffectModelBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005DBD RID: 23997 RVA: 0x000848F4 File Offset: 0x00082AF4
		[NullableContext(1)]
		public UEffectModelBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x06005DBE RID: 23998 RVA: 0x00084927 File Offset: 0x00082B27
		// (set) Token: 0x06005DBF RID: 23999 RVA: 0x00084937 File Offset: 0x00082B37
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_StartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_StartTime) = value;
			}
		}

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x06005DC0 RID: 24000 RVA: 0x00084948 File Offset: 0x00082B48
		// (set) Token: 0x06005DC1 RID: 24001 RVA: 0x00084958 File Offset: 0x00082B58
		public unsafe float LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_LoopTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_LoopTime) = value;
			}
		}

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x06005DC2 RID: 24002 RVA: 0x00084969 File Offset: 0x00082B69
		// (set) Token: 0x06005DC3 RID: 24003 RVA: 0x00084979 File Offset: 0x00082B79
		public unsafe float EndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_EndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_EndTime) = value;
			}
		}

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x06005DC4 RID: 24004 RVA: 0x0008498A File Offset: 0x00082B8A
		// (set) Token: 0x06005DC5 RID: 24005 RVA: 0x0008499A File Offset: 0x00082B9A
		public unsafe bool AutoPlay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_AutoPlay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_AutoPlay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x06005DC6 RID: 24006 RVA: 0x000849AB File Offset: 0x00082BAB
		// (set) Token: 0x06005DC7 RID: 24007 RVA: 0x000849BB File Offset: 0x00082BBB
		public unsafe bool AutoDestroy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_AutoDestroy) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_AutoDestroy) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x06005DC8 RID: 24008 RVA: 0x000849CC File Offset: 0x00082BCC
		// (set) Token: 0x06005DC9 RID: 24009 RVA: 0x000849DC File Offset: 0x00082BDC
		public unsafe bool ContinuousLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_ContinuousLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_ContinuousLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x06005DCA RID: 24010 RVA: 0x000849ED File Offset: 0x00082BED
		// (set) Token: 0x06005DCB RID: 24011 RVA: 0x000849FD File Offset: 0x00082BFD
		public unsafe bool IgnoreTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_IgnoreTimeDilation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_IgnoreTimeDilation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x06005DCC RID: 24012 RVA: 0x00084A0E File Offset: 0x00082C0E
		// (set) Token: 0x06005DCD RID: 24013 RVA: 0x00084A1E File Offset: 0x00082C1E
		public unsafe bool IgnoreGlobalTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_IgnoreGlobalTimeDilation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_IgnoreGlobalTimeDilation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x06005DCE RID: 24014 RVA: 0x00084A2F File Offset: 0x00082C2F
		// (set) Token: 0x06005DCF RID: 24015 RVA: 0x00084A3F File Offset: 0x00082C3F
		public unsafe bool UiScenePrimitive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_UiScenePrimitive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_UiScenePrimitive) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x06005DD0 RID: 24016 RVA: 0x00084A50 File Offset: 0x00082C50
		// (set) Token: 0x06005DD1 RID: 24017 RVA: 0x00084A60 File Offset: 0x00082C60
		public unsafe int ImportanceLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_ImportanceLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_ImportanceLevel) = value;
			}
		}

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x06005DD2 RID: 24018 RVA: 0x00084A71 File Offset: 0x00082C71
		// (set) Token: 0x06005DD3 RID: 24019 RVA: 0x00084A81 File Offset: 0x00082C81
		public unsafe float DefaultManualTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_DefaultManualTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_DefaultManualTime) = value;
			}
		}

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x06005DD4 RID: 24020 RVA: 0x00084A92 File Offset: 0x00082C92
		// (set) Token: 0x06005DD5 RID: 24021 RVA: 0x00084AA2 File Offset: 0x00082CA2
		public unsafe float DefaultManualSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_DefaultManualSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_DefaultManualSpeed) = value;
			}
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06005DD6 RID: 24022 RVA: 0x00084AB3 File Offset: 0x00082CB3
		// (set) Token: 0x06005DD7 RID: 24023 RVA: 0x00084AC3 File Offset: 0x00082CC3
		public unsafe bool IgnoreDisable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_IgnoreDisable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_IgnoreDisable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06005DD8 RID: 24024 RVA: 0x00084AD4 File Offset: 0x00082CD4
		// (set) Token: 0x06005DD9 RID: 24025 RVA: 0x00084AE4 File Offset: 0x00082CE4
		public unsafe bool DisableOnMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_DisableOnMobile) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_DisableOnMobile) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06005DDA RID: 24026 RVA: 0x00084AF5 File Offset: 0x00082CF5
		// (set) Token: 0x06005DDB RID: 24027 RVA: 0x00084B05 File Offset: 0x00082D05
		public unsafe bool HideOnBurstSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_HideOnBurstSkill) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_HideOnBurstSkill) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x06005DDC RID: 24028 RVA: 0x00084B16 File Offset: 0x00082D16
		// (set) Token: 0x06005DDD RID: 24029 RVA: 0x00084B26 File Offset: 0x00082D26
		public unsafe bool HideInOtherUltraSkill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_HideInOtherUltraSkill) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_HideInOtherUltraSkill) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x06005DDE RID: 24030 RVA: 0x00084B37 File Offset: 0x00082D37
		// (set) Token: 0x06005DDF RID: 24031 RVA: 0x00084B47 File Offset: 0x00082D47
		public unsafe bool NeedDisableWithActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_NeedDisableWithActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_NeedDisableWithActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x06005DE0 RID: 24032 RVA: 0x00084B58 File Offset: 0x00082D58
		// (set) Token: 0x06005DE1 RID: 24033 RVA: 0x00084B68 File Offset: 0x00082D68
		public unsafe bool NeverDisableWithActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_NeverDisableWithActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_NeverDisableWithActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06005DE2 RID: 24034 RVA: 0x00084B79 File Offset: 0x00082D79
		// (set) Token: 0x06005DE3 RID: 24035 RVA: 0x00084B89 File Offset: 0x00082D89
		public unsafe bool SuperFarProgramFlag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_SuperFarProgramFlag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_SuperFarProgramFlag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06005DE4 RID: 24036 RVA: 0x00084B9A File Offset: 0x00082D9A
		// (set) Token: 0x06005DE5 RID: 24037 RVA: 0x00084BAA File Offset: 0x00082DAA
		public unsafe bool HideForProtoPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_HideForProtoPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_HideForProtoPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06005DE6 RID: 24038 RVA: 0x00084BBB File Offset: 0x00082DBB
		// (set) Token: 0x06005DE7 RID: 24039 RVA: 0x00084BCB File Offset: 0x00082DCB
		public unsafe bool OnlyShowForProtoPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_OnlyShowForProtoPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_OnlyShowForProtoPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06005DE8 RID: 24040 RVA: 0x00084BDC File Offset: 0x00082DDC
		// (set) Token: 0x06005DE9 RID: 24041 RVA: 0x00084BEC File Offset: 0x00082DEC
		public unsafe bool bDebugHidden
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_bDebugHidden) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelBase.__PropertyOffset_bDebugHidden) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x00084BFD File Offset: 0x00082DFD
		static UEffectModelBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelBase");
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x00084C0B File Offset: 0x00082E0B
		protected UEffectModelBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002711 RID: 10001
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelBase";

		// Token: 0x04002712 RID: 10002
		private static IntPtr _ClassPtr;

		// Token: 0x04002713 RID: 10003
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002714 RID: 10004
		internal static int __PropertyOffset_StartTime;

		// Token: 0x04002715 RID: 10005
		internal static int __PropertyOffset_LoopTime;

		// Token: 0x04002716 RID: 10006
		internal static int __PropertyOffset_EndTime;

		// Token: 0x04002717 RID: 10007
		internal static int __PropertyOffset_AutoPlay;

		// Token: 0x04002718 RID: 10008
		internal static int __PropertyOffset_AutoDestroy;

		// Token: 0x04002719 RID: 10009
		internal static int __PropertyOffset_ContinuousLoop;

		// Token: 0x0400271A RID: 10010
		internal static int __PropertyOffset_IgnoreTimeDilation;

		// Token: 0x0400271B RID: 10011
		internal static int __PropertyOffset_IgnoreGlobalTimeDilation;

		// Token: 0x0400271C RID: 10012
		internal static int __PropertyOffset_UiScenePrimitive;

		// Token: 0x0400271D RID: 10013
		internal static int __PropertyOffset_ImportanceLevel;

		// Token: 0x0400271E RID: 10014
		internal static int __PropertyOffset_DefaultManualTime;

		// Token: 0x0400271F RID: 10015
		internal static int __PropertyOffset_DefaultManualSpeed;

		// Token: 0x04002720 RID: 10016
		internal static int __PropertyOffset_IgnoreDisable;

		// Token: 0x04002721 RID: 10017
		internal static int __PropertyOffset_DisableOnMobile;

		// Token: 0x04002722 RID: 10018
		internal static int __PropertyOffset_HideOnBurstSkill;

		// Token: 0x04002723 RID: 10019
		internal static int __PropertyOffset_HideInOtherUltraSkill;

		// Token: 0x04002724 RID: 10020
		internal static int __PropertyOffset_NeedDisableWithActor;

		// Token: 0x04002725 RID: 10021
		internal static int __PropertyOffset_NeverDisableWithActor;

		// Token: 0x04002726 RID: 10022
		internal static int __PropertyOffset_SuperFarProgramFlag;

		// Token: 0x04002727 RID: 10023
		internal static int __PropertyOffset_HideForProtoPlayer;

		// Token: 0x04002728 RID: 10024
		internal static int __PropertyOffset_OnlyShowForProtoPlayer;

		// Token: 0x04002729 RID: 10025
		internal static int __PropertyOffset_bDebugHidden;
	}
}
