using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EBF RID: 3775
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FMovementModeChangedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600CC69 RID: 52329 RVA: 0x00129D19 File Offset: 0x00127F19
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMovementModeChangedSignature.StaticFunctionPtr();
		}

		// Token: 0x0600CC6A RID: 52330 RVA: 0x00129D25 File Offset: 0x00127F25
		private static IntPtr StaticFunctionPtr()
		{
			if (FMovementModeChangedSignature._FunctionPtr == IntPtr.Zero)
			{
				FMovementModeChangedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.MovementModeChangedSignature__DelegateSignature");
			}
			return FMovementModeChangedSignature._FunctionPtr;
		}

		// Token: 0x0600CC6B RID: 52331 RVA: 0x00129D48 File Offset: 0x00127F48
		public FMovementModeChangedSignature()
		{
		}

		// Token: 0x0600CC6C RID: 52332 RVA: 0x00129D50 File Offset: 0x00127F50
		[NullableContext(2)]
		public FMovementModeChangedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CC6D RID: 52333 RVA: 0x00129D5A File Offset: 0x00127F5A
		public FMovementModeChangedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CC6E RID: 52334 RVA: 0x00129D65 File Offset: 0x00127F65
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ACharacter, TEnumAsByte<EMovementMode>, byte>) ?? ((Action<ACharacter, TEnumAsByte<EMovementMode>, byte>)Delegate.CreateDelegate(typeof(Action<ACharacter, TEnumAsByte<EMovementMode>, byte>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600CC6F RID: 52335 RVA: 0x00129D97 File Offset: 0x00127F97
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<ACharacter, TEnumAsByte<EMovementMode>, byte> Callback)
		{
			if (FMovementModeChangedSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FMovementModeChangedSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FMovementModeChangedSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FMovementModeChangedSignature.OnScriptCallback));
				}
				FMovementModeChangedSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FMovementModeChangedSignature.RegisterId);
		}

		// Token: 0x0600CC70 RID: 52336 RVA: 0x00129DD1 File Offset: 0x00127FD1
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<ACharacter, TEnumAsByte<EMovementMode>, byte> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600CC71 RID: 52337 RVA: 0x00129DDC File Offset: 0x00127FDC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			FMovementModeChangedSignature.__FMovementModeChangedSignature_DelegateParams* ptr = stackalloc FMovementModeChangedSignature.__FMovementModeChangedSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FMovementModeChangedSignature.__FMovementModeChangedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMovementModeChangedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600CC72 RID: 52338 RVA: 0x00129E3C File Offset: 0x0012803C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<ACharacter, TEnumAsByte<EMovementMode>, byte> action = target as Action<ACharacter, TEnumAsByte<EMovementMode>, byte>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			ACharacter orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(((FMovementModeChangedSignature.__FMovementModeChangedSignature_DelegateParams*)__Parameters)->Character);
			action(orCreateUObjectByNativePointer, ((FMovementModeChangedSignature.__FMovementModeChangedSignature_DelegateParams*)__Parameters)->PrevMovementMode, ((FMovementModeChangedSignature.__FMovementModeChangedSignature_DelegateParams*)__Parameters)->PreviousCustomMode);
		}

		// Token: 0x04006E16 RID: 28182
		internal static IntPtr _FunctionPtr;

		// Token: 0x04006E17 RID: 28183
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MovementModeChangedSignature__DelegateSignature";

		// Token: 0x04006E18 RID: 28184
		private static int RegisterId;

		// Token: 0x02002D4D RID: 11597
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FMovementModeChangedSignature_DelegateParams
		{
			// Token: 0x0401675E RID: 91998
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x0401675F RID: 91999
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x04016760 RID: 92000
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}

		// Token: 0x02002D4E RID: 11598
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04016761 RID: 92001
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
