using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000694 RID: 1684
	public sealed class FLGUIExtendToggleAudioDelegate : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600916E RID: 37230 RVA: 0x000DAB74 File Offset: 0x000D8D74
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FLGUIExtendToggleAudioDelegate.StaticFunctionPtr();
		}

		// Token: 0x0600916F RID: 37231 RVA: 0x000DAB80 File Offset: 0x000D8D80
		private static IntPtr StaticFunctionPtr()
		{
			if (FLGUIExtendToggleAudioDelegate._FunctionPtr == IntPtr.Zero)
			{
				FLGUIExtendToggleAudioDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.LGUIExtendToggleAudioDelegate__DelegateSignature");
			}
			return FLGUIExtendToggleAudioDelegate._FunctionPtr;
		}

		// Token: 0x06009170 RID: 37232 RVA: 0x000DABA3 File Offset: 0x000D8DA3
		public FLGUIExtendToggleAudioDelegate()
		{
		}

		// Token: 0x06009171 RID: 37233 RVA: 0x000DABAB File Offset: 0x000D8DAB
		[NullableContext(2)]
		public FLGUIExtendToggleAudioDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009172 RID: 37234 RVA: 0x000DABB5 File Offset: 0x000D8DB5
		public FLGUIExtendToggleAudioDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009173 RID: 37235 RVA: 0x000DABC0 File Offset: 0x000D8DC0
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009174 RID: 37236 RVA: 0x000DABF2 File Offset: 0x000D8DF2
		[NullableContext(1)]
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

		// Token: 0x06009175 RID: 37237 RVA: 0x000DAC2C File Offset: 0x000D8E2C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(string eventName)
		{
			FLGUIExtendToggleAudioDelegate.__FLGUIExtendToggleAudioDelegate_DelegateParams* ptr = stackalloc FLGUIExtendToggleAudioDelegate.__FLGUIExtendToggleAudioDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FLGUIExtendToggleAudioDelegate.__FLGUIExtendToggleAudioDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FLGUIExtendToggleAudioDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->eventName), eventName);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FLGUIExtendToggleAudioDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06009176 RID: 37238 RVA: 0x000DAC80 File Offset: 0x000D8E80
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x04003F69 RID: 16233
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003F6A RID: 16234
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIExtendToggleAudioDelegate__DelegateSignature";

		// Token: 0x04003F6B RID: 16235
		private static int RegisterId;

		// Token: 0x02000EB7 RID: 3767
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FLGUIExtendToggleAudioDelegate_DelegateParams
		{
			// Token: 0x0400626B RID: 25195
			[FieldOffset(0)]
			public FString eventName;
		}

		// Token: 0x02000EB8 RID: 3768
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400626C RID: 25196
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
