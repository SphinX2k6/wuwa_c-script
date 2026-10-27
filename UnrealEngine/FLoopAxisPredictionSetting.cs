using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200078B RID: 1931
	[UnrealObjectPath("/Script/EndlessCity.LoopAxisPredictionSetting")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FLoopAxisPredictionSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600647E RID: 25726 RVA: 0x000903C6 File Offset: 0x0008E5C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLoopAxisPredictionSetting._ScriptStructPtr != 0) ? FLoopAxisPredictionSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/EndlessCity.LoopAxisPredictionSetting", ref FLoopAxisPredictionSetting._ScriptStructPtr);
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x0600647F RID: 25727 RVA: 0x000903EA File Offset: 0x0008E5EA
		// (set) Token: 0x06006480 RID: 25728 RVA: 0x000903FA File Offset: 0x0008E5FA
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLoopAxisPredictionSetting.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLoopAxisPredictionSetting.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x06006481 RID: 25729 RVA: 0x0009040B File Offset: 0x0008E60B
		// (set) Token: 0x06006482 RID: 25730 RVA: 0x0009041B File Offset: 0x0008E61B
		public unsafe float ActivationDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLoopAxisPredictionSetting.__PropertyOffset_ActivationDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLoopAxisPredictionSetting.__PropertyOffset_ActivationDistance) = value;
			}
		}

		// Token: 0x06006483 RID: 25731 RVA: 0x0009042C File Offset: 0x0008E62C
		public FLoopAxisPredictionSetting()
		{
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x00090434 File Offset: 0x0008E634
		public FLoopAxisPredictionSetting(bool bEnabled, float ActivationDistance)
		{
			this.bEnabled = bEnabled;
			this.ActivationDistance = ActivationDistance;
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x0009044A File Offset: 0x0008E64A
		protected override IntPtr GetUStructPtr()
		{
			return FLoopAxisPredictionSetting.StaticStruct();
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x00090456 File Offset: 0x0008E656
		[NullableContext(2)]
		public FLoopAxisPredictionSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006487 RID: 25735 RVA: 0x00090460 File Offset: 0x0008E660
		public FLoopAxisPredictionSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006488 RID: 25736 RVA: 0x0009046B File Offset: 0x0008E66B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLoopAxisPredictionSetting(Pointer, false, true);
		}

		// Token: 0x06006489 RID: 25737 RVA: 0x00090475 File Offset: 0x0008E675
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLoopAxisPredictionSetting(Pointer, MemoryOwner);
		}

		// Token: 0x040030B7 RID: 12471
		[Nullable(1)]
		public const string __ObjectPath = "/Script/EndlessCity.LoopAxisPredictionSetting";

		// Token: 0x040030B8 RID: 12472
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040030B9 RID: 12473
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x040030BA RID: 12474
		internal static int __PropertyOffset_ActivationDistance;
	}
}
