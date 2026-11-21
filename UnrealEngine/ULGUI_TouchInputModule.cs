using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006CE RID: 1742
	[UnrealObjectPath("/Script/LGUI.LGUI_TouchInputModule")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class ULGUI_TouchInputModule : ULGUI_PointerInputModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600949A RID: 38042 RVA: 0x000E00AE File Offset: 0x000DE2AE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_TouchInputModule._ClassPtr;
		}

		// Token: 0x0600949B RID: 38043 RVA: 0x000E00BC File Offset: 0x000DE2BC
		public ULGUI_TouchInputModule() : this(BuiltinUtils.AllocNativeUObject(ULGUI_TouchInputModule.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600949C RID: 38044 RVA: 0x000E00E4 File Offset: 0x000DE2E4
		[NullableContext(1)]
		public ULGUI_TouchInputModule(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUI_TouchInputModule.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600949D RID: 38045 RVA: 0x000E0117 File Offset: 0x000DE317
		public void RefreshProcessInput()
		{
			ULGUI_TouchInputModule.__RefreshProcessInput_Internal(base.NativePtr);
		}

		// Token: 0x0600949E RID: 38046 RVA: 0x000E0124 File Offset: 0x000DE324
		public void InputTouchTrigger(bool inTouchPress, int inTouchID, in FVector inTouchPointPosition)
		{
			ULGUI_TouchInputModule.__InputTouchTrigger_Internal(base.NativePtr, inTouchPress, inTouchID, inTouchPointPosition);
		}

		// Token: 0x0600949F RID: 38047 RVA: 0x000E0134 File Offset: 0x000DE334
		public void InputTouchMoved(int inTouchID, in FVector inTouchPointPosition)
		{
			ULGUI_TouchInputModule.__InputTouchMoved_Internal(base.NativePtr, inTouchID, inTouchPointPosition);
		}

		// Token: 0x060094A0 RID: 38048 RVA: 0x000E0144 File Offset: 0x000DE344
		public unsafe void InputScroll(in float inAxisValue)
		{
			fixed (float* ptr = &inAxisValue)
			{
				void* ptr2 = (void*)ptr;
				ULGUI_TouchInputModule.__InputScroll_Internal(base.NativePtr, inAxisValue);
			}
		}

		// Token: 0x060094A1 RID: 38049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshProcessInput_Internal(IntPtr @this);

		// Token: 0x060094A2 RID: 38050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputTouchTrigger_Internal(IntPtr @this, bool inTouchPress, int inTouchID, in FVector inTouchPointPosition);

		// Token: 0x060094A3 RID: 38051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputTouchMoved_Internal(IntPtr @this, int inTouchID, in FVector inTouchPointPosition);

		// Token: 0x060094A4 RID: 38052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputScroll_Internal(IntPtr @this, in float inAxisValue);

		// Token: 0x060094A5 RID: 38053 RVA: 0x000E0165 File Offset: 0x000DE365
		static ULGUI_TouchInputModule()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_TouchInputModule");
		}

		// Token: 0x060094A6 RID: 38054 RVA: 0x000E0173 File Offset: 0x000DE373
		protected ULGUI_TouchInputModule(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040040A7 RID: 16551
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_TouchInputModule";

		// Token: 0x040040A8 RID: 16552
		private static IntPtr _ClassPtr;

		// Token: 0x040040A9 RID: 16553
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
