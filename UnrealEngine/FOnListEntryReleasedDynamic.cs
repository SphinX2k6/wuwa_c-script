using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029AB RID: 10667
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnListEntryReleasedDynamic : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06027738 RID: 161592 RVA: 0x003C2E9F File Offset: 0x003C109F
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnListEntryReleasedDynamic.StaticFunctionPtr();
		}

		// Token: 0x06027739 RID: 161593 RVA: 0x003C2EAB File Offset: 0x003C10AB
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnListEntryReleasedDynamic._FunctionPtr == IntPtr.Zero)
			{
				FOnListEntryReleasedDynamic._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/UMG.OnListEntryReleasedDynamic__DelegateSignature");
			}
			return FOnListEntryReleasedDynamic._FunctionPtr;
		}

		// Token: 0x0602773A RID: 161594 RVA: 0x003C2ECE File Offset: 0x003C10CE
		public FOnListEntryReleasedDynamic()
		{
		}

		// Token: 0x0602773B RID: 161595 RVA: 0x003C2ED6 File Offset: 0x003C10D6
		[NullableContext(2)]
		public FOnListEntryReleasedDynamic(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602773C RID: 161596 RVA: 0x003C2EE0 File Offset: 0x003C10E0
		public FOnListEntryReleasedDynamic(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602773D RID: 161597 RVA: 0x003C2EEB File Offset: 0x003C10EB
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UUserWidget>) ?? ((Action<UUserWidget>)Delegate.CreateDelegate(typeof(Action<UUserWidget>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0602773E RID: 161598 RVA: 0x003C2F1D File Offset: 0x003C111D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUserWidget> Callback)
		{
			if (FOnListEntryReleasedDynamic.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnListEntryReleasedDynamic.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnListEntryReleasedDynamic.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnListEntryReleasedDynamic.OnScriptCallback));
				}
				FOnListEntryReleasedDynamic.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnListEntryReleasedDynamic.RegisterId);
		}

		// Token: 0x0602773F RID: 161599 RVA: 0x003C2F57 File Offset: 0x003C1157
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<UUserWidget> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06027740 RID: 161600 RVA: 0x003C2F60 File Offset: 0x003C1160
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UUserWidget Widget)
		{
			FOnListEntryReleasedDynamic.__FOnListEntryReleasedDynamic_DelegateParams* ptr = stackalloc FOnListEntryReleasedDynamic.__FOnListEntryReleasedDynamic_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnListEntryReleasedDynamic.__FOnListEntryReleasedDynamic_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnListEntryReleasedDynamic.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Widget = ((Widget != null) ? Widget.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06027741 RID: 161601 RVA: 0x003C2FAC File Offset: 0x003C11AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UUserWidget> action = target as Action<UUserWidget>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UUserWidget orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(((FOnListEntryReleasedDynamic.__FOnListEntryReleasedDynamic_DelegateParams*)__Parameters)->Widget);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x04015A5F RID: 88671
		internal static IntPtr _FunctionPtr;

		// Token: 0x04015A60 RID: 88672
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.OnListEntryReleasedDynamic__DelegateSignature";

		// Token: 0x04015A61 RID: 88673
		private static int RegisterId;

		// Token: 0x02003BAD RID: 15277
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnListEntryReleasedDynamic_DelegateParams
		{
			// Token: 0x04017D8E RID: 97678
			[FieldOffset(0)]
			public IntPtr Widget;
		}

		// Token: 0x02003BAE RID: 15278
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04017D8F RID: 97679
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
