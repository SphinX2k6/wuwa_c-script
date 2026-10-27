using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004D8 RID: 1240
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRigValidator")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UControlRigValidator : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600427A RID: 17018 RVA: 0x00063535 File Offset: 0x00061735
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlRigValidator._ClassPtr;
		}

		// Token: 0x0600427B RID: 17019 RVA: 0x00063544 File Offset: 0x00061744
		public UControlRigValidator() : this(BuiltinUtils.AllocNativeUObject(UControlRigValidator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x0006356C File Offset: 0x0006176C
		public UControlRigValidator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UControlRigValidator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x0600427D RID: 17021 RVA: 0x000635A0 File Offset: 0x000617A0
		// (set) Token: 0x0600427E RID: 17022 RVA: 0x000635D9 File Offset: 0x000617D9
		public TArray<UControlRigValidationPass> Passes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UControlRigValidationPass> result;
				if ((result = this._Passes) == null)
				{
					result = (this._Passes = new TArray<UControlRigValidationPass>(base.NativePtr + (IntPtr)UControlRigValidator.__PropertyOffset_Passes, this));
				}
				return result;
			}
			set
			{
				this.Passes.CopyAssign(value);
			}
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x000635E7 File Offset: 0x000617E7
		static UControlRigValidator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigValidator");
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x000635F5 File Offset: 0x000617F5
		protected UControlRigValidator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F97 RID: 8087
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigValidator";

		// Token: 0x04001F98 RID: 8088
		private static IntPtr _ClassPtr;

		// Token: 0x04001F99 RID: 8089
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001F9A RID: 8090
		internal static int __PropertyOffset_Passes;

		// Token: 0x04001F9B RID: 8091
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UControlRigValidationPass> _Passes;
	}
}
