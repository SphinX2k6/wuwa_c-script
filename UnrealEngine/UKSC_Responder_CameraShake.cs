using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E1F RID: 7711
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Responder_CameraShake")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Responder_CameraShake : UKSC_EventResponder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D680 RID: 120448 RVA: 0x002B6F7D File Offset: 0x002B517D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Responder_CameraShake._ClassPtr;
		}

		// Token: 0x0601D681 RID: 120449 RVA: 0x002B6F8C File Offset: 0x002B518C
		public UKSC_Responder_CameraShake() : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_CameraShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D682 RID: 120450 RVA: 0x002B6FB4 File Offset: 0x002B51B4
		[NullableContext(1)]
		public UKSC_Responder_CameraShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Responder_CameraShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700768F RID: 30351
		// (get) Token: 0x0601D683 RID: 120451 RVA: 0x002B6FE7 File Offset: 0x002B51E7
		// (set) Token: 0x0601D684 RID: 120452 RVA: 0x002B6FF7 File Offset: 0x002B51F7
		public unsafe int ShakeKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Responder_CameraShake.__PropertyOffset_ShakeKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Responder_CameraShake.__PropertyOffset_ShakeKey) = value;
			}
		}

		// Token: 0x0601D685 RID: 120453 RVA: 0x002B7008 File Offset: 0x002B5208
		static UKSC_Responder_CameraShake()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Responder_CameraShake");
		}

		// Token: 0x0601D686 RID: 120454 RVA: 0x002B7016 File Offset: 0x002B5216
		protected UKSC_Responder_CameraShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF1E RID: 65310
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Responder_CameraShake";

		// Token: 0x0400FF1F RID: 65311
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF20 RID: 65312
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF21 RID: 65313
		internal static int __PropertyOffset_ShakeKey;
	}
}
