using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200189C RID: 6300
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelBase")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UEffectModelBase : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017310 RID: 94992 RVA: 0x0021D423 File Offset: 0x0021B623
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelBase._ClassPtr;
		}

		// Token: 0x06017311 RID: 94993 RVA: 0x0021D430 File Offset: 0x0021B630
		public UEffectModelBase() : this(BuiltinUtils.AllocNativeUObject(UEffectModelBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017312 RID: 94994 RVA: 0x0021D458 File Offset: 0x0021B658
		[NullableContext(1)]
		public UEffectModelBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D32 RID: 23858
		// (get) Token: 0x06017313 RID: 94995 RVA: 0x0021D48B File Offset: 0x0021B68B
		// (set) Token: 0x06017314 RID: 94996 RVA: 0x0021D49B File Offset: 0x0021B69B
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

		// Token: 0x17005D33 RID: 23859
		// (get) Token: 0x06017315 RID: 94997 RVA: 0x0021D4AC File Offset: 0x0021B6AC
		// (set) Token: 0x06017316 RID: 94998 RVA: 0x0021D4BC File Offset: 0x0021B6BC
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

		// Token: 0x17005D34 RID: 23860
		// (get) Token: 0x06017317 RID: 94999 RVA: 0x0021D4CD File Offset: 0x0021B6CD
		// (set) Token: 0x06017318 RID: 95000 RVA: 0x0021D4DD File Offset: 0x0021B6DD
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

		// Token: 0x17005D35 RID: 23861
		// (get) Token: 0x06017319 RID: 95001 RVA: 0x0021D4EE File Offset: 0x0021B6EE
		// (set) Token: 0x0601731A RID: 95002 RVA: 0x0021D4FE File Offset: 0x0021B6FE
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

		// Token: 0x17005D36 RID: 23862
		// (get) Token: 0x0601731B RID: 95003 RVA: 0x0021D50F File Offset: 0x0021B70F
		// (set) Token: 0x0601731C RID: 95004 RVA: 0x0021D51F File Offset: 0x0021B71F
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

		// Token: 0x17005D37 RID: 23863
		// (get) Token: 0x0601731D RID: 95005 RVA: 0x0021D530 File Offset: 0x0021B730
		// (set) Token: 0x0601731E RID: 95006 RVA: 0x0021D540 File Offset: 0x0021B740
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

		// Token: 0x17005D38 RID: 23864
		// (get) Token: 0x0601731F RID: 95007 RVA: 0x0021D551 File Offset: 0x0021B751
		// (set) Token: 0x06017320 RID: 95008 RVA: 0x0021D561 File Offset: 0x0021B761
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

		// Token: 0x17005D39 RID: 23865
		// (get) Token: 0x06017321 RID: 95009 RVA: 0x0021D572 File Offset: 0x0021B772
		// (set) Token: 0x06017322 RID: 95010 RVA: 0x0021D582 File Offset: 0x0021B782
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

		// Token: 0x17005D3A RID: 23866
		// (get) Token: 0x06017323 RID: 95011 RVA: 0x0021D593 File Offset: 0x0021B793
		// (set) Token: 0x06017324 RID: 95012 RVA: 0x0021D5A3 File Offset: 0x0021B7A3
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

		// Token: 0x17005D3B RID: 23867
		// (get) Token: 0x06017325 RID: 95013 RVA: 0x0021D5B4 File Offset: 0x0021B7B4
		// (set) Token: 0x06017326 RID: 95014 RVA: 0x0021D5C4 File Offset: 0x0021B7C4
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

		// Token: 0x17005D3C RID: 23868
		// (get) Token: 0x06017327 RID: 95015 RVA: 0x0021D5D5 File Offset: 0x0021B7D5
		// (set) Token: 0x06017328 RID: 95016 RVA: 0x0021D5E5 File Offset: 0x0021B7E5
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

		// Token: 0x17005D3D RID: 23869
		// (get) Token: 0x06017329 RID: 95017 RVA: 0x0021D5F6 File Offset: 0x0021B7F6
		// (set) Token: 0x0601732A RID: 95018 RVA: 0x0021D606 File Offset: 0x0021B806
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

		// Token: 0x17005D3E RID: 23870
		// (get) Token: 0x0601732B RID: 95019 RVA: 0x0021D617 File Offset: 0x0021B817
		// (set) Token: 0x0601732C RID: 95020 RVA: 0x0021D627 File Offset: 0x0021B827
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

		// Token: 0x17005D3F RID: 23871
		// (get) Token: 0x0601732D RID: 95021 RVA: 0x0021D638 File Offset: 0x0021B838
		// (set) Token: 0x0601732E RID: 95022 RVA: 0x0021D648 File Offset: 0x0021B848
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

		// Token: 0x17005D40 RID: 23872
		// (get) Token: 0x0601732F RID: 95023 RVA: 0x0021D659 File Offset: 0x0021B859
		// (set) Token: 0x06017330 RID: 95024 RVA: 0x0021D669 File Offset: 0x0021B869
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

		// Token: 0x17005D41 RID: 23873
		// (get) Token: 0x06017331 RID: 95025 RVA: 0x0021D67A File Offset: 0x0021B87A
		// (set) Token: 0x06017332 RID: 95026 RVA: 0x0021D68A File Offset: 0x0021B88A
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

		// Token: 0x17005D42 RID: 23874
		// (get) Token: 0x06017333 RID: 95027 RVA: 0x0021D69B File Offset: 0x0021B89B
		// (set) Token: 0x06017334 RID: 95028 RVA: 0x0021D6AB File Offset: 0x0021B8AB
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

		// Token: 0x17005D43 RID: 23875
		// (get) Token: 0x06017335 RID: 95029 RVA: 0x0021D6BC File Offset: 0x0021B8BC
		// (set) Token: 0x06017336 RID: 95030 RVA: 0x0021D6CC File Offset: 0x0021B8CC
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

		// Token: 0x17005D44 RID: 23876
		// (get) Token: 0x06017337 RID: 95031 RVA: 0x0021D6DD File Offset: 0x0021B8DD
		// (set) Token: 0x06017338 RID: 95032 RVA: 0x0021D6ED File Offset: 0x0021B8ED
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

		// Token: 0x17005D45 RID: 23877
		// (get) Token: 0x06017339 RID: 95033 RVA: 0x0021D6FE File Offset: 0x0021B8FE
		// (set) Token: 0x0601733A RID: 95034 RVA: 0x0021D70E File Offset: 0x0021B90E
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

		// Token: 0x17005D46 RID: 23878
		// (get) Token: 0x0601733B RID: 95035 RVA: 0x0021D71F File Offset: 0x0021B91F
		// (set) Token: 0x0601733C RID: 95036 RVA: 0x0021D72F File Offset: 0x0021B92F
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

		// Token: 0x0601733D RID: 95037 RVA: 0x0021D740 File Offset: 0x0021B940
		static UEffectModelBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelBase");
		}

		// Token: 0x0601733E RID: 95038 RVA: 0x0021D74E File Offset: 0x0021B94E
		protected UEffectModelBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C942 RID: 51522
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelBase";

		// Token: 0x0400C943 RID: 51523
		private static IntPtr _ClassPtr;

		// Token: 0x0400C944 RID: 51524
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C945 RID: 51525
		internal static int __PropertyOffset_StartTime;

		// Token: 0x0400C946 RID: 51526
		internal static int __PropertyOffset_LoopTime;

		// Token: 0x0400C947 RID: 51527
		internal static int __PropertyOffset_EndTime;

		// Token: 0x0400C948 RID: 51528
		internal static int __PropertyOffset_AutoPlay;

		// Token: 0x0400C949 RID: 51529
		internal static int __PropertyOffset_AutoDestroy;

		// Token: 0x0400C94A RID: 51530
		internal static int __PropertyOffset_ContinuousLoop;

		// Token: 0x0400C94B RID: 51531
		internal static int __PropertyOffset_IgnoreTimeDilation;

		// Token: 0x0400C94C RID: 51532
		internal static int __PropertyOffset_IgnoreGlobalTimeDilation;

		// Token: 0x0400C94D RID: 51533
		internal static int __PropertyOffset_UiScenePrimitive;

		// Token: 0x0400C94E RID: 51534
		internal static int __PropertyOffset_ImportanceLevel;

		// Token: 0x0400C94F RID: 51535
		internal static int __PropertyOffset_DefaultManualTime;

		// Token: 0x0400C950 RID: 51536
		internal static int __PropertyOffset_DefaultManualSpeed;

		// Token: 0x0400C951 RID: 51537
		internal static int __PropertyOffset_IgnoreDisable;

		// Token: 0x0400C952 RID: 51538
		internal static int __PropertyOffset_DisableOnMobile;

		// Token: 0x0400C953 RID: 51539
		internal static int __PropertyOffset_HideOnBurstSkill;

		// Token: 0x0400C954 RID: 51540
		internal static int __PropertyOffset_NeedDisableWithActor;

		// Token: 0x0400C955 RID: 51541
		internal static int __PropertyOffset_NeverDisableWithActor;

		// Token: 0x0400C956 RID: 51542
		internal static int __PropertyOffset_SuperFarProgramFlag;

		// Token: 0x0400C957 RID: 51543
		internal static int __PropertyOffset_HideForProtoPlayer;

		// Token: 0x0400C958 RID: 51544
		internal static int __PropertyOffset_OnlyShowForProtoPlayer;

		// Token: 0x0400C959 RID: 51545
		internal static int __PropertyOffset_bDebugHidden;
	}
}
