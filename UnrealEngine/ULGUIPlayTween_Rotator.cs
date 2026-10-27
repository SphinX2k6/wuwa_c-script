using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200209C RID: 8348
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween_Rotator")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class ULGUIPlayTween_Rotator : ULGUIPlayTween, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F7B5 RID: 128949 RVA: 0x002EC5A1 File Offset: 0x002EA7A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween_Rotator._ClassPtr;
		}

		// Token: 0x0601F7B6 RID: 128950 RVA: 0x002EC5B0 File Offset: 0x002EA7B0
		public ULGUIPlayTween_Rotator() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Rotator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F7B7 RID: 128951 RVA: 0x002EC5D8 File Offset: 0x002EA7D8
		public ULGUIPlayTween_Rotator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Rotator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C30 RID: 31792
		// (get) Token: 0x0601F7B8 RID: 128952 RVA: 0x002EC60B File Offset: 0x002EA80B
		// (set) Token: 0x0601F7B9 RID: 128953 RVA: 0x002EC61F File Offset: 0x002EA81F
		public unsafe FRotator from
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Rotator.__PropertyOffset_from);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Rotator.__PropertyOffset_from) = value;
			}
		}

		// Token: 0x17007C31 RID: 31793
		// (get) Token: 0x0601F7BA RID: 128954 RVA: 0x002EC634 File Offset: 0x002EA834
		// (set) Token: 0x0601F7BB RID: 128955 RVA: 0x002EC648 File Offset: 0x002EA848
		public unsafe FRotator to
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Rotator.__PropertyOffset_to);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Rotator.__PropertyOffset_to) = value;
			}
		}

		// Token: 0x17007C32 RID: 31794
		// (get) Token: 0x0601F7BC RID: 128956 RVA: 0x002EC660 File Offset: 0x002EA860
		// (set) Token: 0x0601F7BD RID: 128957 RVA: 0x002EC699 File Offset: 0x002EA899
		public FLGUIDrawableEvent onUpdateValue
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._onUpdateValue) == null)
				{
					result = (this._onUpdateValue = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)ULGUIPlayTween_Rotator.__PropertyOffset_onUpdateValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)ULGUIPlayTween_Rotator.__PropertyOffset_onUpdateValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F7BE RID: 128958 RVA: 0x002EC6BA File Offset: 0x002EA8BA
		static ULGUIPlayTween_Rotator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween_Rotator");
		}

		// Token: 0x0601F7BF RID: 128959 RVA: 0x002EC6C8 File Offset: 0x002EA8C8
		protected ULGUIPlayTween_Rotator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FFD RID: 69629
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween_Rotator";

		// Token: 0x04010FFE RID: 69630
		private static IntPtr _ClassPtr;

		// Token: 0x04010FFF RID: 69631
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011000 RID: 69632
		internal static int __PropertyOffset_from;

		// Token: 0x04011001 RID: 69633
		internal static int __PropertyOffset_to;

		// Token: 0x04011002 RID: 69634
		internal static int __PropertyOffset_onUpdateValue;

		// Token: 0x04011003 RID: 69635
		[Nullable(2)]
		private FLGUIDrawableEvent _onUpdateValue;
	}
}
