using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CEE RID: 3310
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroFrameStatsCaptureResult")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroFrameStatsCaptureResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AFAD RID: 44973 RVA: 0x000F9308 File Offset: 0x000F7508
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroFrameStatsCaptureResult._ScriptStructPtr != 0) ? FKuroFrameStatsCaptureResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroFrameStatsCaptureResult", ref FKuroFrameStatsCaptureResult._ScriptStructPtr);
		}

		// Token: 0x170027B5 RID: 10165
		// (get) Token: 0x0600AFAE RID: 44974 RVA: 0x000F932C File Offset: 0x000F752C
		// (set) Token: 0x0600AFAF RID: 44975 RVA: 0x000F9340 File Offset: 0x000F7540
		public unsafe string FrameData
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroFrameStatsCaptureResult.__PropertyOffset_FrameData)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroFrameStatsCaptureResult.__PropertyOffset_FrameData)), value);
			}
		}

		// Token: 0x0600AFB0 RID: 44976 RVA: 0x000F9355 File Offset: 0x000F7555
		public FKuroFrameStatsCaptureResult()
		{
		}

		// Token: 0x0600AFB1 RID: 44977 RVA: 0x000F935D File Offset: 0x000F755D
		public FKuroFrameStatsCaptureResult(string FrameData)
		{
			this.FrameData = FrameData;
		}

		// Token: 0x0600AFB2 RID: 44978 RVA: 0x000F936C File Offset: 0x000F756C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroFrameStatsCaptureResult.StaticStruct();
		}

		// Token: 0x0600AFB3 RID: 44979 RVA: 0x000F9378 File Offset: 0x000F7578
		[NullableContext(2)]
		public FKuroFrameStatsCaptureResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AFB4 RID: 44980 RVA: 0x000F9382 File Offset: 0x000F7582
		public FKuroFrameStatsCaptureResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AFB5 RID: 44981 RVA: 0x000F938D File Offset: 0x000F758D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroFrameStatsCaptureResult(Pointer, false, true);
		}

		// Token: 0x0600AFB6 RID: 44982 RVA: 0x000F9397 File Offset: 0x000F7597
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroFrameStatsCaptureResult(Pointer, MemoryOwner);
		}

		// Token: 0x04005BFB RID: 23547
		public const string __ObjectPath = "/Script/Engine.KuroFrameStatsCaptureResult";

		// Token: 0x04005BFC RID: 23548
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005BFD RID: 23549
		internal static int __PropertyOffset_FrameData;
	}
}
