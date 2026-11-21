using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B9 RID: 953
	public sealed class FEffectAudioControllerAddPlayEffectAudioRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D7B RID: 23931 RVA: 0x00084019 File Offset: 0x00082219
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectAudioControllerAddPlayEffectAudioRetVal.StaticFunctionPtr();
		}

		// Token: 0x06005D7C RID: 23932 RVA: 0x00084025 File Offset: 0x00082225
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectAudioControllerAddPlayEffectAudioRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectAudioControllerAddPlayEffectAudioRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectAudioControllerAddPlayEffectAudioRetVal__DelegateSignature");
			}
			return FEffectAudioControllerAddPlayEffectAudioRetVal._FunctionPtr;
		}

		// Token: 0x06005D7D RID: 23933 RVA: 0x00084048 File Offset: 0x00082248
		public FEffectAudioControllerAddPlayEffectAudioRetVal()
		{
		}

		// Token: 0x06005D7E RID: 23934 RVA: 0x00084050 File Offset: 0x00082250
		[NullableContext(2)]
		public FEffectAudioControllerAddPlayEffectAudioRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D7F RID: 23935 RVA: 0x0008405A File Offset: 0x0008225A
		public FEffectAudioControllerAddPlayEffectAudioRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D80 RID: 23936 RVA: 0x00084065 File Offset: 0x00082265
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<UEffectModelAudio, AActor, int, int>) ?? ((Func<UEffectModelAudio, AActor, int, int>)Delegate.CreateDelegate(typeof(Func<UEffectModelAudio, AActor, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D81 RID: 23937 RVA: 0x00084097 File Offset: 0x00082297
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<UEffectModelAudio, AActor, int, int> Callback)
		{
			if (FEffectAudioControllerAddPlayEffectAudioRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectAudioControllerAddPlayEffectAudioRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectAudioControllerAddPlayEffectAudioRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectAudioControllerAddPlayEffectAudioRetVal.OnScriptCallback));
				}
				FEffectAudioControllerAddPlayEffectAudioRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectAudioControllerAddPlayEffectAudioRetVal.RegisterId);
		}

		// Token: 0x06005D82 RID: 23938 RVA: 0x000840D4 File Offset: 0x000822D4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe int Execute(UEffectModelAudio EffectModel, AActor EffectActor, int EffectType)
		{
			FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams* ptr = stackalloc FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams[(UIntPtr)39] + 15L / (long)sizeof(FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectAudioControllerAddPlayEffectAudioRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EffectModel = ((EffectModel != null) ? EffectModel.NativePtr : IntPtr.Zero);
			ptr->EffectActor = ((EffectActor != null) ? EffectActor.NativePtr : IntPtr.Zero);
			ptr->EffectType = EffectType;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005D83 RID: 23939 RVA: 0x00084144 File Offset: 0x00082344
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<UEffectModelAudio, AActor, int, int> func = target as Func<UEffectModelAudio, AActor, int, int>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UEffectModelAudio orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UEffectModelAudio>(((FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams*)__Parameters)->EffectModel);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams*)__Parameters)->EffectActor);
			int _Result = func(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, ((FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams*)__Parameters)->EffectType);
			((FEffectAudioControllerAddPlayEffectAudioRetVal.__FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x040026F7 RID: 9975
		internal static IntPtr _FunctionPtr;

		// Token: 0x040026F8 RID: 9976
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectAudioControllerAddPlayEffectAudioRetVal__DelegateSignature";

		// Token: 0x040026F9 RID: 9977
		private static int RegisterId;

		// Token: 0x02000ABC RID: 2748
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		private ref struct __FEffectAudioControllerAddPlayEffectAudioRetVal_DelegateParams
		{
			// Token: 0x04005B27 RID: 23335
			[FieldOffset(0)]
			public IntPtr EffectModel;

			// Token: 0x04005B28 RID: 23336
			[FieldOffset(8)]
			public IntPtr EffectActor;

			// Token: 0x04005B29 RID: 23337
			[FieldOffset(16)]
			public int EffectType;

			// Token: 0x04005B2A RID: 23338
			[FieldOffset(20)]
			public int __Result;
		}

		// Token: 0x02000ABD RID: 2749
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B2B RID: 23339
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
