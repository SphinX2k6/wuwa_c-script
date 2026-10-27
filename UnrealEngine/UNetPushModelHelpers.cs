using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EE9 RID: 3817
	[UnrealObjectPath("/Script/Engine.NetPushModelHelpers")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UNetPushModelHelpers : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CF03 RID: 52995 RVA: 0x0012E0F1 File Offset: 0x0012C2F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNetPushModelHelpers._ClassPtr;
		}

		// Token: 0x0600CF04 RID: 52996 RVA: 0x0012E100 File Offset: 0x0012C300
		public UNetPushModelHelpers() : this(BuiltinUtils.AllocNativeUObject(UNetPushModelHelpers.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CF05 RID: 52997 RVA: 0x0012E128 File Offset: 0x0012C328
		[NullableContext(1)]
		public UNetPushModelHelpers(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNetPushModelHelpers.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600CF06 RID: 52998 RVA: 0x0012E15B File Offset: 0x0012C35B
		[NullableContext(2)]
		public static void MarkPropertyDirtyFromRepIndex(UObject Object, int RepIndex, FName PropertyName)
		{
			UNetPushModelHelpers.__MarkPropertyDirtyFromRepIndex_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, RepIndex, PropertyName);
		}

		// Token: 0x0600CF07 RID: 52999 RVA: 0x0012E174 File Offset: 0x0012C374
		[NullableContext(2)]
		public static void MarkPropertyDirty(UObject Object, FName PropertyName)
		{
			UNetPushModelHelpers.__MarkPropertyDirty_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, PropertyName);
		}

		// Token: 0x0600CF08 RID: 53000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkPropertyDirtyFromRepIndex_Internal(IntPtr Object, int RepIndex, FName PropertyName);

		// Token: 0x0600CF09 RID: 53001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkPropertyDirty_Internal(IntPtr Object, FName PropertyName);

		// Token: 0x0600CF0A RID: 53002 RVA: 0x0012E18C File Offset: 0x0012C38C
		static UNetPushModelHelpers()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NetPushModelHelpers");
		}

		// Token: 0x0600CF0B RID: 53003 RVA: 0x0012E19A File Offset: 0x0012C39A
		protected UNetPushModelHelpers(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006FA9 RID: 28585
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NetPushModelHelpers";

		// Token: 0x04006FAA RID: 28586
		private static IntPtr _ClassPtr;

		// Token: 0x04006FAB RID: 28587
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
