using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200249A RID: 9370
	[UnrealObjectPath("/Script/NavigationSystem.NavLinkCustomComponent")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class UNavLinkCustomComponent : UNavRelevantComponent, IUnrealUObject, IUnrealObject, INavLinkCustomInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602314D RID: 143693 RVA: 0x0033E146 File Offset: 0x0033C346
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavLinkCustomComponent._ClassPtr;
		}

		// Token: 0x0602314E RID: 143694 RVA: 0x0033E152 File Offset: 0x0033C352
		int INavLinkCustomInterface.InterfaceOffset()
		{
			return UNavLinkCustomComponent.__InterfaceOffset_INavLinkCustomInterface;
		}

		// Token: 0x0602314F RID: 143695 RVA: 0x0033E15C File Offset: 0x0033C35C
		public UNavLinkCustomComponent() : this(BuiltinUtils.AllocNativeUObject(UNavLinkCustomComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023150 RID: 143696 RVA: 0x0033E184 File Offset: 0x0033C384
		[NullableContext(1)]
		public UNavLinkCustomComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavLinkCustomComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170086CA RID: 34506
		// (get) Token: 0x06023151 RID: 143697 RVA: 0x0033E1B7 File Offset: 0x0033C3B7
		// (set) Token: 0x06023152 RID: 143698 RVA: 0x0033E1C7 File Offset: 0x0033C3C7
		public unsafe uint NavLinkUserId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_NavLinkUserId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_NavLinkUserId) = (int)value;
			}
		}

		// Token: 0x170086CB RID: 34507
		// (get) Token: 0x06023153 RID: 143699 RVA: 0x0033E1D8 File Offset: 0x0033C3D8
		// (set) Token: 0x06023154 RID: 143700 RVA: 0x0033E1EC File Offset: 0x0033C3EC
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> EnabledAreaClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_EnabledAreaClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_EnabledAreaClass) = value;
			}
		}

		// Token: 0x170086CC RID: 34508
		// (get) Token: 0x06023155 RID: 143701 RVA: 0x0033E201 File Offset: 0x0033C401
		// (set) Token: 0x06023156 RID: 143702 RVA: 0x0033E215 File Offset: 0x0033C415
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> DisabledAreaClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_DisabledAreaClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_DisabledAreaClass) = value;
			}
		}

		// Token: 0x170086CD RID: 34509
		// (get) Token: 0x06023157 RID: 143703 RVA: 0x0033E22C File Offset: 0x0033C42C
		// (set) Token: 0x06023158 RID: 143704 RVA: 0x0033E265 File Offset: 0x0033C465
		[Nullable(1)]
		public FNavAgentSelector SupportedAgents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNavAgentSelector result;
				if ((result = this._SupportedAgents) == null)
				{
					result = (this._SupportedAgents = new FNavAgentSelector(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_SupportedAgents, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAgentSelector.StaticStruct(), base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_SupportedAgents, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170086CE RID: 34510
		// (get) Token: 0x06023159 RID: 143705 RVA: 0x0033E286 File Offset: 0x0033C486
		// (set) Token: 0x0602315A RID: 143706 RVA: 0x0033E29A File Offset: 0x0033C49A
		public unsafe FVector LinkRelativeStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_LinkRelativeStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_LinkRelativeStart) = value;
			}
		}

		// Token: 0x170086CF RID: 34511
		// (get) Token: 0x0602315B RID: 143707 RVA: 0x0033E2AF File Offset: 0x0033C4AF
		// (set) Token: 0x0602315C RID: 143708 RVA: 0x0033E2C3 File Offset: 0x0033C4C3
		public unsafe FVector LinkRelativeEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_LinkRelativeEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_LinkRelativeEnd) = value;
			}
		}

		// Token: 0x170086D0 RID: 34512
		// (get) Token: 0x0602315D RID: 143709 RVA: 0x0033E2D8 File Offset: 0x0033C4D8
		// (set) Token: 0x0602315E RID: 143710 RVA: 0x0033E2EC File Offset: 0x0033C4EC
		public unsafe TEnumAsByte<ENavLinkDirection> LinkDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_LinkDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_LinkDirection) = value;
			}
		}

		// Token: 0x170086D1 RID: 34513
		// (get) Token: 0x0602315F RID: 143711 RVA: 0x0033E301 File Offset: 0x0033C501
		// (set) Token: 0x06023160 RID: 143712 RVA: 0x0033E31A File Offset: 0x0033C51A
		public unsafe bool bLinkEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_bLinkEnabled) & UNavLinkCustomComponent.__PropertyMask_bLinkEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_bLinkEnabled) = ((*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_bLinkEnabled) & ~UNavLinkCustomComponent.__PropertyMask_bLinkEnabled) | (value ? UNavLinkCustomComponent.__PropertyMask_bLinkEnabled : 0));
			}
		}

		// Token: 0x170086D2 RID: 34514
		// (get) Token: 0x06023161 RID: 143713 RVA: 0x0033E34A File Offset: 0x0033C54A
		// (set) Token: 0x06023162 RID: 143714 RVA: 0x0033E363 File Offset: 0x0033C563
		public unsafe bool bNotifyWhenEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_bNotifyWhenEnabled) & UNavLinkCustomComponent.__PropertyMask_bNotifyWhenEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_bNotifyWhenEnabled) = ((*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_bNotifyWhenEnabled) & ~UNavLinkCustomComponent.__PropertyMask_bNotifyWhenEnabled) | (value ? UNavLinkCustomComponent.__PropertyMask_bNotifyWhenEnabled : 0));
			}
		}

		// Token: 0x170086D3 RID: 34515
		// (get) Token: 0x06023163 RID: 143715 RVA: 0x0033E393 File Offset: 0x0033C593
		// (set) Token: 0x06023164 RID: 143716 RVA: 0x0033E3AC File Offset: 0x0033C5AC
		public unsafe bool bNotifyWhenDisabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_bNotifyWhenDisabled) & UNavLinkCustomComponent.__PropertyMask_bNotifyWhenDisabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_bNotifyWhenDisabled) = ((*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_bNotifyWhenDisabled) & ~UNavLinkCustomComponent.__PropertyMask_bNotifyWhenDisabled) | (value ? UNavLinkCustomComponent.__PropertyMask_bNotifyWhenDisabled : 0));
			}
		}

		// Token: 0x170086D4 RID: 34516
		// (get) Token: 0x06023165 RID: 143717 RVA: 0x0033E3DC File Offset: 0x0033C5DC
		// (set) Token: 0x06023166 RID: 143718 RVA: 0x0033E3F5 File Offset: 0x0033C5F5
		public unsafe bool bCreateBoxObstacle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_bCreateBoxObstacle) & UNavLinkCustomComponent.__PropertyMask_bCreateBoxObstacle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_bCreateBoxObstacle) = ((*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_bCreateBoxObstacle) & ~UNavLinkCustomComponent.__PropertyMask_bCreateBoxObstacle) | (value ? UNavLinkCustomComponent.__PropertyMask_bCreateBoxObstacle : 0));
			}
		}

		// Token: 0x170086D5 RID: 34517
		// (get) Token: 0x06023167 RID: 143719 RVA: 0x0033E425 File Offset: 0x0033C625
		// (set) Token: 0x06023168 RID: 143720 RVA: 0x0033E439 File Offset: 0x0033C639
		public unsafe FVector ObstacleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_ObstacleOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_ObstacleOffset) = value;
			}
		}

		// Token: 0x170086D6 RID: 34518
		// (get) Token: 0x06023169 RID: 143721 RVA: 0x0033E44E File Offset: 0x0033C64E
		// (set) Token: 0x0602316A RID: 143722 RVA: 0x0033E462 File Offset: 0x0033C662
		public unsafe FVector ObstacleExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_ObstacleExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_ObstacleExtent) = value;
			}
		}

		// Token: 0x170086D7 RID: 34519
		// (get) Token: 0x0602316B RID: 143723 RVA: 0x0033E477 File Offset: 0x0033C677
		// (set) Token: 0x0602316C RID: 143724 RVA: 0x0033E48B File Offset: 0x0033C68B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> ObstacleAreaClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_ObstacleAreaClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_ObstacleAreaClass) = value;
			}
		}

		// Token: 0x170086D8 RID: 34520
		// (get) Token: 0x0602316D RID: 143725 RVA: 0x0033E4A0 File Offset: 0x0033C6A0
		// (set) Token: 0x0602316E RID: 143726 RVA: 0x0033E4B0 File Offset: 0x0033C6B0
		public unsafe float BroadcastRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_BroadcastRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_BroadcastRadius) = value;
			}
		}

		// Token: 0x170086D9 RID: 34521
		// (get) Token: 0x0602316F RID: 143727 RVA: 0x0033E4C1 File Offset: 0x0033C6C1
		// (set) Token: 0x06023170 RID: 143728 RVA: 0x0033E4D1 File Offset: 0x0033C6D1
		public unsafe float BroadcastInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_BroadcastInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_BroadcastInterval) = value;
			}
		}

		// Token: 0x170086DA RID: 34522
		// (get) Token: 0x06023171 RID: 143729 RVA: 0x0033E4E2 File Offset: 0x0033C6E2
		// (set) Token: 0x06023172 RID: 143730 RVA: 0x0033E4F6 File Offset: 0x0033C6F6
		public unsafe TEnumAsByte<ECollisionChannel> BroadcastChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_BroadcastChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavLinkCustomComponent.__PropertyOffset_BroadcastChannel) = value;
			}
		}

		// Token: 0x06023173 RID: 143731 RVA: 0x0033E50B File Offset: 0x0033C70B
		static UNavLinkCustomComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavLinkCustomComponent");
		}

		// Token: 0x06023174 RID: 143732 RVA: 0x0033E519 File Offset: 0x0033C719
		protected UNavLinkCustomComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BA2 RID: 76706
		internal static int __InterfaceOffset_INavLinkCustomInterface;

		// Token: 0x04012BA3 RID: 76707
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavLinkCustomComponent";

		// Token: 0x04012BA4 RID: 76708
		private static IntPtr _ClassPtr;

		// Token: 0x04012BA5 RID: 76709
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012BA6 RID: 76710
		internal static int __PropertyOffset_NavLinkUserId;

		// Token: 0x04012BA7 RID: 76711
		internal static int __PropertyOffset_EnabledAreaClass;

		// Token: 0x04012BA8 RID: 76712
		internal static int __PropertyOffset_DisabledAreaClass;

		// Token: 0x04012BA9 RID: 76713
		internal static int __PropertyOffset_SupportedAgents;

		// Token: 0x04012BAA RID: 76714
		[Nullable(2)]
		private FNavAgentSelector _SupportedAgents;

		// Token: 0x04012BAB RID: 76715
		internal static int __PropertyOffset_LinkRelativeStart;

		// Token: 0x04012BAC RID: 76716
		internal static int __PropertyOffset_LinkRelativeEnd;

		// Token: 0x04012BAD RID: 76717
		internal static int __PropertyOffset_LinkDirection;

		// Token: 0x04012BAE RID: 76718
		internal static int __PropertyOffset_bLinkEnabled;

		// Token: 0x04012BAF RID: 76719
		internal static byte __PropertyMask_bLinkEnabled;

		// Token: 0x04012BB0 RID: 76720
		internal static int __PropertyOffset_bNotifyWhenEnabled;

		// Token: 0x04012BB1 RID: 76721
		internal static byte __PropertyMask_bNotifyWhenEnabled;

		// Token: 0x04012BB2 RID: 76722
		internal static int __PropertyOffset_bNotifyWhenDisabled;

		// Token: 0x04012BB3 RID: 76723
		internal static byte __PropertyMask_bNotifyWhenDisabled;

		// Token: 0x04012BB4 RID: 76724
		internal static int __PropertyOffset_bCreateBoxObstacle;

		// Token: 0x04012BB5 RID: 76725
		internal static byte __PropertyMask_bCreateBoxObstacle;

		// Token: 0x04012BB6 RID: 76726
		internal static int __PropertyOffset_ObstacleOffset;

		// Token: 0x04012BB7 RID: 76727
		internal static int __PropertyOffset_ObstacleExtent;

		// Token: 0x04012BB8 RID: 76728
		internal static int __PropertyOffset_ObstacleAreaClass;

		// Token: 0x04012BB9 RID: 76729
		internal static int __PropertyOffset_BroadcastRadius;

		// Token: 0x04012BBA RID: 76730
		internal static int __PropertyOffset_BroadcastInterval;

		// Token: 0x04012BBB RID: 76731
		internal static int __PropertyOffset_BroadcastChannel;
	}
}
