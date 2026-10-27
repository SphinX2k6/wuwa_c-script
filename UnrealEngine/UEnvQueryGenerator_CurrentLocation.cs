using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000197 RID: 407
	[UnrealObjectPath("/Script/AIModule.EnvQueryGenerator_CurrentLocation")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UEnvQueryGenerator_CurrentLocation : UEnvQueryGenerator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001935 RID: 6453 RVA: 0x0002541B File Offset: 0x0002361B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryGenerator_CurrentLocation._ClassPtr;
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00025428 File Offset: 0x00023628
		public UEnvQueryGenerator_CurrentLocation() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_CurrentLocation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00025450 File Offset: 0x00023650
		[NullableContext(1)]
		public UEnvQueryGenerator_CurrentLocation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_CurrentLocation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x00025483 File Offset: 0x00023683
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x00025497 File Offset: 0x00023697
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> QueryContext
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_CurrentLocation.__PropertyOffset_QueryContext);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_CurrentLocation.__PropertyOffset_QueryContext) = value;
			}
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x000254AC File Offset: 0x000236AC
		static UEnvQueryGenerator_CurrentLocation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryGenerator_CurrentLocation");
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x000254BA File Offset: 0x000236BA
		protected UEnvQueryGenerator_CurrentLocation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000738 RID: 1848
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryGenerator_CurrentLocation";

		// Token: 0x04000739 RID: 1849
		private static IntPtr _ClassPtr;

		// Token: 0x0400073A RID: 1850
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400073B RID: 1851
		internal static int __PropertyOffset_QueryContext;
	}
}
