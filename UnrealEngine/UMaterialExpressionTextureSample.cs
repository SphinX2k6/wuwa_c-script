using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E64 RID: 3684
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTextureSample")]
	[UnrealStructLayout(552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 552)]
	public class UMaterialExpressionTextureSample : UMaterialExpressionTextureBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C54E RID: 50510 RVA: 0x0011DA3A File Offset: 0x0011BC3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTextureSample._ClassPtr;
		}

		// Token: 0x0600C54F RID: 50511 RVA: 0x0011DA48 File Offset: 0x0011BC48
		public UMaterialExpressionTextureSample() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureSample.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C550 RID: 50512 RVA: 0x0011DA70 File Offset: 0x0011BC70
		public UMaterialExpressionTextureSample(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureSample.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DD1 RID: 11729
		// (get) Token: 0x0600C551 RID: 50513 RVA: 0x0011DAA4 File Offset: 0x0011BCA4
		// (set) Token: 0x0600C552 RID: 50514 RVA: 0x0011DADD File Offset: 0x0011BCDD
		public FExpressionInput Coordinates
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Coordinates) == null)
				{
					result = (this._Coordinates = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionTextureSample.__PropertyOffset_Coordinates, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionTextureSample.__PropertyOffset_Coordinates, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C553 RID: 50515 RVA: 0x0011DAFE File Offset: 0x0011BCFE
		static UMaterialExpressionTextureSample()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTextureSample");
		}

		// Token: 0x0600C554 RID: 50516 RVA: 0x0011DB0C File Offset: 0x0011BD0C
		protected UMaterialExpressionTextureSample(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006983 RID: 27011
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTextureSample";

		// Token: 0x04006984 RID: 27012
		private static IntPtr _ClassPtr;

		// Token: 0x04006985 RID: 27013
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006986 RID: 27014
		internal static int __PropertyOffset_Coordinates;

		// Token: 0x04006987 RID: 27015
		[Nullable(2)]
		private FExpressionInput _Coordinates;
	}
}
