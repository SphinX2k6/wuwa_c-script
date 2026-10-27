using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000ED4 RID: 3796
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Engine.NavDataConfig")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FNavDataConfig : FNavAgentProperties, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CDA4 RID: 52644 RVA: 0x0012BCD5 File Offset: 0x00129ED5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNavDataConfig._ScriptStructPtr != 0) ? FNavDataConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NavDataConfig", ref FNavDataConfig._ScriptStructPtr);
		}

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x0600CDA5 RID: 52645 RVA: 0x0012BCF9 File Offset: 0x00129EF9
		// (set) Token: 0x0600CDA6 RID: 52646 RVA: 0x0012BD0D File Offset: 0x00129F0D
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavDataConfig.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavDataConfig.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x0600CDA7 RID: 52647 RVA: 0x0012BD22 File Offset: 0x00129F22
		// (set) Token: 0x0600CDA8 RID: 52648 RVA: 0x0012BD36 File Offset: 0x00129F36
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavDataConfig.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavDataConfig.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x0600CDA9 RID: 52649 RVA: 0x0012BD4B File Offset: 0x00129F4B
		// (set) Token: 0x0600CDAA RID: 52650 RVA: 0x0012BD5F File Offset: 0x00129F5F
		public unsafe FVector DefaultQueryExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNavDataConfig.__PropertyOffset_DefaultQueryExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNavDataConfig.__PropertyOffset_DefaultQueryExtent) = value;
			}
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x0600CDAB RID: 52651 RVA: 0x0012BD74 File Offset: 0x00129F74
		// (set) Token: 0x0600CDAC RID: 52652 RVA: 0x0012BD8D File Offset: 0x00129F8D
		public unsafe bool bDefaultBuild
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNavDataConfig.__PropertyOffset_bDefaultBuild) & FNavDataConfig.__PropertyMask_bDefaultBuild) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNavDataConfig.__PropertyOffset_bDefaultBuild) = ((*(base.NativePtr + (IntPtr)FNavDataConfig.__PropertyOffset_bDefaultBuild) & ~FNavDataConfig.__PropertyMask_bDefaultBuild) | (value ? FNavDataConfig.__PropertyMask_bDefaultBuild : 0));
			}
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x0600CDAD RID: 52653 RVA: 0x0012BDBD File Offset: 0x00129FBD
		// (set) Token: 0x0600CDAE RID: 52654 RVA: 0x0012BDD1 File Offset: 0x00129FD1
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<AActor> NavigationDataClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FNavDataConfig.__PropertyOffset_NavigationDataClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FNavDataConfig.__PropertyOffset_NavigationDataClass) = value;
			}
		}

		// Token: 0x17003069 RID: 12393
		// (get) Token: 0x0600CDAF RID: 52655 RVA: 0x0012BDE6 File Offset: 0x00129FE6
		// (set) Token: 0x0600CDB0 RID: 52656 RVA: 0x0012BE05 File Offset: 0x0012A005
		public TSoftClassPtr<AActor> NavDataClass
		{
			get
			{
				return new TSoftClassPtr<AActor>(base.NativePtr + (IntPtr)FNavDataConfig.__PropertyOffset_NavDataClass, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FNavDataConfig.__PropertyOffset_NavDataClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0600CDB1 RID: 52657 RVA: 0x0012BE2A File Offset: 0x0012A02A
		public FNavDataConfig()
		{
		}

		// Token: 0x0600CDB2 RID: 52658 RVA: 0x0012BE34 File Offset: 0x0012A034
		public FNavDataConfig(FName Name, FColor Color, FVector DefaultQueryExtent, bool bDefaultBuild, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> NavigationDataClass, TSoftClassPtr<AActor> NavDataClass, float AgentRadius, float AgentHeight, float AgentStepHeight, float NavWalkingSearchHeightScale, FSoftClassPath PreferredNavData, ENavMeshTargetPlatform TargetPlatform, bool bCanCrouch, bool bCanJump, bool bCanWalk, bool bCanSwim, bool bCanFly)
		{
			this.Name = Name;
			this.Color = Color;
			this.DefaultQueryExtent = DefaultQueryExtent;
			this.bDefaultBuild = bDefaultBuild;
			this.NavigationDataClass = NavigationDataClass;
			this.NavDataClass = NavDataClass;
			base.AgentRadius = AgentRadius;
			base.AgentHeight = AgentHeight;
			base.AgentStepHeight = AgentStepHeight;
			base.NavWalkingSearchHeightScale = NavWalkingSearchHeightScale;
			base.PreferredNavData = PreferredNavData;
			base.TargetPlatform = TargetPlatform;
			base.bCanCrouch = bCanCrouch;
			base.bCanJump = bCanJump;
			base.bCanWalk = bCanWalk;
			base.bCanSwim = bCanSwim;
			base.bCanFly = bCanFly;
		}

		// Token: 0x0600CDB3 RID: 52659 RVA: 0x0012BECC File Offset: 0x0012A0CC
		protected override IntPtr GetUStructPtr()
		{
			return FNavDataConfig.StaticStruct();
		}

		// Token: 0x0600CDB4 RID: 52660 RVA: 0x0012BED8 File Offset: 0x0012A0D8
		[NullableContext(2)]
		public FNavDataConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CDB5 RID: 52661 RVA: 0x0012BEE2 File Offset: 0x0012A0E2
		public FNavDataConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CDB6 RID: 52662 RVA: 0x0012BEED File Offset: 0x0012A0ED
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNavDataConfig(Pointer, false, true);
		}

		// Token: 0x0600CDB7 RID: 52663 RVA: 0x0012BEF7 File Offset: 0x0012A0F7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNavDataConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04006ECD RID: 28365
		public new const string __ObjectPath = "/Script/Engine.NavDataConfig";

		// Token: 0x04006ECE RID: 28366
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006ECF RID: 28367
		internal static int __PropertyOffset_Name;

		// Token: 0x04006ED0 RID: 28368
		internal static int __PropertyOffset_Color;

		// Token: 0x04006ED1 RID: 28369
		internal static int __PropertyOffset_DefaultQueryExtent;

		// Token: 0x04006ED2 RID: 28370
		internal static int __PropertyOffset_bDefaultBuild;

		// Token: 0x04006ED3 RID: 28371
		internal static byte __PropertyMask_bDefaultBuild;

		// Token: 0x04006ED4 RID: 28372
		internal static int __PropertyOffset_NavigationDataClass;

		// Token: 0x04006ED5 RID: 28373
		internal static int __PropertyOffset_NavDataClass;
	}
}
