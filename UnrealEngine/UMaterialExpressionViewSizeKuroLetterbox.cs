using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E7B RID: 3707
	[UnrealObjectPath("/Script/Engine.MaterialExpressionViewSizeKuroLetterbox")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionViewSizeKuroLetterbox : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5F6 RID: 50678 RVA: 0x0011EB8A File Offset: 0x0011CD8A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionViewSizeKuroLetterbox._ClassPtr;
		}

		// Token: 0x0600C5F7 RID: 50679 RVA: 0x0011EB98 File Offset: 0x0011CD98
		public UMaterialExpressionViewSizeKuroLetterbox() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionViewSizeKuroLetterbox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5F8 RID: 50680 RVA: 0x0011EBC0 File Offset: 0x0011CDC0
		[NullableContext(1)]
		public UMaterialExpressionViewSizeKuroLetterbox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionViewSizeKuroLetterbox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C5F9 RID: 50681 RVA: 0x0011EBF3 File Offset: 0x0011CDF3
		static UMaterialExpressionViewSizeKuroLetterbox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionViewSizeKuroLetterbox");
		}

		// Token: 0x0600C5FA RID: 50682 RVA: 0x0011EC01 File Offset: 0x0011CE01
		protected UMaterialExpressionViewSizeKuroLetterbox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069EE RID: 27118
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionViewSizeKuroLetterbox";

		// Token: 0x040069EF RID: 27119
		private static IntPtr _ClassPtr;

		// Token: 0x040069F0 RID: 27120
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
