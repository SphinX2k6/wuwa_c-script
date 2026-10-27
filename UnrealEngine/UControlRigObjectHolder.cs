using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004CD RID: 1229
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRigObjectHolder")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UControlRigObjectHolder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004222 RID: 16930 RVA: 0x00062E15 File Offset: 0x00061015
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlRigObjectHolder._ClassPtr;
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x00062E24 File Offset: 0x00061024
		public UControlRigObjectHolder() : this(BuiltinUtils.AllocNativeUObject(UControlRigObjectHolder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x00062E4C File Offset: 0x0006104C
		public UControlRigObjectHolder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UControlRigObjectHolder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06004225 RID: 16933 RVA: 0x00062E80 File Offset: 0x00061080
		// (set) Token: 0x06004226 RID: 16934 RVA: 0x00062EB9 File Offset: 0x000610B9
		public TArray<UObject> Objects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._Objects) == null)
				{
					result = (this._Objects = new TArray<UObject>(base.NativePtr + (IntPtr)UControlRigObjectHolder.__PropertyOffset_Objects, this));
				}
				return result;
			}
			set
			{
				this.Objects.CopyAssign(value);
			}
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x00062EC7 File Offset: 0x000610C7
		static UControlRigObjectHolder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigObjectHolder");
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x00062ED5 File Offset: 0x000610D5
		protected UControlRigObjectHolder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F6E RID: 8046
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigObjectHolder";

		// Token: 0x04001F6F RID: 8047
		private static IntPtr _ClassPtr;

		// Token: 0x04001F70 RID: 8048
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001F71 RID: 8049
		internal static int __PropertyOffset_Objects;

		// Token: 0x04001F72 RID: 8050
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _Objects;
	}
}
