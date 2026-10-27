using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A50 RID: 6736
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.BirdVATClip")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FBirdVATClip : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018E3D RID: 101949 RVA: 0x0024CCE0 File Offset: 0x0024AEE0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBirdVATClip._ScriptStructPtr != 0) ? FBirdVATClip._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.BirdVATClip", ref FBirdVATClip._ScriptStructPtr);
		}

		// Token: 0x17006283 RID: 25219
		// (get) Token: 0x06018E3E RID: 101950 RVA: 0x0024CD04 File Offset: 0x0024AF04
		// (set) Token: 0x06018E3F RID: 101951 RVA: 0x0024CD14 File Offset: 0x0024AF14
		public unsafe float StartFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBirdVATClip.__PropertyOffset_StartFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBirdVATClip.__PropertyOffset_StartFrame) = value;
			}
		}

		// Token: 0x17006284 RID: 25220
		// (get) Token: 0x06018E40 RID: 101952 RVA: 0x0024CD25 File Offset: 0x0024AF25
		// (set) Token: 0x06018E41 RID: 101953 RVA: 0x0024CD35 File Offset: 0x0024AF35
		public unsafe float FrameCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBirdVATClip.__PropertyOffset_FrameCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBirdVATClip.__PropertyOffset_FrameCount) = value;
			}
		}

		// Token: 0x17006285 RID: 25221
		// (get) Token: 0x06018E42 RID: 101954 RVA: 0x0024CD46 File Offset: 0x0024AF46
		// (set) Token: 0x06018E43 RID: 101955 RVA: 0x0024CD56 File Offset: 0x0024AF56
		public unsafe float FPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBirdVATClip.__PropertyOffset_FPS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBirdVATClip.__PropertyOffset_FPS) = value;
			}
		}

		// Token: 0x17006286 RID: 25222
		// (get) Token: 0x06018E44 RID: 101956 RVA: 0x0024CD67 File Offset: 0x0024AF67
		// (set) Token: 0x06018E45 RID: 101957 RVA: 0x0024CD77 File Offset: 0x0024AF77
		public unsafe bool bLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBirdVATClip.__PropertyOffset_bLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBirdVATClip.__PropertyOffset_bLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006287 RID: 25223
		// (get) Token: 0x06018E46 RID: 101958 RVA: 0x0024CD88 File Offset: 0x0024AF88
		// (set) Token: 0x06018E47 RID: 101959 RVA: 0x0024CD98 File Offset: 0x0024AF98
		public unsafe float BlendIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBirdVATClip.__PropertyOffset_BlendIn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBirdVATClip.__PropertyOffset_BlendIn) = value;
			}
		}

		// Token: 0x06018E48 RID: 101960 RVA: 0x0024CDA9 File Offset: 0x0024AFA9
		public FBirdVATClip()
		{
		}

		// Token: 0x06018E49 RID: 101961 RVA: 0x0024CDB1 File Offset: 0x0024AFB1
		public FBirdVATClip(float StartFrame, float FrameCount, float FPS, bool bLoop, float BlendIn)
		{
			this.StartFrame = StartFrame;
			this.FrameCount = FrameCount;
			this.FPS = FPS;
			this.bLoop = bLoop;
			this.BlendIn = BlendIn;
		}

		// Token: 0x06018E4A RID: 101962 RVA: 0x0024CDDE File Offset: 0x0024AFDE
		protected override IntPtr GetUStructPtr()
		{
			return FBirdVATClip.StaticStruct();
		}

		// Token: 0x06018E4B RID: 101963 RVA: 0x0024CDEA File Offset: 0x0024AFEA
		[NullableContext(2)]
		public FBirdVATClip(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018E4C RID: 101964 RVA: 0x0024CDF4 File Offset: 0x0024AFF4
		public FBirdVATClip(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018E4D RID: 101965 RVA: 0x0024CDFF File Offset: 0x0024AFFF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBirdVATClip(Pointer, false, true);
		}

		// Token: 0x06018E4E RID: 101966 RVA: 0x0024CE09 File Offset: 0x0024B009
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBirdVATClip(Pointer, MemoryOwner);
		}

		// Token: 0x0400D77A RID: 55162
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.BirdVATClip";

		// Token: 0x0400D77B RID: 55163
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D77C RID: 55164
		internal static int __PropertyOffset_StartFrame;

		// Token: 0x0400D77D RID: 55165
		internal static int __PropertyOffset_FrameCount;

		// Token: 0x0400D77E RID: 55166
		internal static int __PropertyOffset_FPS;

		// Token: 0x0400D77F RID: 55167
		internal static int __PropertyOffset_bLoop;

		// Token: 0x0400D780 RID: 55168
		internal static int __PropertyOffset_BlendIn;
	}
}
