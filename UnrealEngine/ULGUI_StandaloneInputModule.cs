using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006CD RID: 1741
	[UnrealObjectPath("/Script/LGUI.LGUI_StandaloneInputModule")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class ULGUI_StandaloneInputModule : ULGUI_PointerInputModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009481 RID: 38017 RVA: 0x000DFEC5 File Offset: 0x000DE0C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_StandaloneInputModule._ClassPtr;
		}

		// Token: 0x06009482 RID: 38018 RVA: 0x000DFED4 File Offset: 0x000DE0D4
		public ULGUI_StandaloneInputModule() : this(BuiltinUtils.AllocNativeUObject(ULGUI_StandaloneInputModule.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009483 RID: 38019 RVA: 0x000DFEFC File Offset: 0x000DE0FC
		[NullableContext(1)]
		public ULGUI_StandaloneInputModule(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUI_StandaloneInputModule.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06009484 RID: 38020 RVA: 0x000DFF2F File Offset: 0x000DE12F
		// (set) Token: 0x06009485 RID: 38021 RVA: 0x000DFF3F File Offset: 0x000DE13F
		public unsafe bool bOverrideMousePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUI_StandaloneInputModule.__PropertyOffset_bOverrideMousePosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUI_StandaloneInputModule.__PropertyOffset_bOverrideMousePosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x06009486 RID: 38022 RVA: 0x000DFF50 File Offset: 0x000DE150
		public void SimulationPointerTrigger(int pointerID, bool IsPressed)
		{
			ULGUI_StandaloneInputModule.__SimulationPointerTrigger_Internal(base.NativePtr, pointerID, IsPressed);
		}

		// Token: 0x06009487 RID: 38023 RVA: 0x000DFF60 File Offset: 0x000DE160
		[NullableContext(2)]
		public bool SimulationPointerDownUp(int pointerID, UUIItem UIItem, bool IsPressed, in FVector2D? ClickPivot = null)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr uiitem = (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero;
			FVector2D? fvector2D = ClickPivot;
			FVector2D fvector2D2;
			FVector2D fvector2D3;
			if (fvector2D == null)
			{
				fvector2D2 = new FVector2D
				{
					X = 0.5f,
					Y = 0.5f
				};
				fvector2D3 = fvector2D2;
			}
			else
			{
				fvector2D3 = fvector2D.GetValueOrDefault();
			}
			fvector2D2 = fvector2D3;
			return ULGUI_StandaloneInputModule.__SimulationPointerDownUp_Internal(nativePtr, pointerID, uiitem, IsPressed, fvector2D2);
		}

		// Token: 0x06009488 RID: 38024 RVA: 0x000DFFC8 File Offset: 0x000DE1C8
		[NullableContext(2)]
		public bool SimulationLineTrace(int pointerID, UUIItem UIItem, in FVector2D? ClickPivot = null)
		{
			IntPtr nativePtr = base.NativePtr;
			IntPtr uiitem = (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero;
			FVector2D? fvector2D = ClickPivot;
			FVector2D fvector2D2;
			FVector2D fvector2D3;
			if (fvector2D == null)
			{
				fvector2D2 = new FVector2D
				{
					X = 0.5f,
					Y = 0.5f
				};
				fvector2D3 = fvector2D2;
			}
			else
			{
				fvector2D3 = fvector2D.GetValueOrDefault();
			}
			fvector2D2 = fvector2D3;
			return ULGUI_StandaloneInputModule.__SimulationLineTrace_Internal(nativePtr, pointerID, uiitem, fvector2D2);
		}

		// Token: 0x06009489 RID: 38025 RVA: 0x000E002D File Offset: 0x000DE22D
		public void SetIsUseMouse(bool value)
		{
			ULGUI_StandaloneInputModule.__SetIsUseMouse_Internal(base.NativePtr, value);
		}

		// Token: 0x0600948A RID: 38026 RVA: 0x000E003B File Offset: 0x000DE23B
		public void SetIsForceChange(bool value)
		{
			ULGUI_StandaloneInputModule.__SetIsForceChange_Internal(base.NativePtr, value);
		}

		// Token: 0x0600948B RID: 38027 RVA: 0x000E0049 File Offset: 0x000DE249
		public void ResetNowIsTriggerPressed(int pointerID)
		{
			ULGUI_StandaloneInputModule.__ResetNowIsTriggerPressed_Internal(base.NativePtr, pointerID);
		}

		// Token: 0x0600948C RID: 38028 RVA: 0x000E0057 File Offset: 0x000DE257
		public void InputTrigger(bool inTriggerPress, EMouseButtonType inMouseButtonType = EMouseButtonType.Left)
		{
			ULGUI_StandaloneInputModule.__InputTrigger_Internal(base.NativePtr, inTriggerPress, inMouseButtonType);
		}

		// Token: 0x0600948D RID: 38029 RVA: 0x000E0068 File Offset: 0x000DE268
		public unsafe void InputScroll(in float inAxisValue)
		{
			fixed (float* ptr = &inAxisValue)
			{
				void* ptr2 = (void*)ptr;
				ULGUI_StandaloneInputModule.__InputScroll_Internal(base.NativePtr, inAxisValue);
			}
		}

		// Token: 0x0600948E RID: 38030 RVA: 0x000E0089 File Offset: 0x000DE289
		public void InputOverrideMousePosition(in FVector2D inMousePosition)
		{
			ULGUI_StandaloneInputModule.__InputOverrideMousePosition_Internal(base.NativePtr, inMousePosition);
		}

		// Token: 0x0600948F RID: 38031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimulationPointerTrigger_Internal(IntPtr @this, int pointerID, bool IsPressed);

		// Token: 0x06009490 RID: 38032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SimulationPointerDownUp_Internal(IntPtr @this, int pointerID, IntPtr UIItem, bool IsPressed, in FVector2D ClickPivot);

		// Token: 0x06009491 RID: 38033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SimulationLineTrace_Internal(IntPtr @this, int pointerID, IntPtr UIItem, in FVector2D ClickPivot);

		// Token: 0x06009492 RID: 38034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsUseMouse_Internal(IntPtr @this, bool value);

		// Token: 0x06009493 RID: 38035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsForceChange_Internal(IntPtr @this, bool value);

		// Token: 0x06009494 RID: 38036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetNowIsTriggerPressed_Internal(IntPtr @this, int pointerID);

		// Token: 0x06009495 RID: 38037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputTrigger_Internal(IntPtr @this, bool inTriggerPress, EMouseButtonType inMouseButtonType);

		// Token: 0x06009496 RID: 38038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputScroll_Internal(IntPtr @this, in float inAxisValue);

		// Token: 0x06009497 RID: 38039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputOverrideMousePosition_Internal(IntPtr @this, in FVector2D inMousePosition);

		// Token: 0x06009498 RID: 38040 RVA: 0x000E0097 File Offset: 0x000DE297
		static ULGUI_StandaloneInputModule()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_StandaloneInputModule");
		}

		// Token: 0x06009499 RID: 38041 RVA: 0x000E00A5 File Offset: 0x000DE2A5
		protected ULGUI_StandaloneInputModule(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040040A3 RID: 16547
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_StandaloneInputModule";

		// Token: 0x040040A4 RID: 16548
		private static IntPtr _ClassPtr;

		// Token: 0x040040A5 RID: 16549
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040040A6 RID: 16550
		internal static int __PropertyOffset_bOverrideMousePosition;
	}
}
