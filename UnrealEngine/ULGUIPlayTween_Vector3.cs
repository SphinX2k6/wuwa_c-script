using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200209E RID: 8350
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween_Vector3")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class ULGUIPlayTween_Vector3 : ULGUIPlayTween, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F7CB RID: 128971 RVA: 0x002EC801 File Offset: 0x002EAA01
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween_Vector3._ClassPtr;
		}

		// Token: 0x0601F7CC RID: 128972 RVA: 0x002EC810 File Offset: 0x002EAA10
		public ULGUIPlayTween_Vector3() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Vector3.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F7CD RID: 128973 RVA: 0x002EC838 File Offset: 0x002EAA38
		public ULGUIPlayTween_Vector3(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Vector3.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C36 RID: 31798
		// (get) Token: 0x0601F7CE RID: 128974 RVA: 0x002EC86B File Offset: 0x002EAA6B
		// (set) Token: 0x0601F7CF RID: 128975 RVA: 0x002EC87F File Offset: 0x002EAA7F
		public unsafe FVector from
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector3.__PropertyOffset_from);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector3.__PropertyOffset_from) = value;
			}
		}

		// Token: 0x17007C37 RID: 31799
		// (get) Token: 0x0601F7D0 RID: 128976 RVA: 0x002EC894 File Offset: 0x002EAA94
		// (set) Token: 0x0601F7D1 RID: 128977 RVA: 0x002EC8A8 File Offset: 0x002EAAA8
		public unsafe FVector to
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector3.__PropertyOffset_to);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector3.__PropertyOffset_to) = value;
			}
		}

		// Token: 0x17007C38 RID: 31800
		// (get) Token: 0x0601F7D2 RID: 128978 RVA: 0x002EC8C0 File Offset: 0x002EAAC0
		// (set) Token: 0x0601F7D3 RID: 128979 RVA: 0x002EC8F9 File Offset: 0x002EAAF9
		public FLGUIDrawableEvent onUpdateValue
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._onUpdateValue) == null)
				{
					result = (this._onUpdateValue = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector3.__PropertyOffset_onUpdateValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)ULGUIPlayTween_Vector3.__PropertyOffset_onUpdateValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F7D4 RID: 128980 RVA: 0x002EC91A File Offset: 0x002EAB1A
		static ULGUIPlayTween_Vector3()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween_Vector3");
		}

		// Token: 0x0601F7D5 RID: 128981 RVA: 0x002EC928 File Offset: 0x002EAB28
		protected ULGUIPlayTween_Vector3(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401100B RID: 69643
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween_Vector3";

		// Token: 0x0401100C RID: 69644
		private static IntPtr _ClassPtr;

		// Token: 0x0401100D RID: 69645
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401100E RID: 69646
		internal static int __PropertyOffset_from;

		// Token: 0x0401100F RID: 69647
		internal static int __PropertyOffset_to;

		// Token: 0x04011010 RID: 69648
		internal static int __PropertyOffset_onUpdateValue;

		// Token: 0x04011011 RID: 69649
		[Nullable(2)]
		private FLGUIDrawableEvent _onUpdateValue;
	}
}
