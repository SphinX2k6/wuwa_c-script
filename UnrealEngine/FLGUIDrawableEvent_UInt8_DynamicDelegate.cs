using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002062 RID: 8290
	public sealed class FLGUIDrawableEvent_UInt8_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F4A2 RID: 128162 RVA: 0x002E7612 File Offset: 0x002E5812
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_UInt8_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F4A3 RID: 128163 RVA: 0x002E761E File Offset: 0x002E581E
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_UInt8_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_UInt8_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_UInt8_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_UInt8_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F4A4 RID: 128164 RVA: 0x002E7641 File Offset: 0x002E5841
		public FLGUIDrawableEvent_UInt8_DynamicDelegate()
		{
		}

		// Token: 0x0601F4A5 RID: 128165 RVA: 0x002E7649 File Offset: 0x002E5849
		[NullableContext(2)]
		public FLGUIDrawableEvent_UInt8_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F4A6 RID: 128166 RVA: 0x002E7653 File Offset: 0x002E5853
		public FLGUIDrawableEvent_UInt8_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F4A7 RID: 128167 RVA: 0x002E765E File Offset: 0x002E585E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<byte>) ?? ((Action<byte>)Delegate.CreateDelegate(typeof(Action<byte>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F4A8 RID: 128168 RVA: 0x002E7690 File Offset: 0x002E5890
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<byte> Callback)
		{
			if (FLGUIDrawableEvent_UInt8_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_UInt8_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_UInt8_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_UInt8_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_UInt8_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_UInt8_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F4A9 RID: 128169 RVA: 0x002E76CC File Offset: 0x002E58CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(byte value)
		{
			FLGUIDrawableEvent_UInt8_DynamicDelegate.__FLGUIDrawableEvent_UInt8_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_UInt8_DynamicDelegate.__FLGUIDrawableEvent_UInt8_DynamicDelegate_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FLGUIDrawableEvent_UInt8_DynamicDelegate.__FLGUIDrawableEvent_UInt8_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_UInt8_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F4AA RID: 128170 RVA: 0x002E770C File Offset: 0x002E590C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<byte> action = target as Action<byte>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_UInt8_DynamicDelegate.__FLGUIDrawableEvent_UInt8_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04010EB9 RID: 69305
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010EBA RID: 69306
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_UInt8_DynamicDelegate__DelegateSignature";

		// Token: 0x04010EBB RID: 69307
		private static int RegisterId;

		// Token: 0x02003464 RID: 13412
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FLGUIDrawableEvent_UInt8_DynamicDelegate_DelegateParams
		{
			// Token: 0x04017447 RID: 95303
			[FieldOffset(0)]
			public byte value;
		}

		// Token: 0x02003465 RID: 13413
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017448 RID: 95304
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
