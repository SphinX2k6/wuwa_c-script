using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C53 RID: 3155
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputAxisKeyDelegateBinding")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UInputAxisKeyDelegateBinding : UInputDelegateBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009FF5 RID: 40949 RVA: 0x000E354E File Offset: 0x000E174E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputAxisKeyDelegateBinding._ClassPtr;
		}

		// Token: 0x06009FF6 RID: 40950 RVA: 0x000E355C File Offset: 0x000E175C
		public UInputAxisKeyDelegateBinding() : this(BuiltinUtils.AllocNativeUObject(UInputAxisKeyDelegateBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009FF7 RID: 40951 RVA: 0x000E3584 File Offset: 0x000E1784
		public UInputAxisKeyDelegateBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInputAxisKeyDelegateBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x06009FF8 RID: 40952 RVA: 0x000E35B8 File Offset: 0x000E17B8
		// (set) Token: 0x06009FF9 RID: 40953 RVA: 0x000E35F1 File Offset: 0x000E17F1
		public TArray<FBlueprintInputAxisKeyDelegateBinding> InputAxisKeyDelegateBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBlueprintInputAxisKeyDelegateBinding> result;
				if ((result = this._InputAxisKeyDelegateBindings) == null)
				{
					result = (this._InputAxisKeyDelegateBindings = new TArray<FBlueprintInputAxisKeyDelegateBinding>(base.NativePtr + (IntPtr)UInputAxisKeyDelegateBinding.__PropertyOffset_InputAxisKeyDelegateBindings, this));
				}
				return result;
			}
			set
			{
				this.InputAxisKeyDelegateBindings.CopyAssign(value);
			}
		}

		// Token: 0x06009FFA RID: 40954 RVA: 0x000E35FF File Offset: 0x000E17FF
		static UInputAxisKeyDelegateBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InputAxisKeyDelegateBinding");
		}

		// Token: 0x06009FFB RID: 40955 RVA: 0x000E360D File Offset: 0x000E180D
		protected UInputAxisKeyDelegateBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005805 RID: 22533
		public new const string __ObjectPath = "/Script/Engine.InputAxisKeyDelegateBinding";

		// Token: 0x04005806 RID: 22534
		private static IntPtr _ClassPtr;

		// Token: 0x04005807 RID: 22535
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005808 RID: 22536
		internal static int __PropertyOffset_InputAxisKeyDelegateBindings;

		// Token: 0x04005809 RID: 22537
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBlueprintInputAxisKeyDelegateBinding> _InputAxisKeyDelegateBindings;
	}
}
