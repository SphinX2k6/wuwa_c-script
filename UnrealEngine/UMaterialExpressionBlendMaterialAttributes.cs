using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D91 RID: 3473
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionBlendMaterialAttributes")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UMaterialExpressionBlendMaterialAttributes : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD67 RID: 48487 RVA: 0x0010EED5 File Offset: 0x0010D0D5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionBlendMaterialAttributes._ClassPtr;
		}

		// Token: 0x0600BD68 RID: 48488 RVA: 0x0010EEE4 File Offset: 0x0010D0E4
		public UMaterialExpressionBlendMaterialAttributes() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBlendMaterialAttributes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD69 RID: 48489 RVA: 0x0010EF0C File Offset: 0x0010D10C
		public UMaterialExpressionBlendMaterialAttributes(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionBlendMaterialAttributes.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x0600BD6A RID: 48490 RVA: 0x0010EF40 File Offset: 0x0010D140
		// (set) Token: 0x0600BD6B RID: 48491 RVA: 0x0010EF79 File Offset: 0x0010D179
		public FMaterialAttributesInput A
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialAttributesInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FMaterialAttributesInput(base.NativePtr + (IntPtr)UMaterialExpressionBlendMaterialAttributes.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialAttributesInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionBlendMaterialAttributes.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x0600BD6C RID: 48492 RVA: 0x0010EF9C File Offset: 0x0010D19C
		// (set) Token: 0x0600BD6D RID: 48493 RVA: 0x0010EFD5 File Offset: 0x0010D1D5
		public FMaterialAttributesInput B
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialAttributesInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FMaterialAttributesInput(base.NativePtr + (IntPtr)UMaterialExpressionBlendMaterialAttributes.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialAttributesInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionBlendMaterialAttributes.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x0600BD6E RID: 48494 RVA: 0x0010EFF8 File Offset: 0x0010D1F8
		// (set) Token: 0x0600BD6F RID: 48495 RVA: 0x0010F031 File Offset: 0x0010D231
		public FExpressionInput Alpha
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Alpha) == null)
				{
					result = (this._Alpha = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionBlendMaterialAttributes.__PropertyOffset_Alpha, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionBlendMaterialAttributes.__PropertyOffset_Alpha, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x0600BD70 RID: 48496 RVA: 0x0010F052 File Offset: 0x0010D252
		// (set) Token: 0x0600BD71 RID: 48497 RVA: 0x0010F066 File Offset: 0x0010D266
		[Nullable(0)]
		public unsafe TEnumAsByte<EMaterialAttributeBlend> PixelAttributeBlendType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionBlendMaterialAttributes.__PropertyOffset_PixelAttributeBlendType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionBlendMaterialAttributes.__PropertyOffset_PixelAttributeBlendType) = value;
			}
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x0600BD72 RID: 48498 RVA: 0x0010F07B File Offset: 0x0010D27B
		// (set) Token: 0x0600BD73 RID: 48499 RVA: 0x0010F08F File Offset: 0x0010D28F
		[Nullable(0)]
		public unsafe TEnumAsByte<EMaterialAttributeBlend> VertexAttributeBlendType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionBlendMaterialAttributes.__PropertyOffset_VertexAttributeBlendType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionBlendMaterialAttributes.__PropertyOffset_VertexAttributeBlendType) = value;
			}
		}

		// Token: 0x0600BD74 RID: 48500 RVA: 0x0010F0A4 File Offset: 0x0010D2A4
		static UMaterialExpressionBlendMaterialAttributes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionBlendMaterialAttributes");
		}

		// Token: 0x0600BD75 RID: 48501 RVA: 0x0010F0B2 File Offset: 0x0010D2B2
		protected UMaterialExpressionBlendMaterialAttributes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063F6 RID: 25590
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionBlendMaterialAttributes";

		// Token: 0x040063F7 RID: 25591
		private static IntPtr _ClassPtr;

		// Token: 0x040063F8 RID: 25592
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063F9 RID: 25593
		internal static int __PropertyOffset_A;

		// Token: 0x040063FA RID: 25594
		[Nullable(2)]
		private FMaterialAttributesInput _A;

		// Token: 0x040063FB RID: 25595
		internal static int __PropertyOffset_B;

		// Token: 0x040063FC RID: 25596
		[Nullable(2)]
		private FMaterialAttributesInput _B;

		// Token: 0x040063FD RID: 25597
		internal static int __PropertyOffset_Alpha;

		// Token: 0x040063FE RID: 25598
		[Nullable(2)]
		private FExpressionInput _Alpha;

		// Token: 0x040063FF RID: 25599
		internal static int __PropertyOffset_PixelAttributeBlendType;

		// Token: 0x04006400 RID: 25600
		internal static int __PropertyOffset_VertexAttributeBlendType;
	}
}
