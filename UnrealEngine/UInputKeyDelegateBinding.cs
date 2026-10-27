using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C5B RID: 3163
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputKeyDelegateBinding")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UInputKeyDelegateBinding : UInputDelegateBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A05C RID: 41052 RVA: 0x000E3D45 File Offset: 0x000E1F45
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInputKeyDelegateBinding._ClassPtr;
		}

		// Token: 0x0600A05D RID: 41053 RVA: 0x000E3D54 File Offset: 0x000E1F54
		public UInputKeyDelegateBinding() : this(BuiltinUtils.AllocNativeUObject(UInputKeyDelegateBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A05E RID: 41054 RVA: 0x000E3D7C File Offset: 0x000E1F7C
		public UInputKeyDelegateBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInputKeyDelegateBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700262E RID: 9774
		// (get) Token: 0x0600A05F RID: 41055 RVA: 0x000E3DB0 File Offset: 0x000E1FB0
		// (set) Token: 0x0600A060 RID: 41056 RVA: 0x000E3DE9 File Offset: 0x000E1FE9
		public TArray<FBlueprintInputKeyDelegateBinding> InputKeyDelegateBindings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBlueprintInputKeyDelegateBinding> result;
				if ((result = this._InputKeyDelegateBindings) == null)
				{
					result = (this._InputKeyDelegateBindings = new TArray<FBlueprintInputKeyDelegateBinding>(base.NativePtr + (IntPtr)UInputKeyDelegateBinding.__PropertyOffset_InputKeyDelegateBindings, this));
				}
				return result;
			}
			set
			{
				this.InputKeyDelegateBindings.CopyAssign(value);
			}
		}

		// Token: 0x0600A061 RID: 41057 RVA: 0x000E3DF7 File Offset: 0x000E1FF7
		static UInputKeyDelegateBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InputKeyDelegateBinding");
		}

		// Token: 0x0600A062 RID: 41058 RVA: 0x000E3E05 File Offset: 0x000E2005
		protected UInputKeyDelegateBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400582D RID: 22573
		public new const string __ObjectPath = "/Script/Engine.InputKeyDelegateBinding";

		// Token: 0x0400582E RID: 22574
		private static IntPtr _ClassPtr;

		// Token: 0x0400582F RID: 22575
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005830 RID: 22576
		internal static int __PropertyOffset_InputKeyDelegateBindings;

		// Token: 0x04005831 RID: 22577
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBlueprintInputKeyDelegateBinding> _InputKeyDelegateBindings;
	}
}
