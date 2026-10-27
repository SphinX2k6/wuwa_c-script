using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200285E RID: 10334
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Slate.SpinBoxWidgetStyle")]
	[UnrealStructLayout(920, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 920)]
	public class USpinBoxWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602652F RID: 156975 RVA: 0x003A378B File Offset: 0x003A198B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpinBoxWidgetStyle._ClassPtr;
		}

		// Token: 0x06026530 RID: 156976 RVA: 0x003A3798 File Offset: 0x003A1998
		public USpinBoxWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(USpinBoxWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026531 RID: 156977 RVA: 0x003A37C0 File Offset: 0x003A19C0
		public USpinBoxWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpinBoxWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093F3 RID: 37875
		// (get) Token: 0x06026532 RID: 156978 RVA: 0x003A37F4 File Offset: 0x003A19F4
		// (set) Token: 0x06026533 RID: 156979 RVA: 0x003A382D File Offset: 0x003A1A2D
		public FSpinBoxStyle SpinBoxStyle
		{
			get
			{
				base.FastCheckIsValid();
				FSpinBoxStyle result;
				if ((result = this._SpinBoxStyle) == null)
				{
					result = (this._SpinBoxStyle = new FSpinBoxStyle(base.NativePtr + (IntPtr)USpinBoxWidgetStyle.__PropertyOffset_SpinBoxStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpinBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)USpinBoxWidgetStyle.__PropertyOffset_SpinBoxStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026534 RID: 156980 RVA: 0x003A384E File Offset: 0x003A1A4E
		static USpinBoxWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Slate.SpinBoxWidgetStyle");
		}

		// Token: 0x06026535 RID: 156981 RVA: 0x003A385C File Offset: 0x003A1A5C
		protected USpinBoxWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015030 RID: 86064
		public new const string __ObjectPath = "/Script/Slate.SpinBoxWidgetStyle";

		// Token: 0x04015031 RID: 86065
		private static IntPtr _ClassPtr;

		// Token: 0x04015032 RID: 86066
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015033 RID: 86067
		internal static int __PropertyOffset_SpinBoxStyle;

		// Token: 0x04015034 RID: 86068
		[Nullable(2)]
		private FSpinBoxStyle _SpinBoxStyle;
	}
}
