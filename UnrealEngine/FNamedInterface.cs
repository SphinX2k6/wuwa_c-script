using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002617 RID: 9751
	[UnrealObjectPath("/Script/OnlineSubsystem.NamedInterface")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNamedInterface : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602444E RID: 148558 RVA: 0x0035B280 File Offset: 0x00359480
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNamedInterface._ScriptStructPtr != 0) ? FNamedInterface._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/OnlineSubsystem.NamedInterface", ref FNamedInterface._ScriptStructPtr);
		}

		// Token: 0x17008BAB RID: 35755
		// (get) Token: 0x0602444F RID: 148559 RVA: 0x0035B2A4 File Offset: 0x003594A4
		// (set) Token: 0x06024450 RID: 148560 RVA: 0x0035B2B8 File Offset: 0x003594B8
		public unsafe FName InterfaceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNamedInterface.__PropertyOffset_InterfaceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNamedInterface.__PropertyOffset_InterfaceName) = value;
			}
		}

		// Token: 0x17008BAC RID: 35756
		// (get) Token: 0x06024451 RID: 148561 RVA: 0x0035B2CD File Offset: 0x003594CD
		// (set) Token: 0x06024452 RID: 148562 RVA: 0x0035B2E1 File Offset: 0x003594E1
		[Nullable(2)]
		public unsafe UObject InterfaceObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FNamedInterface.__PropertyOffset_InterfaceObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNamedInterface.__PropertyOffset_InterfaceObject, value);
			}
		}

		// Token: 0x06024453 RID: 148563 RVA: 0x0035B2F6 File Offset: 0x003594F6
		public FNamedInterface()
		{
		}

		// Token: 0x06024454 RID: 148564 RVA: 0x0035B2FE File Offset: 0x003594FE
		[NullableContext(1)]
		public FNamedInterface(FName InterfaceName, UObject InterfaceObject)
		{
			this.InterfaceName = InterfaceName;
			this.InterfaceObject = InterfaceObject;
		}

		// Token: 0x06024455 RID: 148565 RVA: 0x0035B314 File Offset: 0x00359514
		protected override IntPtr GetUStructPtr()
		{
			return FNamedInterface.StaticStruct();
		}

		// Token: 0x06024456 RID: 148566 RVA: 0x0035B320 File Offset: 0x00359520
		[NullableContext(2)]
		public FNamedInterface(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024457 RID: 148567 RVA: 0x0035B32A File Offset: 0x0035952A
		public FNamedInterface(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024458 RID: 148568 RVA: 0x0035B335 File Offset: 0x00359535
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNamedInterface(Pointer, false, true);
		}

		// Token: 0x06024459 RID: 148569 RVA: 0x0035B33F File Offset: 0x0035953F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNamedInterface(Pointer, MemoryOwner);
		}

		// Token: 0x0401374B RID: 79691
		[Nullable(1)]
		public const string __ObjectPath = "/Script/OnlineSubsystem.NamedInterface";

		// Token: 0x0401374C RID: 79692
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401374D RID: 79693
		internal static int __PropertyOffset_InterfaceName;

		// Token: 0x0401374E RID: 79694
		internal static int __PropertyOffset_InterfaceObject;
	}
}
