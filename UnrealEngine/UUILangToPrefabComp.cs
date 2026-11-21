using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200070F RID: 1807
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UILangToPrefabComp")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UUILangToPrefabComp : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009B27 RID: 39719 RVA: 0x000E82FC File Offset: 0x000E64FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUILangToPrefabComp._ClassPtr;
		}

		// Token: 0x06009B28 RID: 39720 RVA: 0x000E8308 File Offset: 0x000E6508
		public UUILangToPrefabComp() : this(BuiltinUtils.AllocNativeUObject(UUILangToPrefabComp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009B29 RID: 39721 RVA: 0x000E8330 File Offset: 0x000E6530
		public UUILangToPrefabComp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUILangToPrefabComp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x06009B2A RID: 39722 RVA: 0x000E8364 File Offset: 0x000E6564
		// (set) Token: 0x06009B2B RID: 39723 RVA: 0x000E839D File Offset: 0x000E659D
		public TMap<EUILanguageType, FSoftObjectPath> CultureToPrefabAssets
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EUILanguageType, FSoftObjectPath> result;
				if ((result = this._CultureToPrefabAssets) == null)
				{
					result = (this._CultureToPrefabAssets = new TMap<EUILanguageType, FSoftObjectPath>(base.NativePtr + (IntPtr)UUILangToPrefabComp.__PropertyOffset_CultureToPrefabAssets, this));
				}
				return result;
			}
			set
			{
				this.CultureToPrefabAssets.CopyAssign(value);
			}
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x06009B2C RID: 39724 RVA: 0x000E83AB File Offset: 0x000E65AB
		// (set) Token: 0x06009B2D RID: 39725 RVA: 0x000E83BB File Offset: 0x000E65BB
		public unsafe bool bCopyComponentsRegistry
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILangToPrefabComp.__PropertyOffset_bCopyComponentsRegistry) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILangToPrefabComp.__PropertyOffset_bCopyComponentsRegistry) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x06009B2E RID: 39726 RVA: 0x000E83CC File Offset: 0x000E65CC
		// (set) Token: 0x06009B2F RID: 39727 RVA: 0x000E83E0 File Offset: 0x000E65E0
		[Nullable(2)]
		public unsafe UUIItem RootItem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + UUILangToPrefabComp.__PropertyOffset_RootItem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUILangToPrefabComp.__PropertyOffset_RootItem, value);
			}
		}

		// Token: 0x06009B30 RID: 39728 RVA: 0x000E83F5 File Offset: 0x000E65F5
		[NullableContext(2)]
		public UUIItem GetRootItem()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(UUILangToPrefabComp.__GetRootItem_Internal(base.NativePtr));
		}

		// Token: 0x06009B31 RID: 39729
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRootItem_Internal(IntPtr @this);

		// Token: 0x06009B32 RID: 39730 RVA: 0x000E8407 File Offset: 0x000E6607
		static UUILangToPrefabComp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UILangToPrefabComp");
		}

		// Token: 0x06009B33 RID: 39731 RVA: 0x000E8415 File Offset: 0x000E6615
		protected UUILangToPrefabComp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042FB RID: 17147
		public new const string __ObjectPath = "/Script/LGUI.UILangToPrefabComp";

		// Token: 0x040042FC RID: 17148
		private static IntPtr _ClassPtr;

		// Token: 0x040042FD RID: 17149
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040042FE RID: 17150
		internal static int __PropertyOffset_CultureToPrefabAssets;

		// Token: 0x040042FF RID: 17151
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EUILanguageType, FSoftObjectPath> _CultureToPrefabAssets;

		// Token: 0x04004300 RID: 17152
		internal static int __PropertyOffset_bCopyComponentsRegistry;

		// Token: 0x04004301 RID: 17153
		internal static int __PropertyOffset_RootItem;
	}
}
