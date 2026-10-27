using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200285F RID: 10335
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Slate.TextBlockWidgetStyle")]
	[UnrealStructLayout(768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 768)]
	public class UTextBlockWidgetStyle : USlateWidgetStyleContainerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026536 RID: 156982 RVA: 0x003A3865 File Offset: 0x003A1A65
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextBlockWidgetStyle._ClassPtr;
		}

		// Token: 0x06026537 RID: 156983 RVA: 0x003A3874 File Offset: 0x003A1A74
		public UTextBlockWidgetStyle() : this(BuiltinUtils.AllocNativeUObject(UTextBlockWidgetStyle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026538 RID: 156984 RVA: 0x003A389C File Offset: 0x003A1A9C
		public UTextBlockWidgetStyle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextBlockWidgetStyle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170093F4 RID: 37876
		// (get) Token: 0x06026539 RID: 156985 RVA: 0x003A38D0 File Offset: 0x003A1AD0
		// (set) Token: 0x0602653A RID: 156986 RVA: 0x003A3909 File Offset: 0x003A1B09
		public FTextBlockStyle TextBlockStyle
		{
			get
			{
				base.FastCheckIsValid();
				FTextBlockStyle result;
				if ((result = this._TextBlockStyle) == null)
				{
					result = (this._TextBlockStyle = new FTextBlockStyle(base.NativePtr + (IntPtr)UTextBlockWidgetStyle.__PropertyOffset_TextBlockStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextBlockStyle.StaticStruct(), base.NativePtr + (IntPtr)UTextBlockWidgetStyle.__PropertyOffset_TextBlockStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602653B RID: 156987 RVA: 0x003A392A File Offset: 0x003A1B2A
		static UTextBlockWidgetStyle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Slate.TextBlockWidgetStyle");
		}

		// Token: 0x0602653C RID: 156988 RVA: 0x003A3938 File Offset: 0x003A1B38
		protected UTextBlockWidgetStyle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015035 RID: 86069
		public new const string __ObjectPath = "/Script/Slate.TextBlockWidgetStyle";

		// Token: 0x04015036 RID: 86070
		private static IntPtr _ClassPtr;

		// Token: 0x04015037 RID: 86071
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015038 RID: 86072
		internal static int __PropertyOffset_TextBlockStyle;

		// Token: 0x04015039 RID: 86073
		[Nullable(2)]
		private FTextBlockStyle _TextBlockStyle;
	}
}
