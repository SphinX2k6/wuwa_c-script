using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200209D RID: 8349
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween_Vector2")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class ULGUIPlayTween_Vector2 : ULGUIPlayTween, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F7C0 RID: 128960 RVA: 0x002EC6D1 File Offset: 0x002EA8D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween_Vector2._ClassPtr;
		}

		// Token: 0x0601F7C1 RID: 128961 RVA: 0x002EC6E0 File Offset: 0x002EA8E0
		public ULGUIPlayTween_Vector2() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Vector2.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F7C2 RID: 128962 RVA: 0x002EC708 File Offset: 0x002EA908
		public ULGUIPlayTween_Vector2(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Vector2.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C33 RID: 31795
		// (get) Token: 0x0601F7C3 RID: 128963 RVA: 0x002EC73B File Offset: 0x002EA93B
		// (set) Token: 0x0601F7C4 RID: 128964 RVA: 0x002EC74F File Offset: 0x002EA94F
		public unsafe FVector2D from
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector2.__PropertyOffset_from);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector2.__PropertyOffset_from) = value;
			}
		}

		// Token: 0x17007C34 RID: 31796
		// (get) Token: 0x0601F7C5 RID: 128965 RVA: 0x002EC764 File Offset: 0x002EA964
		// (set) Token: 0x0601F7C6 RID: 128966 RVA: 0x002EC778 File Offset: 0x002EA978
		public unsafe FVector2D to
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector2.__PropertyOffset_to);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector2.__PropertyOffset_to) = value;
			}
		}

		// Token: 0x17007C35 RID: 31797
		// (get) Token: 0x0601F7C7 RID: 128967 RVA: 0x002EC790 File Offset: 0x002EA990
		// (set) Token: 0x0601F7C8 RID: 128968 RVA: 0x002EC7C9 File Offset: 0x002EA9C9
		public FLGUIDrawableEvent onUpdateValue
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._onUpdateValue) == null)
				{
					result = (this._onUpdateValue = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector2.__PropertyOffset_onUpdateValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)ULGUIPlayTween_Vector2.__PropertyOffset_onUpdateValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F7C9 RID: 128969 RVA: 0x002EC7EA File Offset: 0x002EA9EA
		static ULGUIPlayTween_Vector2()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween_Vector2");
		}

		// Token: 0x0601F7CA RID: 128970 RVA: 0x002EC7F8 File Offset: 0x002EA9F8
		protected ULGUIPlayTween_Vector2(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011004 RID: 69636
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween_Vector2";

		// Token: 0x04011005 RID: 69637
		private static IntPtr _ClassPtr;

		// Token: 0x04011006 RID: 69638
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011007 RID: 69639
		internal static int __PropertyOffset_from;

		// Token: 0x04011008 RID: 69640
		internal static int __PropertyOffset_to;

		// Token: 0x04011009 RID: 69641
		internal static int __PropertyOffset_onUpdateValue;

		// Token: 0x0401100A RID: 69642
		[Nullable(2)]
		private FLGUIDrawableEvent _onUpdateValue;
	}
}
