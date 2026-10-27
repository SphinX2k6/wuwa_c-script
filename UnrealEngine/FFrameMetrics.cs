using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002307 RID: 8967
	[UnrealObjectPath("/Script/MovieSceneCapture.FrameMetrics")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FFrameMetrics : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021F6D RID: 139117 RVA: 0x003239D1 File Offset: 0x00321BD1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFrameMetrics._ScriptStructPtr != 0) ? FFrameMetrics._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneCapture.FrameMetrics", ref FFrameMetrics._ScriptStructPtr);
		}

		// Token: 0x17008346 RID: 33606
		// (get) Token: 0x06021F6E RID: 139118 RVA: 0x003239F5 File Offset: 0x00321BF5
		// (set) Token: 0x06021F6F RID: 139119 RVA: 0x00323A05 File Offset: 0x00321C05
		public unsafe float TotalElapsedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFrameMetrics.__PropertyOffset_TotalElapsedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFrameMetrics.__PropertyOffset_TotalElapsedTime) = value;
			}
		}

		// Token: 0x17008347 RID: 33607
		// (get) Token: 0x06021F70 RID: 139120 RVA: 0x00323A16 File Offset: 0x00321C16
		// (set) Token: 0x06021F71 RID: 139121 RVA: 0x00323A26 File Offset: 0x00321C26
		public unsafe float FrameDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFrameMetrics.__PropertyOffset_FrameDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFrameMetrics.__PropertyOffset_FrameDelta) = value;
			}
		}

		// Token: 0x17008348 RID: 33608
		// (get) Token: 0x06021F72 RID: 139122 RVA: 0x00323A37 File Offset: 0x00321C37
		// (set) Token: 0x06021F73 RID: 139123 RVA: 0x00323A47 File Offset: 0x00321C47
		public unsafe int FrameNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFrameMetrics.__PropertyOffset_FrameNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFrameMetrics.__PropertyOffset_FrameNumber) = value;
			}
		}

		// Token: 0x17008349 RID: 33609
		// (get) Token: 0x06021F74 RID: 139124 RVA: 0x00323A58 File Offset: 0x00321C58
		// (set) Token: 0x06021F75 RID: 139125 RVA: 0x00323A68 File Offset: 0x00321C68
		public unsafe int NumDroppedFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFrameMetrics.__PropertyOffset_NumDroppedFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFrameMetrics.__PropertyOffset_NumDroppedFrames) = value;
			}
		}

		// Token: 0x06021F76 RID: 139126 RVA: 0x00323A79 File Offset: 0x00321C79
		public FFrameMetrics()
		{
		}

		// Token: 0x06021F77 RID: 139127 RVA: 0x00323A81 File Offset: 0x00321C81
		public FFrameMetrics(float TotalElapsedTime, float FrameDelta, int FrameNumber, int NumDroppedFrames)
		{
			this.TotalElapsedTime = TotalElapsedTime;
			this.FrameDelta = FrameDelta;
			this.FrameNumber = FrameNumber;
			this.NumDroppedFrames = NumDroppedFrames;
		}

		// Token: 0x06021F78 RID: 139128 RVA: 0x00323AA6 File Offset: 0x00321CA6
		protected override IntPtr GetUStructPtr()
		{
			return FFrameMetrics.StaticStruct();
		}

		// Token: 0x06021F79 RID: 139129 RVA: 0x00323AB2 File Offset: 0x00321CB2
		[NullableContext(2)]
		public FFrameMetrics(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021F7A RID: 139130 RVA: 0x00323ABC File Offset: 0x00321CBC
		public FFrameMetrics(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021F7B RID: 139131 RVA: 0x00323AC7 File Offset: 0x00321CC7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFrameMetrics(Pointer, false, true);
		}

		// Token: 0x06021F7C RID: 139132 RVA: 0x00323AD1 File Offset: 0x00321CD1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFrameMetrics(Pointer, MemoryOwner);
		}

		// Token: 0x040121E6 RID: 74214
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneCapture.FrameMetrics";

		// Token: 0x040121E7 RID: 74215
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040121E8 RID: 74216
		internal static int __PropertyOffset_TotalElapsedTime;

		// Token: 0x040121E9 RID: 74217
		internal static int __PropertyOffset_FrameDelta;

		// Token: 0x040121EA RID: 74218
		internal static int __PropertyOffset_FrameNumber;

		// Token: 0x040121EB RID: 74219
		internal static int __PropertyOffset_NumDroppedFrames;
	}
}
