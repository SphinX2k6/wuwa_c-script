using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C3C RID: 3132
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HLODRebuildPolicy")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UHLODRebuildPolicy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009EB6 RID: 40630 RVA: 0x000E1912 File Offset: 0x000DFB12
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHLODRebuildPolicy._ClassPtr;
		}

		// Token: 0x170025E9 RID: 9705
		// (get) Token: 0x06009EB7 RID: 40631 RVA: 0x000E1920 File Offset: 0x000DFB20
		// (set) Token: 0x06009EB8 RID: 40632 RVA: 0x000E1959 File Offset: 0x000DFB59
		public TArray<FSoftObjectPath> HLODRebuildPolicies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._HLODRebuildPolicies) == null)
				{
					result = (this._HLODRebuildPolicies = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)UHLODRebuildPolicy.__PropertyOffset_HLODRebuildPolicies, this));
				}
				return result;
			}
			set
			{
				this.HLODRebuildPolicies.CopyAssign(value);
			}
		}

		// Token: 0x06009EB9 RID: 40633 RVA: 0x000E1967 File Offset: 0x000DFB67
		static UHLODRebuildPolicy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODRebuildPolicy");
		}

		// Token: 0x06009EBA RID: 40634 RVA: 0x000E1978 File Offset: 0x000DFB78
		protected UHLODRebuildPolicy() : this(BuiltinUtils.AllocNativeUObject(UHLODRebuildPolicy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009EBB RID: 40635 RVA: 0x000E19A0 File Offset: 0x000DFBA0
		protected UHLODRebuildPolicy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400577B RID: 22395
		public new const string __ObjectPath = "/Script/Engine.HLODRebuildPolicy";

		// Token: 0x0400577C RID: 22396
		private static IntPtr _ClassPtr;

		// Token: 0x0400577D RID: 22397
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400577E RID: 22398
		internal static int __PropertyOffset_HLODRebuildPolicies;

		// Token: 0x0400577F RID: 22399
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _HLODRebuildPolicies;
	}
}
