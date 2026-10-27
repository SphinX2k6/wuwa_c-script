using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200012C RID: 300
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BlackboardKeyType_NativeEnum")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UBlackboardKeyType_NativeEnum : UBlackboardKeyType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600158A RID: 5514 RVA: 0x0001FAA6 File Offset: 0x0001DCA6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardKeyType_NativeEnum._ClassPtr;
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0001FAB4 File Offset: 0x0001DCB4
		public UBlackboardKeyType_NativeEnum() : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_NativeEnum.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0001FADC File Offset: 0x0001DCDC
		public UBlackboardKeyType_NativeEnum(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_NativeEnum.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x0001FB0F File Offset: 0x0001DD0F
		// (set) Token: 0x0600158E RID: 5518 RVA: 0x0001FB23 File Offset: 0x0001DD23
		public unsafe string EnumName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBlackboardKeyType_NativeEnum.__PropertyOffset_EnumName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBlackboardKeyType_NativeEnum.__PropertyOffset_EnumName)), value);
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x0001FB38 File Offset: 0x0001DD38
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x0001FB4C File Offset: 0x0001DD4C
		[Nullable(2)]
		public unsafe UEnum EnumType
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEnum>(base.NativePtr / (IntPtr)sizeof(void*) + UBlackboardKeyType_NativeEnum.__PropertyOffset_EnumType);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlackboardKeyType_NativeEnum.__PropertyOffset_EnumType, value);
			}
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x0001FB61 File Offset: 0x0001DD61
		static UBlackboardKeyType_NativeEnum()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardKeyType_NativeEnum");
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x0001FB6F File Offset: 0x0001DD6F
		protected UBlackboardKeyType_NativeEnum(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400049A RID: 1178
		public new const string __ObjectPath = "/Script/AIModule.BlackboardKeyType_NativeEnum";

		// Token: 0x0400049B RID: 1179
		private static IntPtr _ClassPtr;

		// Token: 0x0400049C RID: 1180
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400049D RID: 1181
		internal static int __PropertyOffset_EnumName;

		// Token: 0x0400049E RID: 1182
		internal static int __PropertyOffset_EnumType;
	}
}
