using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E79 RID: 3705
	[UnrealObjectPath("/Script/Engine.MaterialExpressionViewProperty")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UMaterialExpressionViewProperty : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5EA RID: 50666 RVA: 0x0011EA62 File Offset: 0x0011CC62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionViewProperty._ClassPtr;
		}

		// Token: 0x0600C5EB RID: 50667 RVA: 0x0011EA70 File Offset: 0x0011CC70
		public UMaterialExpressionViewProperty() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionViewProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5EC RID: 50668 RVA: 0x0011EA98 File Offset: 0x0011CC98
		[NullableContext(1)]
		public UMaterialExpressionViewProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionViewProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x0600C5ED RID: 50669 RVA: 0x0011EACB File Offset: 0x0011CCCB
		// (set) Token: 0x0600C5EE RID: 50670 RVA: 0x0011EADF File Offset: 0x0011CCDF
		public unsafe TEnumAsByte<EMaterialExposedViewProperty> Property
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionViewProperty.__PropertyOffset_Property);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionViewProperty.__PropertyOffset_Property) = value;
			}
		}

		// Token: 0x0600C5EF RID: 50671 RVA: 0x0011EAF4 File Offset: 0x0011CCF4
		static UMaterialExpressionViewProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionViewProperty");
		}

		// Token: 0x0600C5F0 RID: 50672 RVA: 0x0011EB02 File Offset: 0x0011CD02
		protected UMaterialExpressionViewProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069E7 RID: 27111
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionViewProperty";

		// Token: 0x040069E8 RID: 27112
		private static IntPtr _ClassPtr;

		// Token: 0x040069E9 RID: 27113
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040069EA RID: 27114
		internal static int __PropertyOffset_Property;
	}
}
