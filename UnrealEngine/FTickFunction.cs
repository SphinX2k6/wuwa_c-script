using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011E7 RID: 4583
	[UnrealObjectPath("/Script/Engine.TickFunction")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FTickFunction : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010E06 RID: 69126 RVA: 0x0018C8A9 File Offset: 0x0018AAA9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTickFunction._ScriptStructPtr != 0) ? FTickFunction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TickFunction", ref FTickFunction._ScriptStructPtr);
		}

		// Token: 0x170041F9 RID: 16889
		// (get) Token: 0x06010E07 RID: 69127 RVA: 0x0018C8CD File Offset: 0x0018AACD
		// (set) Token: 0x06010E08 RID: 69128 RVA: 0x0018C8E1 File Offset: 0x0018AAE1
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

		// Token: 0x170041FA RID: 16890
		// (get) Token: 0x06010E09 RID: 69129 RVA: 0x0018C8F6 File Offset: 0x0018AAF6
		// (set) Token: 0x06010E0A RID: 69130 RVA: 0x0018C90A File Offset: 0x0018AB0A
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

		// Token: 0x170041FB RID: 16891
		// (get) Token: 0x06010E0B RID: 69131 RVA: 0x0018C91F File Offset: 0x0018AB1F
		// (set) Token: 0x06010E0C RID: 69132 RVA: 0x0018C938 File Offset: 0x0018AB38
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

		// Token: 0x170041FC RID: 16892
		// (get) Token: 0x06010E0D RID: 69133 RVA: 0x0018C968 File Offset: 0x0018AB68
		// (set) Token: 0x06010E0E RID: 69134 RVA: 0x0018C981 File Offset: 0x0018AB81
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

		// Token: 0x170041FD RID: 16893
		// (get) Token: 0x06010E0F RID: 69135 RVA: 0x0018C9B1 File Offset: 0x0018ABB1
		// (set) Token: 0x06010E10 RID: 69136 RVA: 0x0018C9CA File Offset: 0x0018ABCA
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

		// Token: 0x170041FE RID: 16894
		// (get) Token: 0x06010E11 RID: 69137 RVA: 0x0018C9FA File Offset: 0x0018ABFA
		// (set) Token: 0x06010E12 RID: 69138 RVA: 0x0018CA13 File Offset: 0x0018AC13
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

		// Token: 0x170041FF RID: 16895
		// (get) Token: 0x06010E13 RID: 69139 RVA: 0x0018CA43 File Offset: 0x0018AC43
		// (set) Token: 0x06010E14 RID: 69140 RVA: 0x0018CA53 File Offset: 0x0018AC53
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

		// Token: 0x06010E15 RID: 69141 RVA: 0x0018CA64 File Offset: 0x0018AC64
		public FTickFunction()
		{
		}

		// Token: 0x06010E16 RID: 69142 RVA: 0x0018CA6C File Offset: 0x0018AC6C
		public FTickFunction(TEnumAsByte<ETickingGroup> TickGroup, TEnumAsByte<ETickingGroup> EndTickGroup, bool bTickEvenWhenPaused, bool bCanEverTick, bool bStartWithTickEnabled, bool bAllowTickOnDedicatedServer, float TickInterval)
		{
			this.TickGroup = TickGroup;
			this.EndTickGroup = EndTickGroup;
			this.bTickEvenWhenPaused = bTickEvenWhenPaused;
			this.bCanEverTick = bCanEverTick;
			this.bStartWithTickEnabled = bStartWithTickEnabled;
			this.bAllowTickOnDedicatedServer = bAllowTickOnDedicatedServer;
			this.TickInterval = TickInterval;
		}

		// Token: 0x06010E17 RID: 69143 RVA: 0x0018CAA9 File Offset: 0x0018ACA9
		protected override IntPtr GetUStructPtr()
		{
			return FTickFunction.StaticStruct();
		}

		// Token: 0x06010E18 RID: 69144 RVA: 0x0018CAB5 File Offset: 0x0018ACB5
		[NullableContext(2)]
		public FTickFunction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010E19 RID: 69145 RVA: 0x0018CABF File Offset: 0x0018ACBF
		public FTickFunction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010E1A RID: 69146 RVA: 0x0018CACA File Offset: 0x0018ACCA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTickFunction(Pointer, false, true);
		}

		// Token: 0x06010E1B RID: 69147 RVA: 0x0018CAD4 File Offset: 0x0018ACD4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTickFunction(Pointer, MemoryOwner);
		}

		// Token: 0x040090BE RID: 37054
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TickFunction";

		// Token: 0x040090BF RID: 37055
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040090C0 RID: 37056
		internal static int __PropertyOffset_TickGroup;

		// Token: 0x040090C1 RID: 37057
		internal static int __PropertyOffset_EndTickGroup;

		// Token: 0x040090C2 RID: 37058
		internal static int __PropertyOffset_bTickEvenWhenPaused;

		// Token: 0x040090C3 RID: 37059
		internal static byte __PropertyMask_bTickEvenWhenPaused;

		// Token: 0x040090C4 RID: 37060
		internal static int __PropertyOffset_bCanEverTick;

		// Token: 0x040090C5 RID: 37061
		internal static byte __PropertyMask_bCanEverTick;

		// Token: 0x040090C6 RID: 37062
		internal static int __PropertyOffset_bStartWithTickEnabled;

		// Token: 0x040090C7 RID: 37063
		internal static byte __PropertyMask_bStartWithTickEnabled;

		// Token: 0x040090C8 RID: 37064
		internal static int __PropertyOffset_bAllowTickOnDedicatedServer;

		// Token: 0x040090C9 RID: 37065
		internal static byte __PropertyMask_bAllowTickOnDedicatedServer;

		// Token: 0x040090CA RID: 37066
		internal static int __PropertyOffset_TickInterval;
	}
}
