using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002536 RID: 9526
	[UnrealObjectPath("/Script/Niagara.NDCPlacementDebugDrawSettings")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNDCPlacementDebugDrawSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060235CC RID: 144844 RVA: 0x00344C37 File Offset: 0x00342E37
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNDCPlacementDebugDrawSettings._ScriptStructPtr != 0) ? FNDCPlacementDebugDrawSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NDCPlacementDebugDrawSettings", ref FNDCPlacementDebugDrawSettings._ScriptStructPtr);
		}

		// Token: 0x170087F0 RID: 34800
		// (get) Token: 0x060235CD RID: 144845 RVA: 0x00344C5B File Offset: 0x00342E5B
		// (set) Token: 0x060235CE RID: 144846 RVA: 0x00344C74 File Offset: 0x00342E74
		public unsafe bool bEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNDCPlacementDebugDrawSettings.__PropertyOffset_bEnabled) & FNDCPlacementDebugDrawSettings.__PropertyMask_bEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNDCPlacementDebugDrawSettings.__PropertyOffset_bEnabled) = ((*(base.NativePtr + (IntPtr)FNDCPlacementDebugDrawSettings.__PropertyOffset_bEnabled) & ~FNDCPlacementDebugDrawSettings.__PropertyMask_bEnabled) | (value ? FNDCPlacementDebugDrawSettings.__PropertyMask_bEnabled : 0));
			}
		}

		// Token: 0x170087F1 RID: 34801
		// (get) Token: 0x060235CF RID: 144847 RVA: 0x00344CA4 File Offset: 0x00342EA4
		// (set) Token: 0x060235D0 RID: 144848 RVA: 0x00344CBD File Offset: 0x00342EBD
		public unsafe bool bShowPlacementBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FNDCPlacementDebugDrawSettings.__PropertyOffset_bShowPlacementBounds) & FNDCPlacementDebugDrawSettings.__PropertyMask_bShowPlacementBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FNDCPlacementDebugDrawSettings.__PropertyOffset_bShowPlacementBounds) = ((*(base.NativePtr + (IntPtr)FNDCPlacementDebugDrawSettings.__PropertyOffset_bShowPlacementBounds) & ~FNDCPlacementDebugDrawSettings.__PropertyMask_bShowPlacementBounds) | (value ? FNDCPlacementDebugDrawSettings.__PropertyMask_bShowPlacementBounds : 0));
			}
		}

		// Token: 0x060235D1 RID: 144849 RVA: 0x00344CED File Offset: 0x00342EED
		public FNDCPlacementDebugDrawSettings()
		{
		}

		// Token: 0x060235D2 RID: 144850 RVA: 0x00344CF5 File Offset: 0x00342EF5
		public FNDCPlacementDebugDrawSettings(bool bEnabled, bool bShowPlacementBounds)
		{
			this.bEnabled = bEnabled;
			this.bShowPlacementBounds = bShowPlacementBounds;
		}

		// Token: 0x060235D3 RID: 144851 RVA: 0x00344D0B File Offset: 0x00342F0B
		protected override IntPtr GetUStructPtr()
		{
			return FNDCPlacementDebugDrawSettings.StaticStruct();
		}

		// Token: 0x060235D4 RID: 144852 RVA: 0x00344D17 File Offset: 0x00342F17
		[NullableContext(2)]
		public FNDCPlacementDebugDrawSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060235D5 RID: 144853 RVA: 0x00344D21 File Offset: 0x00342F21
		public FNDCPlacementDebugDrawSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060235D6 RID: 144854 RVA: 0x00344D2C File Offset: 0x00342F2C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNDCPlacementDebugDrawSettings(Pointer, false, true);
		}

		// Token: 0x060235D7 RID: 144855 RVA: 0x00344D36 File Offset: 0x00342F36
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNDCPlacementDebugDrawSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04012FB3 RID: 77747
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NDCPlacementDebugDrawSettings";

		// Token: 0x04012FB4 RID: 77748
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FB5 RID: 77749
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x04012FB6 RID: 77750
		internal static byte __PropertyMask_bEnabled;

		// Token: 0x04012FB7 RID: 77751
		internal static int __PropertyOffset_bShowPlacementBounds;

		// Token: 0x04012FB8 RID: 77752
		internal static byte __PropertyMask_bShowPlacementBounds;
	}
}
