using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200069F RID: 1695
	[UnrealObjectPath("/Script/LGUI.LGUILangTextureData")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class ULGUILangTextureData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060091FD RID: 37373 RVA: 0x000DBBA6 File Offset: 0x000D9DA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUILangTextureData._ClassPtr;
		}

		// Token: 0x060091FE RID: 37374 RVA: 0x000DBBB4 File Offset: 0x000D9DB4
		public ULGUILangTextureData() : this(BuiltinUtils.AllocNativeUObject(ULGUILangTextureData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060091FF RID: 37375 RVA: 0x000DBBDC File Offset: 0x000D9DDC
		[NullableContext(1)]
		public ULGUILangTextureData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUILangTextureData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06009200 RID: 37376 RVA: 0x000DBC0F File Offset: 0x000D9E0F
		// (set) Token: 0x06009201 RID: 37377 RVA: 0x000DBC1F File Offset: 0x000D9E1F
		public unsafe EUILanguageType DefaultLanguage
		{
			get
			{
				return (EUILanguageType)(*(base.NativePtr + (IntPtr)ULGUILangTextureData.__PropertyOffset_DefaultLanguage));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUILangTextureData.__PropertyOffset_DefaultLanguage) = (byte)value;
			}
		}

		// Token: 0x06009202 RID: 37378 RVA: 0x000DBC30 File Offset: 0x000D9E30
		static ULGUILangTextureData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUILangTextureData");
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x000DBC3E File Offset: 0x000D9E3E
		protected ULGUILangTextureData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003F9E RID: 16286
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUILangTextureData";

		// Token: 0x04003F9F RID: 16287
		private static IntPtr _ClassPtr;

		// Token: 0x04003FA0 RID: 16288
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003FA1 RID: 16289
		internal static int __PropertyOffset_DefaultLanguage;
	}
}
