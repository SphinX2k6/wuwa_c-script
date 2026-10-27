using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001977 RID: 6519
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnTagSignificantChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601837C RID: 99196 RVA: 0x0023B732 File Offset: 0x00239932
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTagSignificantChanged.StaticFunctionPtr();
		}

		// Token: 0x0601837D RID: 99197 RVA: 0x0023B73E File Offset: 0x0023993E
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTagSignificantChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnTagSignificantChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroGAS.OnTagSignificantChanged__DelegateSignature");
			}
			return FOnTagSignificantChanged._FunctionPtr;
		}

		// Token: 0x0601837E RID: 99198 RVA: 0x0023B761 File Offset: 0x00239961
		public FOnTagSignificantChanged()
		{
		}

		// Token: 0x0601837F RID: 99199 RVA: 0x0023B769 File Offset: 0x00239969
		[NullableContext(2)]
		public FOnTagSignificantChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018380 RID: 99200 RVA: 0x0023B773 File Offset: 0x00239973
		public FOnTagSignificantChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018381 RID: 99201 RVA: 0x0023B77E File Offset: 0x0023997E
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06018382 RID: 99202 RVA: 0x0023B7B0 File Offset: 0x002399B0
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<bool> Callback)
		{
			if (FOnTagSignificantChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTagSignificantChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTagSignificantChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTagSignificantChanged.OnScriptCallback));
				}
				FOnTagSignificantChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnTagSignificantChanged.RegisterId);
		}

		// Token: 0x06018383 RID: 99203 RVA: 0x0023B7EA File Offset: 0x002399EA
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06018384 RID: 99204 RVA: 0x0023B7F4 File Offset: 0x002399F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(bool bTagExists)
		{
			FOnTagSignificantChanged.__FOnTagSignificantChanged_DelegateParams* ptr = stackalloc FOnTagSignificantChanged.__FOnTagSignificantChanged_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnTagSignificantChanged.__FOnTagSignificantChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTagSignificantChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bTagExists = bTagExists;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06018385 RID: 99205 RVA: 0x0023B830 File Offset: 0x00239A30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnTagSignificantChanged.__FOnTagSignificantChanged_DelegateParams*)__Parameters)->bTagExists);
		}

		// Token: 0x0400D1DB RID: 53723
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400D1DC RID: 53724
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGAS.OnTagSignificantChanged__DelegateSignature";

		// Token: 0x0400D1DD RID: 53725
		private static int RegisterId;

		// Token: 0x02003070 RID: 12400
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __FOnTagSignificantChanged_DelegateParams
		{
			// Token: 0x04016D41 RID: 93505
			[FieldOffset(0)]
			public bool bTagExists;
		}

		// Token: 0x02003071 RID: 12401
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016D42 RID: 93506
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
