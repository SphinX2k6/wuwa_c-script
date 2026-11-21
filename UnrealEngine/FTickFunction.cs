using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002A1 RID: 673
	[UnrealObjectPath("/Script/Engine.TickFunction")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FTickFunction : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060049AB RID: 18859 RVA: 0x000674EB File Offset: 0x000656EB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTickFunction._ScriptStructPtr != 0) ? FTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TickFunction", ref FTickFunction._ScriptStructPtr);
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x060049AC RID: 18860 RVA: 0x0006750F File Offset: 0x0006570F
		// (set) Token: 0x060049AD RID: 18861 RVA: 0x00067523 File Offset: 0x00065723
		public unsafe TEnumAsByte<ETickingGroup> TickGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_TickGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_TickGroup) = value;
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x060049AE RID: 18862 RVA: 0x00067538 File Offset: 0x00065738
		// (set) Token: 0x060049AF RID: 18863 RVA: 0x0006754C File Offset: 0x0006574C
		public unsafe TEnumAsByte<ETickingGroup> EndTickGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_EndTickGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_EndTickGroup) = value;
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x060049B0 RID: 18864 RVA: 0x00067561 File Offset: 0x00065761
		// (set) Token: 0x060049B1 RID: 18865 RVA: 0x0006757A File Offset: 0x0006577A
		public unsafe bool bTickEvenWhenPaused
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_bTickEvenWhenPaused) & FTickFunction.__PropertyMask_bTickEvenWhenPaused) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FTickFunction.__PropertyOffset_bTickEvenWhenPaused) = ((*(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_bTickEvenWhenPaused) & ~FTickFunction.__PropertyMask_bTickEvenWhenPaused) | (value ? FTickFunction.__PropertyMask_bTickEvenWhenPaused : 0));
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x060049B2 RID: 18866 RVA: 0x000675AA File Offset: 0x000657AA
		// (set) Token: 0x060049B3 RID: 18867 RVA: 0x000675C3 File Offset: 0x000657C3
		public unsafe bool bCanEverTick
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_bCanEverTick) & FTickFunction.__PropertyMask_bCanEverTick) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FTickFunction.__PropertyOffset_bCanEverTick) = ((*(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_bCanEverTick) & ~FTickFunction.__PropertyMask_bCanEverTick) | (value ? FTickFunction.__PropertyMask_bCanEverTick : 0));
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x060049B4 RID: 18868 RVA: 0x000675F3 File Offset: 0x000657F3
		// (set) Token: 0x060049B5 RID: 18869 RVA: 0x0006760C File Offset: 0x0006580C
		public unsafe bool bStartWithTickEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_bStartWithTickEnabled) & FTickFunction.__PropertyMask_bStartWithTickEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FTickFunction.__PropertyOffset_bStartWithTickEnabled) = ((*(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_bStartWithTickEnabled) & ~FTickFunction.__PropertyMask_bStartWithTickEnabled) | (value ? FTickFunction.__PropertyMask_bStartWithTickEnabled : 0));
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x060049B6 RID: 18870 RVA: 0x0006763C File Offset: 0x0006583C
		// (set) Token: 0x060049B7 RID: 18871 RVA: 0x00067655 File Offset: 0x00065855
		public unsafe bool bAllowTickOnDedicatedServer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_bAllowTickOnDedicatedServer) & FTickFunction.__PropertyMask_bAllowTickOnDedicatedServer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FTickFunction.__PropertyOffset_bAllowTickOnDedicatedServer) = ((*(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_bAllowTickOnDedicatedServer) & ~FTickFunction.__PropertyMask_bAllowTickOnDedicatedServer) | (value ? FTickFunction.__PropertyMask_bAllowTickOnDedicatedServer : 0));
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x060049B8 RID: 18872 RVA: 0x00067685 File Offset: 0x00065885
		// (set) Token: 0x060049B9 RID: 18873 RVA: 0x00067695 File Offset: 0x00065895
		public unsafe float TickInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_TickInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTickFunction.__PropertyOffset_TickInterval) = value;
			}
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x000676A6 File Offset: 0x000658A6
		public FTickFunction()
		{
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x000676AE File Offset: 0x000658AE
		protected override IntPtr GetUStructPtr()
		{
			return FTickFunction.StaticStruct();
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x000676BA File Offset: 0x000658BA
		[NullableContext(2)]
		public FTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x000676C4 File Offset: 0x000658C4
		public FTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x000676CF File Offset: 0x000658CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTickFunction(Pointer, false, true);
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x000676D9 File Offset: 0x000658D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x04001D04 RID: 7428
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TickFunction";

		// Token: 0x04001D05 RID: 7429
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D06 RID: 7430
		internal static int __PropertyOffset_TickGroup;

		// Token: 0x04001D07 RID: 7431
		internal static int __PropertyOffset_EndTickGroup;

		// Token: 0x04001D08 RID: 7432
		internal static int __PropertyOffset_bTickEvenWhenPaused;

		// Token: 0x04001D09 RID: 7433
		internal static byte __PropertyMask_bTickEvenWhenPaused;

		// Token: 0x04001D0A RID: 7434
		internal static int __PropertyOffset_bCanEverTick;

		// Token: 0x04001D0B RID: 7435
		internal static byte __PropertyMask_bCanEverTick;

		// Token: 0x04001D0C RID: 7436
		internal static int __PropertyOffset_bStartWithTickEnabled;

		// Token: 0x04001D0D RID: 7437
		internal static byte __PropertyMask_bStartWithTickEnabled;

		// Token: 0x04001D0E RID: 7438
		internal static int __PropertyOffset_bAllowTickOnDedicatedServer;

		// Token: 0x04001D0F RID: 7439
		internal static byte __PropertyMask_bAllowTickOnDedicatedServer;

		// Token: 0x04001D10 RID: 7440
		internal static int __PropertyOffset_TickInterval;
	}
}
