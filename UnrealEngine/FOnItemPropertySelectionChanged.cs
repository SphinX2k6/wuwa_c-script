using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000293 RID: 659
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnItemPropertySelectionChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060024DD RID: 9437 RVA: 0x00036E4A File Offset: 0x0003504A
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnItemPropertySelectionChanged.StaticFunctionPtr();
		}

		// Token: 0x060024DE RID: 9438 RVA: 0x00036E56 File Offset: 0x00035056
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnItemPropertySelectionChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnItemPropertySelectionChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnItemPropertySelectionChanged__DelegateSignature");
			}
			return FOnItemPropertySelectionChanged._FunctionPtr;
		}

		// Token: 0x060024DF RID: 9439 RVA: 0x00036E79 File Offset: 0x00035079
		public FOnItemPropertySelectionChanged()
		{
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x00036E81 File Offset: 0x00035081
		[NullableContext(2)]
		public FOnItemPropertySelectionChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x00036E8B File Offset: 0x0003508B
		public FOnItemPropertySelectionChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x00036E96 File Offset: 0x00035096
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x00036EC8 File Offset: 0x000350C8
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FOnItemPropertySelectionChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnItemPropertySelectionChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnItemPropertySelectionChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnItemPropertySelectionChanged.OnScriptCallback));
				}
				FOnItemPropertySelectionChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnItemPropertySelectionChanged.RegisterId);
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x00036F02 File Offset: 0x00035102
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x00036F0C File Offset: 0x0003510C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string PropertySelected)
		{
			FOnItemPropertySelectionChanged.__FOnItemPropertySelectionChanged_DelegateParams* ptr = stackalloc FOnItemPropertySelectionChanged.__FOnItemPropertySelectionChanged_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnItemPropertySelectionChanged.__FOnItemPropertySelectionChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnItemPropertySelectionChanged.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->PropertySelected), PropertySelected);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FOnItemPropertySelectionChanged._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x00036F60 File Offset: 0x00035160
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FOnItemPropertySelectionChanged.__FOnItemPropertySelectionChanged_DelegateParams*)__Parameters)->PropertySelected));
			action(obj);
		}

		// Token: 0x04000E03 RID: 3587
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000E04 RID: 3588
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnItemPropertySelectionChanged__DelegateSignature";

		// Token: 0x04000E05 RID: 3589
		private static int RegisterId;

		// Token: 0x02002B9B RID: 11163
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnItemPropertySelectionChanged_DelegateParams
		{
			// Token: 0x04016431 RID: 91185
			[FieldOffset(0)]
			public FString PropertySelected;
		}

		// Token: 0x02002B9C RID: 11164
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016432 RID: 91186
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
