using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DB9 RID: 3513
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDistanceFieldGradient")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionDistanceFieldGradient : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BED5 RID: 48853 RVA: 0x00111736 File Offset: 0x0010F936
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDistanceFieldGradient._ClassPtr;
		}

		// Token: 0x0600BED6 RID: 48854 RVA: 0x00111744 File Offset: 0x0010F944
		public UMaterialExpressionDistanceFieldGradient() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDistanceFieldGradient.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BED7 RID: 48855 RVA: 0x0011176C File Offset: 0x0010F96C
		public UMaterialExpressionDistanceFieldGradient(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDistanceFieldGradient.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C3E RID: 11326
		// (get) Token: 0x0600BED8 RID: 48856 RVA: 0x001117A0 File Offset: 0x0010F9A0
		// (set) Token: 0x0600BED9 RID: 48857 RVA: 0x001117D9 File Offset: 0x0010F9D9
		public FExpressionInput Position
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Position) == null)
				{
					result = (this._Position = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDistanceFieldGradient.__PropertyOffset_Position, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDistanceFieldGradient.__PropertyOffset_Position, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BEDA RID: 48858 RVA: 0x001117FA File Offset: 0x0010F9FA
		static UMaterialExpressionDistanceFieldGradient()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDistanceFieldGradient");
		}

		// Token: 0x0600BEDB RID: 48859 RVA: 0x00111808 File Offset: 0x0010FA08
		protected UMaterialExpressionDistanceFieldGradient(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064EF RID: 25839
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDistanceFieldGradient";

		// Token: 0x040064F0 RID: 25840
		private static IntPtr _ClassPtr;

		// Token: 0x040064F1 RID: 25841
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040064F2 RID: 25842
		internal static int __PropertyOffset_Position;

		// Token: 0x040064F3 RID: 25843
		[Nullable(2)]
		private FExpressionInput _Position;
	}
}
