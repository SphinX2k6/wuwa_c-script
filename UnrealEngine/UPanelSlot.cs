using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200086D RID: 2157
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.PanelSlot")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UPanelSlot : UVisual, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BB38 RID: 47928 RVA: 0x0012BE0A File Offset: 0x0012A00A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPanelSlot._ClassPtr;
		}

		// Token: 0x0600BB39 RID: 47929 RVA: 0x0012BE18 File Offset: 0x0012A018
		public UPanelSlot() : this(BuiltinUtils.AllocNativeUObject(UPanelSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BB3A RID: 47930 RVA: 0x0012BE40 File Offset: 0x0012A040
		[NullableContext(1)]
		public UPanelSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPanelSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x0600BB3B RID: 47931 RVA: 0x0012BE73 File Offset: 0x0012A073
		// (set) Token: 0x0600BB3C RID: 47932 RVA: 0x0012BE87 File Offset: 0x0012A087
		public unsafe UPanelWidget Parent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPanelWidget>(base.NativePtr / (IntPtr)sizeof(void*) + UPanelSlot.__PropertyOffset_Parent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPanelSlot.__PropertyOffset_Parent, value);
			}
		}

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x0600BB3D RID: 47933 RVA: 0x0012BE9C File Offset: 0x0012A09C
		// (set) Token: 0x0600BB3E RID: 47934 RVA: 0x0012BEB0 File Offset: 0x0012A0B0
		public unsafe UWidget Content
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidget>(base.NativePtr / (IntPtr)sizeof(void*) + UPanelSlot.__PropertyOffset_Content);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPanelSlot.__PropertyOffset_Content, value);
			}
		}

		// Token: 0x0600BB3F RID: 47935 RVA: 0x0012BEC5 File Offset: 0x0012A0C5
		static UPanelSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.PanelSlot");
		}

		// Token: 0x0600BB40 RID: 47936 RVA: 0x0012BED3 File Offset: 0x0012A0D3
		protected UPanelSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040054D0 RID: 21712
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.PanelSlot";

		// Token: 0x040054D1 RID: 21713
		private static IntPtr _ClassPtr;

		// Token: 0x040054D2 RID: 21714
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040054D3 RID: 21715
		internal static int __PropertyOffset_Parent;

		// Token: 0x040054D4 RID: 21716
		internal static int __PropertyOffset_Content;
	}
}
