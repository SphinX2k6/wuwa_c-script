using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002097 RID: 8343
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween_Color")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class ULGUIPlayTween_Color : ULGUIPlayTween, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F77E RID: 128894 RVA: 0x002EBFD3 File Offset: 0x002EA1D3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween_Color._ClassPtr;
		}

		// Token: 0x0601F77F RID: 128895 RVA: 0x002EBFE0 File Offset: 0x002EA1E0
		public ULGUIPlayTween_Color() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Color.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F780 RID: 128896 RVA: 0x002EC008 File Offset: 0x002EA208
		public ULGUIPlayTween_Color(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Color.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C21 RID: 31777
		// (get) Token: 0x0601F781 RID: 128897 RVA: 0x002EC03B File Offset: 0x002EA23B
		// (set) Token: 0x0601F782 RID: 128898 RVA: 0x002EC04F File Offset: 0x002EA24F
		public unsafe FColor from
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Color.__PropertyOffset_from);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Color.__PropertyOffset_from) = value;
			}
		}

		// Token: 0x17007C22 RID: 31778
		// (get) Token: 0x0601F783 RID: 128899 RVA: 0x002EC064 File Offset: 0x002EA264
		// (set) Token: 0x0601F784 RID: 128900 RVA: 0x002EC078 File Offset: 0x002EA278
		public unsafe FColor to
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Color.__PropertyOffset_to);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Color.__PropertyOffset_to) = value;
			}
		}

		// Token: 0x17007C23 RID: 31779
		// (get) Token: 0x0601F785 RID: 128901 RVA: 0x002EC090 File Offset: 0x002EA290
		// (set) Token: 0x0601F786 RID: 128902 RVA: 0x002EC0C9 File Offset: 0x002EA2C9
		public FLGUIDrawableEvent onUpdateValue
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._onUpdateValue) == null)
				{
					result = (this._onUpdateValue = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)ULGUIPlayTween_Color.__PropertyOffset_onUpdateValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)ULGUIPlayTween_Color.__PropertyOffset_onUpdateValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F787 RID: 128903 RVA: 0x002EC0EA File Offset: 0x002EA2EA
		static ULGUIPlayTween_Color()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween_Color");
		}

		// Token: 0x0601F788 RID: 128904 RVA: 0x002EC0F8 File Offset: 0x002EA2F8
		protected ULGUIPlayTween_Color(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FDA RID: 69594
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween_Color";

		// Token: 0x04010FDB RID: 69595
		private static IntPtr _ClassPtr;

		// Token: 0x04010FDC RID: 69596
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FDD RID: 69597
		internal static int __PropertyOffset_from;

		// Token: 0x04010FDE RID: 69598
		internal static int __PropertyOffset_to;

		// Token: 0x04010FDF RID: 69599
		internal static int __PropertyOffset_onUpdateValue;

		// Token: 0x04010FE0 RID: 69600
		[Nullable(2)]
		private FLGUIDrawableEvent _onUpdateValue;
	}
}
