using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000514 RID: 1300
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FOnTunnelFlickSwitch : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06007972 RID: 31090 RVA: 0x000B2420 File Offset: 0x000B0620
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FOnTunnelFlickSwitch.StaticFunctionPtr();
		}

		// Token: 0x06007973 RID: 31091 RVA: 0x000B242C File Offset: 0x000B062C
		private static IntPtr StaticFunctionPtr()
		{
			if (FOnTunnelFlickSwitch._FunctionPtr == IntPtr.Zero)
			{
				FOnTunnelFlickSwitch._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/KuroRhythmGame.OnTunnelFlickSwitch__DelegateSignature");
			}
			return FOnTunnelFlickSwitch._FunctionPtr;
		}

		// Token: 0x06007974 RID: 31092 RVA: 0x000B244F File Offset: 0x000B064F
		public FOnTunnelFlickSwitch()
		{
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x000B2457 File Offset: 0x000B0657
		[NullableContext(2)]
		public FOnTunnelFlickSwitch(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007976 RID: 31094 RVA: 0x000B2461 File Offset: 0x000B0661
		public FOnTunnelFlickSwitch(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007977 RID: 31095 RVA: 0x000B246C File Offset: 0x000B066C
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action<bool>) ?? ((Action<bool>)Delegate.CreateDelegate(typeof(Action<bool>), Callback.Target, Callback.Method)));
		}

		// Token: 0x06007978 RID: 31096 RVA: 0x000B249E File Offset: 0x000B069E
		[NullableContext(1)]
		public void Add(Action<bool> Callback)
		{
			if (FOnTunnelFlickSwitch.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FOnTunnelFlickSwitch.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FOnTunnelFlickSwitch.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FOnTunnelFlickSwitch.OnScriptCallback));
				}
				FOnTunnelFlickSwitch.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FOnTunnelFlickSwitch.RegisterId);
		}

		// Token: 0x06007979 RID: 31097 RVA: 0x000B24D8 File Offset: 0x000B06D8
		[NullableContext(1)]
		public void Remove(Action<bool> Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x0600797A RID: 31098 RVA: 0x000B24E4 File Offset: 0x000B06E4
		[SkipLocalsInit]
		public unsafe void Broadcast(bool bGoLeft)
		{
			FOnTunnelFlickSwitch.__FOnTunnelFlickSwitch_DelegateParams* ptr = stackalloc FOnTunnelFlickSwitch.__FOnTunnelFlickSwitch_DelegateParams[(UIntPtr)16] + 15L / (long)sizeof(FOnTunnelFlickSwitch.__FOnTunnelFlickSwitch_DelegateParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(FOnTunnelFlickSwitch.StaticFunctionPtr(), (void*)ptr, 1);
			ptr->bGoLeft = bGoLeft;
			base.BroadcastInternal((void*)ptr);
		}

		// Token: 0x0600797B RID: 31099 RVA: 0x000B2520 File Offset: 0x000B0720
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action<bool> action = target as Action<bool>;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action(((FOnTunnelFlickSwitch.__FOnTunnelFlickSwitch_DelegateParams*)__Parameters)->bGoLeft);
		}

		// Token: 0x04003399 RID: 13209
		internal static IntPtr _FunctionPtr;

		// Token: 0x0400339A RID: 13210
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.OnTunnelFlickSwitch__DelegateSignature";

		// Token: 0x0400339B RID: 13211
		private static int RegisterId;

		// Token: 0x02000C7E RID: 3198
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		private ref struct __FOnTunnelFlickSwitch_DelegateParams
		{
			// Token: 0x04005EE0 RID: 24288
			[FieldOffset(0)]
			public bool bGoLeft;
		}

		// Token: 0x02000C7F RID: 3199
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04005EE1 RID: 24289
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
