using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BEF RID: 3055
	[UnrealObjectPath("/Script/Engine.ForceFeedbackParameters")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FForceFeedbackParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060096B2 RID: 38578 RVA: 0x000D6FFF File Offset: 0x000D51FF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FForceFeedbackParameters._ScriptStructPtr != 0) ? FForceFeedbackParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ForceFeedbackParameters", ref FForceFeedbackParameters._ScriptStructPtr);
		}

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x060096B3 RID: 38579 RVA: 0x000D7023 File Offset: 0x000D5223
		// (set) Token: 0x060096B4 RID: 38580 RVA: 0x000D7037 File Offset: 0x000D5237
		public unsafe FName Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FForceFeedbackParameters.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FForceFeedbackParameters.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x060096B5 RID: 38581 RVA: 0x000D704C File Offset: 0x000D524C
		// (set) Token: 0x060096B6 RID: 38582 RVA: 0x000D705C File Offset: 0x000D525C
		public unsafe bool bLooping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FForceFeedbackParameters.__PropertyOffset_bLooping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FForceFeedbackParameters.__PropertyOffset_bLooping) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x060096B7 RID: 38583 RVA: 0x000D706D File Offset: 0x000D526D
		// (set) Token: 0x060096B8 RID: 38584 RVA: 0x000D707D File Offset: 0x000D527D
		public unsafe bool bIgnoreTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FForceFeedbackParameters.__PropertyOffset_bIgnoreTimeDilation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FForceFeedbackParameters.__PropertyOffset_bIgnoreTimeDilation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x060096B9 RID: 38585 RVA: 0x000D708E File Offset: 0x000D528E
		// (set) Token: 0x060096BA RID: 38586 RVA: 0x000D709E File Offset: 0x000D529E
		public unsafe bool bPlayWhilePaused
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FForceFeedbackParameters.__PropertyOffset_bPlayWhilePaused) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FForceFeedbackParameters.__PropertyOffset_bPlayWhilePaused) = (value ? 1 : 0);
			}
		}

		// Token: 0x060096BB RID: 38587 RVA: 0x000D70AF File Offset: 0x000D52AF
		public FForceFeedbackParameters()
		{
		}

		// Token: 0x060096BC RID: 38588 RVA: 0x000D70B7 File Offset: 0x000D52B7
		public FForceFeedbackParameters(FName Tag, bool bLooping, bool bIgnoreTimeDilation, bool bPlayWhilePaused)
		{
			this.Tag = Tag;
			this.bLooping = bLooping;
			this.bIgnoreTimeDilation = bIgnoreTimeDilation;
			this.bPlayWhilePaused = bPlayWhilePaused;
		}

		// Token: 0x060096BD RID: 38589 RVA: 0x000D70DC File Offset: 0x000D52DC
		protected override IntPtr GetUStructPtr()
		{
			return FForceFeedbackParameters.StaticStruct();
		}

		// Token: 0x060096BE RID: 38590 RVA: 0x000D70E8 File Offset: 0x000D52E8
		[NullableContext(2)]
		public FForceFeedbackParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060096BF RID: 38591 RVA: 0x000D70F2 File Offset: 0x000D52F2
		public FForceFeedbackParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060096C0 RID: 38592 RVA: 0x000D70FD File Offset: 0x000D52FD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FForceFeedbackParameters(Pointer, false, true);
		}

		// Token: 0x060096C1 RID: 38593 RVA: 0x000D7107 File Offset: 0x000D5307
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FForceFeedbackParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0400548D RID: 21645
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ForceFeedbackParameters";

		// Token: 0x0400548E RID: 21646
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400548F RID: 21647
		internal static int __PropertyOffset_Tag;

		// Token: 0x04005490 RID: 21648
		internal static int __PropertyOffset_bLooping;

		// Token: 0x04005491 RID: 21649
		internal static int __PropertyOffset_bIgnoreTimeDilation;

		// Token: 0x04005492 RID: 21650
		internal static int __PropertyOffset_bPlayWhilePaused;
	}
}
