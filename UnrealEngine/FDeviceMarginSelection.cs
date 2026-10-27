using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FD4 RID: 8148
	[UnrealObjectPath("/Script/LGUI.DeviceMarginSelection")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FDeviceMarginSelection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EE7A RID: 126586 RVA: 0x002DED9B File Offset: 0x002DCF9B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDeviceMarginSelection._ScriptStructPtr != 0) ? FDeviceMarginSelection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.DeviceMarginSelection", ref FDeviceMarginSelection._ScriptStructPtr);
		}

		// Token: 0x17007AF8 RID: 31480
		// (get) Token: 0x0601EE7B RID: 126587 RVA: 0x002DEDBF File Offset: 0x002DCFBF
		// (set) Token: 0x0601EE7C RID: 126588 RVA: 0x002DEDD3 File Offset: 0x002DCFD3
		public unsafe FName MarginOptionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDeviceMarginSelection.__PropertyOffset_MarginOptionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDeviceMarginSelection.__PropertyOffset_MarginOptionName) = value;
			}
		}

		// Token: 0x0601EE7D RID: 126589 RVA: 0x002DEDE8 File Offset: 0x002DCFE8
		public FDeviceMarginSelection()
		{
		}

		// Token: 0x0601EE7E RID: 126590 RVA: 0x002DEDF0 File Offset: 0x002DCFF0
		public FDeviceMarginSelection(FName MarginOptionName)
		{
			this.MarginOptionName = MarginOptionName;
		}

		// Token: 0x0601EE7F RID: 126591 RVA: 0x002DEDFF File Offset: 0x002DCFFF
		protected override IntPtr GetUStructPtr()
		{
			return FDeviceMarginSelection.StaticStruct();
		}

		// Token: 0x0601EE80 RID: 126592 RVA: 0x002DEE0B File Offset: 0x002DD00B
		[NullableContext(2)]
		public FDeviceMarginSelection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EE81 RID: 126593 RVA: 0x002DEE15 File Offset: 0x002DD015
		public FDeviceMarginSelection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EE82 RID: 126594 RVA: 0x002DEE20 File Offset: 0x002DD020
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDeviceMarginSelection(Pointer, false, true);
		}

		// Token: 0x0601EE83 RID: 126595 RVA: 0x002DEE2A File Offset: 0x002DD02A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDeviceMarginSelection(Pointer, MemoryOwner);
		}

		// Token: 0x04010B29 RID: 68393
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.DeviceMarginSelection";

		// Token: 0x04010B2A RID: 68394
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010B2B RID: 68395
		internal static int __PropertyOffset_MarginOptionName;
	}
}
