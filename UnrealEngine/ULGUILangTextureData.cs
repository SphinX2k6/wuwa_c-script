using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002081 RID: 8321
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUILangTextureData")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class ULGUILangTextureData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F653 RID: 128595 RVA: 0x002E9FBA File Offset: 0x002E81BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUILangTextureData._ClassPtr;
		}

		// Token: 0x0601F654 RID: 128596 RVA: 0x002E9FC8 File Offset: 0x002E81C8
		public ULGUILangTextureData() : this(BuiltinUtils.AllocNativeUObject(ULGUILangTextureData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F655 RID: 128597 RVA: 0x002E9FF0 File Offset: 0x002E81F0
		public ULGUILangTextureData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUILangTextureData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007BEF RID: 31727
		// (get) Token: 0x0601F656 RID: 128598 RVA: 0x002EA023 File Offset: 0x002E8223
		// (set) Token: 0x0601F657 RID: 128599 RVA: 0x002EA033 File Offset: 0x002E8233
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

		// Token: 0x17007BF0 RID: 31728
		// (get) Token: 0x0601F658 RID: 128600 RVA: 0x002EA044 File Offset: 0x002E8244
		// (set) Token: 0x0601F659 RID: 128601 RVA: 0x002EA07D File Offset: 0x002E827D
		public TArray<FLangTextureInfo> LangTextureList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLangTextureInfo> result;
				if ((result = this._LangTextureList) == null)
				{
					result = (this._LangTextureList = new TArray<FLangTextureInfo>(base.NativePtr + (IntPtr)ULGUILangTextureData.__PropertyOffset_LangTextureList, this));
				}
				return result;
			}
			set
			{
				this.LangTextureList.CopyAssign(value);
			}
		}

		// Token: 0x0601F65A RID: 128602 RVA: 0x002EA08B File Offset: 0x002E828B
		static ULGUILangTextureData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUILangTextureData");
		}

		// Token: 0x0601F65B RID: 128603 RVA: 0x002EA099 File Offset: 0x002E8299
		protected ULGUILangTextureData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F4E RID: 69454
		public new const string __ObjectPath = "/Script/LGUI.LGUILangTextureData";

		// Token: 0x04010F4F RID: 69455
		private static IntPtr _ClassPtr;

		// Token: 0x04010F50 RID: 69456
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F51 RID: 69457
		internal static int __PropertyOffset_DefaultLanguage;

		// Token: 0x04010F52 RID: 69458
		internal static int __PropertyOffset_LangTextureList;

		// Token: 0x04010F53 RID: 69459
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLangTextureInfo> _LangTextureList;
	}
}
