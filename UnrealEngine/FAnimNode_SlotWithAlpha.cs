using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002FF RID: 767
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_SlotWithAlpha")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FAnimNode_SlotWithAlpha : FAnimNode_Slot, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002C0D RID: 11277 RVA: 0x000433DB File Offset: 0x000415DB
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_SlotWithAlpha._ScriptStructPtr != 0) ? FAnimNode_SlotWithAlpha._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_SlotWithAlpha", ref FAnimNode_SlotWithAlpha._ScriptStructPtr);
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002C0E RID: 11278 RVA: 0x000433FF File Offset: 0x000415FF
		// (set) Token: 0x06002C0F RID: 11279 RVA: 0x0004340F File Offset: 0x0004160F
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SlotWithAlpha.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SlotWithAlpha.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x00043420 File Offset: 0x00041620
		public FAnimNode_SlotWithAlpha()
		{
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x00043428 File Offset: 0x00041628
		[NullableContext(1)]
		public FAnimNode_SlotWithAlpha(float Alpha, FPoseLink Source, FName SlotName, bool bAlwaysUpdateSourcePose)
		{
			this.Alpha = Alpha;
			base.Source = Source;
			base.SlotName = SlotName;
			base.bAlwaysUpdateSourcePose = bAlwaysUpdateSourcePose;
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x0004344D File Offset: 0x0004164D
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_SlotWithAlpha.StaticStruct();
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x00043459 File Offset: 0x00041659
		[NullableContext(2)]
		public FAnimNode_SlotWithAlpha(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x00043463 File Offset: 0x00041663
		public FAnimNode_SlotWithAlpha(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x0004346E File Offset: 0x0004166E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_SlotWithAlpha(Pointer, false, true);
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x00043478 File Offset: 0x00041678
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_SlotWithAlpha(Pointer, MemoryOwner);
		}

		// Token: 0x04001200 RID: 4608
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_SlotWithAlpha";

		// Token: 0x04001201 RID: 4609
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001202 RID: 4610
		internal static int __PropertyOffset_Alpha;
	}
}
