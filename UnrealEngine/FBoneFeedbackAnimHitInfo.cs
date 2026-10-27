using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200162A RID: 5674
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.BoneFeedbackAnimHitInfo")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FBoneFeedbackAnimHitInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601487E RID: 84094 RVA: 0x001E3444 File Offset: 0x001E1644
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneFeedbackAnimHitInfo._ScriptStructPtr != 0) ? FBoneFeedbackAnimHitInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.BoneFeedbackAnimHitInfo", ref FBoneFeedbackAnimHitInfo._ScriptStructPtr);
		}

		// Token: 0x170050D9 RID: 20697
		// (get) Token: 0x0601487F RID: 84095 RVA: 0x001E3468 File Offset: 0x001E1668
		// (set) Token: 0x06014880 RID: 84096 RVA: 0x001E34AB File Offset: 0x001E16AB
		public TArray<FName> FirstHitBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._FirstHitBoneNames) == null)
				{
					result = (this._FirstHitBoneNames = new TArray<FName>(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_FirstHitBoneNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FirstHitBoneNames.CopyAssign(value);
			}
		}

		// Token: 0x170050DA RID: 20698
		// (get) Token: 0x06014881 RID: 84097 RVA: 0x001E34BC File Offset: 0x001E16BC
		// (set) Token: 0x06014882 RID: 84098 RVA: 0x001E34FF File Offset: 0x001E16FF
		public TArray<FName> HitBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._HitBoneNames) == null)
				{
					result = (this._HitBoneNames = new TArray<FName>(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_HitBoneNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HitBoneNames.CopyAssign(value);
			}
		}

		// Token: 0x170050DB RID: 20699
		// (get) Token: 0x06014883 RID: 84099 RVA: 0x001E350D File Offset: 0x001E170D
		// (set) Token: 0x06014884 RID: 84100 RVA: 0x001E3521 File Offset: 0x001E1721
		public unsafe FVectorDouble AttackPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_AttackPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_AttackPoint) = value;
			}
		}

		// Token: 0x170050DC RID: 20700
		// (get) Token: 0x06014885 RID: 84101 RVA: 0x001E3536 File Offset: 0x001E1736
		// (set) Token: 0x06014886 RID: 84102 RVA: 0x001E354A File Offset: 0x001E174A
		public unsafe FVector HitVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_HitVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_HitVector) = value;
			}
		}

		// Token: 0x170050DD RID: 20701
		// (get) Token: 0x06014887 RID: 84103 RVA: 0x001E355F File Offset: 0x001E175F
		// (set) Token: 0x06014888 RID: 84104 RVA: 0x001E356F File Offset: 0x001E176F
		public unsafe int StateType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_StateType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_StateType) = value;
			}
		}

		// Token: 0x170050DE RID: 20702
		// (get) Token: 0x06014889 RID: 84105 RVA: 0x001E3580 File Offset: 0x001E1780
		// (set) Token: 0x0601488A RID: 84106 RVA: 0x001E3590 File Offset: 0x001E1790
		public unsafe int HitType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_HitType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFeedbackAnimHitInfo.__PropertyOffset_HitType) = value;
			}
		}

		// Token: 0x0601488B RID: 84107 RVA: 0x001E35A1 File Offset: 0x001E17A1
		public FBoneFeedbackAnimHitInfo()
		{
		}

		// Token: 0x0601488C RID: 84108 RVA: 0x001E35A9 File Offset: 0x001E17A9
		public FBoneFeedbackAnimHitInfo(TArray<FName> FirstHitBoneNames, TArray<FName> HitBoneNames, FVectorDouble AttackPoint, FVector HitVector, int StateType, int HitType)
		{
			this.FirstHitBoneNames = FirstHitBoneNames;
			this.HitBoneNames = HitBoneNames;
			this.AttackPoint = AttackPoint;
			this.HitVector = HitVector;
			this.StateType = StateType;
			this.HitType = HitType;
		}

		// Token: 0x0601488D RID: 84109 RVA: 0x001E35DE File Offset: 0x001E17DE
		protected override IntPtr GetUStructPtr()
		{
			return FBoneFeedbackAnimHitInfo.StaticStruct();
		}

		// Token: 0x0601488E RID: 84110 RVA: 0x001E35EA File Offset: 0x001E17EA
		[NullableContext(2)]
		public FBoneFeedbackAnimHitInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601488F RID: 84111 RVA: 0x001E35F4 File Offset: 0x001E17F4
		public FBoneFeedbackAnimHitInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014890 RID: 84112 RVA: 0x001E35FF File Offset: 0x001E17FF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneFeedbackAnimHitInfo(Pointer, false, true);
		}

		// Token: 0x06014891 RID: 84113 RVA: 0x001E3609 File Offset: 0x001E1809
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneFeedbackAnimHitInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400B2A4 RID: 45732
		public const string __ObjectPath = "/Script/KuroAnim.BoneFeedbackAnimHitInfo";

		// Token: 0x0400B2A5 RID: 45733
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B2A6 RID: 45734
		internal static int __PropertyOffset_FirstHitBoneNames;

		// Token: 0x0400B2A7 RID: 45735
		[Nullable(2)]
		private TArray<FName> _FirstHitBoneNames;

		// Token: 0x0400B2A8 RID: 45736
		internal static int __PropertyOffset_HitBoneNames;

		// Token: 0x0400B2A9 RID: 45737
		[Nullable(2)]
		private TArray<FName> _HitBoneNames;

		// Token: 0x0400B2AA RID: 45738
		internal static int __PropertyOffset_AttackPoint;

		// Token: 0x0400B2AB RID: 45739
		internal static int __PropertyOffset_HitVector;

		// Token: 0x0400B2AC RID: 45740
		internal static int __PropertyOffset_StateType;

		// Token: 0x0400B2AD RID: 45741
		internal static int __PropertyOffset_HitType;
	}
}
