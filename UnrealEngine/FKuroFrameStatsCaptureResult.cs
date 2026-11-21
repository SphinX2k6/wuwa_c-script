using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200022A RID: 554
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroFrameStatsCaptureResult")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroFrameStatsCaptureResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002CD0 RID: 11472 RVA: 0x0003F55D File Offset: 0x0003D75D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroFrameStatsCaptureResult._ScriptStructPtr != 0) ? FKuroFrameStatsCaptureResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroFrameStatsCaptureResult", ref FKuroFrameStatsCaptureResult._ScriptStructPtr);
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x0003F581 File Offset: 0x0003D781
		// (set) Token: 0x06002CD2 RID: 11474 RVA: 0x0003F595 File Offset: 0x0003D795
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

		// Token: 0x06002CD3 RID: 11475 RVA: 0x0003F5AA File Offset: 0x0003D7AA
		public FKuroFrameStatsCaptureResult()
		{
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x0003F5B2 File Offset: 0x0003D7B2
		protected override IntPtr GetUStructPtr()
		{
			return FKuroFrameStatsCaptureResult.StaticStruct();
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x0003F5BE File Offset: 0x0003D7BE
		[NullableContext(2)]
		public FKuroFrameStatsCaptureResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x0003F5C8 File Offset: 0x0003D7C8
		public FKuroFrameStatsCaptureResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x0003F5D3 File Offset: 0x0003D7D3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroFrameStatsCaptureResult(Pointer, false, true);
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x0003F5DD File Offset: 0x0003D7DD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroFrameStatsCaptureResult(Pointer, MemoryOwner);
		}

		// Token: 0x04000E32 RID: 3634
		public const string __ObjectPath = "/Script/Engine.KuroFrameStatsCaptureResult";

		// Token: 0x04000E33 RID: 3635
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000E34 RID: 3636
		internal static int __PropertyOffset_FrameData;
	}
}
