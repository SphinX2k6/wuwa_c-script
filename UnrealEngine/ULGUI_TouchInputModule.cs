using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020E8 RID: 8424
	[UnrealObjectPath("/Script/LGUI.LGUI_TouchInputModule")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class ULGUI_TouchInputModule : ULGUI_PointerInputModule, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FBA0 RID: 129952 RVA: 0x002F2BAE File Offset: 0x002F0DAE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUI_TouchInputModule._ClassPtr;
		}

		// Token: 0x0601FBA1 RID: 129953 RVA: 0x002F2BBC File Offset: 0x002F0DBC
		public ULGUI_TouchInputModule() : this(BuiltinUtils.AllocNativeUObject(ULGUI_TouchInputModule.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FBA2 RID: 129954 RVA: 0x002F2BE4 File Offset: 0x002F0DE4
		[NullableContext(1)]
		public ULGUI_TouchInputModule(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUI_TouchInputModule.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601FBA3 RID: 129955 RVA: 0x002F2C17 File Offset: 0x002F0E17
		public void RefreshProcessInput()
		{
			ULGUI_TouchInputModule.__RefreshProcessInput_Internal(base.NativePtr);
		}

		// Token: 0x0601FBA4 RID: 129956 RVA: 0x002F2C24 File Offset: 0x002F0E24
		public void InputTouchTrigger(bool inTouchPress, int inTouchID, in FVector inTouchPointPosition)
		{
			ULGUI_TouchInputModule.__InputTouchTrigger_Internal(base.NativePtr, inTouchPress, inTouchID, inTouchPointPosition);
		}

		// Token: 0x0601FBA5 RID: 129957 RVA: 0x002F2C34 File Offset: 0x002F0E34
		public void InputTouchMoved(int inTouchID, in FVector inTouchPointPosition)
		{
			ULGUI_TouchInputModule.__InputTouchMoved_Internal(base.NativePtr, inTouchID, inTouchPointPosition);
		}

		// Token: 0x0601FBA6 RID: 129958 RVA: 0x002F2C44 File Offset: 0x002F0E44
		public unsafe void InputScroll(in float inAxisValue)
		{
			fixed (float* ptr = &inAxisValue)
			{
				void* ptr2 = (void*)ptr;
				ULGUI_TouchInputModule.__InputScroll_Internal(base.NativePtr, inAxisValue);
			}
		}

		// Token: 0x0601FBA7 RID: 129959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshProcessInput_Internal(IntPtr @this);

		// Token: 0x0601FBA8 RID: 129960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputTouchTrigger_Internal(IntPtr @this, bool inTouchPress, int inTouchID, in FVector inTouchPointPosition);

		// Token: 0x0601FBA9 RID: 129961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputTouchMoved_Internal(IntPtr @this, int inTouchID, in FVector inTouchPointPosition);

		// Token: 0x0601FBAA RID: 129962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InputScroll_Internal(IntPtr @this, in float inAxisValue);

		// Token: 0x0601FBAB RID: 129963 RVA: 0x002F2C65 File Offset: 0x002F0E65
		static ULGUI_TouchInputModule()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUI_TouchInputModule");
		}

		// Token: 0x0601FBAC RID: 129964 RVA: 0x002F2C73 File Offset: 0x002F0E73
		protected ULGUI_TouchInputModule(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040111AE RID: 70062
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUI_TouchInputModule";

		// Token: 0x040111AF RID: 70063
		private static IntPtr _ClassPtr;

		// Token: 0x040111B0 RID: 70064
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
