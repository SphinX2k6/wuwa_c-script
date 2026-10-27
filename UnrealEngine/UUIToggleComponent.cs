using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021DB RID: 8667
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIToggleComponent")]
	[UnrealStructLayout(1232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1232)]
	public class UUIToggleComponent : UUISelectableComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021060 RID: 135264 RVA: 0x0030B7D0 File Offset: 0x003099D0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIToggleComponent._ClassPtr;
		}

		// Token: 0x06021061 RID: 135265 RVA: 0x0030B7DC File Offset: 0x003099DC
		public UUIToggleComponent() : this(BuiltinUtils.AllocNativeUObject(UUIToggleComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021062 RID: 135266 RVA: 0x0030B804 File Offset: 0x00309A04
		public UUIToggleComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIToggleComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170080E5 RID: 32997
		// (get) Token: 0x06021063 RID: 135267 RVA: 0x0030B837 File Offset: 0x00309A37
		// (set) Token: 0x06021064 RID: 135268 RVA: 0x0030B84B File Offset: 0x00309A4B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> ToggleActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleActor) = value;
			}
		}

		// Token: 0x170080E6 RID: 32998
		// (get) Token: 0x06021065 RID: 135269 RVA: 0x0030B860 File Offset: 0x00309A60
		// (set) Token: 0x06021066 RID: 135270 RVA: 0x0030B870 File Offset: 0x00309A70
		public unsafe UIToggleTransitionType ToggleTransition
		{
			get
			{
				return (UIToggleTransitionType)(*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleTransition));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleTransition) = (byte)value;
			}
		}

		// Token: 0x170080E7 RID: 32999
		// (get) Token: 0x06021067 RID: 135271 RVA: 0x0030B881 File Offset: 0x00309A81
		// (set) Token: 0x06021068 RID: 135272 RVA: 0x0030B895 File Offset: 0x00309A95
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUISelectableTransitionComponent> ToggleTransitionComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleTransitionComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleTransitionComp) = value;
			}
		}

		// Token: 0x170080E8 RID: 33000
		// (get) Token: 0x06021069 RID: 135273 RVA: 0x0030B8AA File Offset: 0x00309AAA
		// (set) Token: 0x0602106A RID: 135274 RVA: 0x0030B8BE File Offset: 0x00309ABE
		[Nullable(2)]
		public unsafe ULTweener ToggleTransitionTweener
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + UUIToggleComponent.__PropertyOffset_ToggleTransitionTweener);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIToggleComponent.__PropertyOffset_ToggleTransitionTweener, value);
			}
		}

		// Token: 0x170080E9 RID: 33001
		// (get) Token: 0x0602106B RID: 135275 RVA: 0x0030B8D3 File Offset: 0x00309AD3
		// (set) Token: 0x0602106C RID: 135276 RVA: 0x0030B8E3 File Offset: 0x00309AE3
		public unsafe float OnAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnAlpha) = value;
			}
		}

		// Token: 0x170080EA RID: 33002
		// (get) Token: 0x0602106D RID: 135277 RVA: 0x0030B8F4 File Offset: 0x00309AF4
		// (set) Token: 0x0602106E RID: 135278 RVA: 0x0030B904 File Offset: 0x00309B04
		public unsafe float OffAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffAlpha) = value;
			}
		}

		// Token: 0x170080EB RID: 33003
		// (get) Token: 0x0602106F RID: 135279 RVA: 0x0030B915 File Offset: 0x00309B15
		// (set) Token: 0x06021070 RID: 135280 RVA: 0x0030B929 File Offset: 0x00309B29
		public unsafe FColor OnColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnColor) = value;
			}
		}

		// Token: 0x170080EC RID: 33004
		// (get) Token: 0x06021071 RID: 135281 RVA: 0x0030B93E File Offset: 0x00309B3E
		// (set) Token: 0x06021072 RID: 135282 RVA: 0x0030B952 File Offset: 0x00309B52
		public unsafe FColor OffColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffColor) = value;
			}
		}

		// Token: 0x170080ED RID: 33005
		// (get) Token: 0x06021073 RID: 135283 RVA: 0x0030B967 File Offset: 0x00309B67
		// (set) Token: 0x06021074 RID: 135284 RVA: 0x0030B977 File Offset: 0x00309B77
		public unsafe float ToggleDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_ToggleDuration) = value;
			}
		}

		// Token: 0x170080EE RID: 33006
		// (get) Token: 0x06021075 RID: 135285 RVA: 0x0030B988 File Offset: 0x00309B88
		// (set) Token: 0x06021076 RID: 135286 RVA: 0x0030B99C File Offset: 0x00309B9C
		public unsafe FName OnTransitionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnTransitionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnTransitionName) = value;
			}
		}

		// Token: 0x170080EF RID: 33007
		// (get) Token: 0x06021077 RID: 135287 RVA: 0x0030B9B1 File Offset: 0x00309BB1
		// (set) Token: 0x06021078 RID: 135288 RVA: 0x0030B9C5 File Offset: 0x00309BC5
		public unsafe FName OffTransitionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffTransitionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffTransitionName) = value;
			}
		}

		// Token: 0x170080F0 RID: 33008
		// (get) Token: 0x06021079 RID: 135289 RVA: 0x0030B9DA File Offset: 0x00309BDA
		// (set) Token: 0x0602107A RID: 135290 RVA: 0x0030B9EE File Offset: 0x00309BEE
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> OnActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnActor) = value;
			}
		}

		// Token: 0x170080F1 RID: 33009
		// (get) Token: 0x0602107B RID: 135291 RVA: 0x0030BA03 File Offset: 0x00309C03
		// (set) Token: 0x0602107C RID: 135292 RVA: 0x0030BA17 File Offset: 0x00309C17
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> OffActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OffActor) = value;
			}
		}

		// Token: 0x170080F2 RID: 33010
		// (get) Token: 0x0602107D RID: 135293 RVA: 0x0030BA2C File Offset: 0x00309C2C
		// (set) Token: 0x0602107E RID: 135294 RVA: 0x0030BA3C File Offset: 0x00309C3C
		public unsafe bool IsOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_IsOn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_IsOn) = (value ? 1 : 0);
			}
		}

		// Token: 0x170080F3 RID: 33011
		// (get) Token: 0x0602107F RID: 135295 RVA: 0x0030BA4D File Offset: 0x00309C4D
		// (set) Token: 0x06021080 RID: 135296 RVA: 0x0030BA5D File Offset: 0x00309C5D
		public unsafe bool bToggleOnSelect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_bToggleOnSelect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_bToggleOnSelect) = (value ? 1 : 0);
			}
		}

		// Token: 0x170080F4 RID: 33012
		// (get) Token: 0x06021081 RID: 135297 RVA: 0x0030BA6E File Offset: 0x00309C6E
		// (set) Token: 0x06021082 RID: 135298 RVA: 0x0030BA82 File Offset: 0x00309C82
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> UIToggleGroupActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_UIToggleGroupActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_UIToggleGroupActor) = value;
			}
		}

		// Token: 0x170080F5 RID: 33013
		// (get) Token: 0x06021083 RID: 135299 RVA: 0x0030BA97 File Offset: 0x00309C97
		// (set) Token: 0x06021084 RID: 135300 RVA: 0x0030BAAB File Offset: 0x00309CAB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIToggleGroupComponent> GroupComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_GroupComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_GroupComp) = value;
			}
		}

		// Token: 0x170080F6 RID: 33014
		// (get) Token: 0x06021085 RID: 135301 RVA: 0x0030BAC0 File Offset: 0x00309CC0
		// (set) Token: 0x06021086 RID: 135302 RVA: 0x0030BAF9 File Offset: 0x00309CF9
		public FLGUIDrawableEvent OnToggle
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnToggle) == null)
				{
					result = (this._OnToggle = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnToggle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnToggle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170080F7 RID: 33015
		// (get) Token: 0x06021087 RID: 135303 RVA: 0x0030BB1C File Offset: 0x00309D1C
		// (set) Token: 0x06021088 RID: 135304 RVA: 0x0030BB55 File Offset: 0x00309D55
		public FLGUIToggleDynamicDelegate OnToggleEvent
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIToggleDynamicDelegate result;
				if ((result = this._OnToggleEvent) == null)
				{
					result = (this._OnToggleEvent = new FLGUIToggleDynamicDelegate(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnToggleEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIToggleComponent.__PropertyOffset_OnToggleEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06021089 RID: 135305 RVA: 0x0030BB76 File Offset: 0x00309D76
		[NullableContext(2)]
		public void UnregisterToggleEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIToggleComponent.__UnregisterToggleEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0602108A RID: 135306 RVA: 0x0030BB93 File Offset: 0x00309D93
		public void SetValue(bool newValue, bool fireEvent = true)
		{
			UUIToggleComponent.__SetValue_Internal(base.NativePtr, newValue, fireEvent);
		}

		// Token: 0x0602108B RID: 135307 RVA: 0x0030BBA2 File Offset: 0x00309DA2
		[NullableContext(2)]
		public void SetToggleGroup(UUIToggleGroupComponent InGroupComp)
		{
			UUIToggleComponent.__SetToggleGroup_Internal(base.NativePtr, (InGroupComp != null) ? InGroupComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602108C RID: 135308 RVA: 0x0030BBBF File Offset: 0x00309DBF
		public void SetState(bool newState, bool fireEvent = true)
		{
			UUIToggleComponent.__SetState_Internal(base.NativePtr, newState, fireEvent);
		}

		// Token: 0x0602108D RID: 135309 RVA: 0x0030BBCE File Offset: 0x00309DCE
		public FLGUIDelegateHandleWrapper RegisterToggleEvent([Nullable(2)] in FLGUIToggleDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIToggleDynamicDelegate flguitoggleDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIToggleComponent.__RegisterToggleEvent_Internal(nativePtr, (flguitoggleDynamicDelegate != null) ? flguitoggleDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0602108E RID: 135310 RVA: 0x0030BBF0 File Offset: 0x00309DF0
		public bool GetValue()
		{
			return UUIToggleComponent.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x0602108F RID: 135311 RVA: 0x0030BBFD File Offset: 0x00309DFD
		[NullableContext(2)]
		public AActor GetToggleGroupActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UUIToggleComponent.__GetToggleGroupActor_Internal(base.NativePtr));
		}

		// Token: 0x06021090 RID: 135312 RVA: 0x0030BC0F File Offset: 0x00309E0F
		public bool GetState()
		{
			return UUIToggleComponent.__GetState_Internal(base.NativePtr);
		}

		// Token: 0x06021091 RID: 135313 RVA: 0x0030BC1C File Offset: 0x00309E1C
		public int GetIndexInGroup()
		{
			return UUIToggleComponent.__GetIndexInGroup_Internal(base.NativePtr);
		}

		// Token: 0x06021092 RID: 135314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterToggleEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06021093 RID: 135315
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValue_Internal(IntPtr @this, bool newValue, bool fireEvent);

		// Token: 0x06021094 RID: 135316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToggleGroup_Internal(IntPtr @this, IntPtr InGroupComp);

		// Token: 0x06021095 RID: 135317
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetState_Internal(IntPtr @this, bool newState, bool fireEvent);

		// Token: 0x06021096 RID: 135318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterToggleEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06021097 RID: 135319
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetValue_Internal(IntPtr @this);

		// Token: 0x06021098 RID: 135320
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetToggleGroupActor_Internal(IntPtr @this);

		// Token: 0x06021099 RID: 135321
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetState_Internal(IntPtr @this);

		// Token: 0x0602109A RID: 135322
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIndexInGroup_Internal(IntPtr @this);

		// Token: 0x0602109B RID: 135323 RVA: 0x0030BC29 File Offset: 0x00309E29
		static UUIToggleComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIToggleComponent");
		}

		// Token: 0x0602109C RID: 135324 RVA: 0x0030BC37 File Offset: 0x00309E37
		protected UUIToggleComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119FA RID: 72186
		public new const string __ObjectPath = "/Script/LGUI.UIToggleComponent";

		// Token: 0x040119FB RID: 72187
		private static IntPtr _ClassPtr;

		// Token: 0x040119FC RID: 72188
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119FD RID: 72189
		internal static int __PropertyOffset_ToggleActor;

		// Token: 0x040119FE RID: 72190
		internal static int __PropertyOffset_ToggleTransition;

		// Token: 0x040119FF RID: 72191
		internal static int __PropertyOffset_ToggleTransitionComp;

		// Token: 0x04011A00 RID: 72192
		internal static int __PropertyOffset_ToggleTransitionTweener;

		// Token: 0x04011A01 RID: 72193
		internal static int __PropertyOffset_OnAlpha;

		// Token: 0x04011A02 RID: 72194
		internal static int __PropertyOffset_OffAlpha;

		// Token: 0x04011A03 RID: 72195
		internal static int __PropertyOffset_OnColor;

		// Token: 0x04011A04 RID: 72196
		internal static int __PropertyOffset_OffColor;

		// Token: 0x04011A05 RID: 72197
		internal static int __PropertyOffset_ToggleDuration;

		// Token: 0x04011A06 RID: 72198
		internal static int __PropertyOffset_OnTransitionName;

		// Token: 0x04011A07 RID: 72199
		internal static int __PropertyOffset_OffTransitionName;

		// Token: 0x04011A08 RID: 72200
		internal static int __PropertyOffset_OnActor;

		// Token: 0x04011A09 RID: 72201
		internal static int __PropertyOffset_OffActor;

		// Token: 0x04011A0A RID: 72202
		internal static int __PropertyOffset_IsOn;

		// Token: 0x04011A0B RID: 72203
		internal static int __PropertyOffset_bToggleOnSelect;

		// Token: 0x04011A0C RID: 72204
		internal static int __PropertyOffset_UIToggleGroupActor;

		// Token: 0x04011A0D RID: 72205
		internal static int __PropertyOffset_GroupComp;

		// Token: 0x04011A0E RID: 72206
		internal static int __PropertyOffset_OnToggle;

		// Token: 0x04011A0F RID: 72207
		[Nullable(2)]
		private FLGUIDrawableEvent _OnToggle;

		// Token: 0x04011A10 RID: 72208
		internal static int __PropertyOffset_OnToggleEvent;

		// Token: 0x04011A11 RID: 72209
		[Nullable(2)]
		private FLGUIToggleDynamicDelegate _OnToggleEvent;
	}
}
