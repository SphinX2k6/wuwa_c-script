using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021D2 RID: 8658
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UITextTransition")]
	[UnrealStructLayout(920, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 920)]
	public class UUITextTransition : UUITransitionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020FBC RID: 135100 RVA: 0x0030AC59 File Offset: 0x00308E59
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITextTransition._ClassPtr;
		}

		// Token: 0x06020FBD RID: 135101 RVA: 0x0030AC68 File Offset: 0x00308E68
		public UUITextTransition() : this(BuiltinUtils.AllocNativeUObject(UUITextTransition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020FBE RID: 135102 RVA: 0x0030AC90 File Offset: 0x00308E90
		[NullableContext(1)]
		public UUITextTransition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUITextTransition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170080C3 RID: 32963
		// (get) Token: 0x06020FBF RID: 135103 RVA: 0x0030ACC4 File Offset: 0x00308EC4
		// (set) Token: 0x06020FC0 RID: 135104 RVA: 0x0030ACFD File Offset: 0x00308EFD
		[Nullable(1)]
		public FTextTransitionInfo TransitionInfo
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfo result;
				if ((result = this._TransitionInfo) == null)
				{
					result = (this._TransitionInfo = new FTextTransitionInfo(base.NativePtr + (IntPtr)UUITextTransition.__PropertyOffset_TransitionInfo, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfo.StaticStruct(), base.NativePtr + (IntPtr)UUITextTransition.__PropertyOffset_TransitionInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170080C4 RID: 32964
		// (get) Token: 0x06020FC1 RID: 135105 RVA: 0x0030AD1E File Offset: 0x00308F1E
		// (set) Token: 0x06020FC2 RID: 135106 RVA: 0x0030AD32 File Offset: 0x00308F32
		public unsafe ULTweener FontColorTweener
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + UUITextTransition.__PropertyOffset_FontColorTweener);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUITextTransition.__PropertyOffset_FontColorTweener, value);
			}
		}

		// Token: 0x170080C5 RID: 32965
		// (get) Token: 0x06020FC3 RID: 135107 RVA: 0x0030AD47 File Offset: 0x00308F47
		// (set) Token: 0x06020FC4 RID: 135108 RVA: 0x0030AD5B File Offset: 0x00308F5B
		public unsafe ULTweener OutlineColorTweener
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + UUITextTransition.__PropertyOffset_OutlineColorTweener);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUITextTransition.__PropertyOffset_OutlineColorTweener, value);
			}
		}

		// Token: 0x06020FC5 RID: 135109 RVA: 0x0030AD70 File Offset: 0x00308F70
		static UUITextTransition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextTransition");
		}

		// Token: 0x06020FC6 RID: 135110 RVA: 0x0030AD7E File Offset: 0x00308F7E
		protected UUITextTransition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119B5 RID: 72117
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextTransition";

		// Token: 0x040119B6 RID: 72118
		private static IntPtr _ClassPtr;

		// Token: 0x040119B7 RID: 72119
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119B8 RID: 72120
		internal static int __PropertyOffset_TransitionInfo;

		// Token: 0x040119B9 RID: 72121
		private FTextTransitionInfo _TransitionInfo;

		// Token: 0x040119BA RID: 72122
		internal static int __PropertyOffset_FontColorTweener;

		// Token: 0x040119BB RID: 72123
		internal static int __PropertyOffset_OutlineColorTweener;
	}
}
