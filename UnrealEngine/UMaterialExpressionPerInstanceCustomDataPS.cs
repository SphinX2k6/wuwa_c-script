using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E16 RID: 3606
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPerInstanceCustomDataPS")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionPerInstanceCustomDataPS : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C25F RID: 49759 RVA: 0x00118307 File Offset: 0x00116507
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPerInstanceCustomDataPS._ClassPtr;
		}

		// Token: 0x0600C260 RID: 49760 RVA: 0x00118314 File Offset: 0x00116514
		public UMaterialExpressionPerInstanceCustomDataPS() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPerInstanceCustomDataPS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C261 RID: 49761 RVA: 0x0011833C File Offset: 0x0011653C
		public UMaterialExpressionPerInstanceCustomDataPS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPerInstanceCustomDataPS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x0600C262 RID: 49762 RVA: 0x00118370 File Offset: 0x00116570
		// (set) Token: 0x0600C263 RID: 49763 RVA: 0x001183A9 File Offset: 0x001165A9
		public FExpressionInput DefaultValue
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._DefaultValue) == null)
				{
					result = (this._DefaultValue = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionPerInstanceCustomDataPS.__PropertyOffset_DefaultValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionPerInstanceCustomDataPS.__PropertyOffset_DefaultValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D1C RID: 11548
		// (get) Token: 0x0600C264 RID: 49764 RVA: 0x001183CA File Offset: 0x001165CA
		// (set) Token: 0x0600C265 RID: 49765 RVA: 0x001183DA File Offset: 0x001165DA
		public unsafe float ConstDefaultValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionPerInstanceCustomDataPS.__PropertyOffset_ConstDefaultValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionPerInstanceCustomDataPS.__PropertyOffset_ConstDefaultValue) = value;
			}
		}

		// Token: 0x17002D1D RID: 11549
		// (get) Token: 0x0600C266 RID: 49766 RVA: 0x001183EB File Offset: 0x001165EB
		// (set) Token: 0x0600C267 RID: 49767 RVA: 0x001183FB File Offset: 0x001165FB
		public unsafe uint DataIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionPerInstanceCustomDataPS.__PropertyOffset_DataIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionPerInstanceCustomDataPS.__PropertyOffset_DataIndex) = (int)value;
			}
		}

		// Token: 0x0600C268 RID: 49768 RVA: 0x0011840C File Offset: 0x0011660C
		static UMaterialExpressionPerInstanceCustomDataPS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPerInstanceCustomDataPS");
		}

		// Token: 0x0600C269 RID: 49769 RVA: 0x0011841A File Offset: 0x0011661A
		protected UMaterialExpressionPerInstanceCustomDataPS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006773 RID: 26483
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPerInstanceCustomDataPS";

		// Token: 0x04006774 RID: 26484
		private static IntPtr _ClassPtr;

		// Token: 0x04006775 RID: 26485
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006776 RID: 26486
		internal static int __PropertyOffset_DefaultValue;

		// Token: 0x04006777 RID: 26487
		[Nullable(2)]
		private FExpressionInput _DefaultValue;

		// Token: 0x04006778 RID: 26488
		internal static int __PropertyOffset_ConstDefaultValue;

		// Token: 0x04006779 RID: 26489
		internal static int __PropertyOffset_DataIndex;
	}
}
