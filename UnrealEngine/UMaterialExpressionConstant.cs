using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DA1 RID: 3489
	[UnrealObjectPath("/Script/Engine.MaterialExpressionConstant")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UMaterialExpressionConstant : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE0C RID: 48652 RVA: 0x00110121 File Offset: 0x0010E321
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionConstant._ClassPtr;
		}

		// Token: 0x0600BE0D RID: 48653 RVA: 0x00110130 File Offset: 0x0010E330
		public UMaterialExpressionConstant() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionConstant.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE0E RID: 48654 RVA: 0x00110158 File Offset: 0x0010E358
		[NullableContext(1)]
		public UMaterialExpressionConstant(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionConstant.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x0600BE0F RID: 48655 RVA: 0x0011018B File Offset: 0x0010E38B
		// (set) Token: 0x0600BE10 RID: 48656 RVA: 0x0011019B File Offset: 0x0010E39B
		public unsafe float R
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionConstant.__PropertyOffset_R);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionConstant.__PropertyOffset_R) = value;
			}
		}

		// Token: 0x0600BE11 RID: 48657 RVA: 0x001101AC File Offset: 0x0010E3AC
		static UMaterialExpressionConstant()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionConstant");
		}

		// Token: 0x0600BE12 RID: 48658 RVA: 0x001101BA File Offset: 0x0010E3BA
		protected UMaterialExpressionConstant(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006468 RID: 25704
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionConstant";

		// Token: 0x04006469 RID: 25705
		private static IntPtr _ClassPtr;

		// Token: 0x0400646A RID: 25706
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400646B RID: 25707
		internal static int __PropertyOffset_R;
	}
}
