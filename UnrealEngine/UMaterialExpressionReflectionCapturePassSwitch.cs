using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E26 RID: 3622
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionReflectionCapturePassSwitch")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionReflectionCapturePassSwitch : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C2D5 RID: 49877 RVA: 0x001190CA File Offset: 0x001172CA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionReflectionCapturePassSwitch._ClassPtr;
		}

		// Token: 0x0600C2D6 RID: 49878 RVA: 0x001190D8 File Offset: 0x001172D8
		public UMaterialExpressionReflectionCapturePassSwitch() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionReflectionCapturePassSwitch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C2D7 RID: 49879 RVA: 0x00119100 File Offset: 0x00117300
		public UMaterialExpressionReflectionCapturePassSwitch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionReflectionCapturePassSwitch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x0600C2D8 RID: 49880 RVA: 0x00119134 File Offset: 0x00117334
		// (set) Token: 0x0600C2D9 RID: 49881 RVA: 0x0011916D File Offset: 0x0011736D
		public FExpressionInput Default
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Default) == null)
				{
					result = (this._Default = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionReflectionCapturePassSwitch.__PropertyOffset_Default, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionReflectionCapturePassSwitch.__PropertyOffset_Default, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x0600C2DA RID: 49882 RVA: 0x00119190 File Offset: 0x00117390
		// (set) Token: 0x0600C2DB RID: 49883 RVA: 0x001191C9 File Offset: 0x001173C9
		public FExpressionInput Reflection
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Reflection) == null)
				{
					result = (this._Reflection = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionReflectionCapturePassSwitch.__PropertyOffset_Reflection, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionReflectionCapturePassSwitch.__PropertyOffset_Reflection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C2DC RID: 49884 RVA: 0x001191EA File Offset: 0x001173EA
		static UMaterialExpressionReflectionCapturePassSwitch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionReflectionCapturePassSwitch");
		}

		// Token: 0x0600C2DD RID: 49885 RVA: 0x001191F8 File Offset: 0x001173F8
		protected UMaterialExpressionReflectionCapturePassSwitch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040067C5 RID: 26565
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionReflectionCapturePassSwitch";

		// Token: 0x040067C6 RID: 26566
		private static IntPtr _ClassPtr;

		// Token: 0x040067C7 RID: 26567
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040067C8 RID: 26568
		internal static int __PropertyOffset_Default;

		// Token: 0x040067C9 RID: 26569
		[Nullable(2)]
		private FExpressionInput _Default;

		// Token: 0x040067CA RID: 26570
		internal static int __PropertyOffset_Reflection;

		// Token: 0x040067CB RID: 26571
		[Nullable(2)]
		private FExpressionInput _Reflection;
	}
}
