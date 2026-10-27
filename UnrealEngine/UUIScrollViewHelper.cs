using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021A6 RID: 8614
	[UnrealObjectPath("/Script/LGUI.UIScrollViewHelper")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UUIScrollViewHelper : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020B24 RID: 133924 RVA: 0x00305CFE File Offset: 0x00303EFE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIScrollViewHelper._ClassPtr;
		}

		// Token: 0x06020B25 RID: 133925 RVA: 0x00305D0C File Offset: 0x00303F0C
		public UUIScrollViewHelper() : this(BuiltinUtils.AllocNativeUObject(UUIScrollViewHelper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020B26 RID: 133926 RVA: 0x00305D34 File Offset: 0x00303F34
		[NullableContext(1)]
		public UUIScrollViewHelper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIScrollViewHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007FC8 RID: 32712
		// (get) Token: 0x06020B27 RID: 133927 RVA: 0x00305D67 File Offset: 0x00303F67
		// (set) Token: 0x06020B28 RID: 133928 RVA: 0x00305D7B File Offset: 0x00303F7B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIScrollViewComponent> TargetComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewHelper.__PropertyOffset_TargetComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewHelper.__PropertyOffset_TargetComp) = value;
			}
		}

		// Token: 0x06020B29 RID: 133929 RVA: 0x00305D90 File Offset: 0x00303F90
		static UUIScrollViewHelper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIScrollViewHelper");
		}

		// Token: 0x06020B2A RID: 133930 RVA: 0x00305D9E File Offset: 0x00303F9E
		protected UUIScrollViewHelper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117CF RID: 71631
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIScrollViewHelper";

		// Token: 0x040117D0 RID: 71632
		private static IntPtr _ClassPtr;

		// Token: 0x040117D1 RID: 71633
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040117D2 RID: 71634
		internal static int __PropertyOffset_TargetComp;
	}
}
