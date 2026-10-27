using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000127 RID: 295
	[UnrealObjectPath("/Script/AIModule.BlackboardKeyType_Class")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UBlackboardKeyType_Class : UBlackboardKeyType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001569 RID: 5481 RVA: 0x0001F762 File Offset: 0x0001D962
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardKeyType_Class._ClassPtr;
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0001F770 File Offset: 0x0001D970
		public UBlackboardKeyType_Class() : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Class.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0001F798 File Offset: 0x0001D998
		[NullableContext(1)]
		public UBlackboardKeyType_Class(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Class.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x0001F7CB File Offset: 0x0001D9CB
		// (set) Token: 0x0600156D RID: 5485 RVA: 0x0001F7DF File Offset: 0x0001D9DF
		public unsafe UClassStackOnlyPtr BaseClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlackboardKeyType_Class.__PropertyOffset_BaseClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlackboardKeyType_Class.__PropertyOffset_BaseClass) = value;
			}
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0001F7F4 File Offset: 0x0001D9F4
		static UBlackboardKeyType_Class()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardKeyType_Class");
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0001F802 File Offset: 0x0001DA02
		protected UBlackboardKeyType_Class(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000486 RID: 1158
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BlackboardKeyType_Class";

		// Token: 0x04000487 RID: 1159
		private static IntPtr _ClassPtr;

		// Token: 0x04000488 RID: 1160
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000489 RID: 1161
		internal static int __PropertyOffset_BaseClass;
	}
}
