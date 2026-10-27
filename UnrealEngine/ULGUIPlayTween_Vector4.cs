using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200209F RID: 8351
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUIPlayTween_Vector4")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class ULGUIPlayTween_Vector4 : ULGUIPlayTween, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F7D6 RID: 128982 RVA: 0x002EC931 File Offset: 0x002EAB31
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIPlayTween_Vector4._ClassPtr;
		}

		// Token: 0x0601F7D7 RID: 128983 RVA: 0x002EC940 File Offset: 0x002EAB40
		public ULGUIPlayTween_Vector4() : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Vector4.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F7D8 RID: 128984 RVA: 0x002EC968 File Offset: 0x002EAB68
		public ULGUIPlayTween_Vector4(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIPlayTween_Vector4.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007C39 RID: 31801
		// (get) Token: 0x0601F7D9 RID: 128985 RVA: 0x002EC99B File Offset: 0x002EAB9B
		// (set) Token: 0x0601F7DA RID: 128986 RVA: 0x002EC9AF File Offset: 0x002EABAF
		public unsafe FVector4 from
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector4.__PropertyOffset_from);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector4.__PropertyOffset_from) = value;
			}
		}

		// Token: 0x17007C3A RID: 31802
		// (get) Token: 0x0601F7DB RID: 128987 RVA: 0x002EC9C4 File Offset: 0x002EABC4
		// (set) Token: 0x0601F7DC RID: 128988 RVA: 0x002EC9D8 File Offset: 0x002EABD8
		public unsafe FVector4 to
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector4.__PropertyOffset_to);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector4.__PropertyOffset_to) = value;
			}
		}

		// Token: 0x17007C3B RID: 31803
		// (get) Token: 0x0601F7DD RID: 128989 RVA: 0x002EC9F0 File Offset: 0x002EABF0
		// (set) Token: 0x0601F7DE RID: 128990 RVA: 0x002ECA29 File Offset: 0x002EAC29
		public FLGUIDrawableEvent onUpdateValue
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._onUpdateValue) == null)
				{
					result = (this._onUpdateValue = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)ULGUIPlayTween_Vector4.__PropertyOffset_onUpdateValue, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)ULGUIPlayTween_Vector4.__PropertyOffset_onUpdateValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F7DF RID: 128991 RVA: 0x002ECA4A File Offset: 0x002EAC4A
		static ULGUIPlayTween_Vector4()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIPlayTween_Vector4");
		}

		// Token: 0x0601F7E0 RID: 128992 RVA: 0x002ECA58 File Offset: 0x002EAC58
		protected ULGUIPlayTween_Vector4(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011012 RID: 69650
		public new const string __ObjectPath = "/Script/LGUI.LGUIPlayTween_Vector4";

		// Token: 0x04011013 RID: 69651
		private static IntPtr _ClassPtr;

		// Token: 0x04011014 RID: 69652
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011015 RID: 69653
		internal static int __PropertyOffset_from;

		// Token: 0x04011016 RID: 69654
		internal static int __PropertyOffset_to;

		// Token: 0x04011017 RID: 69655
		internal static int __PropertyOffset_onUpdateValue;

		// Token: 0x04011018 RID: 69656
		[Nullable(2)]
		private FLGUIDrawableEvent _onUpdateValue;
	}
}
