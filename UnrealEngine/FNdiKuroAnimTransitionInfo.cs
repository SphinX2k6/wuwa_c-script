using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C0C RID: 7180
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.NdiKuroAnimTransitionInfo")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FNdiKuroAnimTransitionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BB3C RID: 113468 RVA: 0x0028C5EB File Offset: 0x0028A7EB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNdiKuroAnimTransitionInfo._ScriptStructPtr != 0) ? FNdiKuroAnimTransitionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.NdiKuroAnimTransitionInfo", ref FNdiKuroAnimTransitionInfo._ScriptStructPtr);
		}

		// Token: 0x17006FBA RID: 28602
		// (get) Token: 0x0601BB3D RID: 113469 RVA: 0x0028C60F File Offset: 0x0028A80F
		// (set) Token: 0x0601BB3E RID: 113470 RVA: 0x0028C623 File Offset: 0x0028A823
		public unsafe FName AnimNameA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_AnimNameA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_AnimNameA) = value;
			}
		}

		// Token: 0x17006FBB RID: 28603
		// (get) Token: 0x0601BB3F RID: 113471 RVA: 0x0028C638 File Offset: 0x0028A838
		// (set) Token: 0x0601BB40 RID: 113472 RVA: 0x0028C648 File Offset: 0x0028A848
		public unsafe int TransitionFrameA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_TransitionFrameA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_TransitionFrameA) = value;
			}
		}

		// Token: 0x17006FBC RID: 28604
		// (get) Token: 0x0601BB41 RID: 113473 RVA: 0x0028C659 File Offset: 0x0028A859
		// (set) Token: 0x0601BB42 RID: 113474 RVA: 0x0028C66D File Offset: 0x0028A86D
		public unsafe FName AnimNameB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_AnimNameB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_AnimNameB) = value;
			}
		}

		// Token: 0x17006FBD RID: 28605
		// (get) Token: 0x0601BB43 RID: 113475 RVA: 0x0028C682 File Offset: 0x0028A882
		// (set) Token: 0x0601BB44 RID: 113476 RVA: 0x0028C692 File Offset: 0x0028A892
		public unsafe int TransitionFrameB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_TransitionFrameB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_TransitionFrameB) = value;
			}
		}

		// Token: 0x17006FBE RID: 28606
		// (get) Token: 0x0601BB45 RID: 113477 RVA: 0x0028C6A3 File Offset: 0x0028A8A3
		// (set) Token: 0x0601BB46 RID: 113478 RVA: 0x0028C6B3 File Offset: 0x0028A8B3
		public unsafe int TransitionTotalFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_TransitionTotalFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_TransitionTotalFrames) = value;
			}
		}

		// Token: 0x17006FBF RID: 28607
		// (get) Token: 0x0601BB47 RID: 113479 RVA: 0x0028C6C4 File Offset: 0x0028A8C4
		// (set) Token: 0x0601BB48 RID: 113480 RVA: 0x0028C6D4 File Offset: 0x0028A8D4
		public unsafe int VatTextureIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_VatTextureIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_VatTextureIndex) = value;
			}
		}

		// Token: 0x17006FC0 RID: 28608
		// (get) Token: 0x0601BB49 RID: 113481 RVA: 0x0028C6E5 File Offset: 0x0028A8E5
		// (set) Token: 0x0601BB4A RID: 113482 RVA: 0x0028C6F5 File Offset: 0x0028A8F5
		public unsafe int RootMotionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_RootMotionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNdiKuroAnimTransitionInfo.__PropertyOffset_RootMotionIndex) = value;
			}
		}

		// Token: 0x0601BB4B RID: 113483 RVA: 0x0028C706 File Offset: 0x0028A906
		public FNdiKuroAnimTransitionInfo()
		{
		}

		// Token: 0x0601BB4C RID: 113484 RVA: 0x0028C70E File Offset: 0x0028A90E
		public FNdiKuroAnimTransitionInfo(FName AnimNameA, int TransitionFrameA, FName AnimNameB, int TransitionFrameB, int TransitionTotalFrames, int VatTextureIndex, int RootMotionIndex)
		{
			this.AnimNameA = AnimNameA;
			this.TransitionFrameA = TransitionFrameA;
			this.AnimNameB = AnimNameB;
			this.TransitionFrameB = TransitionFrameB;
			this.TransitionTotalFrames = TransitionTotalFrames;
			this.VatTextureIndex = VatTextureIndex;
			this.RootMotionIndex = RootMotionIndex;
		}

		// Token: 0x0601BB4D RID: 113485 RVA: 0x0028C74B File Offset: 0x0028A94B
		protected override IntPtr GetUStructPtr()
		{
			return FNdiKuroAnimTransitionInfo.StaticStruct();
		}

		// Token: 0x0601BB4E RID: 113486 RVA: 0x0028C757 File Offset: 0x0028A957
		[NullableContext(2)]
		public FNdiKuroAnimTransitionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BB4F RID: 113487 RVA: 0x0028C761 File Offset: 0x0028A961
		public FNdiKuroAnimTransitionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BB50 RID: 113488 RVA: 0x0028C76C File Offset: 0x0028A96C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNdiKuroAnimTransitionInfo(Pointer, false, true);
		}

		// Token: 0x0601BB51 RID: 113489 RVA: 0x0028C776 File Offset: 0x0028A976
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNdiKuroAnimTransitionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400EE61 RID: 61025
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.NdiKuroAnimTransitionInfo";

		// Token: 0x0400EE62 RID: 61026
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EE63 RID: 61027
		internal static int __PropertyOffset_AnimNameA;

		// Token: 0x0400EE64 RID: 61028
		internal static int __PropertyOffset_TransitionFrameA;

		// Token: 0x0400EE65 RID: 61029
		internal static int __PropertyOffset_AnimNameB;

		// Token: 0x0400EE66 RID: 61030
		internal static int __PropertyOffset_TransitionFrameB;

		// Token: 0x0400EE67 RID: 61031
		internal static int __PropertyOffset_TransitionTotalFrames;

		// Token: 0x0400EE68 RID: 61032
		internal static int __PropertyOffset_VatTextureIndex;

		// Token: 0x0400EE69 RID: 61033
		internal static int __PropertyOffset_RootMotionIndex;
	}
}
