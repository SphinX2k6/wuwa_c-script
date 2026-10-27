using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200205B RID: 8283
	public sealed class FLGUIDrawableEvent_Rotator_DynamicDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F468 RID: 128104 RVA: 0x002E7124 File Offset: 0x002E5324
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIDrawableEvent_Rotator_DynamicDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F469 RID: 128105 RVA: 0x002E7130 File Offset: 0x002E5330
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIDrawableEvent_Rotator_DynamicDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIDrawableEvent_Rotator_DynamicDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIDrawableEvent_Rotator_DynamicDelegate__DelegateSignature");
			}
			return FLGUIDrawableEvent_Rotator_DynamicDelegate._FunctionPtr;
		}

		// Token: 0x0601F46A RID: 128106 RVA: 0x002E7153 File Offset: 0x002E5353
		public FLGUIDrawableEvent_Rotator_DynamicDelegate()
		{
		}

		// Token: 0x0601F46B RID: 128107 RVA: 0x002E715B File Offset: 0x002E535B
		[NullableContext(2)]
		public FLGUIDrawableEvent_Rotator_DynamicDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F46C RID: 128108 RVA: 0x002E7165 File Offset: 0x002E5365
		public FLGUIDrawableEvent_Rotator_DynamicDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F46D RID: 128109 RVA: 0x002E7170 File Offset: 0x002E5370
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<FRotator>) ?? ((Action<FRotator>)Delegate.CreateDelegate(typeof(Action<FRotator>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F46E RID: 128110 RVA: 0x002E71A2 File Offset: 0x002E53A2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<FRotator> Callback)
		{
			if (FLGUIDrawableEvent_Rotator_DynamicDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIDrawableEvent_Rotator_DynamicDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIDrawableEvent_Rotator_DynamicDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIDrawableEvent_Rotator_DynamicDelegate.OnScriptCallback));
				}
				FLGUIDrawableEvent_Rotator_DynamicDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIDrawableEvent_Rotator_DynamicDelegate.RegisterId);
		}

		// Token: 0x0601F46F RID: 128111 RVA: 0x002E71DC File Offset: 0x002E53DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(FRotator value)
		{
			FLGUIDrawableEvent_Rotator_DynamicDelegate.__FLGUIDrawableEvent_Rotator_DynamicDelegate_DelegateParams* ptr = stackalloc FLGUIDrawableEvent_Rotator_DynamicDelegate.__FLGUIDrawableEvent_Rotator_DynamicDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FLGUIDrawableEvent_Rotator_DynamicDelegate.__FLGUIDrawableEvent_Rotator_DynamicDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIDrawableEvent_Rotator_DynamicDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->value = value;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x0601F470 RID: 128112 RVA: 0x002E721C File Offset: 0x002E541C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FRotator> action = target as Action<FRotator>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FLGUIDrawableEvent_Rotator_DynamicDelegate.__FLGUIDrawableEvent_Rotator_DynamicDelegate_DelegateParams*)__Parameters)->value);
		}

		// Token: 0x04010EA9 RID: 69289
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010EAA RID: 69290
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIDrawableEvent_Rotator_DynamicDelegate__DelegateSignature";

		// Token: 0x04010EAB RID: 69291
		private static int RegisterId;

		// Token: 0x02003460 RID: 13408
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FLGUIDrawableEvent_Rotator_DynamicDelegate_DelegateParams
		{
			// Token: 0x04017443 RID: 95299
			[FieldOffset(0)]
			public FRotator value;
		}

		// Token: 0x02003461 RID: 13409
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017444 RID: 95300
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
