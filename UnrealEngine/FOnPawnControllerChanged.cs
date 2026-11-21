using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000259 RID: 601
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnPawnControllerChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06003331 RID: 13105 RVA: 0x00049651 File Offset: 0x00047851
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnPawnControllerChanged.StaticFunctionPtr();
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x0004965D File Offset: 0x0004785D
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnPawnControllerChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnPawnControllerChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnPawnControllerChanged__DelegateSignature");
			}
			return FOnPawnControllerChanged._FunctionPtr;
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00049680 File Offset: 0x00047880
		public FOnPawnControllerChanged()
		{
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00049688 File Offset: 0x00047888
		[NullableContext(2)]
		public FOnPawnControllerChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x00049692 File Offset: 0x00047892
		public FOnPawnControllerChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x0004969D File Offset: 0x0004789D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<APawn, AController>) ?? ((Action<APawn, AController>)Delegate.CreateDelegate(typeof(Action<APawn, AController>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x000496CF File Offset: 0x000478CF
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<APawn, AController> Callback)
		{
			if (FOnPawnControllerChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnPawnControllerChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnPawnControllerChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnPawnControllerChanged.OnScriptCallback));
				}
				FOnPawnControllerChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnPawnControllerChanged.RegisterId);
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00049709 File Offset: 0x00047909
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			2
		})] Action<APawn, AController> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x00049714 File Offset: 0x00047914
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(APawn Pawn, AController Controller)
		{
			FOnPawnControllerChanged.__FOnPawnControllerChanged_DelegateParams* ptr = stackalloc FOnPawnControllerChanged.__FOnPawnControllerChanged_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnPawnControllerChanged.__FOnPawnControllerChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnPawnControllerChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Pawn = ((Pawn != null) ? Pawn.NativePtr : IntPtr.Zero);
			ptr->Controller = ((Controller != null) ? Controller.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x00049778 File Offset: 0x00047978
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<APawn, AController> action = target as Action<APawn, AController>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			APawn orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(((FOnPawnControllerChanged.__FOnPawnControllerChanged_DelegateParams*)__Parameters)->Pawn);
			AController orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<AController>(((FOnPawnControllerChanged.__FOnPawnControllerChanged_DelegateParams*)__Parameters)->Controller);
			action(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
		}

		// Token: 0x040011D7 RID: 4567
		internal static IntPtr _FunctionPtr;

		// Token: 0x040011D8 RID: 4568
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnPawnControllerChanged__DelegateSignature";

		// Token: 0x040011D9 RID: 4569
		private static int RegisterId;

		// Token: 0x020009DD RID: 2525
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnPawnControllerChanged_DelegateParams
		{
			// Token: 0x0400596E RID: 22894
			[FieldOffset(0)]
			public IntPtr Pawn;

			// Token: 0x0400596F RID: 22895
			[FieldOffset(8)]
			public IntPtr Controller;
		}

		// Token: 0x020009DE RID: 2526
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005970 RID: 22896
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
