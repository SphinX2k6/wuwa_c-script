using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000275 RID: 629
	[UnrealObjectPath("/Script/Engine.RootMotionMovementParams")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRootMotionMovementParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600404A RID: 16458 RVA: 0x0005C4FD File Offset: 0x0005A6FD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRootMotionMovementParams._ScriptStructPtr != 0) ? FRootMotionMovementParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RootMotionMovementParams", ref FRootMotionMovementParams._ScriptStructPtr);
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x0600404B RID: 16459 RVA: 0x0005C521 File Offset: 0x0005A721
		// (set) Token: 0x0600404C RID: 16460 RVA: 0x0005C531 File Offset: 0x0005A731
		public unsafe bool bHasRootMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_bHasRootMotion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_bHasRootMotion) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x0600404D RID: 16461 RVA: 0x0005C542 File Offset: 0x0005A742
		// (set) Token: 0x0600404E RID: 16462 RVA: 0x0005C552 File Offset: 0x0005A752
		public unsafe float BlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_BlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_BlendWeight) = value;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x0600404F RID: 16463 RVA: 0x0005C563 File Offset: 0x0005A763
		// (set) Token: 0x06004050 RID: 16464 RVA: 0x0005C573 File Offset: 0x0005A773
		public unsafe float AccumulatedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_AccumulatedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_AccumulatedTime) = value;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06004051 RID: 16465 RVA: 0x0005C584 File Offset: 0x0005A784
		// (set) Token: 0x06004052 RID: 16466 RVA: 0x0005C598 File Offset: 0x0005A798
		public unsafe FTransform RootMotionTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_RootMotionTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionMovementParams.__PropertyOffset_RootMotionTransform) = value;
			}
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x0005C5AD File Offset: 0x0005A7AD
		public FRootMotionMovementParams()
		{
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x0005C5B5 File Offset: 0x0005A7B5
		protected override IntPtr GetUStructPtr()
		{
			return FRootMotionMovementParams.StaticStruct();
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x0005C5C1 File Offset: 0x0005A7C1
		[NullableContext(2)]
		public FRootMotionMovementParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x0005C5CB File Offset: 0x0005A7CB
		public FRootMotionMovementParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x0005C5D6 File Offset: 0x0005A7D6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRootMotionMovementParams(Pointer, false, true);
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x0005C5E0 File Offset: 0x0005A7E0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRootMotionMovementParams(Pointer, MemoryOwner);
		}

		// Token: 0x04001931 RID: 6449
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RootMotionMovementParams";

		// Token: 0x04001932 RID: 6450
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001933 RID: 6451
		internal static int __PropertyOffset_bHasRootMotion;

		// Token: 0x04001934 RID: 6452
		internal static int __PropertyOffset_BlendWeight;

		// Token: 0x04001935 RID: 6453
		internal static int __PropertyOffset_AccumulatedTime;

		// Token: 0x04001936 RID: 6454
		internal static int __PropertyOffset_RootMotionTransform;
	}
}
