using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E63 RID: 3683
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTextureProperty")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMaterialExpressionTextureProperty : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C545 RID: 50501 RVA: 0x0011D936 File Offset: 0x0011BB36
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTextureProperty._ClassPtr;
		}

		// Token: 0x0600C546 RID: 50502 RVA: 0x0011D944 File Offset: 0x0011BB44
		public UMaterialExpressionTextureProperty() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C547 RID: 50503 RVA: 0x0011D96C File Offset: 0x0011BB6C
		[NullableContext(1)]
		public UMaterialExpressionTextureProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DCF RID: 11727
		// (get) Token: 0x0600C548 RID: 50504 RVA: 0x0011D9A0 File Offset: 0x0011BBA0
		// (set) Token: 0x0600C549 RID: 50505 RVA: 0x0011D9D9 File Offset: 0x0011BBD9
		[Nullable(1)]
		public FExpressionInput TextureObject
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._TextureObject) == null)
				{
					result = (this._TextureObject = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionTextureProperty.__PropertyOffset_TextureObject, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionTextureProperty.__PropertyOffset_TextureObject, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DD0 RID: 11728
		// (get) Token: 0x0600C54A RID: 50506 RVA: 0x0011D9FA File Offset: 0x0011BBFA
		// (set) Token: 0x0600C54B RID: 50507 RVA: 0x0011DA0E File Offset: 0x0011BC0E
		public unsafe TEnumAsByte<EMaterialExposedTextureProperty> Property
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionTextureProperty.__PropertyOffset_Property);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionTextureProperty.__PropertyOffset_Property) = value;
			}
		}

		// Token: 0x0600C54C RID: 50508 RVA: 0x0011DA23 File Offset: 0x0011BC23
		static UMaterialExpressionTextureProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTextureProperty");
		}

		// Token: 0x0600C54D RID: 50509 RVA: 0x0011DA31 File Offset: 0x0011BC31
		protected UMaterialExpressionTextureProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400697D RID: 27005
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTextureProperty";

		// Token: 0x0400697E RID: 27006
		private static IntPtr _ClassPtr;

		// Token: 0x0400697F RID: 27007
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006980 RID: 27008
		internal static int __PropertyOffset_TextureObject;

		// Token: 0x04006981 RID: 27009
		[Nullable(2)]
		private FExpressionInput _TextureObject;

		// Token: 0x04006982 RID: 27010
		internal static int __PropertyOffset_Property;
	}
}
