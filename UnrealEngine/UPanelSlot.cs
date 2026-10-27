using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029C1 RID: 10689
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.PanelSlot")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UPanelSlot : UVisual, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027814 RID: 161812 RVA: 0x003C4A59 File Offset: 0x003C2C59
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPanelSlot._ClassPtr;
		}

		// Token: 0x06027815 RID: 161813 RVA: 0x003C4A68 File Offset: 0x003C2C68
		public UPanelSlot() : this(BuiltinUtils.AllocNativeUObject(UPanelSlot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027816 RID: 161814 RVA: 0x003C4A90 File Offset: 0x003C2C90
		[NullableContext(1)]
		public UPanelSlot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPanelSlot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009769 RID: 38761
		// (get) Token: 0x06027817 RID: 161815 RVA: 0x003C4AC3 File Offset: 0x003C2CC3
		// (set) Token: 0x06027818 RID: 161816 RVA: 0x003C4AD7 File Offset: 0x003C2CD7
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

		// Token: 0x1700976A RID: 38762
		// (get) Token: 0x06027819 RID: 161817 RVA: 0x003C4AEC File Offset: 0x003C2CEC
		// (set) Token: 0x0602781A RID: 161818 RVA: 0x003C4B00 File Offset: 0x003C2D00
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

		// Token: 0x0602781B RID: 161819 RVA: 0x003C4B15 File Offset: 0x003C2D15
		static UPanelSlot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.PanelSlot");
		}

		// Token: 0x0602781C RID: 161820 RVA: 0x003C4B23 File Offset: 0x003C2D23
		protected UPanelSlot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015A99 RID: 88729
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.PanelSlot";

		// Token: 0x04015A9A RID: 88730
		private static IntPtr _ClassPtr;

		// Token: 0x04015A9B RID: 88731
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015A9C RID: 88732
		internal static int __PropertyOffset_Parent;

		// Token: 0x04015A9D RID: 88733
		internal static int __PropertyOffset_Content;
	}
}
