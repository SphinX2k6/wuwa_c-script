using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011BE RID: 4542
	[UnrealObjectPath("/Script/Engine.SwarmDebugOptions")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FSwarmDebugOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010BF3 RID: 68595 RVA: 0x001894DC File Offset: 0x001876DC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSwarmDebugOptions._ScriptStructPtr != 0) ? FSwarmDebugOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SwarmDebugOptions", ref FSwarmDebugOptions._ScriptStructPtr);
		}

		// Token: 0x17004168 RID: 16744
		// (get) Token: 0x06010BF4 RID: 68596 RVA: 0x00189500 File Offset: 0x00187700
		// (set) Token: 0x06010BF5 RID: 68597 RVA: 0x00189519 File Offset: 0x00187719
		public unsafe bool bDistributionEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSwarmDebugOptions.__PropertyOffset_bDistributionEnabled) & FSwarmDebugOptions.__PropertyMask_bDistributionEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSwarmDebugOptions.__PropertyOffset_bDistributionEnabled) = ((*(base.NativePtr + (IntPtr)FSwarmDebugOptions.__PropertyOffset_bDistributionEnabled) & ~FSwarmDebugOptions.__PropertyMask_bDistributionEnabled) | (value ? FSwarmDebugOptions.__PropertyMask_bDistributionEnabled : 0));
			}
		}

		// Token: 0x17004169 RID: 16745
		// (get) Token: 0x06010BF6 RID: 68598 RVA: 0x00189549 File Offset: 0x00187749
		// (set) Token: 0x06010BF7 RID: 68599 RVA: 0x00189562 File Offset: 0x00187762
		public unsafe bool bForceContentExport
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSwarmDebugOptions.__PropertyOffset_bForceContentExport) & FSwarmDebugOptions.__PropertyMask_bForceContentExport) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSwarmDebugOptions.__PropertyOffset_bForceContentExport) = ((*(base.NativePtr + (IntPtr)FSwarmDebugOptions.__PropertyOffset_bForceContentExport) & ~FSwarmDebugOptions.__PropertyMask_bForceContentExport) | (value ? FSwarmDebugOptions.__PropertyMask_bForceContentExport : 0));
			}
		}

		// Token: 0x1700416A RID: 16746
		// (get) Token: 0x06010BF8 RID: 68600 RVA: 0x00189592 File Offset: 0x00187792
		// (set) Token: 0x06010BF9 RID: 68601 RVA: 0x001895AB File Offset: 0x001877AB
		public unsafe bool bInitialized
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSwarmDebugOptions.__PropertyOffset_bInitialized) & FSwarmDebugOptions.__PropertyMask_bInitialized) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSwarmDebugOptions.__PropertyOffset_bInitialized) = ((*(base.NativePtr + (IntPtr)FSwarmDebugOptions.__PropertyOffset_bInitialized) & ~FSwarmDebugOptions.__PropertyMask_bInitialized) | (value ? FSwarmDebugOptions.__PropertyMask_bInitialized : 0));
			}
		}

		// Token: 0x06010BFA RID: 68602 RVA: 0x001895DB File Offset: 0x001877DB
		public FSwarmDebugOptions()
		{
		}

		// Token: 0x06010BFB RID: 68603 RVA: 0x001895E3 File Offset: 0x001877E3
		public FSwarmDebugOptions(bool bDistributionEnabled, bool bForceContentExport, bool bInitialized)
		{
			this.bDistributionEnabled = bDistributionEnabled;
			this.bForceContentExport = bForceContentExport;
			this.bInitialized = bInitialized;
		}

		// Token: 0x06010BFC RID: 68604 RVA: 0x00189600 File Offset: 0x00187800
		protected override IntPtr GetUStructPtr()
		{
			return FSwarmDebugOptions.StaticStruct();
		}

		// Token: 0x06010BFD RID: 68605 RVA: 0x0018960C File Offset: 0x0018780C
		[NullableContext(2)]
		public FSwarmDebugOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010BFE RID: 68606 RVA: 0x00189616 File Offset: 0x00187816
		public FSwarmDebugOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010BFF RID: 68607 RVA: 0x00189621 File Offset: 0x00187821
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSwarmDebugOptions(Pointer, false, true);
		}

		// Token: 0x06010C00 RID: 68608 RVA: 0x0018962B File Offset: 0x0018782B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSwarmDebugOptions(Pointer, MemoryOwner);
		}

		// Token: 0x04008F37 RID: 36663
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SwarmDebugOptions";

		// Token: 0x04008F38 RID: 36664
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008F39 RID: 36665
		internal static int __PropertyOffset_bDistributionEnabled;

		// Token: 0x04008F3A RID: 36666
		internal static byte __PropertyMask_bDistributionEnabled;

		// Token: 0x04008F3B RID: 36667
		internal static int __PropertyOffset_bForceContentExport;

		// Token: 0x04008F3C RID: 36668
		internal static byte __PropertyMask_bForceContentExport;

		// Token: 0x04008F3D RID: 36669
		internal static int __PropertyOffset_bInitialized;

		// Token: 0x04008F3E RID: 36670
		internal static byte __PropertyMask_bInitialized;
	}
}
