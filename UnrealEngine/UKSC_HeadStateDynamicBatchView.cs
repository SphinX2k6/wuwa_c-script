using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001884 RID: 6276
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplayUI.KSC_HeadStateDynamicBatchView")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKSC_HeadStateDynamicBatchView : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017218 RID: 94744 RVA: 0x0021B3EC File Offset: 0x002195EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_HeadStateDynamicBatchView._ClassPtr;
		}

		// Token: 0x06017219 RID: 94745 RVA: 0x0021B3F8 File Offset: 0x002195F8
		public UKSC_HeadStateDynamicBatchView() : this(BuiltinUtils.AllocNativeUObject(UKSC_HeadStateDynamicBatchView.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601721A RID: 94746 RVA: 0x0021B420 File Offset: 0x00219620
		[NullableContext(1)]
		public UKSC_HeadStateDynamicBatchView(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_HeadStateDynamicBatchView.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D15 RID: 23829
		// (get) Token: 0x0601721B RID: 94747 RVA: 0x0021B453 File Offset: 0x00219653
		// (set) Token: 0x0601721C RID: 94748 RVA: 0x0021B467 File Offset: 0x00219667
		public unsafe UKSC_HeadStateView HeadStateView
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_HeadStateView>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateDynamicBatchView.__PropertyOffset_HeadStateView);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateDynamicBatchView.__PropertyOffset_HeadStateView, value);
			}
		}

		// Token: 0x17005D16 RID: 23830
		// (get) Token: 0x0601721D RID: 94749 RVA: 0x0021B47C File Offset: 0x0021967C
		// (set) Token: 0x0601721E RID: 94750 RVA: 0x0021B490 File Offset: 0x00219690
		public unsafe AUIBaseActor RootActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AUIBaseActor>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateDynamicBatchView.__PropertyOffset_RootActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateDynamicBatchView.__PropertyOffset_RootActor, value);
			}
		}

		// Token: 0x17005D17 RID: 23831
		// (get) Token: 0x0601721F RID: 94751 RVA: 0x0021B4A5 File Offset: 0x002196A5
		// (set) Token: 0x06017220 RID: 94752 RVA: 0x0021B4B9 File Offset: 0x002196B9
		public unsafe UUIDynamicBatchMesh DynamicBatch
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIDynamicBatchMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateDynamicBatchView.__PropertyOffset_DynamicBatch);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateDynamicBatchView.__PropertyOffset_DynamicBatch, value);
			}
		}

		// Token: 0x17005D18 RID: 23832
		// (get) Token: 0x06017221 RID: 94753 RVA: 0x0021B4CE File Offset: 0x002196CE
		// (set) Token: 0x06017222 RID: 94754 RVA: 0x0021B4E2 File Offset: 0x002196E2
		public unsafe UUIItem HpParentItem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateDynamicBatchView.__PropertyOffset_HpParentItem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_HeadStateDynamicBatchView.__PropertyOffset_HpParentItem, value);
			}
		}

		// Token: 0x06017223 RID: 94755 RVA: 0x0021B4F7 File Offset: 0x002196F7
		static UKSC_HeadStateDynamicBatchView()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayUI.KSC_HeadStateDynamicBatchView");
		}

		// Token: 0x06017224 RID: 94756 RVA: 0x0021B505 File Offset: 0x00219705
		protected UKSC_HeadStateDynamicBatchView(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C8BE RID: 51390
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayUI.KSC_HeadStateDynamicBatchView";

		// Token: 0x0400C8BF RID: 51391
		private static IntPtr _ClassPtr;

		// Token: 0x0400C8C0 RID: 51392
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C8C1 RID: 51393
		internal static int __PropertyOffset_HeadStateView;

		// Token: 0x0400C8C2 RID: 51394
		internal static int __PropertyOffset_RootActor;

		// Token: 0x0400C8C3 RID: 51395
		internal static int __PropertyOffset_DynamicBatch;

		// Token: 0x0400C8C4 RID: 51396
		internal static int __PropertyOffset_HpParentItem;
	}
}
