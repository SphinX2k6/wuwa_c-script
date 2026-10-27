using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C1 RID: 449
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FEQSQueryDoneSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001ADD RID: 6877 RVA: 0x0002808B File Offset: 0x0002628B
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FEQSQueryDoneSignature.StaticFunctionPtr();
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00028097 File Offset: 0x00026297
		private static IntPtr StaticFunctionPtr()
		{
			if (UEnvQueryInstanceBlueprintWrapper.__EQSQueryDoneSignature__DelegateSignature_NativeFunctionPtr == IntPtr.Zero)
			{
				UEnvQueryInstanceBlueprintWrapper.__EQSQueryDoneSignature__DelegateSignature_NativeFunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/AIModule.EnvQueryInstanceBlueprintWrapper:EQSQueryDoneSignature__DelegateSignature");
			}
			return UEnvQueryInstanceBlueprintWrapper.__EQSQueryDoneSignature__DelegateSignature_NativeFunctionPtr;
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x000280BA File Offset: 0x000262BA
		public FEQSQueryDoneSignature()
		{
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x000280C2 File Offset: 0x000262C2
		[NullableContext(2)]
		public FEQSQueryDoneSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x000280CC File Offset: 0x000262CC
		public FEQSQueryDoneSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x000280D7 File Offset: 0x000262D7
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<UEnvQueryInstanceBlueprintWrapper, TEnumAsByte<EEnvQueryStatus>>) ?? ((Action<UEnvQueryInstanceBlueprintWrapper, TEnumAsByte<EEnvQueryStatus>>)Delegate.CreateDelegate(typeof(Action<UEnvQueryInstanceBlueprintWrapper, TEnumAsByte<EEnvQueryStatus>>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001AE3 RID: 6883 RVA: 0x00028109 File Offset: 0x00026309
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<UEnvQueryInstanceBlueprintWrapper, TEnumAsByte<EEnvQueryStatus>> Callback)
		{
			if (FEQSQueryDoneSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FEQSQueryDoneSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FEQSQueryDoneSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FEQSQueryDoneSignature.OnScriptCallback));
				}
				FEQSQueryDoneSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FEQSQueryDoneSignature.RegisterId);
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00028143 File Offset: 0x00026343
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<UEnvQueryInstanceBlueprintWrapper, TEnumAsByte<EEnvQueryStatus>> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0002814C File Offset: 0x0002634C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(UEnvQueryInstanceBlueprintWrapper QueryInstance, EEnvQueryStatus QueryStatus)
		{
			FEQSQueryDoneSignature.__FEQSQueryDoneSignature_DelegateParams* ptr = stackalloc FEQSQueryDoneSignature.__FEQSQueryDoneSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FEQSQueryDoneSignature.__FEQSQueryDoneSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FEQSQueryDoneSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->QueryInstance = ((QueryInstance != null) ? QueryInstance.NativePtr : IntPtr.Zero);
			ptr->QueryStatus = QueryStatus;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x000281A4 File Offset: 0x000263A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<UEnvQueryInstanceBlueprintWrapper, TEnumAsByte<EEnvQueryStatus>> action = target as Action<UEnvQueryInstanceBlueprintWrapper, TEnumAsByte<EEnvQueryStatus>>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			UEnvQueryInstanceBlueprintWrapper orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UEnvQueryInstanceBlueprintWrapper>(((FEQSQueryDoneSignature.__FEQSQueryDoneSignature_DelegateParams*)__Parameters)->QueryInstance);
			action(orCreateUObjectByNativePointer, ((FEQSQueryDoneSignature.__FEQSQueryDoneSignature_DelegateParams*)__Parameters)->QueryStatus);
		}

		// Token: 0x0400087B RID: 2171
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.EnvQueryInstanceBlueprintWrapper:EQSQueryDoneSignature__DelegateSignature";

		// Token: 0x0400087C RID: 2172
		private static int RegisterId;

		// Token: 0x02002B68 RID: 11112
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FEQSQueryDoneSignature_DelegateParams
		{
			// Token: 0x040163EC RID: 91116
			[FieldOffset(0)]
			public IntPtr QueryInstance;

			// Token: 0x040163ED RID: 91117
			[FieldOffset(8)]
			public TEnumAsByte<EEnvQueryStatus> QueryStatus;
		}

		// Token: 0x02002B69 RID: 11113
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040163EE RID: 91118
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
