using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E06 RID: 3590
	[UnrealObjectPath("/Script/Engine.MaterialExpressionOriginLocation")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionOriginLocation : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C1F5 RID: 49653 RVA: 0x00117839 File Offset: 0x00115A39
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionOriginLocation._ClassPtr;
		}

		// Token: 0x0600C1F6 RID: 49654 RVA: 0x00117848 File Offset: 0x00115A48
		public UMaterialExpressionOriginLocation() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionOriginLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C1F7 RID: 49655 RVA: 0x00117870 File Offset: 0x00115A70
		[NullableContext(1)]
		public UMaterialExpressionOriginLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionOriginLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C1F8 RID: 49656 RVA: 0x001178A3 File Offset: 0x00115AA3
		static UMaterialExpressionOriginLocation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionOriginLocation");
		}

		// Token: 0x0600C1F9 RID: 49657 RVA: 0x001178B1 File Offset: 0x00115AB1
		protected UMaterialExpressionOriginLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006731 RID: 26417
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionOriginLocation";

		// Token: 0x04006732 RID: 26418
		private static IntPtr _ClassPtr;

		// Token: 0x04006733 RID: 26419
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
