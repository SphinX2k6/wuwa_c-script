using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002115 RID: 8469
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.ToggleAnimationPlayInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FToggleAnimationPlayInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FDDC RID: 130524 RVA: 0x002F68CD File Offset: 0x002F4ACD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FToggleAnimationPlayInfo._ScriptStructPtr != 0) ? FToggleAnimationPlayInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ToggleAnimationPlayInfo", ref FToggleAnimationPlayInfo._ScriptStructPtr);
		}

		// Token: 0x17007D56 RID: 32086
		// (get) Token: 0x0601FDDD RID: 130525 RVA: 0x002F68F4 File Offset: 0x002F4AF4
		// (set) Token: 0x0601FDDE RID: 130526 RVA: 0x002F6937 File Offset: 0x002F4B37
		public FSequenceInfo Animation
		{
			get
			{
				base.FastCheckIsValid();
				FSequenceInfo result;
				if ((result = this._Animation) == null)
				{
					result = (this._Animation = new FSequenceInfo(base.NativePtr + (IntPtr)FToggleAnimationPlayInfo.__PropertyOffset_Animation, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSequenceInfo.StaticStruct(), base.NativePtr + (IntPtr)FToggleAnimationPlayInfo.__PropertyOffset_Animation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007D57 RID: 32087
		// (get) Token: 0x0601FDDF RID: 130527 RVA: 0x002F6958 File Offset: 0x002F4B58
		// (set) Token: 0x0601FDE0 RID: 130528 RVA: 0x002F6968 File Offset: 0x002F4B68
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FToggleAnimationPlayInfo.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FToggleAnimationPlayInfo.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x17007D58 RID: 32088
		// (get) Token: 0x0601FDE1 RID: 130529 RVA: 0x002F6979 File Offset: 0x002F4B79
		// (set) Token: 0x0601FDE2 RID: 130530 RVA: 0x002F6989 File Offset: 0x002F4B89
		public unsafe bool bPlayReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FToggleAnimationPlayInfo.__PropertyOffset_bPlayReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FToggleAnimationPlayInfo.__PropertyOffset_bPlayReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007D59 RID: 32089
		// (get) Token: 0x0601FDE3 RID: 130531 RVA: 0x002F699A File Offset: 0x002F4B9A
		// (set) Token: 0x0601FDE4 RID: 130532 RVA: 0x002F69AA File Offset: 0x002F4BAA
		public unsafe int JumpToFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FToggleAnimationPlayInfo.__PropertyOffset_JumpToFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FToggleAnimationPlayInfo.__PropertyOffset_JumpToFrame) = value;
			}
		}

		// Token: 0x0601FDE5 RID: 130533 RVA: 0x002F69BB File Offset: 0x002F4BBB
		public FToggleAnimationPlayInfo()
		{
		}

		// Token: 0x0601FDE6 RID: 130534 RVA: 0x002F69C3 File Offset: 0x002F4BC3
		public FToggleAnimationPlayInfo(FSequenceInfo Animation, float PlayRate, bool bPlayReverse, int JumpToFrame)
		{
			this.Animation = Animation;
			this.PlayRate = PlayRate;
			this.bPlayReverse = bPlayReverse;
			this.JumpToFrame = JumpToFrame;
		}

		// Token: 0x0601FDE7 RID: 130535 RVA: 0x002F69E8 File Offset: 0x002F4BE8
		protected override IntPtr GetUStructPtr()
		{
			return FToggleAnimationPlayInfo.StaticStruct();
		}

		// Token: 0x0601FDE8 RID: 130536 RVA: 0x002F69F4 File Offset: 0x002F4BF4
		[NullableContext(2)]
		public FToggleAnimationPlayInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FDE9 RID: 130537 RVA: 0x002F69FE File Offset: 0x002F4BFE
		public FToggleAnimationPlayInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FDEA RID: 130538 RVA: 0x002F6A09 File Offset: 0x002F4C09
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FToggleAnimationPlayInfo(Pointer, false, true);
		}

		// Token: 0x0601FDEB RID: 130539 RVA: 0x002F6A13 File Offset: 0x002F4C13
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FToggleAnimationPlayInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040112C4 RID: 70340
		public const string __ObjectPath = "/Script/LGUI.ToggleAnimationPlayInfo";

		// Token: 0x040112C5 RID: 70341
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040112C6 RID: 70342
		internal static int __PropertyOffset_Animation;

		// Token: 0x040112C7 RID: 70343
		[Nullable(2)]
		private FSequenceInfo _Animation;

		// Token: 0x040112C8 RID: 70344
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x040112C9 RID: 70345
		internal static int __PropertyOffset_bPlayReverse;

		// Token: 0x040112CA RID: 70346
		internal static int __PropertyOffset_JumpToFrame;
	}
}
