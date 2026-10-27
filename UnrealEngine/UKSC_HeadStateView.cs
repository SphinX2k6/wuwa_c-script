using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001886 RID: 6278
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.KSC_HeadStateView")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKSC_HeadStateView : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017237 RID: 94775 RVA: 0x0021B689 File Offset: 0x00219889
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_HeadStateView._ClassPtr;
		}

		// Token: 0x06017238 RID: 94776 RVA: 0x0021B698 File Offset: 0x00219898
		public UKSC_HeadStateView() : this(BuiltinUtils.AllocNativeUObject(UKSC_HeadStateView.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017239 RID: 94777 RVA: 0x0021B6C0 File Offset: 0x002198C0
		[NullableContext(1)]
		public UKSC_HeadStateView(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_HeadStateView.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D1B RID: 23835
		// (get) Token: 0x0601723A RID: 94778 RVA: 0x0021B6F3 File Offset: 0x002198F3
		// (set) Token: 0x0601723B RID: 94779 RVA: 0x0021B707 File Offset: 0x00219907
		public unsafe UCurveFloat ScaleCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateView.__PropertyOffset_ScaleCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateView.__PropertyOffset_ScaleCurve, value);
			}
		}

		// Token: 0x17005D1C RID: 23836
		// (get) Token: 0x0601723C RID: 94780 RVA: 0x0021B71C File Offset: 0x0021991C
		// (set) Token: 0x0601723D RID: 94781 RVA: 0x0021B730 File Offset: 0x00219930
		public unsafe AUIBaseActor RootActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIBaseActor>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateView.__PropertyOffset_RootActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateView.__PropertyOffset_RootActor, value);
			}
		}

		// Token: 0x17005D1D RID: 23837
		// (get) Token: 0x0601723E RID: 94782 RVA: 0x0021B745 File Offset: 0x00219945
		// (set) Token: 0x0601723F RID: 94783 RVA: 0x0021B759 File Offset: 0x00219959
		public unsafe UUIItem RootItem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateView.__PropertyOffset_RootItem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateView.__PropertyOffset_RootItem, value);
			}
		}

		// Token: 0x17005D1E RID: 23838
		// (get) Token: 0x06017240 RID: 94784 RVA: 0x0021B76E File Offset: 0x0021996E
		// (set) Token: 0x06017241 RID: 94785 RVA: 0x0021B782 File Offset: 0x00219982
		public unsafe UUITextAdditionalUVModifier HpBarUVModifier
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUITextAdditionalUVModifier>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateView.__PropertyOffset_HpBarUVModifier);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateView.__PropertyOffset_HpBarUVModifier, value);
			}
		}

		// Token: 0x17005D1F RID: 23839
		// (get) Token: 0x06017242 RID: 94786 RVA: 0x0021B797 File Offset: 0x00219997
		// (set) Token: 0x06017243 RID: 94787 RVA: 0x0021B7AB File Offset: 0x002199AB
		public unsafe UUITextAdditionalUVModifier HpBarBufferUVModifier
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUITextAdditionalUVModifier>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateView.__PropertyOffset_HpBarBufferUVModifier);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateView.__PropertyOffset_HpBarBufferUVModifier, value);
			}
		}

		// Token: 0x17005D20 RID: 23840
		// (get) Token: 0x06017244 RID: 94788 RVA: 0x0021B7C0 File Offset: 0x002199C0
		// (set) Token: 0x06017245 RID: 94789 RVA: 0x0021B7D4 File Offset: 0x002199D4
		public unsafe UUITextAdditionalUVModifier ShieldBarUVModifier
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUITextAdditionalUVModifier>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateView.__PropertyOffset_ShieldBarUVModifier);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateView.__PropertyOffset_ShieldBarUVModifier, value);
			}
		}

		// Token: 0x17005D21 RID: 23841
		// (get) Token: 0x06017246 RID: 94790 RVA: 0x0021B7EC File Offset: 0x002199EC
		// (set) Token: 0x06017247 RID: 94791 RVA: 0x0021B825 File Offset: 0x00219A25
		[Nullable(1)]
		public TArray<UUITextAdditionalUVModifier> UvModifierList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UUITextAdditionalUVModifier> result;
				if ((result = this._UvModifierList) == null)
				{
					result = (this._UvModifierList = new TArray<UUITextAdditionalUVModifier>(base.NativePtr + (IntPtr)UKSC_HeadStateView.__PropertyOffset_UvModifierList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.UvModifierList.CopyAssign(value);
			}
		}

		// Token: 0x17005D22 RID: 23842
		// (get) Token: 0x06017248 RID: 94792 RVA: 0x0021B834 File Offset: 0x00219A34
		// (set) Token: 0x06017249 RID: 94793 RVA: 0x0021B86D File Offset: 0x00219A6D
		[Nullable(1)]
		public TArray<UUIItem> UvModifierItemList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UUIItem> result;
				if ((result = this._UvModifierItemList) == null)
				{
					result = (this._UvModifierItemList = new TArray<UUIItem>(base.NativePtr + (IntPtr)UKSC_HeadStateView.__PropertyOffset_UvModifierItemList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.UvModifierItemList.CopyAssign(value);
			}
		}

		// Token: 0x0601724A RID: 94794 RVA: 0x0021B87B File Offset: 0x00219A7B
		static UKSC_HeadStateView()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayUI.KSC_HeadStateView");
		}

		// Token: 0x0601724B RID: 94795 RVA: 0x0021B889 File Offset: 0x00219A89
		protected UKSC_HeadStateView(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C8CA RID: 51402
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayUI.KSC_HeadStateView";

		// Token: 0x0400C8CB RID: 51403
		private static IntPtr _ClassPtr;

		// Token: 0x0400C8CC RID: 51404
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C8CD RID: 51405
		internal static int __PropertyOffset_ScaleCurve;

		// Token: 0x0400C8CE RID: 51406
		internal static int __PropertyOffset_RootActor;

		// Token: 0x0400C8CF RID: 51407
		internal static int __PropertyOffset_RootItem;

		// Token: 0x0400C8D0 RID: 51408
		internal static int __PropertyOffset_HpBarUVModifier;

		// Token: 0x0400C8D1 RID: 51409
		internal static int __PropertyOffset_HpBarBufferUVModifier;

		// Token: 0x0400C8D2 RID: 51410
		internal static int __PropertyOffset_ShieldBarUVModifier;

		// Token: 0x0400C8D3 RID: 51411
		internal static int __PropertyOffset_UvModifierList;

		// Token: 0x0400C8D4 RID: 51412
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUITextAdditionalUVModifier> _UvModifierList;

		// Token: 0x0400C8D5 RID: 51413
		internal static int __PropertyOffset_UvModifierItemList;

		// Token: 0x0400C8D6 RID: 51414
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIItem> _UvModifierItemList;
	}
}
