using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DD2 RID: 3538
	[UnrealObjectPath("/Script/Engine.MaterialExpressionHairAttributes")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UMaterialExpressionHairAttributes : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BFC8 RID: 49096 RVA: 0x00113399 File Offset: 0x00111599
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionHairAttributes._ClassPtr;
		}

		// Token: 0x0600BFC9 RID: 49097 RVA: 0x001133A8 File Offset: 0x001115A8
		public UMaterialExpressionHairAttributes() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionHairAttributes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BFCA RID: 49098 RVA: 0x001133D0 File Offset: 0x001115D0
		[NullableContext(1)]
		public UMaterialExpressionHairAttributes(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionHairAttributes.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x0600BFCB RID: 49099 RVA: 0x00113403 File Offset: 0x00111603
		// (set) Token: 0x0600BFCC RID: 49100 RVA: 0x0011341C File Offset: 0x0011161C
		public unsafe bool bUseTangentSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionHairAttributes.__PropertyOffset_bUseTangentSpace) & UMaterialExpressionHairAttributes.__PropertyMask_bUseTangentSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionHairAttributes.__PropertyOffset_bUseTangentSpace) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionHairAttributes.__PropertyOffset_bUseTangentSpace) & ~UMaterialExpressionHairAttributes.__PropertyMask_bUseTangentSpace) | (value ? UMaterialExpressionHairAttributes.__PropertyMask_bUseTangentSpace : 0));
			}
		}

		// Token: 0x0600BFCD RID: 49101 RVA: 0x0011344C File Offset: 0x0011164C
		static UMaterialExpressionHairAttributes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionHairAttributes");
		}

		// Token: 0x0600BFCE RID: 49102 RVA: 0x0011345A File Offset: 0x0011165A
		protected UMaterialExpressionHairAttributes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006599 RID: 26009
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionHairAttributes";

		// Token: 0x0400659A RID: 26010
		private static IntPtr _ClassPtr;

		// Token: 0x0400659B RID: 26011
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400659C RID: 26012
		internal static int __PropertyOffset_bUseTangentSpace;

		// Token: 0x0400659D RID: 26013
		internal static byte __PropertyMask_bUseTangentSpace;
	}
}
