using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B8 RID: 952
	public sealed class FEffectAudioControllerAddPlayEffectAudioPriorityRetVal : FScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06005D72 RID: 23922 RVA: 0x00083E73 File Offset: 0x00082073
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.StaticFunctionPtr();
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x00083E7F File Offset: 0x0008207F
		private static IntPtr StaticFunctionPtr()
		{
			if (FEffectAudioControllerAddPlayEffectAudioPriorityRetVal._FunctionPtr == IntPtr.Zero)
			{
				FEffectAudioControllerAddPlayEffectAudioPriorityRetVal._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGameplay.EffectAudioControllerAddPlayEffectAudioPriorityRetVal__DelegateSignature");
			}
			return FEffectAudioControllerAddPlayEffectAudioPriorityRetVal._FunctionPtr;
		}

		// Token: 0x06005D74 RID: 23924 RVA: 0x00083EA2 File Offset: 0x000820A2
		public FEffectAudioControllerAddPlayEffectAudioPriorityRetVal()
		{
		}

		// Token: 0x06005D75 RID: 23925 RVA: 0x00083EAA File Offset: 0x000820AA
		[NullableContext(2)]
		public FEffectAudioControllerAddPlayEffectAudioPriorityRetVal(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D76 RID: 23926 RVA: 0x00083EB4 File Offset: 0x000820B4
		public FEffectAudioControllerAddPlayEffectAudioPriorityRetVal(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D77 RID: 23927 RVA: 0x00083EBF File Offset: 0x000820BF
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Bind((Callback as Func<UEffectModelAudio, AActor, int, int, int>) ?? ((Func<UEffectModelAudio, AActor, int, int, int>)Delegate.CreateDelegate(typeof(Func<UEffectModelAudio, AActor, int, int, int>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06005D78 RID: 23928 RVA: 0x00083EF1 File Offset: 0x000820F1
		public void Bind([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Func<UEffectModelAudio, AActor, int, int, int> Callback)
		{
			if (FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.OnScriptCallback));
				}
				FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Bind(Callback, FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.RegisterId);
		}

		// Token: 0x06005D79 RID: 23929 RVA: 0x00083F2C File Offset: 0x0008212C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe int Execute(UEffectModelAudio EffectModel, AActor EffectActor, int EffectType, int Priority)
		{
			FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams* ptr = stackalloc FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams[(UIntPtr)47] + 15L / (long)sizeof(FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->EffectModel = ((EffectModel != null) ? EffectModel.NativePtr : IntPtr.Zero);
			ptr->EffectActor = ((EffectActor != null) ? EffectActor.NativePtr : IntPtr.Zero);
			ptr->EffectType = EffectType;
			ptr->Priority = Priority;
			base.ExecuteInternal((void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005D7A RID: 23930 RVA: 0x00083FA4 File Offset: 0x000821A4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Func<UEffectModelAudio, AActor, int, int, int> func = target as Func<UEffectModelAudio, AActor, int, int, int>;
			if (func == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UEffectModelAudio orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UEffectModelAudio>(((FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams*)__Parameters)->EffectModel);
			AActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams*)__Parameters)->EffectActor);
			int _Result = func(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, ((FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams*)__Parameters)->EffectType, ((FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams*)__Parameters)->Priority);
			((FEffectAudioControllerAddPlayEffectAudioPriorityRetVal.__FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams*)__Parameters)->__Result = _Result;
		}

		// Token: 0x040026F4 RID: 9972
		internal static IntPtr _FunctionPtr;

		// Token: 0x040026F5 RID: 9973
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.EffectAudioControllerAddPlayEffectAudioPriorityRetVal__DelegateSignature";

		// Token: 0x040026F6 RID: 9974
		private static int RegisterId;

		// Token: 0x02000ABA RID: 2746
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		private ref struct __FEffectAudioControllerAddPlayEffectAudioPriorityRetVal_DelegateParams
		{
			// Token: 0x04005B21 RID: 23329
			[FieldOffset(0)]
			public IntPtr EffectModel;

			// Token: 0x04005B22 RID: 23330
			[FieldOffset(8)]
			public IntPtr EffectActor;

			// Token: 0x04005B23 RID: 23331
			[FieldOffset(16)]
			public int EffectType;

			// Token: 0x04005B24 RID: 23332
			[FieldOffset(20)]
			public int Priority;

			// Token: 0x04005B25 RID: 23333
			[FieldOffset(24)]
			public int __Result;
		}

		// Token: 0x02000ABB RID: 2747
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005B26 RID: 23334
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
