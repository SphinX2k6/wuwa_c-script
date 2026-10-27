using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200209A RID: 8346
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween_LinearColor")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class ULGUIPlayTween_LinearColor : ULGUIPlayTween, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F79F RID: 128927 RVA: 0x002EC341 File Offset: 0x002EA541
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween_LinearColor._ClassPtr;
		}

		// Token: 0x0601F7A0 RID: 128928 RVA: 0x002EC350 File Offset: 0x002EA550
		public ULGUIPlayTween_LinearColor() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_LinearColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F7A1 RID: 128929 RVA: 0x002EC378 File Offset: 0x002EA578
		public ULGUIPlayTween_LinearColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_LinearColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C2A RID: 31786
		// (get) Token: 0x0601F7A2 RID: 128930 RVA: 0x002EC3AB File Offset: 0x002EA5AB
		// (set) Token: 0x0601F7A3 RID: 128931 RVA: 0x002EC3BF File Offset: 0x002EA5BF
		public unsafe FLinearColor from
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_LinearColor.__PropertyOffset_from);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_LinearColor.__PropertyOffset_from) = value;
			}
		}

		// Token: 0x17007C2B RID: 31787
		// (get) Token: 0x0601F7A4 RID: 128932 RVA: 0x002EC3D4 File Offset: 0x002EA5D4
		// (set) Token: 0x0601F7A5 RID: 128933 RVA: 0x002EC3E8 File Offset: 0x002EA5E8
		public unsafe FLinearColor to
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_LinearColor.__PropertyOffset_to);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_LinearColor.__PropertyOffset_to) = value;
			}
		}

		// Token: 0x17007C2C RID: 31788
		// (get) Token: 0x0601F7A6 RID: 128934 RVA: 0x002EC400 File Offset: 0x002EA600
		// (set) Token: 0x0601F7A7 RID: 128935 RVA: 0x002EC439 File Offset: 0x002EA639
		public FLGUIDrawableEvent onUpdateValue
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._onUpdateValue) == null)
				{
					result = (this._onUpdateValue = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)ULGUIPlayTween_LinearColor.__PropertyOffset_onUpdateValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)ULGUIPlayTween_LinearColor.__PropertyOffset_onUpdateValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F7A8 RID: 128936 RVA: 0x002EC45A File Offset: 0x002EA65A
		static ULGUIPlayTween_LinearColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween_LinearColor");
		}

		// Token: 0x0601F7A9 RID: 128937 RVA: 0x002EC468 File Offset: 0x002EA668
		protected ULGUIPlayTween_LinearColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FEF RID: 69615
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween_LinearColor";

		// Token: 0x04010FF0 RID: 69616
		private static IntPtr _ClassPtr;

		// Token: 0x04010FF1 RID: 69617
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FF2 RID: 69618
		internal static int __PropertyOffset_from;

		// Token: 0x04010FF3 RID: 69619
		internal static int __PropertyOffset_to;

		// Token: 0x04010FF4 RID: 69620
		internal static int __PropertyOffset_onUpdateValue;

		// Token: 0x04010FF5 RID: 69621
		[Nullable(2)]
		private FLGUIDrawableEvent _onUpdateValue;
	}
}
