using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200012F RID: 303
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BlackboardKeyType_String")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UBlackboardKeyType_String : UBlackboardKeyType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600159F RID: 5535 RVA: 0x0001FC9E File Offset: 0x0001DE9E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardKeyType_String._ClassPtr;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x0001FCAC File Offset: 0x0001DEAC
		public UBlackboardKeyType_String() : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_String.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x0001FCD4 File Offset: 0x0001DED4
		public UBlackboardKeyType_String(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_String.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x0001FD07 File Offset: 0x0001DF07
		// (set) Token: 0x060015A3 RID: 5539 RVA: 0x0001FD1B File Offset: 0x0001DF1B
		public unsafe string StringValue
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UBlackboardKeyType_String.__PropertyOffset_StringValue)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UBlackboardKeyType_String.__PropertyOffset_StringValue)), value);
			}
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0001FD30 File Offset: 0x0001DF30
		static UBlackboardKeyType_String()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardKeyType_String");
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0001FD3E File Offset: 0x0001DF3E
		protected UBlackboardKeyType_String(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004A6 RID: 1190
		public new const string __ObjectPath = "/Script/AIModule.BlackboardKeyType_String";

		// Token: 0x040004A7 RID: 1191
		private static IntPtr _ClassPtr;

		// Token: 0x040004A8 RID: 1192
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040004A9 RID: 1193
		internal static int __PropertyOffset_StringValue;
	}
}
