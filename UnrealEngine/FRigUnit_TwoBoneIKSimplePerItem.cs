using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F4 RID: 1780
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 464)]
	public class FRigUnit_TwoBoneIKSimplePerItem : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005FF8 RID: 24568 RVA: 0x00089A64 File Offset: 0x00087C64
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TwoBoneIKSimplePerItem._ScriptStructPtr != 0) ? FRigUnit_TwoBoneIKSimplePerItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem", ref FRigUnit_TwoBoneIKSimplePerItem._ScriptStructPtr);
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x06005FF9 RID: 24569 RVA: 0x00089A88 File Offset: 0x00087C88
		// (set) Token: 0x06005FFA RID: 24570 RVA: 0x00089ACB File Offset: 0x00087CCB
		public FRigElementKey ItemA
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._ItemA) == null)
				{
					result = (this._ItemA = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_ItemA, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_ItemA, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x06005FFB RID: 24571 RVA: 0x00089AEC File Offset: 0x00087CEC
		// (set) Token: 0x06005FFC RID: 24572 RVA: 0x00089B2F File Offset: 0x00087D2F
		public FRigElementKey ItemB
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._ItemB) == null)
				{
					result = (this._ItemB = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_ItemB, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_ItemB, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06005FFD RID: 24573 RVA: 0x00089B50 File Offset: 0x00087D50
		// (set) Token: 0x06005FFE RID: 24574 RVA: 0x00089B93 File Offset: 0x00087D93
		public FRigElementKey EffectorItem
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._EffectorItem) == null)
				{
					result = (this._EffectorItem = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_EffectorItem, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_EffectorItem, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06005FFF RID: 24575 RVA: 0x00089BB4 File Offset: 0x00087DB4
		// (set) Token: 0x06006000 RID: 24576 RVA: 0x00089BC8 File Offset: 0x00087DC8
		public unsafe FTransform Effector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_Effector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_Effector) = value;
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06006001 RID: 24577 RVA: 0x00089BDD File Offset: 0x00087DDD
		// (set) Token: 0x06006002 RID: 24578 RVA: 0x00089BF1 File Offset: 0x00087DF1
		public unsafe FVector PrimaryAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_PrimaryAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_PrimaryAxis) = value;
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06006003 RID: 24579 RVA: 0x00089C06 File Offset: 0x00087E06
		// (set) Token: 0x06006004 RID: 24580 RVA: 0x00089C1A File Offset: 0x00087E1A
		public unsafe FVector SecondaryAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_SecondaryAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_SecondaryAxis) = value;
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06006005 RID: 24581 RVA: 0x00089C2F File Offset: 0x00087E2F
		// (set) Token: 0x06006006 RID: 24582 RVA: 0x00089C3F File Offset: 0x00087E3F
		public unsafe float SecondaryAxisWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_SecondaryAxisWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_SecondaryAxisWeight) = value;
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06006007 RID: 24583 RVA: 0x00089C50 File Offset: 0x00087E50
		// (set) Token: 0x06006008 RID: 24584 RVA: 0x00089C64 File Offset: 0x00087E64
		public unsafe FVector PoleVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_PoleVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_PoleVector) = value;
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06006009 RID: 24585 RVA: 0x00089C79 File Offset: 0x00087E79
		// (set) Token: 0x0600600A RID: 24586 RVA: 0x00089C89 File Offset: 0x00087E89
		public unsafe EControlRigVectorKind PoleVectorKind
		{
			get
			{
				return (EControlRigVectorKind)(*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_PoleVectorKind));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_PoleVectorKind) = (byte)value;
			}
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x0600600B RID: 24587 RVA: 0x00089C9C File Offset: 0x00087E9C
		// (set) Token: 0x0600600C RID: 24588 RVA: 0x00089CDF File Offset: 0x00087EDF
		public FRigElementKey PoleVectorSpace
		{
			get
			{
				base.FastCheckIsValid();
				FRigElementKey result;
				if ((result = this._PoleVectorSpace) == null)
				{
					result = (this._PoleVectorSpace = new FRigElementKey(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_PoleVectorSpace, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigElementKey.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_PoleVectorSpace, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x0600600D RID: 24589 RVA: 0x00089D00 File Offset: 0x00087F00
		// (set) Token: 0x0600600E RID: 24590 RVA: 0x00089D10 File Offset: 0x00087F10
		public unsafe bool bEnableStretch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_bEnableStretch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_bEnableStretch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x0600600F RID: 24591 RVA: 0x00089D21 File Offset: 0x00087F21
		// (set) Token: 0x06006010 RID: 24592 RVA: 0x00089D31 File Offset: 0x00087F31
		public unsafe float StretchStartRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_StretchStartRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_StretchStartRatio) = value;
			}
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x06006011 RID: 24593 RVA: 0x00089D42 File Offset: 0x00087F42
		// (set) Token: 0x06006012 RID: 24594 RVA: 0x00089D52 File Offset: 0x00087F52
		public unsafe float StretchMaximumRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_StretchMaximumRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_StretchMaximumRatio) = value;
			}
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x06006013 RID: 24595 RVA: 0x00089D63 File Offset: 0x00087F63
		// (set) Token: 0x06006014 RID: 24596 RVA: 0x00089D73 File Offset: 0x00087F73
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06006015 RID: 24597 RVA: 0x00089D84 File Offset: 0x00087F84
		// (set) Token: 0x06006016 RID: 24598 RVA: 0x00089D94 File Offset: 0x00087F94
		public unsafe float ItemALength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_ItemALength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_ItemALength) = value;
			}
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x06006017 RID: 24599 RVA: 0x00089DA5 File Offset: 0x00087FA5
		// (set) Token: 0x06006018 RID: 24600 RVA: 0x00089DB5 File Offset: 0x00087FB5
		public unsafe float ItemBLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_ItemBLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_ItemBLength) = value;
			}
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x06006019 RID: 24601 RVA: 0x00089DC6 File Offset: 0x00087FC6
		// (set) Token: 0x0600601A RID: 24602 RVA: 0x00089DD6 File Offset: 0x00087FD6
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x0600601B RID: 24603 RVA: 0x00089DE8 File Offset: 0x00087FE8
		// (set) Token: 0x0600601C RID: 24604 RVA: 0x00089E2B File Offset: 0x0008802B
		public FRigUnit_TwoBoneIKSimple_DebugSettings DebugSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_TwoBoneIKSimple_DebugSettings result;
				if ((result = this._DebugSettings) == null)
				{
					result = (this._DebugSettings = new FRigUnit_TwoBoneIKSimple_DebugSettings(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_DebugSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_TwoBoneIKSimple_DebugSettings.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_DebugSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x0600601D RID: 24605 RVA: 0x00089E4C File Offset: 0x0008804C
		// (set) Token: 0x0600601E RID: 24606 RVA: 0x00089E8F File Offset: 0x0008808F
		public FCachedRigElement CachedItemAIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedItemAIndex) == null)
				{
					result = (this._CachedItemAIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_CachedItemAIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_CachedItemAIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x0600601F RID: 24607 RVA: 0x00089EB0 File Offset: 0x000880B0
		// (set) Token: 0x06006020 RID: 24608 RVA: 0x00089EF3 File Offset: 0x000880F3
		public FCachedRigElement CachedItemBIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedItemBIndex) == null)
				{
					result = (this._CachedItemBIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_CachedItemBIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_CachedItemBIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x06006021 RID: 24609 RVA: 0x00089F14 File Offset: 0x00088114
		// (set) Token: 0x06006022 RID: 24610 RVA: 0x00089F57 File Offset: 0x00088157
		public FCachedRigElement CachedEffectorItemIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedEffectorItemIndex) == null)
				{
					result = (this._CachedEffectorItemIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_CachedEffectorItemIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_CachedEffectorItemIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x06006023 RID: 24611 RVA: 0x00089F78 File Offset: 0x00088178
		// (set) Token: 0x06006024 RID: 24612 RVA: 0x00089FBB File Offset: 0x000881BB
		public FCachedRigElement CachedPoleVectorSpaceIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedPoleVectorSpaceIndex) == null)
				{
					result = (this._CachedPoleVectorSpaceIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_CachedPoleVectorSpaceIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwoBoneIKSimplePerItem.__PropertyOffset_CachedPoleVectorSpaceIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x00089FDC File Offset: 0x000881DC
		public FRigUnit_TwoBoneIKSimplePerItem()
		{
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x00089FE4 File Offset: 0x000881E4
		public FRigUnit_TwoBoneIKSimplePerItem(FRigElementKey ItemA, FRigElementKey ItemB, FRigElementKey EffectorItem, FTransform Effector, FVector PrimaryAxis, FVector SecondaryAxis, float SecondaryAxisWeight, FVector PoleVector, EControlRigVectorKind PoleVectorKind, FRigElementKey PoleVectorSpace, bool bEnableStretch, float StretchStartRatio, float StretchMaximumRatio, float Weight, float ItemALength, float ItemBLength, bool bPropagateToChildren, FRigUnit_TwoBoneIKSimple_DebugSettings DebugSettings, FCachedRigElement CachedItemAIndex, FCachedRigElement CachedItemBIndex, FCachedRigElement CachedEffectorItemIndex, FCachedRigElement CachedPoleVectorSpaceIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.ItemA = ItemA;
			this.ItemB = ItemB;
			this.EffectorItem = EffectorItem;
			this.Effector = Effector;
			this.PrimaryAxis = PrimaryAxis;
			this.SecondaryAxis = SecondaryAxis;
			this.SecondaryAxisWeight = SecondaryAxisWeight;
			this.PoleVector = PoleVector;
			this.PoleVectorKind = PoleVectorKind;
			this.PoleVectorSpace = PoleVectorSpace;
			this.bEnableStretch = bEnableStretch;
			this.StretchStartRatio = StretchStartRatio;
			this.StretchMaximumRatio = StretchMaximumRatio;
			this.Weight = Weight;
			this.ItemALength = ItemALength;
			this.ItemBLength = ItemBLength;
			this.bPropagateToChildren = bPropagateToChildren;
			this.DebugSettings = DebugSettings;
			this.CachedItemAIndex = CachedItemAIndex;
			this.CachedItemBIndex = CachedItemBIndex;
			this.CachedEffectorItemIndex = CachedEffectorItemIndex;
			this.CachedPoleVectorSpaceIndex = CachedPoleVectorSpaceIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x0008A0AC File Offset: 0x000882AC
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TwoBoneIKSimplePerItem.StaticStruct();
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x0008A0B8 File Offset: 0x000882B8
		[NullableContext(2)]
		public FRigUnit_TwoBoneIKSimplePerItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x0008A0C2 File Offset: 0x000882C2
		public FRigUnit_TwoBoneIKSimplePerItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x0008A0CD File Offset: 0x000882CD
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TwoBoneIKSimplePerItem(Pointer, false, true);
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x0008A0D7 File Offset: 0x000882D7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TwoBoneIKSimplePerItem(Pointer, MemoryOwner);
		}

		// Token: 0x04002CE2 RID: 11490
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_TwoBoneIKSimplePerItem";

		// Token: 0x04002CE3 RID: 11491
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002CE4 RID: 11492
		internal static int __PropertyOffset_ItemA;

		// Token: 0x04002CE5 RID: 11493
		[Nullable(2)]
		private FRigElementKey _ItemA;

		// Token: 0x04002CE6 RID: 11494
		internal static int __PropertyOffset_ItemB;

		// Token: 0x04002CE7 RID: 11495
		[Nullable(2)]
		private FRigElementKey _ItemB;

		// Token: 0x04002CE8 RID: 11496
		internal static int __PropertyOffset_EffectorItem;

		// Token: 0x04002CE9 RID: 11497
		[Nullable(2)]
		private FRigElementKey _EffectorItem;

		// Token: 0x04002CEA RID: 11498
		internal static int __PropertyOffset_Effector;

		// Token: 0x04002CEB RID: 11499
		internal static int __PropertyOffset_PrimaryAxis;

		// Token: 0x04002CEC RID: 11500
		internal static int __PropertyOffset_SecondaryAxis;

		// Token: 0x04002CED RID: 11501
		internal static int __PropertyOffset_SecondaryAxisWeight;

		// Token: 0x04002CEE RID: 11502
		internal static int __PropertyOffset_PoleVector;

		// Token: 0x04002CEF RID: 11503
		internal static int __PropertyOffset_PoleVectorKind;

		// Token: 0x04002CF0 RID: 11504
		internal static int __PropertyOffset_PoleVectorSpace;

		// Token: 0x04002CF1 RID: 11505
		[Nullable(2)]
		private FRigElementKey _PoleVectorSpace;

		// Token: 0x04002CF2 RID: 11506
		internal static int __PropertyOffset_bEnableStretch;

		// Token: 0x04002CF3 RID: 11507
		internal static int __PropertyOffset_StretchStartRatio;

		// Token: 0x04002CF4 RID: 11508
		internal static int __PropertyOffset_StretchMaximumRatio;

		// Token: 0x04002CF5 RID: 11509
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002CF6 RID: 11510
		internal static int __PropertyOffset_ItemALength;

		// Token: 0x04002CF7 RID: 11511
		internal static int __PropertyOffset_ItemBLength;

		// Token: 0x04002CF8 RID: 11512
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002CF9 RID: 11513
		internal static int __PropertyOffset_DebugSettings;

		// Token: 0x04002CFA RID: 11514
		[Nullable(2)]
		private FRigUnit_TwoBoneIKSimple_DebugSettings _DebugSettings;

		// Token: 0x04002CFB RID: 11515
		internal static int __PropertyOffset_CachedItemAIndex;

		// Token: 0x04002CFC RID: 11516
		[Nullable(2)]
		private FCachedRigElement _CachedItemAIndex;

		// Token: 0x04002CFD RID: 11517
		internal static int __PropertyOffset_CachedItemBIndex;

		// Token: 0x04002CFE RID: 11518
		[Nullable(2)]
		private FCachedRigElement _CachedItemBIndex;

		// Token: 0x04002CFF RID: 11519
		internal static int __PropertyOffset_CachedEffectorItemIndex;

		// Token: 0x04002D00 RID: 11520
		[Nullable(2)]
		private FCachedRigElement _CachedEffectorItemIndex;

		// Token: 0x04002D01 RID: 11521
		internal static int __PropertyOffset_CachedPoleVectorSpaceIndex;

		// Token: 0x04002D02 RID: 11522
		[Nullable(2)]
		private FCachedRigElement _CachedPoleVectorSpaceIndex;
	}
}
