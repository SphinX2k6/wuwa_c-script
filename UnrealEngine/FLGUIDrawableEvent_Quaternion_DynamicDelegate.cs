using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002059 RID: 8281
	public sealed class FLGUIDrawableEvent_Quaternion_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F457 RID: 128087 RVA: 0x002E6F6B File Offset: 0x002E516B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Quaternion_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F458 RID: 128088 RVA: 0x002E6F77 File Offset: 0x002E5177
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Quaternion_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Quaternion_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Quaternion_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Quaternion_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F459 RID: 128089 RVA: 0x002E6F9A File Offset: 0x002E519A
		public FLGUIDrawableEvent_Quaternion_DynamicDelegate()
		{
		}

		// Token: 0x0601F45A RID: 128090 RVA: 0x002E6FA2 File Offset: 0x002E51A2
		[NullableContext(2)]
		public FLGUIDrawableEvent_Quaternion_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F45B RID: 128091 RVA: 0x002E6FAC File Offset: 0x002E51AC
		public FLGUIDrawableEvent_Quaternion_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F45C RID: 128092 RVA: 0x002E6FB7 File Offset: 0x002E51B7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FQuat>) ?? ((Action<FQuat>)Delegate.CreateDelegate(typeof(Action<FQuat>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F45D RID: 128093 RVA: 0x002E6FE9 File Offset: 0x002E51E9
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FQuat> Callback)
		{
			if (FLGUIDrawableEvent_Quaternion_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Quaternion_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Quaternion_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Quaternion_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Quaternion_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Quaternion_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F45E RID: 128094 RVA: 0x002E7024 File Offset: 0x002E5224
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FQuat value)
		{
			FLGUIDrawableEvent_Quaternion_DynamicDelegate.__FLGUIDrawableEvent_Quaternion_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Quaternion_DynamicDelegate.__FLGUIDrawableEvent_Quaternion_DynamicDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIDrawableEvent_Quaternion_DynamicDelegate.__FLGUIDrawableEvent_Quaternion_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Quaternion_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F45F RID: 128095 RVA: 0x002E7064 File Offset: 0x002E5264
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FQuat> action = target as Action<FQuat>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Quaternion_DynamicDelegate.__FLGUIDrawableEvent_Quaternion_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04010EA4 RID: 69284
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010EA5 RID: 69285
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Quaternion_DynamicDelegate__DelegateSignature";

		// Token: 0x04010EA6 RID: 69286
		private static int RegisterId;

		// Token: 0x0200345E RID: 13406
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIDrawableEvent_Quaternion_DynamicDelegate_DelegateParams
		{
			// Token: 0x04017441 RID: 95297
			[FieldOffset(0)]
			public FQuat value;
		}

		// Token: 0x0200345F RID: 13407
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017442 RID: 95298
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
