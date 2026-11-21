using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000866 RID: 2150
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnListEntryGeneratedDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600BAF2 RID: 47858 RVA: 0x0012B47F File Offset: 0x0012967F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnListEntryGeneratedDynamic.StaticFunctionPtr();
		}

		// Token: 0x0600BAF3 RID: 47859 RVA: 0x0012B48B File Offset: 0x0012968B
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnListEntryGeneratedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnListEntryGeneratedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnListEntryGeneratedDynamic__DelegateSignature");
			}
			return FOnListEntryGeneratedDynamic._FunctionPtr;
		}

		// Token: 0x0600BAF4 RID: 47860 RVA: 0x0012B4AE File Offset: 0x001296AE
		public FOnListEntryGeneratedDynamic()
		{
		}

		// Token: 0x0600BAF5 RID: 47861 RVA: 0x0012B4B6 File Offset: 0x001296B6
		[NullableContext(2)]
		public FOnListEntryGeneratedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600BAF6 RID: 47862 RVA: 0x0012B4C0 File Offset: 0x001296C0
		public FOnListEntryGeneratedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600BAF7 RID: 47863 RVA: 0x0012B4CB File Offset: 0x001296CB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UUserWidget>) ?? ((Action<UUserWidget>)Delegate.CreateDelegate(typeof(Action<UUserWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600BAF8 RID: 47864 RVA: 0x0012B4FD File Offset: 0x001296FD
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUserWidget> Callback)
		{
			if (FOnListEntryGeneratedDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnListEntryGeneratedDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnListEntryGeneratedDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnListEntryGeneratedDynamic.OnScriptCallback));
				}
				FOnListEntryGeneratedDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnListEntryGeneratedDynamic.RegisterId);
		}

		// Token: 0x0600BAF9 RID: 47865 RVA: 0x0012B537 File Offset: 0x00129737
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUserWidget> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600BAFA RID: 47866 RVA: 0x0012B540 File Offset: 0x00129740
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(UUserWidget Widget)
		{
			FOnListEntryGeneratedDynamic.__FOnListEntryGeneratedDynamic_DelegateParams* ptr = stackalloc FOnListEntryGeneratedDynamic.__FOnListEntryGeneratedDynamic_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnListEntryGeneratedDynamic.__FOnListEntryGeneratedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnListEntryGeneratedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600BAFB RID: 47867 RVA: 0x0012B58C File Offset: 0x0012978C
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUserWidget> action = target as Action<UUserWidget>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUserWidget orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(((FOnListEntryGeneratedDynamic.__FOnListEntryGeneratedDynamic_DelegateParams*)__Parameters)->Widget);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x040054BC RID: 21692
		internal static IntPtr _FunctionPtr;

		// Token: 0x040054BD RID: 21693
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnListEntryGeneratedDynamic__DelegateSignature";

		// Token: 0x040054BE RID: 21694
		private static int RegisterId;

		// Token: 0x02001401 RID: 5121
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		private ref struct __FOnListEntryGeneratedDynamic_DelegateParams
		{
			// Token: 0x040068AC RID: 26796
			[FieldOffset(0)]
			public IntPtr Widget;
		}

		// Token: 0x02001402 RID: 5122
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040068AD RID: 26797
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
