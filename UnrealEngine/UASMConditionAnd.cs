using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000821 RID: 2081
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.ASMConditionAnd")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UASMConditionAnd : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B5FC RID: 46588 RVA: 0x00121775 File Offset: 0x0011F975
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UASMConditionAnd._ClassPtr;
		}

		// Token: 0x0600B5FD RID: 46589 RVA: 0x00121784 File Offset: 0x0011F984
		public UASMConditionAnd() : this(BuiltinUtils.AllocNativeUObject(UASMConditionAnd.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B5FE RID: 46590 RVA: 0x001217AC File Offset: 0x0011F9AC
		public UASMConditionAnd(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UASMConditionAnd.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x0600B5FF RID: 46591 RVA: 0x001217E0 File Offset: 0x0011F9E0
		// (set) Token: 0x0600B600 RID: 46592 RVA: 0x00121819 File Offset: 0x0011FA19
		public TArray<UASMConditionBase> Conditions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UASMConditionBase> result;
				if ((result = this._Conditions) == null)
				{
					result = (this._Conditions = new TArray<UASMConditionBase>(base.NativePtr + (IntPtr)UASMConditionAnd.__PropertyOffset_Conditions, this));
				}
				return result;
			}
			set
			{
				this.Conditions.CopyAssign(value);
			}
		}

		// Token: 0x0600B601 RID: 46593 RVA: 0x00121827 File Offset: 0x0011FA27
		static UASMConditionAnd()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.ASMConditionAnd");
		}

		// Token: 0x0600B602 RID: 46594 RVA: 0x00121835 File Offset: 0x0011FA35
		protected UASMConditionAnd(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400523A RID: 21050
		public new const string __ObjectPath = "/Script/SMSystem.ASMConditionAnd";

		// Token: 0x0400523B RID: 21051
		private static IntPtr _ClassPtr;

		// Token: 0x0400523C RID: 21052
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400523D RID: 21053
		internal static int __PropertyOffset_Conditions;

		// Token: 0x0400523E RID: 21054
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UASMConditionBase> _Conditions;
	}
}
