using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000285 RID: 645
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SlotAnimationTrack")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSlotAnimationTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004591 RID: 17809 RVA: 0x0006281D File Offset: 0x00060A1D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlotAnimationTrack._ScriptStructPtr != 0) ? FSlotAnimationTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SlotAnimationTrack", ref FSlotAnimationTrack._ScriptStructPtr);
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x06004592 RID: 17810 RVA: 0x00062841 File Offset: 0x00060A41
		// (set) Token: 0x06004593 RID: 17811 RVA: 0x00062855 File Offset: 0x00060A55
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

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x06004594 RID: 17812 RVA: 0x0006286C File Offset: 0x00060A6C
		// (set) Token: 0x06004595 RID: 17813 RVA: 0x000628AF File Offset: 0x00060AAF
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

		// Token: 0x06004596 RID: 17814 RVA: 0x000628D0 File Offset: 0x00060AD0
		public FSlotAnimationTrack()
		{
		}

		// Token: 0x06004597 RID: 17815 RVA: 0x000628D8 File Offset: 0x00060AD8
		protected override IntPtr GetUStructPtr()
		{
			return FSlotAnimationTrack.StaticStruct();
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x000628E4 File Offset: 0x00060AE4
		[NullableContext(2)]
		public FSlotAnimationTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x000628EE File Offset: 0x00060AEE
		public FSlotAnimationTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600459A RID: 17818 RVA: 0x000628F9 File Offset: 0x00060AF9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSlotAnimationTrack(Pointer, false, true);
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00062903 File Offset: 0x00060B03
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSlotAnimationTrack(Pointer, MemoryOwner);
		}

		// Token: 0x04001B39 RID: 6969
		public const string __ObjectPath = "/Script/Engine.SlotAnimationTrack";

		// Token: 0x04001B3A RID: 6970
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001B3B RID: 6971
		internal static int __PropertyOffset_SlotName;

		// Token: 0x04001B3C RID: 6972
		internal static int __PropertyOffset_AnimTrack;

		// Token: 0x04001B3D RID: 6973
		[Nullable(2)]
		private FAnimTrack _AnimTrack;
	}
}
