using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200012D RID: 301
	[UnrealObjectPath("/Script/AIModule.BlackboardKeyType_Object")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UBlackboardKeyType_Object : UBlackboardKeyType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001593 RID: 5523 RVA: 0x0001FB78 File Offset: 0x0001DD78
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardKeyType_Object._ClassPtr;
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x0001FB84 File Offset: 0x0001DD84
		public UBlackboardKeyType_Object() : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Object.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x0001FBAC File Offset: 0x0001DDAC
		[NullableContext(1)]
		public UBlackboardKeyType_Object(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlackboardKeyType_Object.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x0001FBDF File Offset: 0x0001DDDF
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x0001FBF3 File Offset: 0x0001DDF3
		public unsafe UClassStackOnlyPtr BaseClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlackboardKeyType_Object.__PropertyOffset_BaseClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlackboardKeyType_Object.__PropertyOffset_BaseClass) = value;
			}
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x0001FC08 File Offset: 0x0001DE08
		static UBlackboardKeyType_Object()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardKeyType_Object");
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x0001FC16 File Offset: 0x0001DE16
		protected UBlackboardKeyType_Object(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400049F RID: 1183
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BlackboardKeyType_Object";

		// Token: 0x040004A0 RID: 1184
		private static IntPtr _ClassPtr;

		// Token: 0x040004A1 RID: 1185
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040004A2 RID: 1186
		internal static int __PropertyOffset_BaseClass;
	}
}
