using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D38 RID: 7480
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_StopAction")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Buff_StopAction : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CAA9 RID: 117417 RVA: 0x002A60BF File Offset: 0x002A42BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_StopAction._ClassPtr;
		}

		// Token: 0x0601CAAA RID: 117418 RVA: 0x002A60CC File Offset: 0x002A42CC
		public UKSC_Buff_StopAction() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_StopAction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CAAB RID: 117419 RVA: 0x002A60F4 File Offset: 0x002A42F4
		[NullableContext(1)]
		public UKSC_Buff_StopAction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_StopAction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007352 RID: 29522
		// (get) Token: 0x0601CAAC RID: 117420 RVA: 0x002A6127 File Offset: 0x002A4327
		// (set) Token: 0x0601CAAD RID: 117421 RVA: 0x002A613B File Offset: 0x002A433B
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_StopAction DaBuffMoveStop_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_StopAction>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_StopAction.__PropertyOffset_DaBuffMoveStop_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_StopAction.__PropertyOffset_DaBuffMoveStop_, value);
			}
		}

		// Token: 0x0601CAAE RID: 117422 RVA: 0x002A6150 File Offset: 0x002A4350
		static UKSC_Buff_StopAction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_StopAction");
		}

		// Token: 0x0601CAAF RID: 117423 RVA: 0x002A615E File Offset: 0x002A435E
		protected UKSC_Buff_StopAction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F8A8 RID: 63656
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_StopAction";

		// Token: 0x0400F8A9 RID: 63657
		private static IntPtr _ClassPtr;

		// Token: 0x0400F8AA RID: 63658
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F8AB RID: 63659
		internal static int __PropertyOffset_DaBuffMoveStop_;
	}
}
