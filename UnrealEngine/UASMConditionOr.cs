using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002868 RID: 10344
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.ASMConditionOr")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UASMConditionOr : UASMConditionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026560 RID: 157024 RVA: 0x003A3BED File Offset: 0x003A1DED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UASMConditionOr._ClassPtr;
		}

		// Token: 0x06026561 RID: 157025 RVA: 0x003A3BFC File Offset: 0x003A1DFC
		public UASMConditionOr() : this(BuiltinUtils.AllocNativeUObject(UASMConditionOr.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026562 RID: 157026 RVA: 0x003A3C24 File Offset: 0x003A1E24
		public UASMConditionOr(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UASMConditionOr.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093F8 RID: 37880
		// (get) Token: 0x06026563 RID: 157027 RVA: 0x003A3C58 File Offset: 0x003A1E58
		// (set) Token: 0x06026564 RID: 157028 RVA: 0x003A3C91 File Offset: 0x003A1E91
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

		// Token: 0x06026565 RID: 157029 RVA: 0x003A3C9F File Offset: 0x003A1E9F
		static UASMConditionOr()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.ASMConditionOr");
		}

		// Token: 0x06026566 RID: 157030 RVA: 0x003A3CAD File Offset: 0x003A1EAD
		protected UASMConditionOr(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015057 RID: 86103
		public new const string __ObjectPath = "/Script/SMSystem.ASMConditionOr";

		// Token: 0x04015058 RID: 86104
		private static IntPtr _ClassPtr;

		// Token: 0x04015059 RID: 86105
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401505A RID: 86106
		internal static int __PropertyOffset_Conditions;

		// Token: 0x0401505B RID: 86107
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UASMConditionBase> _Conditions;
	}
}
