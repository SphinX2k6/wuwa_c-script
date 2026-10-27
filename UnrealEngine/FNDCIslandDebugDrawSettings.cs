using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002534 RID: 9524
	[UnrealObjectPath("/Script/Niagara.NDCIslandDebugDrawSettings")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNDCIslandDebugDrawSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060235B2 RID: 144818 RVA: 0x00344A37 File Offset: 0x00342C37
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNDCIslandDebugDrawSettings._ScriptStructPtr != 0) ? FNDCIslandDebugDrawSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NDCIslandDebugDrawSettings", ref FNDCIslandDebugDrawSettings._ScriptStructPtr);
		}

		// Token: 0x170087EB RID: 34795
		// (get) Token: 0x060235B3 RID: 144819 RVA: 0x00344A5B File Offset: 0x00342C5B
		// (set) Token: 0x060235B4 RID: 144820 RVA: 0x00344A74 File Offset: 0x00342C74
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNDCIslandDebugDrawSettings.__PropertyOffset_bEnabled) & FNDCIslandDebugDrawSettings.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNDCIslandDebugDrawSettings.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)FNDCIslandDebugDrawSettings.__PropertyOffset_bEnabled) & ~FNDCIslandDebugDrawSettings.__PropertyMask_bEnabled) | (value ? FNDCIslandDebugDrawSettings.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x170087EC RID: 34796
		// (get) Token: 0x060235B5 RID: 144821 RVA: 0x00344AA4 File Offset: 0x00342CA4
		// (set) Token: 0x060235B6 RID: 144822 RVA: 0x00344ABD File Offset: 0x00342CBD
		public unsafe bool bShowIslandBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNDCIslandDebugDrawSettings.__PropertyOffset_bShowIslandBounds) & FNDCIslandDebugDrawSettings.__PropertyMask_bShowIslandBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNDCIslandDebugDrawSettings.__PropertyOffset_bShowIslandBounds) = ((*(base.NativePtr + (IntPtr)FNDCIslandDebugDrawSettings.__PropertyOffset_bShowIslandBounds) & ~FNDCIslandDebugDrawSettings.__PropertyMask_bShowIslandBounds) | (value ? FNDCIslandDebugDrawSettings.__PropertyMask_bShowIslandBounds : 0));
			}
		}

		// Token: 0x060235B7 RID: 144823 RVA: 0x00344AED File Offset: 0x00342CED
		public FNDCIslandDebugDrawSettings()
		{
		}

		// Token: 0x060235B8 RID: 144824 RVA: 0x00344AF5 File Offset: 0x00342CF5
		public FNDCIslandDebugDrawSettings(bool bEnabled, bool bShowIslandBounds)
		{
			this.bEnabled = bEnabled;
			this.bShowIslandBounds = bShowIslandBounds;
		}

		// Token: 0x060235B9 RID: 144825 RVA: 0x00344B0B File Offset: 0x00342D0B
		protected override IntPtr GetUStructPtr()
		{
			return FNDCIslandDebugDrawSettings.StaticStruct();
		}

		// Token: 0x060235BA RID: 144826 RVA: 0x00344B17 File Offset: 0x00342D17
		[NullableContext(2)]
		public FNDCIslandDebugDrawSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060235BB RID: 144827 RVA: 0x00344B21 File Offset: 0x00342D21
		public FNDCIslandDebugDrawSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060235BC RID: 144828 RVA: 0x00344B2C File Offset: 0x00342D2C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNDCIslandDebugDrawSettings(Pointer, false, true);
		}

		// Token: 0x060235BD RID: 144829 RVA: 0x00344B36 File Offset: 0x00342D36
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNDCIslandDebugDrawSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04012FA8 RID: 77736
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NDCIslandDebugDrawSettings";

		// Token: 0x04012FA9 RID: 77737
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FAA RID: 77738
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04012FAB RID: 77739
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x04012FAC RID: 77740
		internal static int __PropertyOffset_bShowIslandBounds;

		// Token: 0x04012FAD RID: 77741
		internal static byte __PropertyMask_bShowIslandBounds;
	}
}
