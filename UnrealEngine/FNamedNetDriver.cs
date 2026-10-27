using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EC9 RID: 3785
	[UnrealObjectPath("/Script/Engine.NamedNetDriver")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FNamedNetDriver : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600CCE0 RID: 52448 RVA: 0x0012A6BC File Offset: 0x001288BC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedNetDriver._ScriptStructPtr != 0) ? FNamedNetDriver._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.NamedNetDriver", ref FNamedNetDriver._ScriptStructPtr);
		}

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x0600CCE1 RID: 52449 RVA: 0x0012A6E0 File Offset: 0x001288E0
		// (set) Token: 0x0600CCE2 RID: 52450 RVA: 0x0012A6F4 File Offset: 0x001288F4
		[Nullable(2)]
		public unsafe UNetDriver NetDriver
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNetDriver>(base.NativePtr / (IntPtr)sizeof(void*) + FNamedNetDriver.__PropertyOffset_NetDriver);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNamedNetDriver.__PropertyOffset_NetDriver, value);
			}
		}

		// Token: 0x0600CCE3 RID: 52451 RVA: 0x0012A709 File Offset: 0x00128909
		public FNamedNetDriver()
		{
		}

		// Token: 0x0600CCE4 RID: 52452 RVA: 0x0012A711 File Offset: 0x00128911
		[NullableContext(1)]
		public FNamedNetDriver(UNetDriver NetDriver)
		{
			this.NetDriver = NetDriver;
		}

		// Token: 0x0600CCE5 RID: 52453 RVA: 0x0012A720 File Offset: 0x00128920
		protected override IntPtr GetUStructPtr()
		{
			return FNamedNetDriver.StaticStruct();
		}

		// Token: 0x0600CCE6 RID: 52454 RVA: 0x0012A72C File Offset: 0x0012892C
		[NullableContext(2)]
		public FNamedNetDriver(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600CCE7 RID: 52455 RVA: 0x0012A736 File Offset: 0x00128936
		public FNamedNetDriver(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600CCE8 RID: 52456 RVA: 0x0012A741 File Offset: 0x00128941
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedNetDriver(Pointer, false, true);
		}

		// Token: 0x0600CCE9 RID: 52457 RVA: 0x0012A74B File Offset: 0x0012894B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedNetDriver(Pointer, MemoryOwner);
		}

		// Token: 0x04006E46 RID: 28230
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NamedNetDriver";

		// Token: 0x04006E47 RID: 28231
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006E48 RID: 28232
		internal static int __PropertyOffset_NetDriver;
	}
}
