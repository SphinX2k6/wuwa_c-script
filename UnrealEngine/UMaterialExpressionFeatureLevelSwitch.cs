using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DC3 RID: 3523
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionFeatureLevelSwitch")]
	[UnrealStructLayout(528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 528)]
	public class UMaterialExpressionFeatureLevelSwitch : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF27 RID: 48935 RVA: 0x00112082 File Offset: 0x00110282
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionFeatureLevelSwitch._ClassPtr;
		}

		// Token: 0x0600BF28 RID: 48936 RVA: 0x00112090 File Offset: 0x00110290
		public UMaterialExpressionFeatureLevelSwitch() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFeatureLevelSwitch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF29 RID: 48937 RVA: 0x001120B8 File Offset: 0x001102B8
		public UMaterialExpressionFeatureLevelSwitch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFeatureLevelSwitch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C4E RID: 11342
		// (get) Token: 0x0600BF2A RID: 48938 RVA: 0x001120EC File Offset: 0x001102EC
		// (set) Token: 0x0600BF2B RID: 48939 RVA: 0x00112125 File Offset: 0x00110325
		public FExpressionInput Default
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Default) == null)
				{
					result = (this._Default = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFeatureLevelSwitch.__PropertyOffset_Default, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFeatureLevelSwitch.__PropertyOffset_Default, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BF2C RID: 48940 RVA: 0x00112146 File Offset: 0x00110346
		static UMaterialExpressionFeatureLevelSwitch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionFeatureLevelSwitch");
		}

		// Token: 0x0600BF2D RID: 48941 RVA: 0x00112154 File Offset: 0x00110354
		protected UMaterialExpressionFeatureLevelSwitch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006527 RID: 25895
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionFeatureLevelSwitch";

		// Token: 0x04006528 RID: 25896
		private static IntPtr _ClassPtr;

		// Token: 0x04006529 RID: 25897
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400652A RID: 25898
		internal static int __PropertyOffset_Default;

		// Token: 0x0400652B RID: 25899
		[Nullable(2)]
		private FExpressionInput _Default;
	}
}
