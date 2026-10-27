using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E0B RID: 3595
	[UnrealObjectPath("/Script/Engine.MaterialExpressionParticleMacroUV")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionParticleMacroUV : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C220 RID: 49696 RVA: 0x00117CA2 File Offset: 0x00115EA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionParticleMacroUV._ClassPtr;
		}

		// Token: 0x0600C221 RID: 49697 RVA: 0x00117CB0 File Offset: 0x00115EB0
		public UMaterialExpressionParticleMacroUV() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleMacroUV.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C222 RID: 49698 RVA: 0x00117CD8 File Offset: 0x00115ED8
		[NullableContext(1)]
		public UMaterialExpressionParticleMacroUV(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleMacroUV.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C223 RID: 49699 RVA: 0x00117D0B File Offset: 0x00115F0B
		static UMaterialExpressionParticleMacroUV()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionParticleMacroUV");
		}

		// Token: 0x0600C224 RID: 49700 RVA: 0x00117D19 File Offset: 0x00115F19
		protected UMaterialExpressionParticleMacroUV(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400674C RID: 26444
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionParticleMacroUV";

		// Token: 0x0400674D RID: 26445
		private static IntPtr _ClassPtr;

		// Token: 0x0400674E RID: 26446
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
