using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F2B RID: 3883
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnSubmixRecordedFileDone : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0600D18B RID: 53643 RVA: 0x00132E47 File Offset: 0x00131047
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnSubmixRecordedFileDone.StaticFunctionPtr();
		}

		// Token: 0x0600D18C RID: 53644 RVA: 0x00132E53 File Offset: 0x00131053
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnSubmixRecordedFileDone._FunctionPtr == IntPtr.Zero)
			{
				FOnSubmixRecordedFileDone._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.OnSubmixRecordedFileDone__DelegateSignature");
			}
			return FOnSubmixRecordedFileDone._FunctionPtr;
		}

		// Token: 0x0600D18D RID: 53645 RVA: 0x00132E76 File Offset: 0x00131076
		public FOnSubmixRecordedFileDone()
		{
		}

		// Token: 0x0600D18E RID: 53646 RVA: 0x00132E7E File Offset: 0x0013107E
		[NullableContext(2)]
		public FOnSubmixRecordedFileDone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D18F RID: 53647 RVA: 0x00132E88 File Offset: 0x00131088
		public FOnSubmixRecordedFileDone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D190 RID: 53648 RVA: 0x00132E93 File Offset: 0x00131093
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<USoundWave>) ?? ((Action<USoundWave>)Delegate.CreateDelegate(typeof(Action<USoundWave>), Callback.Target, Callback.Method)));
		}

		// Token: 0x0600D191 RID: 53649 RVA: 0x00132EC5 File Offset: 0x001310C5
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add([Nullable(new byte[]
		{
			1,
			2
		})] Action<USoundWave> Callback)
		{
			if (FOnSubmixRecordedFileDone.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnSubmixRecordedFileDone.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnSubmixRecordedFileDone.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnSubmixRecordedFileDone.OnScriptCallback));
				}
				FOnSubmixRecordedFileDone.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnSubmixRecordedFileDone.RegisterId);
		}

		// Token: 0x0600D192 RID: 53650 RVA: 0x00132EFF File Offset: 0x001310FF
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove([Nullable(new byte[]
		{
			1,
			2
		})] Action<USoundWave> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600D193 RID: 53651 RVA: 0x00132F08 File Offset: 0x00131108
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(USoundWave ResultingSoundWave)
		{
			FOnSubmixRecordedFileDone.__FOnSubmixRecordedFileDone_DelegateParams* ptr = stackalloc FOnSubmixRecordedFileDone.__FOnSubmixRecordedFileDone_DelegateParams[(UIntPtr)23] + 15L / (long)sizeof(FOnSubmixRecordedFileDone.__FOnSubmixRecordedFileDone_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnSubmixRecordedFileDone.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ResultingSoundWave = ((ResultingSoundWave != null) ? ResultingSoundWave.NativePtr : IntPtr.Zero);
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600D194 RID: 53652 RVA: 0x00132F54 File Offset: 0x00131154
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<USoundWave> action = target as Action<USoundWave>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			USoundWave orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USoundWave>(((FOnSubmixRecordedFileDone.__FOnSubmixRecordedFileDone_DelegateParams*)__Parameters)->ResultingSoundWave);
			action(orCreateUObjectByNativePointer);
		}

		// Token: 0x0400708D RID: 28813
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400708E RID: 28814
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.OnSubmixRecordedFileDone__DelegateSignature";

		// Token: 0x0400708F RID: 28815
		private static int RegisterId;

		// Token: 0x02002DA2 RID: 11682
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __FOnSubmixRecordedFileDone_DelegateParams
		{
			// Token: 0x040167C8 RID: 92104
			[FieldOffset(0)]
			public IntPtr ResultingSoundWave;
		}

		// Token: 0x02002DA3 RID: 11683
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040167C9 RID: 92105
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
