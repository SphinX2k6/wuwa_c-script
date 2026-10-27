using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DFE RID: 3582
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionNoForceFullPrecision")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionNoForceFullPrecision : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C1AF RID: 49583 RVA: 0x001170D0 File Offset: 0x001152D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionNoForceFullPrecision._ClassPtr;
		}

		// Token: 0x0600C1B0 RID: 49584 RVA: 0x001170DC File Offset: 0x001152DC
		public UMaterialExpressionNoForceFullPrecision() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionNoForceFullPrecision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C1B1 RID: 49585 RVA: 0x00117104 File Offset: 0x00115304
		public UMaterialExpressionNoForceFullPrecision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionNoForceFullPrecision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CFF RID: 11519
		// (get) Token: 0x0600C1B2 RID: 49586 RVA: 0x00117138 File Offset: 0x00115338
		// (set) Token: 0x0600C1B3 RID: 49587 RVA: 0x00117171 File Offset: 0x00115371
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionNoForceFullPrecision.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionNoForceFullPrecision.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C1B4 RID: 49588 RVA: 0x00117192 File Offset: 0x00115392
		static UMaterialExpressionNoForceFullPrecision()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionNoForceFullPrecision");
		}

		// Token: 0x0600C1B5 RID: 49589 RVA: 0x001171A0 File Offset: 0x001153A0
		protected UMaterialExpressionNoForceFullPrecision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006703 RID: 26371
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionNoForceFullPrecision";

		// Token: 0x04006704 RID: 26372
		private static IntPtr _ClassPtr;

		// Token: 0x04006705 RID: 26373
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006706 RID: 26374
		internal static int __PropertyOffset_A;

		// Token: 0x04006707 RID: 26375
		[Nullable(2)]
		private FExpressionInput _A;
	}
}
