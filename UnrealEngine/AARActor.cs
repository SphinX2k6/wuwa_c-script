using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000394 RID: 916
	[UnrealObjectPath("/Script/AugmentedReality.ARActor")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AARActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600325B RID: 12891 RVA: 0x0004DA9F File Offset: 0x0004BC9F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AARActor._ClassPtr;
		}

		// Token: 0x0600325C RID: 12892 RVA: 0x0004DAAC File Offset: 0x0004BCAC
		public AARActor() : this(BuiltinUtils.AllocNativeUObject(AARActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x0004DAD4 File Offset: 0x0004BCD4
		[NullableContext(1)]
		public AARActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AARActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x0004DB07 File Offset: 0x0004BD07
		[NullableContext(2)]
		public UARComponent AddARComponent([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UARComponent> InComponentClass, in FGuid NativeID)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UARComponent>(AARActor.__AddARComponent_Internal(base.NativePtr, InComponentClass._NativePtr, NativeID));
		}

		// Token: 0x0600325F RID: 12895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddARComponent_Internal(IntPtr @this, IntPtr InComponentClass, in FGuid NativeID);

		// Token: 0x06003260 RID: 12896 RVA: 0x0004DB20 File Offset: 0x0004BD20
		static AARActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AugmentedReality.ARActor");
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x0004DB2E File Offset: 0x0004BD2E
		protected AARActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001618 RID: 5656
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AugmentedReality.ARActor";

		// Token: 0x04001619 RID: 5657
		private static IntPtr _ClassPtr;

		// Token: 0x0400161A RID: 5658
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
