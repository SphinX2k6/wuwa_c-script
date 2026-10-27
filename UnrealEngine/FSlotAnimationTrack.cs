using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001119 RID: 4377
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SlotAnimationTrack")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSlotAnimationTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FFE0 RID: 65504 RVA: 0x00178DCD File Offset: 0x00176FCD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlotAnimationTrack._ScriptStructPtr != 0) ? FSlotAnimationTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SlotAnimationTrack", ref FSlotAnimationTrack._ScriptStructPtr);
		}

		// Token: 0x17003E74 RID: 15988
		// (get) Token: 0x0600FFE1 RID: 65505 RVA: 0x00178DF1 File Offset: 0x00176FF1
		// (set) Token: 0x0600FFE2 RID: 65506 RVA: 0x00178E05 File Offset: 0x00177005
		public unsafe FName SlotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlotAnimationTrack.__PropertyOffset_SlotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlotAnimationTrack.__PropertyOffset_SlotName) = value;
			}
		}

		// Token: 0x17003E75 RID: 15989
		// (get) Token: 0x0600FFE3 RID: 65507 RVA: 0x00178E1C File Offset: 0x0017701C
		// (set) Token: 0x0600FFE4 RID: 65508 RVA: 0x00178E5F File Offset: 0x0017705F
		public FAnimTrack AnimTrack
		{
			get
			{
				base.FastCheckIsValid();
				FAnimTrack result;
				if ((result = this._AnimTrack) == null)
				{
					result = (this._AnimTrack = new FAnimTrack(base.NativePtr + (IntPtr)FSlotAnimationTrack.__PropertyOffset_AnimTrack, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAnimTrack.StaticStruct(), base.NativePtr + (IntPtr)FSlotAnimationTrack.__PropertyOffset_AnimTrack, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600FFE5 RID: 65509 RVA: 0x00178E80 File Offset: 0x00177080
		public FSlotAnimationTrack()
		{
		}

		// Token: 0x0600FFE6 RID: 65510 RVA: 0x00178E88 File Offset: 0x00177088
		public FSlotAnimationTrack(FName SlotName, FAnimTrack AnimTrack)
		{
			this.SlotName = SlotName;
			this.AnimTrack = AnimTrack;
		}

		// Token: 0x0600FFE7 RID: 65511 RVA: 0x00178E9E File Offset: 0x0017709E
		protected override IntPtr GetUStructPtr()
		{
			return FSlotAnimationTrack.StaticStruct();
		}

		// Token: 0x0600FFE8 RID: 65512 RVA: 0x00178EAA File Offset: 0x001770AA
		[NullableContext(2)]
		public FSlotAnimationTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FFE9 RID: 65513 RVA: 0x00178EB4 File Offset: 0x001770B4
		public FSlotAnimationTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FFEA RID: 65514 RVA: 0x00178EBF File Offset: 0x001770BF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSlotAnimationTrack(Pointer, false, true);
		}

		// Token: 0x0600FFEB RID: 65515 RVA: 0x00178EC9 File Offset: 0x001770C9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSlotAnimationTrack(Pointer, MemoryOwner);
		}

		// Token: 0x04008982 RID: 35202
		public const string __ObjectPath = "/Script/Engine.SlotAnimationTrack";

		// Token: 0x04008983 RID: 35203
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008984 RID: 35204
		internal static int __PropertyOffset_SlotName;

		// Token: 0x04008985 RID: 35205
		internal static int __PropertyOffset_AnimTrack;

		// Token: 0x04008986 RID: 35206
		[Nullable(2)]
		private FAnimTrack _AnimTrack;
	}
}
