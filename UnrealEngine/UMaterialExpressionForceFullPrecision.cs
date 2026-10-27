using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DCB RID: 3531
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionForceFullPrecision")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionForceFullPrecision : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF6F RID: 49007 RVA: 0x00112939 File Offset: 0x00110B39
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionForceFullPrecision._ClassPtr;
		}

		// Token: 0x0600BF70 RID: 49008 RVA: 0x00112948 File Offset: 0x00110B48
		public UMaterialExpressionForceFullPrecision() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionForceFullPrecision.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF71 RID: 49009 RVA: 0x00112970 File Offset: 0x00110B70
		public UMaterialExpressionForceFullPrecision(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionForceFullPrecision.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C5E RID: 11358
		// (get) Token: 0x0600BF72 RID: 49010 RVA: 0x001129A4 File Offset: 0x00110BA4
		// (set) Token: 0x0600BF73 RID: 49011 RVA: 0x001129DD File Offset: 0x00110BDD
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionForceFullPrecision.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionForceFullPrecision.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BF74 RID: 49012 RVA: 0x001129FE File Offset: 0x00110BFE
		static UMaterialExpressionForceFullPrecision()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionForceFullPrecision");
		}

		// Token: 0x0600BF75 RID: 49013 RVA: 0x00112A0C File Offset: 0x00110C0C
		protected UMaterialExpressionForceFullPrecision(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400655A RID: 25946
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionForceFullPrecision";

		// Token: 0x0400655B RID: 25947
		private static IntPtr _ClassPtr;

		// Token: 0x0400655C RID: 25948
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400655D RID: 25949
		internal static int __PropertyOffset_A;

		// Token: 0x0400655E RID: 25950
		[Nullable(2)]
		private FExpressionInput _A;
	}
}
