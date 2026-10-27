using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000128 RID: 296
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BlackboardKeyType_Enum")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UBlackboardKeyType_Enum : UBlackboardKeyType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001570 RID: 5488 RVA: 0x0001F80B File Offset: 0x0001DA0B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardKeyType_Enum._ClassPtr;
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x0001F818 File Offset: 0x0001DA18
		public UBlackboardKeyType_Enum() : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Enum.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x0001F840 File Offset: 0x0001DA40
		public UBlackboardKeyType_Enum(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Enum.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x0001F873 File Offset: 0x0001DA73
		// (set) Token: 0x06001574 RID: 5492 RVA: 0x0001F887 File Offset: 0x0001DA87
		[Nullable(2)]
		public unsafe UEnum EnumType
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEnum>(base.NativePtr / (IntPtr)sizeof(void*) + UBlackboardKeyType_Enum.__PropertyOffset_EnumType);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlackboardKeyType_Enum.__PropertyOffset_EnumType, value);
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x0001F89C File Offset: 0x0001DA9C
		// (set) Token: 0x06001576 RID: 5494 RVA: 0x0001F8B0 File Offset: 0x0001DAB0
		public unsafe string EnumName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBlackboardKeyType_Enum.__PropertyOffset_EnumName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBlackboardKeyType_Enum.__PropertyOffset_EnumName)), value);
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x0001F8C5 File Offset: 0x0001DAC5
		// (set) Token: 0x06001578 RID: 5496 RVA: 0x0001F8DE File Offset: 0x0001DADE
		public unsafe bool bIsEnumNameValid
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBlackboardKeyType_Enum.__PropertyOffset_bIsEnumNameValid) & UBlackboardKeyType_Enum.__PropertyMask_bIsEnumNameValid) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBlackboardKeyType_Enum.__PropertyOffset_bIsEnumNameValid) = ((*(base.NativePtr + (IntPtr)UBlackboardKeyType_Enum.__PropertyOffset_bIsEnumNameValid) & ~UBlackboardKeyType_Enum.__PropertyMask_bIsEnumNameValid) | (value ? UBlackboardKeyType_Enum.__PropertyMask_bIsEnumNameValid : 0));
			}
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0001F90E File Offset: 0x0001DB0E
		static UBlackboardKeyType_Enum()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardKeyType_Enum");
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x0001F91C File Offset: 0x0001DB1C
		protected UBlackboardKeyType_Enum(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400048A RID: 1162
		public new const string __ObjectPath = "/Script/AIModule.BlackboardKeyType_Enum";

		// Token: 0x0400048B RID: 1163
		private static IntPtr _ClassPtr;

		// Token: 0x0400048C RID: 1164
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400048D RID: 1165
		internal static int __PropertyOffset_EnumType;

		// Token: 0x0400048E RID: 1166
		internal static int __PropertyOffset_EnumName;

		// Token: 0x0400048F RID: 1167
		internal static int __PropertyOffset_bIsEnumNameValid;

		// Token: 0x04000490 RID: 1168
		internal static byte __PropertyMask_bIsEnumNameValid;
	}
}
