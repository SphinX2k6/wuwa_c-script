using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FCA RID: 8138
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.AnimationPlayInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FAnimationPlayInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EDF4 RID: 126452 RVA: 0x002DE10B File Offset: 0x002DC30B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimationPlayInfo._ScriptStructPtr != 0) ? FAnimationPlayInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.AnimationPlayInfo", ref FAnimationPlayInfo._ScriptStructPtr);
		}

		// Token: 0x17007ADA RID: 31450
		// (get) Token: 0x0601EDF5 RID: 126453 RVA: 0x002DE12F File Offset: 0x002DC32F
		// (set) Token: 0x0601EDF6 RID: 126454 RVA: 0x002DE13F File Offset: 0x002DC33F
		public unsafe EAnimationPlayMode PlayMode
		{
			get
			{
				return (EAnimationPlayMode)(*(base.NativePtr + (IntPtr)FAnimationPlayInfo.__PropertyOffset_PlayMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationPlayInfo.__PropertyOffset_PlayMode) = (byte)value;
			}
		}

		// Token: 0x17007ADB RID: 31451
		// (get) Token: 0x0601EDF7 RID: 126455 RVA: 0x002DE150 File Offset: 0x002DC350
		// (set) Token: 0x0601EDF8 RID: 126456 RVA: 0x002DE160 File Offset: 0x002DC360
		public unsafe EStateTransferType ReverseType
		{
			get
			{
				return (EStateTransferType)(*(base.NativePtr + (IntPtr)FAnimationPlayInfo.__PropertyOffset_ReverseType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationPlayInfo.__PropertyOffset_ReverseType) = (byte)value;
			}
		}

		// Token: 0x17007ADC RID: 31452
		// (get) Token: 0x0601EDF9 RID: 126457 RVA: 0x002DE174 File Offset: 0x002DC374
		// (set) Token: 0x0601EDFA RID: 126458 RVA: 0x002DE1B7 File Offset: 0x002DC3B7
		public FSequenceInfo Animation
		{
			get
			{
				base.FastCheckIsValid();
				FSequenceInfo result;
				if ((result = this._Animation) == null)
				{
					result = (this._Animation = new FSequenceInfo(base.NativePtr + (IntPtr)FAnimationPlayInfo.__PropertyOffset_Animation, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSequenceInfo.StaticStruct(), base.NativePtr + (IntPtr)FAnimationPlayInfo.__PropertyOffset_Animation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007ADD RID: 31453
		// (get) Token: 0x0601EDFB RID: 126459 RVA: 0x002DE1D8 File Offset: 0x002DC3D8
		// (set) Token: 0x0601EDFC RID: 126460 RVA: 0x002DE1E8 File Offset: 0x002DC3E8
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimationPlayInfo.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimationPlayInfo.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x0601EDFD RID: 126461 RVA: 0x002DE1F9 File Offset: 0x002DC3F9
		public FAnimationPlayInfo()
		{
		}

		// Token: 0x0601EDFE RID: 126462 RVA: 0x002DE201 File Offset: 0x002DC401
		public FAnimationPlayInfo(EAnimationPlayMode PlayMode, EStateTransferType ReverseType, FSequenceInfo Animation, float PlayRate)
		{
			this.PlayMode = PlayMode;
			this.ReverseType = ReverseType;
			this.Animation = Animation;
			this.PlayRate = PlayRate;
		}

		// Token: 0x0601EDFF RID: 126463 RVA: 0x002DE226 File Offset: 0x002DC426
		protected override IntPtr GetUStructPtr()
		{
			return FAnimationPlayInfo.StaticStruct();
		}

		// Token: 0x0601EE00 RID: 126464 RVA: 0x002DE232 File Offset: 0x002DC432
		[NullableContext(2)]
		public FAnimationPlayInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EE01 RID: 126465 RVA: 0x002DE23C File Offset: 0x002DC43C
		public FAnimationPlayInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EE02 RID: 126466 RVA: 0x002DE247 File Offset: 0x002DC447
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimationPlayInfo(Pointer, false, true);
		}

		// Token: 0x0601EE03 RID: 126467 RVA: 0x002DE251 File Offset: 0x002DC451
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimationPlayInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04010AD9 RID: 68313
		public const string __ObjectPath = "/Script/LGUI.AnimationPlayInfo";

		// Token: 0x04010ADA RID: 68314
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010ADB RID: 68315
		internal static int __PropertyOffset_PlayMode;

		// Token: 0x04010ADC RID: 68316
		internal static int __PropertyOffset_ReverseType;

		// Token: 0x04010ADD RID: 68317
		internal static int __PropertyOffset_Animation;

		// Token: 0x04010ADE RID: 68318
		[Nullable(2)]
		private FSequenceInfo _Animation;

		// Token: 0x04010ADF RID: 68319
		internal static int __PropertyOffset_PlayRate;
	}
}
