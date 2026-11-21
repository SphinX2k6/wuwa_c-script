using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000D9 RID: 217
	public sealed class FOnSetCurrentAudioCultureCallback : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06000F60 RID: 3936 RVA: 0x00017C67 File Offset: 0x00015E67
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSetCurrentAudioCultureCallback.StaticFunctionPtr();
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00017C73 File Offset: 0x00015E73
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSetCurrentAudioCultureCallback._FunctionPtr == IntPtr.Zero)
			{
				FOnSetCurrentAudioCultureCallback._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnSetCurrentAudioCultureCallback__DelegateSignature");
			}
			return FOnSetCurrentAudioCultureCallback._FunctionPtr;
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00017C96 File Offset: 0x00015E96
		public FOnSetCurrentAudioCultureCallback()
		{
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00017C9E File Offset: 0x00015E9E
		[NullableContext(2)]
		public FOnSetCurrentAudioCultureCallback(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00017CA8 File Offset: 0x00015EA8
		public FOnSetCurrentAudioCultureCallback(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00017CB3 File Offset: 0x00015EB3
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00017CE5 File Offset: 0x00015EE5
		[NullableContext(1)]
		public void Bind(Action<bool> Callback)
		{
			if (FOnSetCurrentAudioCultureCallback.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSetCurrentAudioCultureCallback.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSetCurrentAudioCultureCallback.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSetCurrentAudioCultureCallback.OnScriptCallback));
				}
				FOnSetCurrentAudioCultureCallback.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FOnSetCurrentAudioCultureCallback.RegisterId);
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00017D20 File Offset: 0x00015F20
		[SkipLocalsInit]
		public unsafe void Execute(bool Succeeded)
		{
			FOnSetCurrentAudioCultureCallback.__FOnSetCurrentAudioCultureCallback_DelegateParams* ptr = stackalloc FOnSetCurrentAudioCultureCallback.__FOnSetCurrentAudioCultureCallback_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnSetCurrentAudioCultureCallback.__FOnSetCurrentAudioCultureCallback_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSetCurrentAudioCultureCallback.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Succeeded = Succeeded;
			base.ExecuteInternal((void*)ptr);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00017D60 File Offset: 0x00015F60
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnSetCurrentAudioCultureCallback.__FOnSetCurrentAudioCultureCallback_DelegateParams*)__Parameters)->Succeeded);
		}

		// Token: 0x0400036A RID: 874
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400036B RID: 875
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnSetCurrentAudioCultureCallback__DelegateSignature";

		// Token: 0x0400036C RID: 876
		private static int RegisterId;

		// Token: 0x02000907 RID: 2311
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnSetCurrentAudioCultureCallback_DelegateParams
		{
			// Token: 0x040057E1 RID: 22497
			[FieldOffset(0)]
			public bool Succeeded;
		}

		// Token: 0x02000908 RID: 2312
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040057E2 RID: 22498
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
