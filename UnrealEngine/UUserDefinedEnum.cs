using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002AA RID: 682
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.UserDefinedEnum")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UUserDefinedEnum : UEnum, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004A19 RID: 18969 RVA: 0x00067C83 File Offset: 0x00065E83
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUserDefinedEnum._ClassPtr;
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x00067C90 File Offset: 0x00065E90
		public UUserDefinedEnum() : this(BuiltinUtils.AllocNativeUObject(UUserDefinedEnum.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x00067CB8 File Offset: 0x00065EB8
		public UUserDefinedEnum(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUserDefinedEnum.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06004A1C RID: 18972 RVA: 0x00067CEC File Offset: 0x00065EEC
		// (set) Token: 0x06004A1D RID: 18973 RVA: 0x00067D25 File Offset: 0x00065F25
		public TMap<FName, FText> DisplayNameMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FText> result;
				if ((result = this._DisplayNameMap) == null)
				{
					result = (this._DisplayNameMap = new TMap<FName, FText>(base.NativePtr + (IntPtr)UUserDefinedEnum.__PropertyOffset_DisplayNameMap, this));
				}
				return result;
			}
			set
			{
				this.DisplayNameMap.CopyAssign(value);
			}
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x00067D33 File Offset: 0x00065F33
		static UUserDefinedEnum()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.UserDefinedEnum");
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x00067D41 File Offset: 0x00065F41
		protected UUserDefinedEnum(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D30 RID: 7472
		public new const string __ObjectPath = "/Script/Engine.UserDefinedEnum";

		// Token: 0x04001D31 RID: 7473
		private static IntPtr _ClassPtr;

		// Token: 0x04001D32 RID: 7474
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D33 RID: 7475
		internal static int __PropertyOffset_DisplayNameMap;

		// Token: 0x04001D34 RID: 7476
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FText> _DisplayNameMap;
	}
}
