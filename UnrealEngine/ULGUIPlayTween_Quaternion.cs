using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200209B RID: 8347
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween_Quaternion")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class ULGUIPlayTween_Quaternion : ULGUIPlayTween, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F7AA RID: 128938 RVA: 0x002EC471 File Offset: 0x002EA671
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween_Quaternion._ClassPtr;
		}

		// Token: 0x0601F7AB RID: 128939 RVA: 0x002EC480 File Offset: 0x002EA680
		public ULGUIPlayTween_Quaternion() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Quaternion.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F7AC RID: 128940 RVA: 0x002EC4A8 File Offset: 0x002EA6A8
		public ULGUIPlayTween_Quaternion(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Quaternion.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C2D RID: 31789
		// (get) Token: 0x0601F7AD RID: 128941 RVA: 0x002EC4DB File Offset: 0x002EA6DB
		// (set) Token: 0x0601F7AE RID: 128942 RVA: 0x002EC4EF File Offset: 0x002EA6EF
		public unsafe FQuat from
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Quaternion.__PropertyOffset_from);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Quaternion.__PropertyOffset_from) = value;
			}
		}

		// Token: 0x17007C2E RID: 31790
		// (get) Token: 0x0601F7AF RID: 128943 RVA: 0x002EC504 File Offset: 0x002EA704
		// (set) Token: 0x0601F7B0 RID: 128944 RVA: 0x002EC518 File Offset: 0x002EA718
		public unsafe FQuat to
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Quaternion.__PropertyOffset_to);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Quaternion.__PropertyOffset_to) = value;
			}
		}

		// Token: 0x17007C2F RID: 31791
		// (get) Token: 0x0601F7B1 RID: 128945 RVA: 0x002EC530 File Offset: 0x002EA730
		// (set) Token: 0x0601F7B2 RID: 128946 RVA: 0x002EC569 File Offset: 0x002EA769
		public FLGUIDrawableEvent onUpdateValue
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._onUpdateValue) == null)
				{
					result = (this._onUpdateValue = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)ULGUIPlayTween_Quaternion.__PropertyOffset_onUpdateValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)ULGUIPlayTween_Quaternion.__PropertyOffset_onUpdateValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F7B3 RID: 128947 RVA: 0x002EC58A File Offset: 0x002EA78A
		static ULGUIPlayTween_Quaternion()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween_Quaternion");
		}

		// Token: 0x0601F7B4 RID: 128948 RVA: 0x002EC598 File Offset: 0x002EA798
		protected ULGUIPlayTween_Quaternion(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FF6 RID: 69622
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween_Quaternion";

		// Token: 0x04010FF7 RID: 69623
		private static IntPtr _ClassPtr;

		// Token: 0x04010FF8 RID: 69624
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FF9 RID: 69625
		internal static int __PropertyOffset_from;

		// Token: 0x04010FFA RID: 69626
		internal static int __PropertyOffset_to;

		// Token: 0x04010FFB RID: 69627
		internal static int __PropertyOffset_onUpdateValue;

		// Token: 0x04010FFC RID: 69628
		[Nullable(2)]
		private FLGUIDrawableEvent _onUpdateValue;
	}
}
