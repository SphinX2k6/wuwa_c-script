using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000FB RID: 251
	[UnrealObjectPath("/Script/AIModule.AISense")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public abstract class UAISense : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600135B RID: 4955 RVA: 0x0001C942 File Offset: 0x0001AB42
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISense._ClassPtr;
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x0001C94E File Offset: 0x0001AB4E
		// (set) Token: 0x0600135D RID: 4957 RVA: 0x0001C95E File Offset: 0x0001AB5E
		public unsafe float DefaultExpirationAge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISense.__PropertyOffset_DefaultExpirationAge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISense.__PropertyOffset_DefaultExpirationAge) = value;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x0001C96F File Offset: 0x0001AB6F
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x0001C97F File Offset: 0x0001AB7F
		public unsafe EAISenseNotifyType NotifyType
		{
			get
			{
				return (EAISenseNotifyType)(*(base.NativePtr + (IntPtr)UAISense.__PropertyOffset_NotifyType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISense.__PropertyOffset_NotifyType) = (byte)value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x0001C990 File Offset: 0x0001AB90
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x0001C9A9 File Offset: 0x0001ABA9
		public unsafe bool bWantsNewPawnNotification
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAISense.__PropertyOffset_bWantsNewPawnNotification) & UAISense.__PropertyMask_bWantsNewPawnNotification) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAISense.__PropertyOffset_bWantsNewPawnNotification) = ((*(base.NativePtr + (IntPtr)UAISense.__PropertyOffset_bWantsNewPawnNotification) & ~UAISense.__PropertyMask_bWantsNewPawnNotification) | (value ? UAISense.__PropertyMask_bWantsNewPawnNotification : 0));
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x0001C9D9 File Offset: 0x0001ABD9
		// (set) Token: 0x06001363 RID: 4963 RVA: 0x0001C9F2 File Offset: 0x0001ABF2
		public unsafe bool bAutoRegisterAllPawnsAsSources
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAISense.__PropertyOffset_bAutoRegisterAllPawnsAsSources) & UAISense.__PropertyMask_bAutoRegisterAllPawnsAsSources) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAISense.__PropertyOffset_bAutoRegisterAllPawnsAsSources) = ((*(base.NativePtr + (IntPtr)UAISense.__PropertyOffset_bAutoRegisterAllPawnsAsSources) & ~UAISense.__PropertyMask_bAutoRegisterAllPawnsAsSources) | (value ? UAISense.__PropertyMask_bAutoRegisterAllPawnsAsSources : 0));
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x0001CA22 File Offset: 0x0001AC22
		// (set) Token: 0x06001365 RID: 4965 RVA: 0x0001CA36 File Offset: 0x0001AC36
		[Nullable(2)]
		public unsafe UAIPerceptionSystem PerceptionSystemInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAIPerceptionSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UAISense.__PropertyOffset_PerceptionSystemInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAISense.__PropertyOffset_PerceptionSystemInstance, value);
			}
		}

		// Token: 0x06001366 RID: 4966 RVA: 0x0001CA4B File Offset: 0x0001AC4B
		static UAISense()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISense");
		}

		// Token: 0x06001367 RID: 4967 RVA: 0x0001CA5C File Offset: 0x0001AC5C
		protected UAISense() : this(BuiltinUtils.AllocNativeUObject(UAISense.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x0001CA84 File Offset: 0x0001AC84
		protected UAISense(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000383 RID: 899
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISense";

		// Token: 0x04000384 RID: 900
		private static IntPtr _ClassPtr;

		// Token: 0x04000385 RID: 901
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000386 RID: 902
		internal static int __PropertyOffset_DefaultExpirationAge;

		// Token: 0x04000387 RID: 903
		internal static int __PropertyOffset_NotifyType;

		// Token: 0x04000388 RID: 904
		internal static int __PropertyOffset_bWantsNewPawnNotification;

		// Token: 0x04000389 RID: 905
		internal static byte __PropertyMask_bWantsNewPawnNotification;

		// Token: 0x0400038A RID: 906
		internal static int __PropertyOffset_bAutoRegisterAllPawnsAsSources;

		// Token: 0x0400038B RID: 907
		internal static byte __PropertyMask_bAutoRegisterAllPawnsAsSources;

		// Token: 0x0400038C RID: 908
		internal static int __PropertyOffset_PerceptionSystemInstance;
	}
}
