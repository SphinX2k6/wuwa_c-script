using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000438 RID: 1080
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnRotateSequenceFinishedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060068C5 RID: 26821 RVA: 0x00098E8A File Offset: 0x0009708A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnRotateSequenceFinishedSignature.StaticFunctionPtr();
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x00098E96 File Offset: 0x00097096
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnRotateSequenceFinishedSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnRotateSequenceFinishedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnRotateSequenceFinishedSignature__DelegateSignature");
			}
			return FOnRotateSequenceFinishedSignature._FunctionPtr;
		}

		// Token: 0x060068C7 RID: 26823 RVA: 0x00098EB9 File Offset: 0x000970B9
		public FOnRotateSequenceFinishedSignature()
		{
		}

		// Token: 0x060068C8 RID: 26824 RVA: 0x00098EC1 File Offset: 0x000970C1
		[NullableContext(2)]
		public FOnRotateSequenceFinishedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060068C9 RID: 26825 RVA: 0x00098ECB File Offset: 0x000970CB
		public FOnRotateSequenceFinishedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x00098ED6 File Offset: 0x000970D6
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USceneComponent>) ?? ((Action<USceneComponent>)Delegate.CreateDelegate(typeof(Action<USceneComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060068CB RID: 26827 RVA: 0x00098F08 File Offset: 0x00097108
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USceneComponent> Callback)
		{
			if (FOnRotateSequenceFinishedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnRotateSequenceFinishedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnRotateSequenceFinishedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnRotateSequenceFinishedSignature.OnScriptCallback));
				}
				FOnRotateSequenceFinishedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnRotateSequenceFinishedSignature.RegisterId);
		}

		// Token: 0x060068CC RID: 26828 RVA: 0x00098F42 File Offset: 0x00097142
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USceneComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060068CD RID: 26829 RVA: 0x00098F4C File Offset: 0x0009714C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(USceneComponent AimPivot)
		{
			FOnRotateSequenceFinishedSignature.__FOnRotateSequenceFinishedSignature_DelegateParams* ptr = stackalloc FOnRotateSequenceFinishedSignature.__FOnRotateSequenceFinishedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnRotateSequenceFinishedSignature.__FOnRotateSequenceFinishedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnRotateSequenceFinishedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->AimPivot = ((AimPivot != null) ? AimPivot.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x00098F98 File Offset: 0x00097198
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USceneComponent> action = target as Action<USceneComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USceneComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(((FOnRotateSequenceFinishedSignature.__FOnRotateSequenceFinishedSignature_DelegateParams*)__Parameters)->AimPivot);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04002CA7 RID: 11431
		internal static IntPtr _FunctionPtr;

		// Token: 0x04002CA8 RID: 11432
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnRotateSequenceFinishedSignature__DelegateSignature";

		// Token: 0x04002CA9 RID: 11433
		private static int RegisterId;

		// Token: 0x02000B58 RID: 2904
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnRotateSequenceFinishedSignature_DelegateParams
		{
			// Token: 0x04005C6B RID: 23659
			[FieldOffset(0)]
			public IntPtr AimPivot;
		}

		// Token: 0x02000B59 RID: 2905
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005C6C RID: 23660
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
