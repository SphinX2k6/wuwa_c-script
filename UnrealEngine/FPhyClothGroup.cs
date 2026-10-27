using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200167C RID: 5756
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.PhyClothGroup")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FPhyClothGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014E1E RID: 85534 RVA: 0x001EB2F0 File Offset: 0x001E94F0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPhyClothGroup._ScriptStructPtr != 0) ? FPhyClothGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.PhyClothGroup", ref FPhyClothGroup._ScriptStructPtr);
		}

		// Token: 0x170052B7 RID: 21175
		// (get) Token: 0x06014E1F RID: 85535 RVA: 0x001EB314 File Offset: 0x001E9514
		// (set) Token: 0x06014E20 RID: 85536 RVA: 0x001EB357 File Offset: 0x001E9557
		public TArray<FPhyClothLine> RootBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPhyClothLine> result;
				if ((result = this._RootBones) == null)
				{
					result = (this._RootBones = new TArray<FPhyClothLine>(base.NativePtr + (IntPtr)FPhyClothGroup.__PropertyOffset_RootBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RootBones.CopyAssign(value);
			}
		}

		// Token: 0x170052B8 RID: 21176
		// (get) Token: 0x06014E21 RID: 85537 RVA: 0x001EB365 File Offset: 0x001E9565
		// (set) Token: 0x06014E22 RID: 85538 RVA: 0x001EB375 File Offset: 0x001E9575
		public unsafe EClothType Type
		{
			get
			{
				return (EClothType)(*(base.NativePtr + (IntPtr)FPhyClothGroup.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothGroup.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x170052B9 RID: 21177
		// (get) Token: 0x06014E23 RID: 85539 RVA: 0x001EB388 File Offset: 0x001E9588
		// (set) Token: 0x06014E24 RID: 85540 RVA: 0x001EB3CB File Offset: 0x001E95CB
		public TArray<FBoneReference> ExceptBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._ExceptBones) == null)
				{
					result = (this._ExceptBones = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FPhyClothGroup.__PropertyOffset_ExceptBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExceptBones.CopyAssign(value);
			}
		}

		// Token: 0x170052BA RID: 21178
		// (get) Token: 0x06014E25 RID: 85541 RVA: 0x001EB3DC File Offset: 0x001E95DC
		// (set) Token: 0x06014E26 RID: 85542 RVA: 0x001EB41F File Offset: 0x001E961F
		public TArray<FBoneReference> HelperLinkBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._HelperLinkBones) == null)
				{
					result = (this._HelperLinkBones = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FPhyClothGroup.__PropertyOffset_HelperLinkBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HelperLinkBones.CopyAssign(value);
			}
		}

		// Token: 0x170052BB RID: 21179
		// (get) Token: 0x06014E27 RID: 85543 RVA: 0x001EB430 File Offset: 0x001E9630
		// (set) Token: 0x06014E28 RID: 85544 RVA: 0x001EB473 File Offset: 0x001E9673
		public FPhyClothConfig Config
		{
			get
			{
				base.FastCheckIsValid();
				FPhyClothConfig result;
				if ((result = this._Config) == null)
				{
					result = (this._Config = new FPhyClothConfig(base.NativePtr + (IntPtr)FPhyClothGroup.__PropertyOffset_Config, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPhyClothConfig.StaticStruct(), base.NativePtr + (IntPtr)FPhyClothGroup.__PropertyOffset_Config, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170052BC RID: 21180
		// (get) Token: 0x06014E29 RID: 85545 RVA: 0x001EB494 File Offset: 0x001E9694
		// (set) Token: 0x06014E2A RID: 85546 RVA: 0x001EB4D7 File Offset: 0x001E96D7
		public TArray<FPhyClothCollision> Collisions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPhyClothCollision> result;
				if ((result = this._Collisions) == null)
				{
					result = (this._Collisions = new TArray<FPhyClothCollision>(base.NativePtr + (IntPtr)FPhyClothGroup.__PropertyOffset_Collisions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Collisions.CopyAssign(value);
			}
		}

		// Token: 0x170052BD RID: 21181
		// (get) Token: 0x06014E2B RID: 85547 RVA: 0x001EB4E5 File Offset: 0x001E96E5
		// (set) Token: 0x06014E2C RID: 85548 RVA: 0x001EB4F9 File Offset: 0x001E96F9
		public unsafe FVector CenterLineStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothGroup.__PropertyOffset_CenterLineStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothGroup.__PropertyOffset_CenterLineStart) = value;
			}
		}

		// Token: 0x170052BE RID: 21182
		// (get) Token: 0x06014E2D RID: 85549 RVA: 0x001EB50E File Offset: 0x001E970E
		// (set) Token: 0x06014E2E RID: 85550 RVA: 0x001EB522 File Offset: 0x001E9722
		public unsafe FVector CenterLineDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhyClothGroup.__PropertyOffset_CenterLineDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhyClothGroup.__PropertyOffset_CenterLineDirect) = value;
			}
		}

		// Token: 0x06014E2F RID: 85551 RVA: 0x001EB537 File Offset: 0x001E9737
		public FPhyClothGroup()
		{
		}

		// Token: 0x06014E30 RID: 85552 RVA: 0x001EB540 File Offset: 0x001E9740
		public FPhyClothGroup(TArray<FPhyClothLine> RootBones, EClothType Type, TArray<FBoneReference> ExceptBones, TArray<FBoneReference> HelperLinkBones, FPhyClothConfig Config, TArray<FPhyClothCollision> Collisions, FVector CenterLineStart, FVector CenterLineDirect)
		{
			this.RootBones = RootBones;
			this.Type = Type;
			this.ExceptBones = ExceptBones;
			this.HelperLinkBones = HelperLinkBones;
			this.Config = Config;
			this.Collisions = Collisions;
			this.CenterLineStart = CenterLineStart;
			this.CenterLineDirect = CenterLineDirect;
		}

		// Token: 0x06014E31 RID: 85553 RVA: 0x001EB590 File Offset: 0x001E9790
		protected override IntPtr GetUStructPtr()
		{
			return FPhyClothGroup.StaticStruct();
		}

		// Token: 0x06014E32 RID: 85554 RVA: 0x001EB59C File Offset: 0x001E979C
		[NullableContext(2)]
		public FPhyClothGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014E33 RID: 85555 RVA: 0x001EB5A6 File Offset: 0x001E97A6
		public FPhyClothGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014E34 RID: 85556 RVA: 0x001EB5B1 File Offset: 0x001E97B1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPhyClothGroup(Pointer, false, true);
		}

		// Token: 0x06014E35 RID: 85557 RVA: 0x001EB5BB File Offset: 0x001E97BB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPhyClothGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400B60C RID: 46604
		public const string __ObjectPath = "/Script/KuroAnim.PhyClothGroup";

		// Token: 0x0400B60D RID: 46605
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B60E RID: 46606
		internal static int __PropertyOffset_RootBones;

		// Token: 0x0400B60F RID: 46607
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPhyClothLine> _RootBones;

		// Token: 0x0400B610 RID: 46608
		internal static int __PropertyOffset_Type;

		// Token: 0x0400B611 RID: 46609
		internal static int __PropertyOffset_ExceptBones;

		// Token: 0x0400B612 RID: 46610
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _ExceptBones;

		// Token: 0x0400B613 RID: 46611
		internal static int __PropertyOffset_HelperLinkBones;

		// Token: 0x0400B614 RID: 46612
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _HelperLinkBones;

		// Token: 0x0400B615 RID: 46613
		internal static int __PropertyOffset_Config;

		// Token: 0x0400B616 RID: 46614
		[Nullable(2)]
		private FPhyClothConfig _Config;

		// Token: 0x0400B617 RID: 46615
		internal static int __PropertyOffset_Collisions;

		// Token: 0x0400B618 RID: 46616
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPhyClothCollision> _Collisions;

		// Token: 0x0400B619 RID: 46617
		internal static int __PropertyOffset_CenterLineStart;

		// Token: 0x0400B61A RID: 46618
		internal static int __PropertyOffset_CenterLineDirect;
	}
}
