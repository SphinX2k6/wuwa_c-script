using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020009A3 RID: 2467
	[UnrealObjectPath("/Script/Engine.DebugCameraControllerSettingsViewModeIndex")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FDebugCameraControllerSettingsViewModeIndex : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008B65 RID: 35685 RVA: 0x000C7BDE File Offset: 0x000C5DDE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDebugCameraControllerSettingsViewModeIndex._ScriptStructPtr != 0) ? FDebugCameraControllerSettingsViewModeIndex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DebugCameraControllerSettingsViewModeIndex", ref FDebugCameraControllerSettingsViewModeIndex._ScriptStructPtr);
		}

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x06008B66 RID: 35686 RVA: 0x000C7C02 File Offset: 0x000C5E02
		// (set) Token: 0x06008B67 RID: 35687 RVA: 0x000C7C16 File Offset: 0x000C5E16
		public unsafe TEnumAsByte<EViewModeIndex> ViewModeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDebugCameraControllerSettingsViewModeIndex.__PropertyOffset_ViewModeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDebugCameraControllerSettingsViewModeIndex.__PropertyOffset_ViewModeIndex) = value;
			}
		}

		// Token: 0x06008B68 RID: 35688 RVA: 0x000C7C2B File Offset: 0x000C5E2B
		public FDebugCameraControllerSettingsViewModeIndex()
		{
		}

		// Token: 0x06008B69 RID: 35689 RVA: 0x000C7C33 File Offset: 0x000C5E33
		public FDebugCameraControllerSettingsViewModeIndex(TEnumAsByte<EViewModeIndex> ViewModeIndex)
		{
			this.ViewModeIndex = ViewModeIndex;
		}

		// Token: 0x06008B6A RID: 35690 RVA: 0x000C7C42 File Offset: 0x000C5E42
		protected override IntPtr GetUStructPtr()
		{
			return FDebugCameraControllerSettingsViewModeIndex.StaticStruct();
		}

		// Token: 0x06008B6B RID: 35691 RVA: 0x000C7C4E File Offset: 0x000C5E4E
		[NullableContext(2)]
		public FDebugCameraControllerSettingsViewModeIndex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008B6C RID: 35692 RVA: 0x000C7C58 File Offset: 0x000C5E58
		public FDebugCameraControllerSettingsViewModeIndex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008B6D RID: 35693 RVA: 0x000C7C63 File Offset: 0x000C5E63
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDebugCameraControllerSettingsViewModeIndex(Pointer, false, true);
		}

		// Token: 0x06008B6E RID: 35694 RVA: 0x000C7C6D File Offset: 0x000C5E6D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDebugCameraControllerSettingsViewModeIndex(Pointer, MemoryOwner);
		}

		// Token: 0x04004239 RID: 16953
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.DebugCameraControllerSettingsViewModeIndex";

		// Token: 0x0400423A RID: 16954
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400423B RID: 16955
		internal static int __PropertyOffset_ViewModeIndex;
	}
}
