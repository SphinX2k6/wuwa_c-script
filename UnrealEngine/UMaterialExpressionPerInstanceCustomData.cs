using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E15 RID: 3605
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPerInstanceCustomData")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionPerInstanceCustomData : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C254 RID: 49748 RVA: 0x001181EA File Offset: 0x001163EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPerInstanceCustomData._ClassPtr;
		}

		// Token: 0x0600C255 RID: 49749 RVA: 0x001181F8 File Offset: 0x001163F8
		public UMaterialExpressionPerInstanceCustomData() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPerInstanceCustomData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C256 RID: 49750 RVA: 0x00118220 File Offset: 0x00116420
		public UMaterialExpressionPerInstanceCustomData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPerInstanceCustomData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x0600C257 RID: 49751 RVA: 0x00118254 File Offset: 0x00116454
		// (set) Token: 0x0600C258 RID: 49752 RVA: 0x0011828D File Offset: 0x0011648D
		public FExpressionInput DefaultValue
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._DefaultValue) == null)
				{
					result = (this._DefaultValue = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionPerInstanceCustomData.__PropertyOffset_DefaultValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionPerInstanceCustomData.__PropertyOffset_DefaultValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x0600C259 RID: 49753 RVA: 0x001182AE File Offset: 0x001164AE
		// (set) Token: 0x0600C25A RID: 49754 RVA: 0x001182BE File Offset: 0x001164BE
		public unsafe float ConstDefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionPerInstanceCustomData.__PropertyOffset_ConstDefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionPerInstanceCustomData.__PropertyOffset_ConstDefaultValue) = value;
			}
		}

		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x0600C25B RID: 49755 RVA: 0x001182CF File Offset: 0x001164CF
		// (set) Token: 0x0600C25C RID: 49756 RVA: 0x001182DF File Offset: 0x001164DF
		public unsafe uint DataIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionPerInstanceCustomData.__PropertyOffset_DataIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionPerInstanceCustomData.__PropertyOffset_DataIndex) = (int)value;
			}
		}

		// Token: 0x0600C25D RID: 49757 RVA: 0x001182F0 File Offset: 0x001164F0
		static UMaterialExpressionPerInstanceCustomData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPerInstanceCustomData");
		}

		// Token: 0x0600C25E RID: 49758 RVA: 0x001182FE File Offset: 0x001164FE
		protected UMaterialExpressionPerInstanceCustomData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400676C RID: 26476
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPerInstanceCustomData";

		// Token: 0x0400676D RID: 26477
		private static IntPtr _ClassPtr;

		// Token: 0x0400676E RID: 26478
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400676F RID: 26479
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x04006770 RID: 26480
		[Nullable(2)]
		private FExpressionInput _DefaultValue;

		// Token: 0x04006771 RID: 26481
		internal static int __PropertyOffset_ConstDefaultValue;

		// Token: 0x04006772 RID: 26482
		internal static int __PropertyOffset_DataIndex;
	}
}
