using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002072 RID: 8306
	public sealed class FLGUIExtendToggleAudioDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601F571 RID: 128369 RVA: 0x002E8A4C File Offset: 0x002E6C4C
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIExtendToggleAudioDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601F572 RID: 128370 RVA: 0x002E8A58 File Offset: 0x002E6C58
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIExtendToggleAudioDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIExtendToggleAudioDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIExtendToggleAudioDelegate__DelegateSignature");
			}
			return FLGUIExtendToggleAudioDelegate._FunctionPtr;
		}

		// Token: 0x0601F573 RID: 128371 RVA: 0x002E8A7B File Offset: 0x002E6C7B
		public FLGUIExtendToggleAudioDelegate()
		{
		}

		// Token: 0x0601F574 RID: 128372 RVA: 0x002E8A83 File Offset: 0x002E6C83
		[NullableContext(2)]
		public FLGUIExtendToggleAudioDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F575 RID: 128373 RVA: 0x002E8A8D File Offset: 0x002E6C8D
		public FLGUIExtendToggleAudioDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F576 RID: 128374 RVA: 0x002E8A98 File Offset: 0x002E6C98
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0601F577 RID: 128375 RVA: 0x002E8ACA File Offset: 0x002E6CCA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Bind(Action<string> Callback)
		{
			if (FLGUIExtendToggleAudioDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FLGUIExtendToggleAudioDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FLGUIExtendToggleAudioDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FLGUIExtendToggleAudioDelegate.OnScriptCallback));
				}
				FLGUIExtendToggleAudioDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FLGUIExtendToggleAudioDelegate.RegisterId);
		}

		// Token: 0x0601F578 RID: 128376 RVA: 0x002E8B04 File Offset: 0x002E6D04
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(string eventName)
		{
			FLGUIExtendToggleAudioDelegate.__FLGUIExtendToggleAudioDelegate_DelegateParams* ptr = stackalloc FLGUIExtendToggleAudioDelegate.__FLGUIExtendToggleAudioDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIExtendToggleAudioDelegate.__FLGUIExtendToggleAudioDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIExtendToggleAudioDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->eventName), eventName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLGUIExtendToggleAudioDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601F579 RID: 128377 RVA: 0x002E8B58 File Offset: 0x002E6D58
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
			string obj = FString.ToString((void*)(&((FLGUIExtendToggleAudioDelegate.__FLGUIExtendToggleAudioDelegate_DelegateParams*)__Parameters)->eventName));
			action(obj);
		}

		// Token: 0x04010EFC RID: 69372
		internal static IntPtr _FunctionPtr;

		// Token: 0x04010EFD RID: 69373
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIExtendToggleAudioDelegate__DelegateSignature";

		// Token: 0x04010EFE RID: 69374
		private static int RegisterId;

		// Token: 0x02003474 RID: 13428
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FLGUIExtendToggleAudioDelegate_DelegateParams
		{
			// Token: 0x0401745C RID: 95324
			[FieldOffset(0)]
			public FString eventName;
		}

		// Token: 0x02003475 RID: 13429
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401745D RID: 95325
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
