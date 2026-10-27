using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015C5 RID: 5573
	[UnrealObjectPath("/Script/JsonUtilities.JsonUtilitiesDummyObject")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UJsonUtilitiesDummyObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014171 RID: 82289 RVA: 0x001D7E86 File Offset: 0x001D6086
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UJsonUtilitiesDummyObject._ClassPtr;
		}

		// Token: 0x06014172 RID: 82290 RVA: 0x001D7E94 File Offset: 0x001D6094
		public UJsonUtilitiesDummyObject() : this(BuiltinUtils.AllocNativeUObject(UJsonUtilitiesDummyObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014173 RID: 82291 RVA: 0x001D7EBC File Offset: 0x001D60BC
		[NullableContext(1)]
		public UJsonUtilitiesDummyObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UJsonUtilitiesDummyObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014174 RID: 82292 RVA: 0x001D7EEF File Offset: 0x001D60EF
		static UJsonUtilitiesDummyObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/JsonUtilities.JsonUtilitiesDummyObject");
		}

		// Token: 0x06014175 RID: 82293 RVA: 0x001D7EFD File Offset: 0x001D60FD
		protected UJsonUtilitiesDummyObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AEC8 RID: 44744
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/JsonUtilities.JsonUtilitiesDummyObject";

		// Token: 0x0400AEC9 RID: 44745
		private static IntPtr _ClassPtr;

		// Token: 0x0400AECA RID: 44746
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
