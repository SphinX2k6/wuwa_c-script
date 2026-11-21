using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001A3 RID: 419
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.MulticastDelegate)]
	public sealed class FCharacterReachedApexSignature : FMulticastScriptDelegate, IUnrealDelegateProxy, IUnrealObject
	{
		// Token: 0x06001EE9 RID: 7913 RVA: 0x0002D1D6 File Offset: 0x0002B3D6
		public static UFunctionStackOnlyPtr StaticFunction()
		{
			return FCharacterReachedApexSignature.StaticFunctionPtr();
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x0002D1E2 File Offset: 0x0002B3E2
		private static IntPtr StaticFunctionPtr()
		{
			if (FCharacterReachedApexSignature._FunctionPtr == IntPtr.Zero)
			{
				FCharacterReachedApexSignature._FunctionPtr = UObjectGlobals.StaticLoadDelegateFunctionChecked(null, "/Script/Engine.CharacterReachedApexSignature__DelegateSignature");
			}
			return FCharacterReachedApexSignature._FunctionPtr;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0002D205 File Offset: 0x0002B405
		public FCharacterReachedApexSignature()
		{
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0002D20D File Offset: 0x0002B40D
		[NullableContext(2)]
		public FCharacterReachedApexSignature(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0002D217 File Offset: 0x0002B417
		public FCharacterReachedApexSignature(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x0002D222 File Offset: 0x0002B422
		[NullableContext(1)]
		public override void DynamicBind(Delegate Callback)
		{
			this.Add((Callback as Action) ?? ((Action)Delegate.CreateDelegate(typeof(Action), Callback.Target, Callback.Method)));
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x0002D254 File Offset: 0x0002B454
		[NullableContext(1)]
		public void Add(Action Callback)
		{
			if (FCharacterReachedApexSignature.RegisterId == 0)
			{
				UnrealScriptDelegate.CallbackType callback;
				if ((callback = FCharacterReachedApexSignature.<>O.<0>__OnScriptCallback) == null)
				{
					callback = (FCharacterReachedApexSignature.<>O.<0>__OnScriptCallback = new UnrealScriptDelegate.CallbackType(FCharacterReachedApexSignature.OnScriptCallback));
				}
				FCharacterReachedApexSignature.RegisterId = UnrealScriptDelegate.RegisterDelegate(callback);
			}
			base.Add(Callback, FCharacterReachedApexSignature.RegisterId);
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x0002D28E File Offset: 0x0002B48E
		[NullableContext(1)]
		public void Remove(Action Callback)
		{
			base.Remove(Callback);
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x0002D297 File Offset: 0x0002B497
		[SkipLocalsInit]
		public void Broadcast()
		{
			base.BroadcastInternal(null);
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x0002D2A4 File Offset: 0x0002B4A4
		[SkipLocalsInit]
		private unsafe static void OnScriptCallback(IntPtr __Handle, byte* __Parameters)
		{
			object target = GCHandle.FromIntPtr(__Handle).Target;
			Action action = target as Action;
			if (action == null)
			{
				throw new ArgumentException((target != null) ? target.GetType().ToString() : null);
			}
			action();
		}

		// Token: 0x04000A5D RID: 2653
		internal static IntPtr _FunctionPtr;

		// Token: 0x04000A5E RID: 2654
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CharacterReachedApexSignature__DelegateSignature";

		// Token: 0x04000A5F RID: 2655
		private static int RegisterId;

		// Token: 0x0200097A RID: 2426
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040058C4 RID: 22724
			public static UnrealScriptDelegate.CallbackType <0>__OnScriptCallback;
		}
	}
}
