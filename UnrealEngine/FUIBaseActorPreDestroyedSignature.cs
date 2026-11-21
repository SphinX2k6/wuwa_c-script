using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006EB RID: 1771
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)]
	public sealed class FUIBaseActorPreDestroyedSignature : FSparseDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06009652 RID: 38482 RVA: 0x000E2C6D File Offset: 0x000E0E6D
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FUIBaseActorPreDestroyedSignature.StaticFunctionPtr();
		}

		// Token: 0x06009653 RID: 38483 RVA: 0x000E2C79 File Offset: 0x000E0E79
		private static IntPtr StaticFunctionPtr()
		{
			if (FUIBaseActorPreDestroyedSignature._FunctionPtr == IntPtr.Zero)
			{
				FUIBaseActorPreDestroyedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/LGUI.UIBaseActorPreDestroyedSignature__DelegateSignature");
			}
			return FUIBaseActorPreDestroyedSignature._FunctionPtr;
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x06009654 RID: 38484 RVA: 0x000E2C9C File Offset: 0x000E0E9C
		public override FName DelegateName
		{
			get
			{
				return FNameStatic.OnPreDestroyed;
			}
		}

		// Token: 0x06009655 RID: 38485 RVA: 0x000E2CA3 File Offset: 0x000E0EA3
		[NullableContext(2)]
		public FUIBaseActorPreDestroyedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009656 RID: 38486 RVA: 0x000E2CAD File Offset: 0x000E0EAD
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<AActor>) ?? ((Action<AActor>)Delegate.CreateDelegate(typeof(Action<AActor>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06009657 RID: 38487 RVA: 0x000E2CE0 File Offset: 0x000E0EE0
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			if (FUIBaseActorPreDestroyedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FUIBaseActorPreDestroyedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FUIBaseActorPreDestroyedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FUIBaseActorPreDestroyedSignature.OnScriptCallback));
				}
				FUIBaseActorPreDestroyedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			FName delegateName = this.DelegateName;
			base.Add(delegateName, Callback, FUIBaseActorPreDestroyedSignature.RegisterId);
		}

		// Token: 0x06009658 RID: 38488 RVA: 0x000E2D30 File Offset: 0x000E0F30
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<AActor> Callback)
		{
			FName delegateName = this.DelegateName;
			base.Remove(delegateName, Callback);
		}

		// Token: 0x06009659 RID: 38489 RVA: 0x000E2D50 File Offset: 0x000E0F50
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(AActor DestroyedActor)
		{
			FUIBaseActorPreDestroyedSignature.__FUIBaseActorPreDestroyedSignature_DelegateParams* ptr = stackalloc FUIBaseActorPreDestroyedSignature.__FUIBaseActorPreDestroyedSignature_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FUIBaseActorPreDestroyedSignature.__FUIBaseActorPreDestroyedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FUIBaseActorPreDestroyedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DestroyedActor = ((DestroyedActor != null) ? DestroyedActor.NativePtr : IntPtr.Zero);
			FSparseDelegate.BroadcastInternal(base.GetOwner().NativePtr, this.DelegateName, (void*)ptr);
		}

		// Token: 0x0600965A RID: 38490 RVA: 0x000E2DAC File Offset: 0x000E0FAC
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<AActor> action = target as Action<AActor>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(((FUIBaseActorPreDestroyedSignature.__FUIBaseActorPreDestroyedSignature_DelegateParams*)__Parameters)->DestroyedActor);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04004160 RID: 16736
		internal static IntPtr _FunctionPtr;

		// Token: 0x04004161 RID: 16737
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UIBaseActorPreDestroyedSignature__DelegateSignature";

		// Token: 0x04004162 RID: 16738
		private static int RegisterId;

		// Token: 0x02000F14 RID: 3860
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FUIBaseActorPreDestroyedSignature_DelegateParams
		{
			// Token: 0x040062E3 RID: 25315
			[FieldOffset(0)]
			public IntPtr DestroyedActor;
		}

		// Token: 0x02000F15 RID: 3861
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040062E4 RID: 25316
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
