using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FF7 RID: 4087
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlannedRuntimePartitionModifier")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FPlannedRuntimePartitionModifier : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DD55 RID: 56661 RVA: 0x00145DD4 File Offset: 0x00143FD4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPlannedRuntimePartitionModifier._ScriptStructPtr != 0) ? FPlannedRuntimePartitionModifier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PlannedRuntimePartitionModifier", ref FPlannedRuntimePartitionModifier._ScriptStructPtr);
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x0600DD56 RID: 56662 RVA: 0x00145DF8 File Offset: 0x00143FF8
		// (set) Token: 0x0600DD57 RID: 56663 RVA: 0x00145E08 File Offset: 0x00144008
		public unsafe int MinLoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlannedRuntimePartitionModifier.__PropertyOffset_MinLoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlannedRuntimePartitionModifier.__PropertyOffset_MinLoadingRange) = value;
			}
		}

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x0600DD58 RID: 56664 RVA: 0x00145E19 File Offset: 0x00144019
		// (set) Token: 0x0600DD59 RID: 56665 RVA: 0x00145E29 File Offset: 0x00144029
		public unsafe int MaxLoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlannedRuntimePartitionModifier.__PropertyOffset_MaxLoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlannedRuntimePartitionModifier.__PropertyOffset_MaxLoadingRange) = value;
			}
		}

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x0600DD5A RID: 56666 RVA: 0x00145E3C File Offset: 0x0014403C
		// (set) Token: 0x0600DD5B RID: 56667 RVA: 0x00145E7F File Offset: 0x0014407F
		public FRuntimeFloatCurve ScaleCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._ScaleCurve) == null)
				{
					result = (this._ScaleCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FPlannedRuntimePartitionModifier.__PropertyOffset_ScaleCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FPlannedRuntimePartitionModifier.__PropertyOffset_ScaleCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x0600DD5C RID: 56668 RVA: 0x00145EA0 File Offset: 0x001440A0
		// (set) Token: 0x0600DD5D RID: 56669 RVA: 0x00145EB0 File Offset: 0x001440B0
		public unsafe float ScaleMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPlannedRuntimePartitionModifier.__PropertyOffset_ScaleMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPlannedRuntimePartitionModifier.__PropertyOffset_ScaleMultiplier) = value;
			}
		}

		// Token: 0x0600DD5E RID: 56670 RVA: 0x00145EC1 File Offset: 0x001440C1
		public FPlannedRuntimePartitionModifier()
		{
		}

		// Token: 0x0600DD5F RID: 56671 RVA: 0x00145EC9 File Offset: 0x001440C9
		public FPlannedRuntimePartitionModifier(int MinLoadingRange, int MaxLoadingRange, FRuntimeFloatCurve ScaleCurve, float ScaleMultiplier)
		{
			this.MinLoadingRange = MinLoadingRange;
			this.MaxLoadingRange = MaxLoadingRange;
			this.ScaleCurve = ScaleCurve;
			this.ScaleMultiplier = ScaleMultiplier;
		}

		// Token: 0x0600DD60 RID: 56672 RVA: 0x00145EEE File Offset: 0x001440EE
		protected override IntPtr GetUStructPtr()
		{
			return FPlannedRuntimePartitionModifier.StaticStruct();
		}

		// Token: 0x0600DD61 RID: 56673 RVA: 0x00145EFA File Offset: 0x001440FA
		[NullableContext(2)]
		public FPlannedRuntimePartitionModifier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DD62 RID: 56674 RVA: 0x00145F04 File Offset: 0x00144104
		public FPlannedRuntimePartitionModifier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DD63 RID: 56675 RVA: 0x00145F0F File Offset: 0x0014410F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPlannedRuntimePartitionModifier(Pointer, false, true);
		}

		// Token: 0x0600DD64 RID: 56676 RVA: 0x00145F19 File Offset: 0x00144119
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPlannedRuntimePartitionModifier(Pointer, MemoryOwner);
		}

		// Token: 0x040077A2 RID: 30626
		public const string __ObjectPath = "/Script/Engine.PlannedRuntimePartitionModifier";

		// Token: 0x040077A3 RID: 30627
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040077A4 RID: 30628
		internal static int __PropertyOffset_MinLoadingRange;

		// Token: 0x040077A5 RID: 30629
		internal static int __PropertyOffset_MaxLoadingRange;

		// Token: 0x040077A6 RID: 30630
		internal static int __PropertyOffset_ScaleCurve;

		// Token: 0x040077A7 RID: 30631
		[Nullable(2)]
		private FRuntimeFloatCurve _ScaleCurve;

		// Token: 0x040077A8 RID: 30632
		internal static int __PropertyOffset_ScaleMultiplier;
	}
}
