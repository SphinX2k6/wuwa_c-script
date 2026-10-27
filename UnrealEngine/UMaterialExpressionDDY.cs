using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DAE RID: 3502
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDDY")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionDDY : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE7E RID: 48766 RVA: 0x00110D4D File Offset: 0x0010EF4D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDDY._ClassPtr;
		}

		// Token: 0x0600BE7F RID: 48767 RVA: 0x00110D5C File Offset: 0x0010EF5C
		public UMaterialExpressionDDY() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDDY.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE80 RID: 48768 RVA: 0x00110D84 File Offset: 0x0010EF84
		public UMaterialExpressionDDY(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDDY.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C2E RID: 11310
		// (get) Token: 0x0600BE81 RID: 48769 RVA: 0x00110DB8 File Offset: 0x0010EFB8
		// (set) Token: 0x0600BE82 RID: 48770 RVA: 0x00110DF1 File Offset: 0x0010EFF1
		public FExpressionInput Value
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDDY.__PropertyOffset_Value, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDDY.__PropertyOffset_Value, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BE83 RID: 48771 RVA: 0x00110E12 File Offset: 0x0010F012
		static UMaterialExpressionDDY()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDDY");
		}

		// Token: 0x0600BE84 RID: 48772 RVA: 0x00110E20 File Offset: 0x0010F020
		protected UMaterialExpressionDDY(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064B4 RID: 25780
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDDY";

		// Token: 0x040064B5 RID: 25781
		private static IntPtr _ClassPtr;

		// Token: 0x040064B6 RID: 25782
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040064B7 RID: 25783
		internal static int __PropertyOffset_Value;

		// Token: 0x040064B8 RID: 25784
		[Nullable(2)]
		private FExpressionInput _Value;
	}
}
