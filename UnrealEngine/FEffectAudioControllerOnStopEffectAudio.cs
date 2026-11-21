using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003BA RID: 954
	public sealed class FEffectAudioControllerOnStopEffectAudio : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D84 RID: 23940 RVA: 0x000841B3 File Offset: 0x000823B3
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectAudioControllerOnStopEffectAudio.StaticFunctionPtr();
		}

		// Token: 0x06005D85 RID: 23941 RVA: 0x000841BF File Offset: 0x000823BF
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectAudioControllerOnStopEffectAudio._FunctionPtr == IntPtr.Zero)
			{
				FEffectAudioControllerOnStopEffectAudio._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectAudioControllerOnStopEffectAudio__DelegateSignature");
			}
			return FEffectAudioControllerOnStopEffectAudio._FunctionPtr;
		}

		// Token: 0x06005D86 RID: 23942 RVA: 0x000841E2 File Offset: 0x000823E2
		public FEffectAudioControllerOnStopEffectAudio()
		{
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x000841EA File Offset: 0x000823EA
		[NullableContext(2)]
		public FEffectAudioControllerOnStopEffectAudio(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D88 RID: 23944 RVA: 0x000841F4 File Offset: 0x000823F4
		public FEffectAudioControllerOnStopEffectAudio(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x000841FF File Offset: 0x000823FF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, string>) ?? ((Action<int, string>)Delegate.CreateDelegate(typeof(Action<int, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x00084231 File Offset: 0x00082431
		[NullableContext(1)]
		public void Bind(Action<int, string> Callback)
		{
			if (FEffectAudioControllerOnStopEffectAudio.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectAudioControllerOnStopEffectAudio.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectAudioControllerOnStopEffectAudio.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectAudioControllerOnStopEffectAudio.OnScriptCallback));
				}
				FEffectAudioControllerOnStopEffectAudio.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectAudioControllerOnStopEffectAudio.RegisterId);
		}

		// Token: 0x06005D8B RID: 23947 RVA: 0x0008426C File Offset: 0x0008246C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe void Execute(int Uid, string Context)
		{
			FEffectAudioControllerOnStopEffectAudio.__FEffectAudioControllerOnStopEffectAudio_DelegateParams* ptr = stackalloc FEffectAudioControllerOnStopEffectAudio.__FEffectAudioControllerOnStopEffectAudio_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FEffectAudioControllerOnStopEffectAudio.__FEffectAudioControllerOnStopEffectAudio_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectAudioControllerOnStopEffectAudio.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Uid = Uid;
			FString.CopyFrom((void*)(&ptr->Context), Context);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FEffectAudioControllerOnStopEffectAudio._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06005D8C RID: 23948 RVA: 0x000842C8 File Offset: 0x000824C8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<int, string> action = target as Action<int, string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string arg = FString.ToString((void*)(&((FEffectAudioControllerOnStopEffectAudio.__FEffectAudioControllerOnStopEffectAudio_DelegateParams*)__Parameters)->Context));
			action(((FEffectAudioControllerOnStopEffectAudio.__FEffectAudioControllerOnStopEffectAudio_DelegateParams*)__Parameters)->Uid, arg);
		}

		// Token: 0x040026FA RID: 9978
		internal static IntPtr _FunctionPtr;

		// Token: 0x040026FB RID: 9979
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectAudioControllerOnStopEffectAudio__DelegateSignature";

		// Token: 0x040026FC RID: 9980
		private static int RegisterId;

		// Token: 0x02000ABE RID: 2750
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FEffectAudioControllerOnStopEffectAudio_DelegateParams
		{
			// Token: 0x04005B2C RID: 23340
			[FieldOffset(0)]
			public int Uid;

			// Token: 0x04005B2D RID: 23341
			[FieldOffset(8)]
			public FString Context;
		}

		// Token: 0x02000ABF RID: 2751
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B2E RID: 23342
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
