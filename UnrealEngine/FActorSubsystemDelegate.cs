using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007CB RID: 1995
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FActorSubsystemDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06006A6B RID: 27243 RVA: 0x000995BA File Offset: 0x000977BA
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FActorSubsystemDelegate.StaticFunctionPtr();
		}

		// Token: 0x06006A6C RID: 27244 RVA: 0x000995C6 File Offset: 0x000977C6
		private static IntPtr StaticFunctionPtr()
		{
			if (FActorSubsystemDelegate._FunctionPtr == IntPtr.Zero)
			{
				FActorSubsystemDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.ActorSubsystemDelegate__DelegateSignature");
			}
			return FActorSubsystemDelegate._FunctionPtr;
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x000995E9 File Offset: 0x000977E9
		public FActorSubsystemDelegate()
		{
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x000995F1 File Offset: 0x000977F1
		[NullableContext(2)]
		public FActorSubsystemDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x000995FB File Offset: 0x000977FB
		public FActorSubsystemDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x00099606 File Offset: 0x00097806
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<FName>) ?? ((Action<FName>)Delegate.CreateDelegate(typeof(Action<FName>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x00099638 File Offset: 0x00097838
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<FName> Callback)
		{
			if (FActorSubsystemDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FActorSubsystemDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FActorSubsystemDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FActorSubsystemDelegate.OnScriptCallback));
				}
				FActorSubsystemDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FActorSubsystemDelegate.RegisterId);
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x00099672 File Offset: 0x00097872
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<FName> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x0009967C File Offset: 0x0009787C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(FName ActorKey)
		{
			FActorSubsystemDelegate.__FActorSubsystemDelegate_DelegateParams* ptr = stackalloc FActorSubsystemDelegate.__FActorSubsystemDelegate_DelegateParams[(UIntPtr)27] + 15L / (long)sizeof(FActorSubsystemDelegate.__FActorSubsystemDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FActorSubsystemDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->ActorKey = ActorKey;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x000996B8 File Offset: 0x000978B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<FName> action = target as Action<FName>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FActorSubsystemDelegate.__FActorSubsystemDelegate_DelegateParams*)__Parameters)->ActorKey);
		}

		// Token: 0x0400333F RID: 13119
		internal static IntPtr _FunctionPtr;

		// Token: 0x04003340 RID: 13120
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ActorSubsystemDelegate__DelegateSignature";

		// Token: 0x04003341 RID: 13121
		private static int RegisterId;

		// Token: 0x02002C81 RID: 11393
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FActorSubsystemDelegate_DelegateParams
		{
			// Token: 0x040165BA RID: 91578
			[FieldOffset(0)]
			public FName ActorKey;
		}

		// Token: 0x02002C82 RID: 11394
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040165BB RID: 91579
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
