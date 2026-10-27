using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007E9 RID: 2025
	[UnrealObjectPath("/Script/Engine.AnimationTransitionBetweenStates")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FAnimationTransitionBetweenStates : FAnimationStateBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006BF9 RID: 27641 RVA: 0x0009B51C File Offset: 0x0009971C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationTransitionBetweenStates._ScriptStructPtr != 0) ? FAnimationTransitionBetweenStates._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimationTransitionBetweenStates", ref FAnimationTransitionBetweenStates._ScriptStructPtr);
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06006BFA RID: 27642 RVA: 0x0009B540 File Offset: 0x00099740
		// (set) Token: 0x06006BFB RID: 27643 RVA: 0x0009B550 File Offset: 0x00099750
		public unsafe bool AllowSimulate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_AllowSimulate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_AllowSimulate) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x06006BFC RID: 27644 RVA: 0x0009B561 File Offset: 0x00099761
		// (set) Token: 0x06006BFD RID: 27645 RVA: 0x0009B571 File Offset: 0x00099771
		public unsafe int PreviousState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_PreviousState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_PreviousState) = value;
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x06006BFE RID: 27646 RVA: 0x0009B582 File Offset: 0x00099782
		// (set) Token: 0x06006BFF RID: 27647 RVA: 0x0009B592 File Offset: 0x00099792
		public unsafe int NextState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_NextState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_NextState) = value;
			}
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x06006C00 RID: 27648 RVA: 0x0009B5A3 File Offset: 0x000997A3
		// (set) Token: 0x06006C01 RID: 27649 RVA: 0x0009B5B3 File Offset: 0x000997B3
		public unsafe float CrossfadeDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_CrossfadeDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_CrossfadeDuration) = value;
			}
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x06006C02 RID: 27650 RVA: 0x0009B5C4 File Offset: 0x000997C4
		// (set) Token: 0x06006C03 RID: 27651 RVA: 0x0009B5D4 File Offset: 0x000997D4
		public unsafe int StartNotify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_StartNotify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_StartNotify) = value;
			}
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x06006C04 RID: 27652 RVA: 0x0009B5E5 File Offset: 0x000997E5
		// (set) Token: 0x06006C05 RID: 27653 RVA: 0x0009B5F5 File Offset: 0x000997F5
		public unsafe int EndNotify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_EndNotify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_EndNotify) = value;
			}
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x06006C06 RID: 27654 RVA: 0x0009B606 File Offset: 0x00099806
		// (set) Token: 0x06006C07 RID: 27655 RVA: 0x0009B616 File Offset: 0x00099816
		public unsafe int InterruptNotify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_InterruptNotify);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_InterruptNotify) = value;
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x06006C08 RID: 27656 RVA: 0x0009B627 File Offset: 0x00099827
		// (set) Token: 0x06006C09 RID: 27657 RVA: 0x0009B637 File Offset: 0x00099837
		public unsafe EAlphaBlendOption BlendMode
		{
			get
			{
				return (EAlphaBlendOption)(*(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_BlendMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_BlendMode) = (byte)value;
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x06006C0A RID: 27658 RVA: 0x0009B648 File Offset: 0x00099848
		// (set) Token: 0x06006C0B RID: 27659 RVA: 0x0009B65C File Offset: 0x0009985C
		[Nullable(2)]
		public unsafe UCurveFloat CustomCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimationTransitionBetweenStates.__PropertyOffset_CustomCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimationTransitionBetweenStates.__PropertyOffset_CustomCurve, value);
			}
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x06006C0C RID: 27660 RVA: 0x0009B671 File Offset: 0x00099871
		// (set) Token: 0x06006C0D RID: 27661 RVA: 0x0009B685 File Offset: 0x00099885
		[Nullable(2)]
		public unsafe UBlendProfile BlendProfile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlendProfile>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimationTransitionBetweenStates.__PropertyOffset_BlendProfile);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimationTransitionBetweenStates.__PropertyOffset_BlendProfile, value);
			}
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x06006C0E RID: 27662 RVA: 0x0009B69A File Offset: 0x0009989A
		// (set) Token: 0x06006C0F RID: 27663 RVA: 0x0009B6AE File Offset: 0x000998AE
		public unsafe TEnumAsByte<ETransitionLogicType> LogicType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_LogicType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationTransitionBetweenStates.__PropertyOffset_LogicType) = value;
			}
		}

		// Token: 0x06006C10 RID: 27664 RVA: 0x0009B6C3 File Offset: 0x000998C3
		public FAnimationTransitionBetweenStates()
		{
		}

		// Token: 0x06006C11 RID: 27665 RVA: 0x0009B6CC File Offset: 0x000998CC
		[NullableContext(1)]
		public FAnimationTransitionBetweenStates(bool AllowSimulate, int PreviousState, int NextState, float CrossfadeDuration, int StartNotify, int EndNotify, int InterruptNotify, EAlphaBlendOption BlendMode, UCurveFloat CustomCurve, UBlendProfile BlendProfile, [Nullable(0)] TEnumAsByte<ETransitionLogicType> LogicType, FName StateName)
		{
			this.AllowSimulate = AllowSimulate;
			this.PreviousState = PreviousState;
			this.NextState = NextState;
			this.CrossfadeDuration = CrossfadeDuration;
			this.StartNotify = StartNotify;
			this.EndNotify = EndNotify;
			this.InterruptNotify = InterruptNotify;
			this.BlendMode = BlendMode;
			this.CustomCurve = CustomCurve;
			this.BlendProfile = BlendProfile;
			this.LogicType = LogicType;
			base.StateName = StateName;
		}

		// Token: 0x06006C12 RID: 27666 RVA: 0x0009B73C File Offset: 0x0009993C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationTransitionBetweenStates.StaticStruct();
		}

		// Token: 0x06006C13 RID: 27667 RVA: 0x0009B748 File Offset: 0x00099948
		[NullableContext(2)]
		public FAnimationTransitionBetweenStates(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006C14 RID: 27668 RVA: 0x0009B752 File Offset: 0x00099952
		public FAnimationTransitionBetweenStates(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006C15 RID: 27669 RVA: 0x0009B75D File Offset: 0x0009995D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationTransitionBetweenStates(Pointer, false, true);
		}

		// Token: 0x06006C16 RID: 27670 RVA: 0x0009B767 File Offset: 0x00099967
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationTransitionBetweenStates(Pointer, MemoryOwner);
		}

		// Token: 0x040033F6 RID: 13302
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimationTransitionBetweenStates";

		// Token: 0x040033F7 RID: 13303
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040033F8 RID: 13304
		internal static int __PropertyOffset_AllowSimulate;

		// Token: 0x040033F9 RID: 13305
		internal static int __PropertyOffset_PreviousState;

		// Token: 0x040033FA RID: 13306
		internal static int __PropertyOffset_NextState;

		// Token: 0x040033FB RID: 13307
		internal static int __PropertyOffset_CrossfadeDuration;

		// Token: 0x040033FC RID: 13308
		internal static int __PropertyOffset_StartNotify;

		// Token: 0x040033FD RID: 13309
		internal static int __PropertyOffset_EndNotify;

		// Token: 0x040033FE RID: 13310
		internal static int __PropertyOffset_InterruptNotify;

		// Token: 0x040033FF RID: 13311
		internal static int __PropertyOffset_BlendMode;

		// Token: 0x04003400 RID: 13312
		internal static int __PropertyOffset_CustomCurve;

		// Token: 0x04003401 RID: 13313
		internal static int __PropertyOffset_BlendProfile;

		// Token: 0x04003402 RID: 13314
		internal static int __PropertyOffset_LogicType;
	}
}
