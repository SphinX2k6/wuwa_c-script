using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002948 RID: 10568
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.ComboBox")]
	[UnrealStructLayout(736, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 736)]
	public class UComboBox : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060271F0 RID: 160240 RVA: 0x003BA562 File Offset: 0x003B8762
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UComboBox._ClassPtr;
		}

		// Token: 0x060271F1 RID: 160241 RVA: 0x003BA570 File Offset: 0x003B8770
		public UComboBox() : this(BuiltinUtils.AllocNativeUObject(UComboBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060271F2 RID: 160242 RVA: 0x003BA598 File Offset: 0x003B8798
		public UComboBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UComboBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700967E RID: 38526
		// (get) Token: 0x060271F3 RID: 160243 RVA: 0x003BA5CC File Offset: 0x003B87CC
		// (set) Token: 0x060271F4 RID: 160244 RVA: 0x003BA605 File Offset: 0x003B8805
		public TArray<UObject> Items
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._Items) == null)
				{
					result = (this._Items = new TArray<UObject>(base.NativePtr + (IntPtr)UComboBox.__PropertyOffset_Items, this));
				}
				return result;
			}
			set
			{
				this.Items.CopyAssign(value);
			}
		}

		// Token: 0x1700967F RID: 38527
		// (get) Token: 0x060271F5 RID: 160245 RVA: 0x003BA614 File Offset: 0x003B8814
		// (set) Token: 0x060271F6 RID: 160246 RVA: 0x003BA64D File Offset: 0x003B884D
		public FGenerateWidgetForObject OnGenerateWidgetEvent
		{
			get
			{
				base.FastCheckIsValid();
				FGenerateWidgetForObject result;
				if ((result = this._OnGenerateWidgetEvent) == null)
				{
					result = (this._OnGenerateWidgetEvent = new FGenerateWidgetForObject(base.NativePtr + (IntPtr)UComboBox.__PropertyOffset_OnGenerateWidgetEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UComboBox.__PropertyOffset_OnGenerateWidgetEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009680 RID: 38528
		// (get) Token: 0x060271F7 RID: 160247 RVA: 0x003BA66E File Offset: 0x003B886E
		// (set) Token: 0x060271F8 RID: 160248 RVA: 0x003BA67E File Offset: 0x003B887E
		public unsafe bool bIsFocusable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UComboBox.__PropertyOffset_bIsFocusable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UComboBox.__PropertyOffset_bIsFocusable) = (value ? 1 : 0);
			}
		}

		// Token: 0x060271F9 RID: 160249 RVA: 0x003BA68F File Offset: 0x003B888F
		static UComboBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ComboBox");
		}

		// Token: 0x060271FA RID: 160250 RVA: 0x003BA69D File Offset: 0x003B889D
		protected UComboBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040157C1 RID: 88001
		public new const string __ObjectPath = "/Script/UMG.ComboBox";

		// Token: 0x040157C2 RID: 88002
		private static IntPtr _ClassPtr;

		// Token: 0x040157C3 RID: 88003
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040157C4 RID: 88004
		internal static int __PropertyOffset_Items;

		// Token: 0x040157C5 RID: 88005
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _Items;

		// Token: 0x040157C6 RID: 88006
		internal static int __PropertyOffset_OnGenerateWidgetEvent;

		// Token: 0x040157C7 RID: 88007
		[Nullable(2)]
		private FGenerateWidgetForObject _OnGenerateWidgetEvent;

		// Token: 0x040157C8 RID: 88008
		internal static int __PropertyOffset_bIsFocusable;
	}
}
