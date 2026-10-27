using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000561 RID: 1377
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ChainHarmonics_Reach")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_ChainHarmonics_Reach : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004923 RID: 18723 RVA: 0x0006C840 File Offset: 0x0006AA40
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ChainHarmonics_Reach._ScriptStructPtr != 0) ? FRigUnit_ChainHarmonics_Reach._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ChainHarmonics_Reach", ref FRigUnit_ChainHarmonics_Reach._ScriptStructPtr);
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x06004924 RID: 18724 RVA: 0x0006C864 File Offset: 0x0006AA64
		// (set) Token: 0x06004925 RID: 18725 RVA: 0x0006C874 File Offset: 0x0006AA74
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Reach.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Reach.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x06004926 RID: 18726 RVA: 0x0006C885 File Offset: 0x0006AA85
		// (set) Token: 0x06004927 RID: 18727 RVA: 0x0006C899 File Offset: 0x0006AA99
		public unsafe FVector ReachTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Reach.__PropertyOffset_ReachTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Reach.__PropertyOffset_ReachTarget) = value;
			}
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x06004928 RID: 18728 RVA: 0x0006C8AE File Offset: 0x0006AAAE
		// (set) Token: 0x06004929 RID: 18729 RVA: 0x0006C8C2 File Offset: 0x0006AAC2
		public unsafe FVector ReachAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Reach.__PropertyOffset_ReachAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Reach.__PropertyOffset_ReachAxis) = value;
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x0600492A RID: 18730 RVA: 0x0006C8D7 File Offset: 0x0006AAD7
		// (set) Token: 0x0600492B RID: 18731 RVA: 0x0006C8E7 File Offset: 0x0006AAE7
		public unsafe float ReachMinimum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Reach.__PropertyOffset_ReachMinimum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Reach.__PropertyOffset_ReachMinimum) = value;
			}
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x0600492C RID: 18732 RVA: 0x0006C8F8 File Offset: 0x0006AAF8
		// (set) Token: 0x0600492D RID: 18733 RVA: 0x0006C908 File Offset: 0x0006AB08
		public unsafe float ReachMaximum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Reach.__PropertyOffset_ReachMaximum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Reach.__PropertyOffset_ReachMaximum) = value;
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x0600492E RID: 18734 RVA: 0x0006C919 File Offset: 0x0006AB19
		// (set) Token: 0x0600492F RID: 18735 RVA: 0x0006C929 File Offset: 0x0006AB29
		public unsafe EControlRigAnimEasingType ReachEase
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Reach.__PropertyOffset_ReachEase));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ChainHarmonics_Reach.__PropertyOffset_ReachEase) = (byte)value;
			}
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x0006C93A File Offset: 0x0006AB3A
		public FRigUnit_ChainHarmonics_Reach()
		{
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x0006C942 File Offset: 0x0006AB42
		public FRigUnit_ChainHarmonics_Reach(bool bEnabled, FVector ReachTarget, FVector ReachAxis, float ReachMinimum, float ReachMaximum, EControlRigAnimEasingType ReachEase)
		{
			this.bEnabled = bEnabled;
			this.ReachTarget = ReachTarget;
			this.ReachAxis = ReachAxis;
			this.ReachMinimum = ReachMinimum;
			this.ReachMaximum = ReachMaximum;
			this.ReachEase = ReachEase;
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x0006C977 File Offset: 0x0006AB77
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ChainHarmonics_Reach.StaticStruct();
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x0006C983 File Offset: 0x0006AB83
		[NullableContext(2)]
		public FRigUnit_ChainHarmonics_Reach(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x0006C98D File Offset: 0x0006AB8D
		public FRigUnit_ChainHarmonics_Reach(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x0006C998 File Offset: 0x0006AB98
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ChainHarmonics_Reach(Pointer, false, true);
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x0006C9A2 File Offset: 0x0006ABA2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ChainHarmonics_Reach(Pointer, MemoryOwner);
		}

		// Token: 0x04002381 RID: 9089
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_ChainHarmonics_Reach";

		// Token: 0x04002382 RID: 9090
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002383 RID: 9091
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04002384 RID: 9092
		internal static int __PropertyOffset_ReachTarget;

		// Token: 0x04002385 RID: 9093
		internal static int __PropertyOffset_ReachAxis;

		// Token: 0x04002386 RID: 9094
		internal static int __PropertyOffset_ReachMinimum;

		// Token: 0x04002387 RID: 9095
		internal static int __PropertyOffset_ReachMaximum;

		// Token: 0x04002388 RID: 9096
		internal static int __PropertyOffset_ReachEase;
	}
}
