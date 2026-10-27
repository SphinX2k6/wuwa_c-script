using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200285C RID: 10332
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Slate.ScrollBoxWidgetStyle")]
	[UnrealStructLayout(704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public class UScrollBoxWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026521 RID: 156961 RVA: 0x003A360D File Offset: 0x003A180D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UScrollBoxWidgetStyle._ClassPtr;
		}

		// Token: 0x06026522 RID: 156962 RVA: 0x003A361C File Offset: 0x003A181C
		public UScrollBoxWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UScrollBoxWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026523 RID: 156963 RVA: 0x003A3644 File Offset: 0x003A1844
		public UScrollBoxWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UScrollBoxWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093F1 RID: 37873
		// (get) Token: 0x06026524 RID: 156964 RVA: 0x003A3678 File Offset: 0x003A1878
		// (set) Token: 0x06026525 RID: 156965 RVA: 0x003A36B1 File Offset: 0x003A18B1
		public FScrollBoxStyle ScrollBoxStyle
		{
			get
			{
				base.FastCheckIsValid();
				FScrollBoxStyle result;
				if ((result = this._ScrollBoxStyle) == null)
				{
					result = (this._ScrollBoxStyle = new FScrollBoxStyle(base.NativePtr + (IntPtr)UScrollBoxWidgetStyle.__PropertyOffset_ScrollBoxStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScrollBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)UScrollBoxWidgetStyle.__PropertyOffset_ScrollBoxStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026526 RID: 156966 RVA: 0x003A36D2 File Offset: 0x003A18D2
		static UScrollBoxWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Slate.ScrollBoxWidgetStyle");
		}

		// Token: 0x06026527 RID: 156967 RVA: 0x003A36E0 File Offset: 0x003A18E0
		protected UScrollBoxWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015027 RID: 86055
		public new const string __ObjectPath = "/Script/Slate.ScrollBoxWidgetStyle";

		// Token: 0x04015028 RID: 86056
		private static IntPtr _ClassPtr;

		// Token: 0x04015029 RID: 86057
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401502A RID: 86058
		internal static int __PropertyOffset_ScrollBoxStyle;

		// Token: 0x0401502B RID: 86059
		[Nullable(2)]
		private FScrollBoxStyle _ScrollBoxStyle;
	}
}
