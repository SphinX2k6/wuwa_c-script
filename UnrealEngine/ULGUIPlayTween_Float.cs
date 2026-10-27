using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002098 RID: 8344
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween_Float")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class ULGUIPlayTween_Float : ULGUIPlayTween, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F789 RID: 128905 RVA: 0x002EC101 File Offset: 0x002EA301
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween_Float._ClassPtr;
		}

		// Token: 0x0601F78A RID: 128906 RVA: 0x002EC110 File Offset: 0x002EA310
		public ULGUIPlayTween_Float() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Float.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F78B RID: 128907 RVA: 0x002EC138 File Offset: 0x002EA338
		public ULGUIPlayTween_Float(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Float.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C24 RID: 31780
		// (get) Token: 0x0601F78C RID: 128908 RVA: 0x002EC16B File Offset: 0x002EA36B
		// (set) Token: 0x0601F78D RID: 128909 RVA: 0x002EC17B File Offset: 0x002EA37B
		public unsafe float from
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Float.__PropertyOffset_from);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Float.__PropertyOffset_from) = value;
			}
		}

		// Token: 0x17007C25 RID: 31781
		// (get) Token: 0x0601F78E RID: 128910 RVA: 0x002EC18C File Offset: 0x002EA38C
		// (set) Token: 0x0601F78F RID: 128911 RVA: 0x002EC19C File Offset: 0x002EA39C
		public unsafe float to
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Float.__PropertyOffset_to);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Float.__PropertyOffset_to) = value;
			}
		}

		// Token: 0x17007C26 RID: 31782
		// (get) Token: 0x0601F790 RID: 128912 RVA: 0x002EC1B0 File Offset: 0x002EA3B0
		// (set) Token: 0x0601F791 RID: 128913 RVA: 0x002EC1E9 File Offset: 0x002EA3E9
		public FLGUIDrawableEvent onUpdateValue
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._onUpdateValue) == null)
				{
					result = (this._onUpdateValue = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)ULGUIPlayTween_Float.__PropertyOffset_onUpdateValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)ULGUIPlayTween_Float.__PropertyOffset_onUpdateValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F792 RID: 128914 RVA: 0x002EC20A File Offset: 0x002EA40A
		static ULGUIPlayTween_Float()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween_Float");
		}

		// Token: 0x0601F793 RID: 128915 RVA: 0x002EC218 File Offset: 0x002EA418
		protected ULGUIPlayTween_Float(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010FE1 RID: 69601
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween_Float";

		// Token: 0x04010FE2 RID: 69602
		private static IntPtr _ClassPtr;

		// Token: 0x04010FE3 RID: 69603
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010FE4 RID: 69604
		internal static int __PropertyOffset_from;

		// Token: 0x04010FE5 RID: 69605
		internal static int __PropertyOffset_to;

		// Token: 0x04010FE6 RID: 69606
		internal static int __PropertyOffset_onUpdateValue;

		// Token: 0x04010FE7 RID: 69607
		[Nullable(2)]
		private FLGUIDrawableEvent _onUpdateValue;
	}
}
