using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015C3 RID: 5571
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FJsonDelegate : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x0601415D RID: 82269 RVA: 0x001D7C86 File Offset: 0x001D5E86
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FJsonDelegate.StaticFunctionPtr();
		}

		// Token: 0x0601415E RID: 82270 RVA: 0x001D7C92 File Offset: 0x001D5E92
		private static IntPtr StaticFunctionPtr()
		{
			if (FJsonDelegate._FunctionPtr == IntPtr.Zero)
			{
				FJsonDelegate._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/json2struct.JsonDelegate__DelegateSignature");
			}
			return FJsonDelegate._FunctionPtr;
		}

		// Token: 0x0601415F RID: 82271 RVA: 0x001D7CB5 File Offset: 0x001D5EB5
		public FJsonDelegate()
		{
		}

		// Token: 0x06014160 RID: 82272 RVA: 0x001D7CBD File Offset: 0x001D5EBD
		[NullableContext(2)]
		public FJsonDelegate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014161 RID: 82273 RVA: 0x001D7CC7 File Offset: 0x001D5EC7
		public FJsonDelegate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014162 RID: 82274 RVA: 0x001D7CD2 File Offset: 0x001D5ED2
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<string>) ?? ((Action<string>)Delegate.CreateDelegate(typeof(Action<string>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06014163 RID: 82275 RVA: 0x001D7D04 File Offset: 0x001D5F04
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Add(Action<string> Callback)
		{
			if (FJsonDelegate.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FJsonDelegate.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FJsonDelegate.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FJsonDelegate.OnScriptCallback));
				}
				FJsonDelegate.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FJsonDelegate.RegisterId);
		}

		// Token: 0x06014164 RID: 82276 RVA: 0x001D7D3E File Offset: 0x001D5F3E
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Remove(Action<string> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06014165 RID: 82277 RVA: 0x001D7D48 File Offset: 0x001D5F48
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Broadcast(string Response)
		{
			FJsonDelegate.__FJsonDelegate_DelegateParams* ptr = stackalloc FJsonDelegate.__FJsonDelegate_DelegateParams[(UIntPtr)31] + 15L / (long)sizeof(FJsonDelegate.__FJsonDelegate_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FJsonDelegate.StaticFunctionPtr(), (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Response), Response);
			base.BroadcastInternal((void*)ptr);
			UnrealReflectionUtils.DestroyStruct(FJsonDelegate._FunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06014166 RID: 82278 RVA: 0x001D7D9C File Offset: 0x001D5F9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		protected unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<string> action = target as Action<string>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			string obj = FString.ToString((void*)(&((FJsonDelegate.__FJsonDelegate_DelegateParams*)__Parameters)->Response));
			action(obj);
		}

		// Token: 0x0400AEC2 RID: 44738
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400AEC3 RID: 44739
		[Nullable(1)]
		public const string __ObjectPath = "/Script/json2struct.JsonDelegate__DelegateSignature";

		// Token: 0x0400AEC4 RID: 44740
		private static int RegisterId;

		// Token: 0x02002EC7 RID: 11975
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __FJsonDelegate_DelegateParams
		{
			// Token: 0x040169CC RID: 92620
			[FieldOffset(0)]
			public FString Response;
		}

		// Token: 0x02002EC8 RID: 11976
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040169CD RID: 92621
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
