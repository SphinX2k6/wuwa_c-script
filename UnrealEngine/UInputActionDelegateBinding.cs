using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C4D RID: 3149
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputActionDelegateBinding")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UInputActionDelegateBinding : UInputDelegateBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009FA7 RID: 40871 RVA: 0x000E2E02 File Offset: 0x000E1002
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputActionDelegateBinding._ClassPtr;
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x000E2E10 File Offset: 0x000E1010
		public UInputActionDelegateBinding() : this(BuiltinUtils.AllocNativeUObject(UInputActionDelegateBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009FA9 RID: 40873 RVA: 0x000E2E38 File Offset: 0x000E1038
		public UInputActionDelegateBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInputActionDelegateBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700260C RID: 9740
		// (get) Token: 0x06009FAA RID: 40874 RVA: 0x000E2E6C File Offset: 0x000E106C
		// (set) Token: 0x06009FAB RID: 40875 RVA: 0x000E2EA5 File Offset: 0x000E10A5
		public TArray<FBlueprintInputActionDelegateBinding> InputActionDelegateBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBlueprintInputActionDelegateBinding> result;
				if ((result = this._InputActionDelegateBindings) == null)
				{
					result = (this._InputActionDelegateBindings = new TArray<FBlueprintInputActionDelegateBinding>(base.NativePtr + (IntPtr)UInputActionDelegateBinding.__PropertyOffset_InputActionDelegateBindings, this));
				}
				return result;
			}
			set
			{
				this.InputActionDelegateBindings.CopyAssign(value);
			}
		}

		// Token: 0x06009FAC RID: 40876 RVA: 0x000E2EB3 File Offset: 0x000E10B3
		static UInputActionDelegateBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InputActionDelegateBinding");
		}

		// Token: 0x06009FAD RID: 40877 RVA: 0x000E2EC1 File Offset: 0x000E10C1
		protected UInputActionDelegateBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040057DC RID: 22492
		public new const string __ObjectPath = "/Script/Engine.InputActionDelegateBinding";

		// Token: 0x040057DD RID: 22493
		private static IntPtr _ClassPtr;

		// Token: 0x040057DE RID: 22494
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040057DF RID: 22495
		internal static int __PropertyOffset_InputActionDelegateBindings;

		// Token: 0x040057E0 RID: 22496
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBlueprintInputActionDelegateBinding> _InputActionDelegateBindings;
	}
}
