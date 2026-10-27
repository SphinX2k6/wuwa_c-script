using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E13 RID: 3603
	[UnrealObjectPath("/Script/Engine.MaterialExpressionParticleSubUV")]
	[UnrealStructLayout(560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class UMaterialExpressionParticleSubUV : UMaterialExpressionTextureSample, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C248 RID: 49736 RVA: 0x001180A2 File Offset: 0x001162A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionParticleSubUV._ClassPtr;
		}

		// Token: 0x0600C249 RID: 49737 RVA: 0x001180B0 File Offset: 0x001162B0
		public UMaterialExpressionParticleSubUV() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleSubUV.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C24A RID: 49738 RVA: 0x001180D8 File Offset: 0x001162D8
		[NullableContext(1)]
		public UMaterialExpressionParticleSubUV(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleSubUV.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x0600C24B RID: 49739 RVA: 0x0011810B File Offset: 0x0011630B
		// (set) Token: 0x0600C24C RID: 49740 RVA: 0x00118124 File Offset: 0x00116324
		public unsafe bool bBlend
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionParticleSubUV.__PropertyOffset_bBlend) & UMaterialExpressionParticleSubUV.__PropertyMask_bBlend) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionParticleSubUV.__PropertyOffset_bBlend) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionParticleSubUV.__PropertyOffset_bBlend) & ~UMaterialExpressionParticleSubUV.__PropertyMask_bBlend) | (value ? UMaterialExpressionParticleSubUV.__PropertyMask_bBlend : 0));
			}
		}

		// Token: 0x0600C24D RID: 49741 RVA: 0x00118154 File Offset: 0x00116354
		static UMaterialExpressionParticleSubUV()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionParticleSubUV");
		}

		// Token: 0x0600C24E RID: 49742 RVA: 0x00118162 File Offset: 0x00116362
		protected UMaterialExpressionParticleSubUV(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006764 RID: 26468
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionParticleSubUV";

		// Token: 0x04006765 RID: 26469
		private static IntPtr _ClassPtr;

		// Token: 0x04006766 RID: 26470
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006767 RID: 26471
		internal static int __PropertyOffset_bBlend;

		// Token: 0x04006768 RID: 26472
		internal static byte __PropertyMask_bBlend;
	}
}
