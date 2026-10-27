using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021AF RID: 8623
	[UnrealObjectPath("/Script/LGUI.UISizeControlByAspectRatioHelper")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UUISizeControlByAspectRatioHelper : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020CA6 RID: 134310 RVA: 0x00307617 File Offset: 0x00305817
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISizeControlByAspectRatioHelper._ClassPtr;
		}

		// Token: 0x06020CA7 RID: 134311 RVA: 0x00307624 File Offset: 0x00305824
		public UUISizeControlByAspectRatioHelper() : this(BuiltinUtils.AllocNativeUObject(UUISizeControlByAspectRatioHelper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020CA8 RID: 134312 RVA: 0x0030764C File Offset: 0x0030584C
		[NullableContext(1)]
		public UUISizeControlByAspectRatioHelper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISizeControlByAspectRatioHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008010 RID: 32784
		// (get) Token: 0x06020CA9 RID: 134313 RVA: 0x0030767F File Offset: 0x0030587F
		// (set) Token: 0x06020CAA RID: 134314 RVA: 0x00307693 File Offset: 0x00305893
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUISizeControlByAspectRatio> TargetComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByAspectRatioHelper.__PropertyOffset_TargetComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByAspectRatioHelper.__PropertyOffset_TargetComp) = value;
			}
		}

		// Token: 0x06020CAB RID: 134315 RVA: 0x003076A8 File Offset: 0x003058A8
		static UUISizeControlByAspectRatioHelper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISizeControlByAspectRatioHelper");
		}

		// Token: 0x06020CAC RID: 134316 RVA: 0x003076B6 File Offset: 0x003058B6
		protected UUISizeControlByAspectRatioHelper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011849 RID: 71753
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISizeControlByAspectRatioHelper";

		// Token: 0x0401184A RID: 71754
		private static IntPtr _ClassPtr;

		// Token: 0x0401184B RID: 71755
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401184C RID: 71756
		internal static int __PropertyOffset_TargetComp;
	}
}
