using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000255 RID: 597
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnGlobalDataLayerStateChanged : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06003309 RID: 13065 RVA: 0x000490C0 File Offset: 0x000472C0
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnGlobalDataLayerStateChanged.StaticFunctionPtr();
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x000490CC File Offset: 0x000472CC
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnGlobalDataLayerStateChanged._FunctionPtr == IntPtr.Zero)
			{
				FOnGlobalDataLayerStateChanged._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnGlobalDataLayerStateChanged__DelegateSignature");
			}
			return FOnGlobalDataLayerStateChanged._FunctionPtr;
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x000490EF File Offset: 0x000472EF
		public FOnGlobalDataLayerStateChanged()
		{
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x000490F7 File Offset: 0x000472F7
		[NullableContext(2)]
		public FOnGlobalDataLayerStateChanged(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x00049101 File Offset: 0x00047301
		public FOnGlobalDataLayerStateChanged(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x0004910C File Offset: 0x0004730C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName, EDataLayerState>) ?? ((Action<FName, EDataLayerState>)Delegate.CreateDelegate(typeof(Action<FName, EDataLayerState>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x0004913E File Offset: 0x0004733E
		[NullableContext(1)]
		public void Add(Action<FName, EDataLayerState> Callback)
		{
			if (FOnGlobalDataLayerStateChanged.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnGlobalDataLayerStateChanged.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnGlobalDataLayerStateChanged.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnGlobalDataLayerStateChanged.OnScriptCallback));
				}
				FOnGlobalDataLayerStateChanged.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnGlobalDataLayerStateChanged.RegisterId);
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x00049178 File Offset: 0x00047378
		[NullableContext(1)]
		public void Remove(Action<FName, EDataLayerState> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00049184 File Offset: 0x00047384
		[SkipLocalsInit]
		public unsafe void Broadcast(FName DataLayerLabel, EDataLayerState State)
		{
			FOnGlobalDataLayerStateChanged.__FOnGlobalDataLayerStateChanged_DelegateParams* ptr = stackalloc FOnGlobalDataLayerStateChanged.__FOnGlobalDataLayerStateChanged_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FOnGlobalDataLayerStateChanged.__FOnGlobalDataLayerStateChanged_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnGlobalDataLayerStateChanged.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->DataLayerLabel = DataLayerLabel;
			ptr->State = State;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x000491C8 File Offset: 0x000473C8
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName, EDataLayerState> action = target as Action<FName, EDataLayerState>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnGlobalDataLayerStateChanged.__FOnGlobalDataLayerStateChanged_DelegateParams*)__Parameters)->DataLayerLabel, ((FOnGlobalDataLayerStateChanged.__FOnGlobalDataLayerStateChanged_DelegateParams*)__Parameters)->State);
		}

		// Token: 0x040011CB RID: 4555
		internal static IntPtr _FunctionPtr;

		// Token: 0x040011CC RID: 4556
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnGlobalDataLayerStateChanged__DelegateSignature";

		// Token: 0x040011CD RID: 4557
		private static int RegisterId;

		// Token: 0x020009D5 RID: 2517
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FOnGlobalDataLayerStateChanged_DelegateParams
		{
			// Token: 0x04005963 RID: 22883
			[FieldOffset(0)]
			public FName DataLayerLabel;

			// Token: 0x04005964 RID: 22884
			[FieldOffset(12)]
			public EDataLayerState State;
		}

		// Token: 0x020009D6 RID: 2518
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005965 RID: 22885
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
