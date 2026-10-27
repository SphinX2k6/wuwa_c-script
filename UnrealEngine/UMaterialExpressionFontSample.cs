using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DC9 RID: 3529
	[UnrealObjectPath("/Script/Engine.MaterialExpressionFontSample")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMaterialExpressionFontSample : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF5B RID: 48987 RVA: 0x00112775 File Offset: 0x00110975
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionFontSample._ClassPtr;
		}

		// Token: 0x0600BF5C RID: 48988 RVA: 0x00112784 File Offset: 0x00110984
		public UMaterialExpressionFontSample() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFontSample.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF5D RID: 48989 RVA: 0x001127AC File Offset: 0x001109AC
		[NullableContext(1)]
		public UMaterialExpressionFontSample(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFontSample.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x0600BF5E RID: 48990 RVA: 0x001127DF File Offset: 0x001109DF
		// (set) Token: 0x0600BF5F RID: 48991 RVA: 0x001127F3 File Offset: 0x001109F3
		[Nullable(2)]
		public unsafe UFont Font
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFont>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionFontSample.__PropertyOffset_Font);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialExpressionFontSample.__PropertyOffset_Font, value);
			}
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x0600BF60 RID: 48992 RVA: 0x00112808 File Offset: 0x00110A08
		// (set) Token: 0x0600BF61 RID: 48993 RVA: 0x00112818 File Offset: 0x00110A18
		public unsafe int FontTexturePage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFontSample.__PropertyOffset_FontTexturePage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFontSample.__PropertyOffset_FontTexturePage) = value;
			}
		}

		// Token: 0x0600BF62 RID: 48994 RVA: 0x00112829 File Offset: 0x00110A29
		static UMaterialExpressionFontSample()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionFontSample");
		}

		// Token: 0x0600BF63 RID: 48995 RVA: 0x00112837 File Offset: 0x00110A37
		protected UMaterialExpressionFontSample(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400654F RID: 25935
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionFontSample";

		// Token: 0x04006550 RID: 25936
		private static IntPtr _ClassPtr;

		// Token: 0x04006551 RID: 25937
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006552 RID: 25938
		internal static int __PropertyOffset_Font;

		// Token: 0x04006553 RID: 25939
		internal static int __PropertyOffset_FontTexturePage;
	}
}
