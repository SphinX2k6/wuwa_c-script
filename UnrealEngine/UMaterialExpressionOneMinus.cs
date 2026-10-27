using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E05 RID: 3589
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionOneMinus")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionOneMinus : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C1EE RID: 49646 RVA: 0x0011775E File Offset: 0x0011595E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionOneMinus._ClassPtr;
		}

		// Token: 0x0600C1EF RID: 49647 RVA: 0x0011776C File Offset: 0x0011596C
		public UMaterialExpressionOneMinus() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionOneMinus.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C1F0 RID: 49648 RVA: 0x00117794 File Offset: 0x00115994
		public UMaterialExpressionOneMinus(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionOneMinus.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D0D RID: 11533
		// (get) Token: 0x0600C1F1 RID: 49649 RVA: 0x001177C8 File Offset: 0x001159C8
		// (set) Token: 0x0600C1F2 RID: 49650 RVA: 0x00117801 File Offset: 0x00115A01
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionOneMinus.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionOneMinus.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C1F3 RID: 49651 RVA: 0x00117822 File Offset: 0x00115A22
		static UMaterialExpressionOneMinus()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionOneMinus");
		}

		// Token: 0x0600C1F4 RID: 49652 RVA: 0x00117830 File Offset: 0x00115A30
		protected UMaterialExpressionOneMinus(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400672C RID: 26412
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionOneMinus";

		// Token: 0x0400672D RID: 26413
		private static IntPtr _ClassPtr;

		// Token: 0x0400672E RID: 26414
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400672F RID: 26415
		internal static int __PropertyOffset_Input;

		// Token: 0x04006730 RID: 26416
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
