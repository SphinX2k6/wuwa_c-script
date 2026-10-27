using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000294 RID: 660
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnItemSelectionChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x060024E7 RID: 9447 RVA: 0x00036FB2 File Offset: 0x000351B2
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnItemSelectionChanged.StaticFunctionPtr();
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00036FBE File Offset: 0x000351BE
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnItemSelectionChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnItemSelectionChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AkAudio.OnItemSelectionChanged__DelegateSignature");
			}
			return FOnItemSelectionChanged._FunctionPtr;
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00036FE1 File Offset: 0x000351E1
		public FOnItemSelectionChanged()
		{
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x00036FE9 File Offset: 0x000351E9
		[NullableContext(2)]
		public FOnItemSelectionChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x00036FF3 File Offset: 0x000351F3
		public FOnItemSelectionChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x00036FFE File Offset: 0x000351FE
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FGuid>) ?? ((Action<FGuid>)Delegate.CreateDelegate(typeof(Action<FGuid>), Callback.Target, Callback.Method)));
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00037030 File Offset: 0x00035230
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FGuid> Callback)
		{
			if (FOnItemSelectionChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnItemSelectionChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnItemSelectionChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnItemSelectionChanged.OnScriptCallback));
				}
				FOnItemSelectionChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnItemSelectionChanged.RegisterId);
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x0003706A File Offset: 0x0003526A
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FGuid> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x00037074 File Offset: 0x00035274
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FGuid ItemSelectedID)
		{
			FOnItemSelectionChanged.__FOnItemSelectionChanged_DelegateParams* ptr = stackalloc FOnItemSelectionChanged.__FOnItemSelectionChanged_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnItemSelectionChanged.__FOnItemSelectionChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnItemSelectionChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ItemSelectedID = ItemSelectedID;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x000370B0 File Offset: 0x000352B0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FGuid> action = target as Action<FGuid>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnItemSelectionChanged.__FOnItemSelectionChanged_DelegateParams*)__Parameters)->ItemSelectedID);
		}

		// Token: 0x04000E06 RID: 3590
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000E07 RID: 3591
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.OnItemSelectionChanged__DelegateSignature";

		// Token: 0x04000E08 RID: 3592
		private static int RegisterId;

		// Token: 0x02002B9D RID: 11165
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FOnItemSelectionChanged_DelegateParams
		{
			// Token: 0x04016433 RID: 91187
			[FieldOffset(0)]
			public FGuid ItemSelectedID;
		}

		// Token: 0x02002B9E RID: 11166
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016434 RID: 91188
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
