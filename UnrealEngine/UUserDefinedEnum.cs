using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001219 RID: 4633
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.UserDefinedEnum")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UUserDefinedEnum : UEnum, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060110DE RID: 69854 RVA: 0x00190600 File Offset: 0x0018E800
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUserDefinedEnum._ClassPtr;
		}

		// Token: 0x060110DF RID: 69855 RVA: 0x0019060C File Offset: 0x0018E80C
		public UUserDefinedEnum() : this(BuiltinUtils.AllocNativeUObject(UUserDefinedEnum.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060110E0 RID: 69856 RVA: 0x00190634 File Offset: 0x0018E834
		public UUserDefinedEnum(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUserDefinedEnum.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004292 RID: 17042
		// (get) Token: 0x060110E1 RID: 69857 RVA: 0x00190668 File Offset: 0x0018E868
		// (set) Token: 0x060110E2 RID: 69858 RVA: 0x001906A1 File Offset: 0x0018E8A1
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

		// Token: 0x060110E3 RID: 69859 RVA: 0x001906AF File Offset: 0x0018E8AF
		static UUserDefinedEnum()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.UserDefinedEnum");
		}

		// Token: 0x060110E4 RID: 69860 RVA: 0x001906BD File Offset: 0x0018E8BD
		protected UUserDefinedEnum(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400920E RID: 37390
		public new const string __ObjectPath = "/Script/Engine.UserDefinedEnum";

		// Token: 0x0400920F RID: 37391
		private static IntPtr _ClassPtr;

		// Token: 0x04009210 RID: 37392
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009211 RID: 37393
		internal static int __PropertyOffset_DisplayNameMap;

		// Token: 0x04009212 RID: 37394
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FText> _DisplayNameMap;
	}
}
