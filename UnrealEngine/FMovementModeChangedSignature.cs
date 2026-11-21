using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000245 RID: 581
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FMovementModeChangedSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600321B RID: 12827 RVA: 0x00047401 File Offset: 0x00045601
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FMovementModeChangedSignature.StaticFunctionPtr();
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x0004740D File Offset: 0x0004560D
		private static IntPtr StaticFunctionPtr()
		{
			if (FMovementModeChangedSignature._FunctionPtr == IntPtr.Zero)
			{
				FMovementModeChangedSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.MovementModeChangedSignature__DelegateSignature");
			}
			return FMovementModeChangedSignature._FunctionPtr;
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x00047430 File Offset: 0x00045630
		public FMovementModeChangedSignature()
		{
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x00047438 File Offset: 0x00045638
		[NullableContext(2)]
		public FMovementModeChangedSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x00047442 File Offset: 0x00045642
		public FMovementModeChangedSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x0004744D File Offset: 0x0004564D
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<ACharacter, TEnumAsByte<EMovementMode>, byte>) ?? ((Action<ACharacter, TEnumAsByte<EMovementMode>, byte>)Delegate.CreateDelegate(typeof(Action<ACharacter, TEnumAsByte<EMovementMode>, byte>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x0004747F File Offset: 0x0004567F
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

		// Token: 0x06003222 RID: 12834 RVA: 0x000474B9 File Offset: 0x000456B9
		public void Remove([Nullable(new byte[]
		{
			1,
			2,
			0
		})] Action<ACharacter, TEnumAsByte<EMovementMode>, byte> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x000474C4 File Offset: 0x000456C4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void Broadcast(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			FMovementModeChangedSignature.__FMovementModeChangedSignature_DelegateParams* ptr = stackalloc FMovementModeChangedSignature.__FMovementModeChangedSignature_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FMovementModeChangedSignature.__FMovementModeChangedSignature_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FMovementModeChangedSignature.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->Character = ((Character != null) ? Character.NativePtr : IntPtr.Zero);
			ptr->PrevMovementMode = PrevMovementMode;
			ptr->PreviousCustomMode = PreviousCustomMode;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x00047524 File Offset: 0x00045724
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
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

		// Token: 0x0400114A RID: 4426
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400114B RID: 4427
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MovementModeChangedSignature__DelegateSignature";

		// Token: 0x0400114C RID: 4428
		private static int RegisterId;

		// Token: 0x020009C2 RID: 2498
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		private ref struct __FMovementModeChangedSignature_DelegateParams
		{
			// Token: 0x0400594D RID: 22861
			[FieldOffset(0)]
			public IntPtr Character;

			// Token: 0x0400594E RID: 22862
			[FieldOffset(8)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x0400594F RID: 22863
			[FieldOffset(9)]
			public byte PreviousCustomMode;
		}

		// Token: 0x020009C3 RID: 2499
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005950 RID: 22864
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
