using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020E7 RID: 8423
	[UnrealObjectPath("/Script/LGUI.LGUI_StandaloneInputModule")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class ULGUI_StandaloneInputModule : ULGUI_PointerInputModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB87 RID: 129927 RVA: 0x002F29C7 File Offset: 0x002F0BC7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_StandaloneInputModule._ClassPtr;
		}

		// Token: 0x0601FB88 RID: 129928 RVA: 0x002F29D4 File Offset: 0x002F0BD4
		public ULGUI_StandaloneInputModule() : this(BuiltinUtils.AllocNativeUObject(ULGUI_StandaloneInputModule.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB89 RID: 129929 RVA: 0x002F29FC File Offset: 0x002F0BFC
		[NullableContext(1)]
		public ULGUI_StandaloneInputModule(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUI_StandaloneInputModule.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007CEE RID: 31982
		// (get) Token: 0x0601FB8A RID: 129930 RVA: 0x002F2A2F File Offset: 0x002F0C2F
		// (set) Token: 0x0601FB8B RID: 129931 RVA: 0x002F2A3F File Offset: 0x002F0C3F
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

		// Token: 0x0601FB8C RID: 129932 RVA: 0x002F2A50 File Offset: 0x002F0C50
		public void SimulationPointerTrigger(int pointerID, bool IsPressed)
		{
			ULGUI_StandaloneInputModule.__SimulationPointerTrigger_Internal(base.NativePtr, pointerID, IsPressed);
		}

		// Token: 0x0601FB8D RID: 129933 RVA: 0x002F2A60 File Offset: 0x002F0C60
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

		// Token: 0x0601FB8E RID: 129934 RVA: 0x002F2AC8 File Offset: 0x002F0CC8
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

		// Token: 0x0601FB8F RID: 129935 RVA: 0x002F2B2D File Offset: 0x002F0D2D
		public void SetIsUseMouse(bool value)
		{
			ULGUI_StandaloneInputModule.__SetIsUseMouse_Internal(base.NativePtr, value);
		}

		// Token: 0x0601FB90 RID: 129936 RVA: 0x002F2B3B File Offset: 0x002F0D3B
		public void SetIsForceChange(bool value)
		{
			ULGUI_StandaloneInputModule.__SetIsForceChange_Internal(base.NativePtr, value);
		}

		// Token: 0x0601FB91 RID: 129937 RVA: 0x002F2B49 File Offset: 0x002F0D49
		public void ResetNowIsTriggerPressed(int pointerID)
		{
			ULGUI_StandaloneInputModule.__ResetNowIsTriggerPressed_Internal(base.NativePtr, pointerID);
		}

		// Token: 0x0601FB92 RID: 129938 RVA: 0x002F2B57 File Offset: 0x002F0D57
		public void InputTrigger(bool inTriggerPress, EMouseButtonType inMouseButtonType = EMouseButtonType.Left)
		{
			ULGUI_StandaloneInputModule.__InputTrigger_Internal(base.NativePtr, inTriggerPress, inMouseButtonType);
		}

		// Token: 0x0601FB93 RID: 129939 RVA: 0x002F2B68 File Offset: 0x002F0D68
		public unsafe void InputScroll(in float inAxisValue)
		{
			fixed (float* ptr = &inAxisValue)
			{
				void* ptr2 = (void*)ptr;
				ULGUI_StandaloneInputModule.__InputScroll_Internal(base.NativePtr, inAxisValue);
			}
		}

		// Token: 0x0601FB94 RID: 129940 RVA: 0x002F2B89 File Offset: 0x002F0D89
		public void InputOverrideMousePosition(in FVector2D inMousePosition)
		{
			ULGUI_StandaloneInputModule.__InputOverrideMousePosition_Internal(base.NativePtr, inMousePosition);
		}

		// Token: 0x0601FB95 RID: 129941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SimulationPointerTrigger_Internal(IntPtr @this, int pointerID, bool IsPressed);

		// Token: 0x0601FB96 RID: 129942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SimulationPointerDownUp_Internal(IntPtr @this, int pointerID, IntPtr UIItem, bool IsPressed, in FVector2D ClickPivot);

		// Token: 0x0601FB97 RID: 129943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SimulationLineTrace_Internal(IntPtr @this, int pointerID, IntPtr UIItem, in FVector2D ClickPivot);

		// Token: 0x0601FB98 RID: 129944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsUseMouse_Internal(IntPtr @this, bool value);

		// Token: 0x0601FB99 RID: 129945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsForceChange_Internal(IntPtr @this, bool value);

		// Token: 0x0601FB9A RID: 129946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetNowIsTriggerPressed_Internal(IntPtr @this, int pointerID);

		// Token: 0x0601FB9B RID: 129947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputTrigger_Internal(IntPtr @this, bool inTriggerPress, EMouseButtonType inMouseButtonType);

		// Token: 0x0601FB9C RID: 129948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputScroll_Internal(IntPtr @this, in float inAxisValue);

		// Token: 0x0601FB9D RID: 129949
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputOverrideMousePosition_Internal(IntPtr @this, in FVector2D inMousePosition);

		// Token: 0x0601FB9E RID: 129950 RVA: 0x002F2B97 File Offset: 0x002F0D97
		static ULGUI_StandaloneInputModule()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_StandaloneInputModule");
		}

		// Token: 0x0601FB9F RID: 129951 RVA: 0x002F2BA5 File Offset: 0x002F0DA5
		protected ULGUI_StandaloneInputModule(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040111AA RID: 70058
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_StandaloneInputModule";

		// Token: 0x040111AB RID: 70059
		private static IntPtr _ClassPtr;

		// Token: 0x040111AC RID: 70060
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040111AD RID: 70061
		internal static int __PropertyOffset_bOverrideMousePosition;
	}
}
