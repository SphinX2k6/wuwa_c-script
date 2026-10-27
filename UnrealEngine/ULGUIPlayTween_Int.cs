using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002099 RID: 8345
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween_Int")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class ULGUIPlayTween_Int : ULGUIPlayTween, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F794 RID: 128916 RVA: 0x002EC221 File Offset: 0x002EA421
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween_Int._ClassPtr;
		}

		// Token: 0x0601F795 RID: 128917 RVA: 0x002EC230 File Offset: 0x002EA430
		public ULGUIPlayTween_Int() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Int.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F796 RID: 128918 RVA: 0x002EC258 File Offset: 0x002EA458
		public ULGUIPlayTween_Int(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Int.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C27 RID: 31783
		// (get) Token: 0x0601F797 RID: 128919 RVA: 0x002EC28B File Offset: 0x002EA48B
		// (set) Token: 0x0601F798 RID: 128920 RVA: 0x002EC29B File Offset: 0x002EA49B
		public unsafe int from
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Int.__PropertyOffset_from);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Int.__PropertyOffset_from) = value;
			}
		}

		// Token: 0x17007C28 RID: 31784
		// (get) Token: 0x0601F799 RID: 128921 RVA: 0x002EC2AC File Offset: 0x002EA4AC
		// (set) Token: 0x0601F79A RID: 128922 RVA: 0x002EC2BC File Offset: 0x002EA4BC
		public unsafe int to
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Int.__PropertyOffset_to);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Int.__PropertyOffset_to) = value;
			}
		}

		// Token: 0x17007C29 RID: 31785
		// (get) Token: 0x0601F79B RID: 128923 RVA: 0x002EC2D0 File Offset: 0x002EA4D0
		// (set) Token: 0x0601F79C RID: 128924 RVA: 0x002EC309 File Offset: 0x002EA509
		public FLGUIDrawableEvent onUpdateValue
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._onUpdateValue) == null)
				{
					result = (this._onUpdateValue = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)ULGUIPlayTween_Int.__PropertyOffset_onUpdateValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)ULGUIPlayTween_Int.__PropertyOffset_onUpdateValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F79D RID: 128925 RVA: 0x002EC32A File Offset: 0x002EA52A
		static ULGUIPlayTween_Int()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween_Int");
		}

		// Token: 0x0601F79E RID: 128926 RVA: 0x002EC338 File Offset: 0x002EA538
		protected ULGUIPlayTween_Int(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FE8 RID: 69608
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween_Int";

		// Token: 0x04010FE9 RID: 69609
		private static IntPtr _ClassPtr;

		// Token: 0x04010FEA RID: 69610
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FEB RID: 69611
		internal static int __PropertyOffset_from;

		// Token: 0x04010FEC RID: 69612
		internal static int __PropertyOffset_to;

		// Token: 0x04010FED RID: 69613
		internal static int __PropertyOffset_onUpdateValue;

		// Token: 0x04010FEE RID: 69614
		[Nullable(2)]
		private FLGUIDrawableEvent _onUpdateValue;
	}
}
