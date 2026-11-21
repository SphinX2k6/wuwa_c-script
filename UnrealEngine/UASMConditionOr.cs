using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000823 RID: 2083
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.ASMConditionOr")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UASMConditionOr : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B609 RID: 46601 RVA: 0x001218AD File Offset: 0x0011FAAD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UASMConditionOr._ClassPtr;
		}

		// Token: 0x0600B60A RID: 46602 RVA: 0x001218BC File Offset: 0x0011FABC
		public UASMConditionOr() : this(BuiltinUtils.AllocNativeUObject(UASMConditionOr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B60B RID: 46603 RVA: 0x001218E4 File Offset: 0x0011FAE4
		public UASMConditionOr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UASMConditionOr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002216 RID: 8726
		// (get) Token: 0x0600B60C RID: 46604 RVA: 0x00121918 File Offset: 0x0011FB18
		// (set) Token: 0x0600B60D RID: 46605 RVA: 0x00121951 File Offset: 0x0011FB51
		public TArray<UASMConditionBase> Conditions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UASMConditionBase> result;
				if ((result = this._Conditions) == null)
				{
					result = (this._Conditions = new TArray<UASMConditionBase>(base.NativePtr + (IntPtr)UASMConditionOr.__PropertyOffset_Conditions, this));
				}
				return result;
			}
			set
			{
				this.Conditions.CopyAssign(value);
			}
		}

		// Token: 0x0600B60E RID: 46606 RVA: 0x0012195F File Offset: 0x0011FB5F
		static UASMConditionOr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.ASMConditionOr");
		}

		// Token: 0x0600B60F RID: 46607 RVA: 0x0012196D File Offset: 0x0011FB6D
		protected UASMConditionOr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005243 RID: 21059
		public new const string __ObjectPath = "/Script/SMSystem.ASMConditionOr";

		// Token: 0x04005244 RID: 21060
		private static IntPtr _ClassPtr;

		// Token: 0x04005245 RID: 21061
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005246 RID: 21062
		internal static int __PropertyOffset_Conditions;

		// Token: 0x04005247 RID: 21063
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UASMConditionBase> _Conditions;
	}
}
