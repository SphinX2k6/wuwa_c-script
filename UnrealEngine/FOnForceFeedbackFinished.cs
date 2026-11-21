using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000252 RID: 594
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnForceFeedbackFinished : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060032EB RID: 13035 RVA: 0x00048CFD File Offset: 0x00046EFD
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnForceFeedbackFinished.StaticFunctionPtr();
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x00048D09 File Offset: 0x00046F09
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnForceFeedbackFinished._FunctionPtr == IntPtr.Zero)
			{
				FOnForceFeedbackFinished._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnForceFeedbackFinished__DelegateSignature");
			}
			return FOnForceFeedbackFinished._FunctionPtr;
		}

		// Token: 0x060032ED RID: 13037 RVA: 0x00048D2C File Offset: 0x00046F2C
		public FOnForceFeedbackFinished()
		{
		}

		// Token: 0x060032EE RID: 13038 RVA: 0x00048D34 File Offset: 0x00046F34
		[NullableContext(2)]
		public FOnForceFeedbackFinished(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060032EF RID: 13039 RVA: 0x00048D3E File Offset: 0x00046F3E
		public FOnForceFeedbackFinished(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060032F0 RID: 13040 RVA: 0x00048D49 File Offset: 0x00046F49
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UForceFeedbackComponent>) ?? ((Action<UForceFeedbackComponent>)Delegate.CreateDelegate(typeof(Action<UForceFeedbackComponent>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060032F1 RID: 13041 RVA: 0x00048D7B File Offset: 0x00046F7B
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UForceFeedbackComponent> Callback)
		{
			if (FOnForceFeedbackFinished.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnForceFeedbackFinished.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnForceFeedbackFinished.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnForceFeedbackFinished.OnScriptCallback));
				}
				FOnForceFeedbackFinished.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnForceFeedbackFinished.RegisterId);
		}

		// Token: 0x060032F2 RID: 13042 RVA: 0x00048DB5 File Offset: 0x00046FB5
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UForceFeedbackComponent> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060032F3 RID: 13043 RVA: 0x00048DC0 File Offset: 0x00046FC0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UForceFeedbackComponent ForceFeedbackComponent)
		{
			FOnForceFeedbackFinished.__FOnForceFeedbackFinished_DelegateParams* ptr = stackalloc FOnForceFeedbackFinished.__FOnForceFeedbackFinished_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnForceFeedbackFinished.__FOnForceFeedbackFinished_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnForceFeedbackFinished.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ForceFeedbackComponent = ((ForceFeedbackComponent != null) ? ForceFeedbackComponent.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060032F4 RID: 13044 RVA: 0x00048E0C File Offset: 0x0004700C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UForceFeedbackComponent> action = target as Action<UForceFeedbackComponent>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UForceFeedbackComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UForceFeedbackComponent>(((FOnForceFeedbackFinished.__FOnForceFeedbackFinished_DelegateParams*)__Parameters)->ForceFeedbackComponent);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040011C2 RID: 4546
		internal static IntPtr _FunctionPtr;

		// Token: 0x040011C3 RID: 4547
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnForceFeedbackFinished__DelegateSignature";

		// Token: 0x040011C4 RID: 4548
		private static int RegisterId;

		// Token: 0x020009D0 RID: 2512
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnForceFeedbackFinished_DelegateParams
		{
			// Token: 0x0400595D RID: 22877
			[FieldOffset(0)]
			public IntPtr ForceFeedbackComponent;
		}

		// Token: 0x020009D1 RID: 2513
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400595E RID: 22878
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
