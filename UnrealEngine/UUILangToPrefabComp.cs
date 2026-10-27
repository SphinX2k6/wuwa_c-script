using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002181 RID: 8577
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UILangToPrefabComp")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UUILangToPrefabComp : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602078A RID: 133002 RVA: 0x00301FC0 File Offset: 0x003001C0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUILangToPrefabComp._ClassPtr;
		}

		// Token: 0x0602078B RID: 133003 RVA: 0x00301FCC File Offset: 0x003001CC
		public UUILangToPrefabComp() : this(BuiltinUtils.AllocNativeUObject(UUILangToPrefabComp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602078C RID: 133004 RVA: 0x00301FF4 File Offset: 0x003001F4
		public UUILangToPrefabComp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUILangToPrefabComp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F11 RID: 32529
		// (get) Token: 0x0602078D RID: 133005 RVA: 0x00302028 File Offset: 0x00300228
		// (set) Token: 0x0602078E RID: 133006 RVA: 0x00302061 File Offset: 0x00300261
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

		// Token: 0x17007F12 RID: 32530
		// (get) Token: 0x0602078F RID: 133007 RVA: 0x0030206F File Offset: 0x0030026F
		// (set) Token: 0x06020790 RID: 133008 RVA: 0x0030207F File Offset: 0x0030027F
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

		// Token: 0x17007F13 RID: 32531
		// (get) Token: 0x06020791 RID: 133009 RVA: 0x00302090 File Offset: 0x00300290
		// (set) Token: 0x06020792 RID: 133010 RVA: 0x003020A4 File Offset: 0x003002A4
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

		// Token: 0x06020793 RID: 133011 RVA: 0x003020B9 File Offset: 0x003002B9
		[NullableContext(2)]
		public UUIItem GetRootItem()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(UUILangToPrefabComp.__GetRootItem_Internal(base.NativePtr));
		}

		// Token: 0x06020794 RID: 133012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRootItem_Internal(IntPtr @this);

		// Token: 0x06020795 RID: 133013 RVA: 0x003020CB File Offset: 0x003002CB
		static UUILangToPrefabComp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UILangToPrefabComp");
		}

		// Token: 0x06020796 RID: 133014 RVA: 0x003020D9 File Offset: 0x003002D9
		protected UUILangToPrefabComp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401166E RID: 71278
		public new const string __ObjectPath = "/Script/LGUI.UILangToPrefabComp";

		// Token: 0x0401166F RID: 71279
		private static IntPtr _ClassPtr;

		// Token: 0x04011670 RID: 71280
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011671 RID: 71281
		internal static int __PropertyOffset_CultureToPrefabAssets;

		// Token: 0x04011672 RID: 71282
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EUILanguageType, FSoftObjectPath> _CultureToPrefabAssets;

		// Token: 0x04011673 RID: 71283
		internal static int __PropertyOffset_bCopyComponentsRegistry;

		// Token: 0x04011674 RID: 71284
		internal static int __PropertyOffset_RootItem;
	}
}
