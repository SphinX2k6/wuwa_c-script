using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001897 RID: 6295
	public sealed class FEffectAudioControllerOnStopEffectAudio : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060172D9 RID: 94937 RVA: 0x0021CD17 File Offset: 0x0021AF17
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectAudioControllerOnStopEffectAudio.StaticFunctionPtr();
		}

		// Token: 0x060172DA RID: 94938 RVA: 0x0021CD23 File Offset: 0x0021AF23
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectAudioControllerOnStopEffectAudio._FunctionPtr == IntPtr.Zero)
			{
				FEffectAudioControllerOnStopEffectAudio._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectAudioControllerOnStopEffectAudio__DelegateSignature");
			}
			return FEffectAudioControllerOnStopEffectAudio._FunctionPtr;
		}

		// Token: 0x060172DB RID: 94939 RVA: 0x0021CD46 File Offset: 0x0021AF46
		public FEffectAudioControllerOnStopEffectAudio()
		{
		}

		// Token: 0x060172DC RID: 94940 RVA: 0x0021CD4E File Offset: 0x0021AF4E
		[NullableContext(2)]
		public FEffectAudioControllerOnStopEffectAudio(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060172DD RID: 94941 RVA: 0x0021CD58 File Offset: 0x0021AF58
		public FEffectAudioControllerOnStopEffectAudio(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060172DE RID: 94942 RVA: 0x0021CD63 File Offset: 0x0021AF63
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Action<int, string>) ?? ((Action<int, string>)Delegate.CreateDelegate(typeof(Action<int, string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060172DF RID: 94943 RVA: 0x0021CD95 File Offset: 0x0021AF95
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060172E0 RID: 94944 RVA: 0x0021CDD0 File Offset: 0x0021AFD0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Execute(int Uid, string Context)
		{
			FEffectAudioControllerOnStopEffectAudio.__FEffectAudioControllerOnStopEffectAudio_DelegateParams* ptr = stackalloc FEffectAudioControllerOnStopEffectAudio.__FEffectAudioControllerOnStopEffectAudio_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FEffectAudioControllerOnStopEffectAudio.__FEffectAudioControllerOnStopEffectAudio_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectAudioControllerOnStopEffectAudio.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Uid = Uid;
			FString.CopyFrom((void*)(&ptr->Context), Context);
			base.ExecuteInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FEffectAudioControllerOnStopEffectAudio._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060172E1 RID: 94945 RVA: 0x0021CE2C File Offset: 0x0021B02C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400C92B RID: 51499
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400C92C RID: 51500
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectAudioControllerOnStopEffectAudio__DelegateSignature";

		// Token: 0x0400C92D RID: 51501
		private static int RegisterId;

		// Token: 0x02002F9B RID: 12187
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __FEffectAudioControllerOnStopEffectAudio_DelegateParams
		{
			// Token: 0x04016B6F RID: 93039
			[FieldOffset(0)]
			public int Uid;

			// Token: 0x04016B70 RID: 93040
			[FieldOffset(8)]
			public FString Context;
		}

		// Token: 0x02002F9C RID: 12188
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016B71 RID: 93041
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
