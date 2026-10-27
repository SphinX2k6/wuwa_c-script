using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002029 RID: 8233
	public sealed class FLGUIButtonAudioDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F17D RID: 127357 RVA: 0x002E3315 File Offset: 0x002E1515
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIButtonAudioDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F17E RID: 127358 RVA: 0x002E3321 File Offset: 0x002E1521
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIButtonAudioDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIButtonAudioDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIButtonAudioDelegate__DelegateSignature");
			}
			return FLGUIButtonAudioDelegate._FunctionPtr;
		}

		// Token: 0x0601F17F RID: 127359 RVA: 0x002E3344 File Offset: 0x002E1544
		public FLGUIButtonAudioDelegate()
		{
		}

		// Token: 0x0601F180 RID: 127360 RVA: 0x002E334C File Offset: 0x002E154C
		[NullableContext(2)]
		public FLGUIButtonAudioDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F181 RID: 127361 RVA: 0x002E3356 File Offset: 0x002E1556
		public FLGUIButtonAudioDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F182 RID: 127362 RVA: 0x002E3361 File Offset: 0x002E1561
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F183 RID: 127363 RVA: 0x002E3393 File Offset: 0x002E1593
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string> Callback)
		{
			if (FLGUIButtonAudioDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIButtonAudioDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIButtonAudioDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIButtonAudioDelegate.OnScriptCallback));
				}
				FLGUIButtonAudioDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIButtonAudioDelegate.RegisterId);
		}

		// Token: 0x0601F184 RID: 127364 RVA: 0x002E33D0 File Offset: 0x002E15D0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string eventName)
		{
			FLGUIButtonAudioDelegate.__FLGUIButtonAudioDelegate_DelegateParams* ptr = stackalloc FLGUIButtonAudioDelegate.__FLGUIButtonAudioDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIButtonAudioDelegate.__FLGUIButtonAudioDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIButtonAudioDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->eventName), eventName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLGUIButtonAudioDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F185 RID: 127365 RVA: 0x002E3424 File Offset: 0x002E1624
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FLGUIButtonAudioDelegate.__FLGUIButtonAudioDelegate_DelegateParams*)__Parameters)->eventName));
			action(obj);
		}

		// Token: 0x04010DA8 RID: 69032
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010DA9 RID: 69033
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIButtonAudioDelegate__DelegateSignature";

		// Token: 0x04010DAA RID: 69034
		private static int RegisterId;

		// Token: 0x02003435 RID: 13365
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIButtonAudioDelegate_DelegateParams
		{
			// Token: 0x04017414 RID: 95252
			[FieldOffset(0)]
			public FString eventName;
		}

		// Token: 0x02003436 RID: 13366
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017415 RID: 95253
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
