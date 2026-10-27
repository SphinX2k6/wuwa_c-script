using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021B1 RID: 8625
	[UnrealObjectPath("/Script/LGUI.UISizeControlByOtherHelper")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UUISizeControlByOtherHelper : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020CE2 RID: 134370 RVA: 0x003079BF File Offset: 0x00305BBF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISizeControlByOtherHelper._ClassPtr;
		}

		// Token: 0x06020CE3 RID: 134371 RVA: 0x003079CC File Offset: 0x00305BCC
		public UUISizeControlByOtherHelper() : this(BuiltinUtils.AllocNativeUObject(UUISizeControlByOtherHelper.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020CE4 RID: 134372 RVA: 0x003079F4 File Offset: 0x00305BF4
		[NullableContext(1)]
		public UUISizeControlByOtherHelper(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISizeControlByOtherHelper.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700801F RID: 32799
		// (get) Token: 0x06020CE5 RID: 134373 RVA: 0x00307A27 File Offset: 0x00305C27
		// (set) Token: 0x06020CE6 RID: 134374 RVA: 0x00307A3B File Offset: 0x00305C3B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUISizeControlByOther> TargetComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOtherHelper.__PropertyOffset_TargetComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOtherHelper.__PropertyOffset_TargetComp) = value;
			}
		}

		// Token: 0x06020CE7 RID: 134375 RVA: 0x00307A50 File Offset: 0x00305C50
		static UUISizeControlByOtherHelper()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISizeControlByOtherHelper");
		}

		// Token: 0x06020CE8 RID: 134376 RVA: 0x00307A5E File Offset: 0x00305C5E
		protected UUISizeControlByOtherHelper(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401185E RID: 71774
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISizeControlByOtherHelper";

		// Token: 0x0401185F RID: 71775
		private static IntPtr _ClassPtr;

		// Token: 0x04011860 RID: 71776
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011861 RID: 71777
		internal static int __PropertyOffset_TargetComp;
	}
}
