using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F9 RID: 249
	[UnrealObjectPath("/Script/AIModule.AIResource_Logic")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UAIResource_Logic : UGameplayTaskResource, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001351 RID: 4945 RVA: 0x0001C843 File Offset: 0x0001AA43
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAIResource_Logic._ClassPtr;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x0001C850 File Offset: 0x0001AA50
		public UAIResource_Logic() : this(BuiltinUtils.AllocNativeUObject(UAIResource_Logic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x0001C878 File Offset: 0x0001AA78
		[NullableContext(1)]
		public UAIResource_Logic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAIResource_Logic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0001C8AB File Offset: 0x0001AAAB
		static UAIResource_Logic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIResource_Logic");
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0001C8B9 File Offset: 0x0001AAB9
		protected UAIResource_Logic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400037D RID: 893
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIResource_Logic";

		// Token: 0x0400037E RID: 894
		private static IntPtr _ClassPtr;

		// Token: 0x0400037F RID: 895
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
