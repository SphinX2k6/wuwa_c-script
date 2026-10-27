using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DA2 RID: 3490
	[UnrealObjectPath("/Script/Engine.MaterialExpressionConstant2Vector")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UMaterialExpressionConstant2Vector : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE13 RID: 48659 RVA: 0x001101C3 File Offset: 0x0010E3C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionConstant2Vector._ClassPtr;
		}

		// Token: 0x0600BE14 RID: 48660 RVA: 0x001101D0 File Offset: 0x0010E3D0
		public UMaterialExpressionConstant2Vector() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionConstant2Vector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE15 RID: 48661 RVA: 0x001101F8 File Offset: 0x0010E3F8
		[NullableContext(1)]
		public UMaterialExpressionConstant2Vector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionConstant2Vector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x0600BE16 RID: 48662 RVA: 0x0011022B File Offset: 0x0010E42B
		// (set) Token: 0x0600BE17 RID: 48663 RVA: 0x0011023B File Offset: 0x0010E43B
		public unsafe float R
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionConstant2Vector.__PropertyOffset_R);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionConstant2Vector.__PropertyOffset_R) = value;
			}
		}

		// Token: 0x17002C17 RID: 11287
		// (get) Token: 0x0600BE18 RID: 48664 RVA: 0x0011024C File Offset: 0x0010E44C
		// (set) Token: 0x0600BE19 RID: 48665 RVA: 0x0011025C File Offset: 0x0010E45C
		public unsafe float G
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionConstant2Vector.__PropertyOffset_G);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionConstant2Vector.__PropertyOffset_G) = value;
			}
		}

		// Token: 0x0600BE1A RID: 48666 RVA: 0x0011026D File Offset: 0x0010E46D
		static UMaterialExpressionConstant2Vector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionConstant2Vector");
		}

		// Token: 0x0600BE1B RID: 48667 RVA: 0x0011027B File Offset: 0x0010E47B
		protected UMaterialExpressionConstant2Vector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400646C RID: 25708
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionConstant2Vector";

		// Token: 0x0400646D RID: 25709
		private static IntPtr _ClassPtr;

		// Token: 0x0400646E RID: 25710
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400646F RID: 25711
		internal static int __PropertyOffset_R;

		// Token: 0x04006470 RID: 25712
		internal static int __PropertyOffset_G;
	}
}
