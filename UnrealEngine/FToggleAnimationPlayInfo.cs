using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006E2 RID: 1762
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.ToggleAnimationPlayInfo")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FToggleAnimationPlayInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060095A5 RID: 38309 RVA: 0x000E1F65 File Offset: 0x000E0165
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FToggleAnimationPlayInfo._ScriptStructPtr != 0) ? FToggleAnimationPlayInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ToggleAnimationPlayInfo", ref FToggleAnimationPlayInfo._ScriptStructPtr);
		}

		// Token: 0x17001BC8 RID: 7112
		// (get) Token: 0x060095A6 RID: 38310 RVA: 0x000E1F8C File Offset: 0x000E018C
		// (set) Token: 0x060095A7 RID: 38311 RVA: 0x000E1FCF File Offset: 0x000E01CF
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

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x060095A8 RID: 38312 RVA: 0x000E1FF0 File Offset: 0x000E01F0
		// (set) Token: 0x060095A9 RID: 38313 RVA: 0x000E2000 File Offset: 0x000E0200
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

		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x060095AA RID: 38314 RVA: 0x000E2011 File Offset: 0x000E0211
		// (set) Token: 0x060095AB RID: 38315 RVA: 0x000E2021 File Offset: 0x000E0221
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

		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x060095AC RID: 38316 RVA: 0x000E2032 File Offset: 0x000E0232
		// (set) Token: 0x060095AD RID: 38317 RVA: 0x000E2042 File Offset: 0x000E0242
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

		// Token: 0x060095AE RID: 38318 RVA: 0x000E2053 File Offset: 0x000E0253
		public FToggleAnimationPlayInfo()
		{
		}

		// Token: 0x060095AF RID: 38319 RVA: 0x000E205B File Offset: 0x000E025B
		protected override IntPtr GetUStructPtr()
		{
			return FToggleAnimationPlayInfo.StaticStruct();
		}

		// Token: 0x060095B0 RID: 38320 RVA: 0x000E2067 File Offset: 0x000E0267
		[NullableContext(2)]
		public FToggleAnimationPlayInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060095B1 RID: 38321 RVA: 0x000E2071 File Offset: 0x000E0271
		public FToggleAnimationPlayInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060095B2 RID: 38322 RVA: 0x000E207C File Offset: 0x000E027C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FToggleAnimationPlayInfo(Pointer, false, true);
		}

		// Token: 0x060095B3 RID: 38323 RVA: 0x000E2086 File Offset: 0x000E0286
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FToggleAnimationPlayInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400411F RID: 16671
		public const string __ObjectPath = "/Script/LGUI.ToggleAnimationPlayInfo";

		// Token: 0x04004120 RID: 16672
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004121 RID: 16673
		internal static int __PropertyOffset_Animation;

		// Token: 0x04004122 RID: 16674
		[Nullable(2)]
		private FSequenceInfo _Animation;

		// Token: 0x04004123 RID: 16675
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x04004124 RID: 16676
		internal static int __PropertyOffset_bPlayReverse;

		// Token: 0x04004125 RID: 16677
		internal static int __PropertyOffset_JumpToFrame;
	}
}
