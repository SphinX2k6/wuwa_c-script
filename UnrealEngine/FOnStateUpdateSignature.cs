using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200082F RID: 2095
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnStateUpdateSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600B656 RID: 46678 RVA: 0x001222EB File Offset: 0x001204EB
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnStateUpdateSignature.StaticFunctionPtr();
		}

		// Token: 0x0600B657 RID: 46679 RVA: 0x001222F7 File Offset: 0x001204F7
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnStateUpdateSignature._FunctionPtr == IntPtr.Zero)
			{
				FOnStateUpdateSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/SMSystem.OnStateUpdateSignature__DelegateSignature");
			}
			return FOnStateUpdateSignature._FunctionPtr;
		}

		// Token: 0x0600B658 RID: 46680 RVA: 0x0012231A File Offset: 0x0012051A
		public FOnStateUpdateSignature()
		{
		}

		// Token: 0x0600B659 RID: 46681 RVA: 0x00122322 File Offset: 0x00120522
		[NullableContext(2)]
		public FOnStateUpdateSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B65A RID: 46682 RVA: 0x0012232C File Offset: 0x0012052C
		public FOnStateUpdateSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B65B RID: 46683 RVA: 0x00122337 File Offset: 0x00120537
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USMStateInstance_Base, float>) ?? ((Action<USMStateInstance_Base, float>)Delegate.CreateDelegate(typeof(Action<USMStateInstance_Base, float>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600B65C RID: 46684 RVA: 0x00122369 File Offset: 0x00120569
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMStateInstance_Base, float> Callback)
		{
			if (FOnStateUpdateSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnStateUpdateSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnStateUpdateSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnStateUpdateSignature.OnScriptCallback));
				}
				FOnStateUpdateSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnStateUpdateSignature.RegisterId);
		}

		// Token: 0x0600B65D RID: 46685 RVA: 0x001223A3 File Offset: 0x001205A3
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USMStateInstance_Base, float> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600B65E RID: 46686 RVA: 0x001223AC File Offset: 0x001205AC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(USMStateInstance_Base StateInstance, float DeltaSeconds)
		{
			FOnStateUpdateSignature.__FOnStateUpdateSignature_DelegateParams* ptr = stackalloc FOnStateUpdateSignature.__FOnStateUpdateSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnStateUpdateSignature.__FOnStateUpdateSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnStateUpdateSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->StateInstance = ((StateInstance != null) ? StateInstance.NativePtr : IntPtr.Zero);
			ptr->DeltaSeconds = DeltaSeconds;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600B65F RID: 46687 RVA: 0x00122400 File Offset: 0x00120600
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USMStateInstance_Base, float> action = target as Action<USMStateInstance_Base, float>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USMStateInstance_Base orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USMStateInstance_Base>(((FOnStateUpdateSignature.__FOnStateUpdateSignature_DelegateParams*)__Parameters)->StateInstance);
			action(orCreateUObjectByNativePointer, ((FOnStateUpdateSignature.__FOnStateUpdateSignature_DelegateParams*)__Parameters)->DeltaSeconds);
		}

		// Token: 0x0400526E RID: 21102
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400526F RID: 21103
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.OnStateUpdateSignature__DelegateSignature";

		// Token: 0x04005270 RID: 21104
		private static int RegisterId;

		// Token: 0x02001344 RID: 4932
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnStateUpdateSignature_DelegateParams
		{
			// Token: 0x04006783 RID: 26499
			[FieldOffset(0)]
			public IntPtr StateInstance;

			// Token: 0x04006784 RID: 26500
			[FieldOffset(8)]
			public float DeltaSeconds;
		}

		// Token: 0x02001345 RID: 4933
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04006785 RID: 26501
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
