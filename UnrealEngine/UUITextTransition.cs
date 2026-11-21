using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000733 RID: 1843
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UITextTransition")]
	[UnrealStructLayout(920, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 920)]
	public class UUITextTransition : UUITransitionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A0A1 RID: 41121 RVA: 0x000EDCC2 File Offset: 0x000EBEC2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITextTransition._ClassPtr;
		}

		// Token: 0x0600A0A2 RID: 41122 RVA: 0x000EDCD0 File Offset: 0x000EBED0
		public UUITextTransition() : this(BuiltinUtils.AllocNativeUObject(UUITextTransition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A0A3 RID: 41123 RVA: 0x000EDCF8 File Offset: 0x000EBEF8
		[NullableContext(1)]
		public UUITextTransition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUITextTransition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x0600A0A4 RID: 41124 RVA: 0x000EDD2C File Offset: 0x000EBF2C
		// (set) Token: 0x0600A0A5 RID: 41125 RVA: 0x000EDD65 File Offset: 0x000EBF65
		[Nullable(1)]
		public FTextTransitionInfo TransitionInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfo result;
				if ((result = this._TransitionInfo) == null)
				{
					result = (this._TransitionInfo = new FTextTransitionInfo(base.NativePtr + (IntPtr)UUITextTransition.__PropertyOffset_TransitionInfo, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfo.StaticStruct(), base.NativePtr + (IntPtr)UUITextTransition.__PropertyOffset_TransitionInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x0600A0A6 RID: 41126 RVA: 0x000EDD86 File Offset: 0x000EBF86
		// (set) Token: 0x0600A0A7 RID: 41127 RVA: 0x000EDD9A File Offset: 0x000EBF9A
		public unsafe ULTweener FontColorTweener
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + UUITextTransition.__PropertyOffset_FontColorTweener);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUITextTransition.__PropertyOffset_FontColorTweener, value);
			}
		}

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x0600A0A8 RID: 41128 RVA: 0x000EDDAF File Offset: 0x000EBFAF
		// (set) Token: 0x0600A0A9 RID: 41129 RVA: 0x000EDDC3 File Offset: 0x000EBFC3
		public unsafe ULTweener OutlineColorTweener
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + UUITextTransition.__PropertyOffset_OutlineColorTweener);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUITextTransition.__PropertyOffset_OutlineColorTweener, value);
			}
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x000EDDD8 File Offset: 0x000EBFD8
		static UUITextTransition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextTransition");
		}

		// Token: 0x0600A0AB RID: 41131 RVA: 0x000EDDE6 File Offset: 0x000EBFE6
		protected UUITextTransition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040044D1 RID: 17617
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextTransition";

		// Token: 0x040044D2 RID: 17618
		private static IntPtr _ClassPtr;

		// Token: 0x040044D3 RID: 17619
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040044D4 RID: 17620
		internal static int __PropertyOffset_TransitionInfo;

		// Token: 0x040044D5 RID: 17621
		private FTextTransitionInfo _TransitionInfo;

		// Token: 0x040044D6 RID: 17622
		internal static int __PropertyOffset_FontColorTweener;

		// Token: 0x040044D7 RID: 17623
		internal static int __PropertyOffset_OutlineColorTweener;
	}
}
